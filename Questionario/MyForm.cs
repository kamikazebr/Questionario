using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Questionario
{
     public class MyForm:Form
    {
        public OleDbDataAdapter adapter;
        public static DataSet dataSet;
        public static DataTable dataTable;

        //private OleDbConnection conn;
        private string tableName = "questionario";

        public static Stack<MyForm> _pilhas;

        public static Stack<MyForm> Pilhas {
            get {
                if (_pilhas == null)
                {
                    _pilhas = new Stack<MyForm>();
                }
                return _pilhas;
                }
            set { _pilhas = value; }
        }
        
        public int lastID { get; set; }
        public String col_idioma = "idioma";
        public String col_idioma_type = "TEXT";

        public String col_encerrado = "encerrado";
        public String col_encerrado_type = "int";

        public String col_ultima = "ultima";
        public String col_ultima_type = "TEXT";

        private global::System.Data.OleDb.OleDbCommand[] _commandCollection;

        //public bancoDataSetTableAdapters.questionarioTableAdapter adapter;
        public static DataRow rowCurrent;
        //public bancoDataSet.questionarioDataTable dataTable;
	
        public MyForm():base()
        {
            if (this.DesignMode)
            {
                return;
            }
            this.Load +=MyForm_Load;
            this.Shown += MyForm_Shown;
            this._commandCollection = new global::System.Data.OleDb.OleDbCommand[1];
        }

        void MyForm_Shown(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            initDB();
            
        }
        public void buttonBack_Click(object sender, EventArgs e)
        {
            backToForm();
        }
        private void MyForm_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            //initDB();
            if (this.Controls.ContainsKey("button1"))
            {
                this.SuspendLayout();
                Button buttonBack = new System.Windows.Forms.Button();
                //resources.ApplyResources(buttonBack, "buttonBack");
                buttonBack.Name = "buttonBack";
                buttonBack.UseVisualStyleBackColor = true;
                buttonBack.Size = this.Controls["button1"].Size;
                buttonBack.Location = new System.Drawing.Point(this.Controls["button1"].Location.X - buttonBack.Size.Width - 50, this.Controls["button1"].Location.Y);
                buttonBack.Text = isPT() ? "Voltar" : "Volver";
                buttonBack.Click += buttonBack_Click;
                this.Controls.Add(buttonBack);
                this.ResumeLayout(false);
                this.PerformLayout();

            }
        }

        public void initDB()
        {
            string commandstring = "select * from "+tableName;
            string cs = Properties.Settings.Default.bancoConnectionString;
            
            adapter = new OleDbDataAdapter(commandstring, cs);

            BuildCommands();

            dataSet = new DataSet();
            dataSet.CaseSensitive = true;
            adapter.Fill(dataSet, tableName);

            dataTable = dataSet.Tables[0];
            Console.WriteLine(adapter.SelectCommand.CommandText);
            //adapter = new bancoDataSetTableAdapters.questionarioTableAdapter();
            //dataTable = new bancoDataSet.questionarioDataTable();
            //adapter.Fill(dataTable);
            if (lastID != 0)
            {
                rowCurrent = dataTable.Rows[dataTable.Rows.Count-1];
                //rowCurrent = dataTable.Rows.Find(lastID);
                //FindByid(lastID);
            }
        }
        public bool findPanels(Dictionary<String, Object> row, bool onePanelFoi)
        {
            foreach (Panel panel in this.Controls.OfType<Panel>().OrderBy(Panel => Panel.Name))
            {
                Console.WriteLine("Quem {0}",panel.Name);
                String[] partes = panel.Name.Split("_".ToCharArray());
                onePanelFoi = findRadioButtons(row,panel, partes);
                onePanelFoi |= findCheckBoxs(row, panel, partes);

                foreach (Panel panelIn in panel.Controls.OfType<Panel>().OrderBy(Panel => Panel.Name))
                {
                    Console.WriteLine("Quem {0}", panelIn.Name);
                    partes = panelIn.Name.Split("_".ToCharArray());
                    onePanelFoi = findRadioButtons(row, panelIn, partes);
                    onePanelFoi |= findCheckBoxs(row, panelIn, partes);
                }
            }

            if (onePanelFoi)
            {
                initDB();
            }
            
            return onePanelFoi;
        }

        private bool findCheckBoxs(Dictionary<string, object> row, Panel panel, string[] partes)
        {
            bool onePanelFoi = false;
           
                foreach (CheckBox cb in panel.Controls.OfType<CheckBox>().OrderBy(CheckBox => CheckBox.Name))
                {
                    //if (!rb.Checked)
                    //{
                    //    continue;
                    //}

                    if (cb.Name != null)
                    {
                        String[] partes_cb = cb.Name.ToLower().Split(typeof(CheckBox).Name.ToLower().ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        if (partes_cb.Length > 0)
                        {
                            string str = partes_cb[partes_cb.Length - 1];
                            int value = convertStringToInt(str);


                            if (value == -1)
                            {
                                MessageBox.Show(String.Format("Erro na criacao da tela, verifique o nome dos componentes tipo:{0}", typeof(CheckBox).Name));
                                Application.DoEvents();
                                throw new Exception();
                            }

                            String col = this.Name + "_" + partes[1] + "_" + value;

                            InsertColumnIFNotExist(col, "INT");
                            row[col] = cb.Checked ? 1 : 0;
                            onePanelFoi = true;

                            findTag(row, panel, col, cb);
                        }
                    }
                }
            
            return onePanelFoi;
        }
     
        private bool findRadioButtons(Dictionary<String, Object> row,Panel panel, String[] partes)
        {
            bool onePanelFoi = false;
            foreach (RadioButton rb in panel.Controls.OfType<RadioButton>().OrderBy(RadioButton => RadioButton.Name))
            {
                if (!rb.Checked)
                {
                    continue;
                }

                if (rb.Name != null)
                {
                    String[] partes_rb = rb.Name.ToLower().Split(typeof(RadioButton).Name.ToLower().ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (partes_rb.Length > 0)
                    {
                        string str = partes_rb[partes_rb.Length-1];
                        int value = convertStringToInt(str);
                        
                        if (value == -1)
                        {
                            MessageBox.Show(String.Format("Erro na criacao da tela, verifique o nome dos componentes tipo:{0}", typeof(RadioButton).Name));
                            Application.DoEvents();
                            throw new Exception();
                        }

                        String col = this.Name + "_" + partes[1];
                        InsertColumnIFNotExist(col, "INT");
                        row[col] = value;
                        onePanelFoi = true;
                       
                        findTag(row, panel, col, rb);
                    }
                }
            }
            return onePanelFoi;
        }

        public static int convertStringToInt(string str)
        {
            int value = -1;
            try
            {
                value = Int16.Parse(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception ignored: {0}", ex);
                value = -1;
            }
            return value;
        }

        private void findTag(Dictionary<String, Object> row, Panel panel, String colName, Control rb)
        {
            if (rb.Tag != null)
            {
                String nameControl = (String)rb.Tag;
                if (nameControl != null && panel.Controls[nameControl] != null)
                {
                    
                    String col = colName + "_EXTRAS";
                    InsertColumnIFNotExist(col, "TEXT");
                    Control control = panel.Controls[nameControl];
                    if (control != null)
                    {
                        String valor = "";

                        if (control is TextBox)
                        {
                            valor = ((TextBox)control).Text;
                        }
                        else if (control is NumericUpDown)
                        {
                            valor = ((NumericUpDown)control).Value.ToString();
                        }

                        if (valor.Length > 0)
                        {
                            row[col] = valor;
                        }
                    }
                }
            }
        }
        public void newRow(Dictionary<String, Object> row)
        {
            
            // create a new row, populate it
            rowCurrent = dataTable.NewRow();
			try{
                rowCurrent.BeginEdit();
                foreach (String key in row.Keys.AsEnumerable<String>())
                {

                    rowCurrent[key] = row[key];
                }
                rowCurrent.EndEdit();
                dataTable.Rows.Add(rowCurrent);
                adapter.Update(dataSet,tableName);
                dataSet.AcceptChanges();


                //// inform the user
                //MessageBox.Show("Updated.");
                //Application.DoEvents();
				
            }
            catch (OleDbException ex)
            {
                dataSet.RejectChanges();
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ErrorCode.ToString());
            }
        }

        public object LastIDNaoEncerrado()
        {
            global::System.Data.OleDb.OleDbCommand command = new OleDbCommand("",null);
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open)
                        != global::System.Data.ConnectionState.Open))
            {
                command.Connection.Open();
            }
            object returnValue;
            try
            {
                returnValue = command.ExecuteScalar();
            }
            finally
            {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null)
                        || (returnValue.GetType() == typeof(global::System.DBNull))))
            {
                return null;
            }
            else
            {
                return ((object)(returnValue));
            }
        }

        public object LastID() {
            global::System.Data.OleDb.OleDbCommand command = adapter.SelectCommand;
            global::System.Data.ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & global::System.Data.ConnectionState.Open) 
                        != global::System.Data.ConnectionState.Open)) {
                command.Connection.Open();
            }
            object returnValue;
            try {
                returnValue = command.ExecuteScalar();
            }
            finally {
                if ((previousConnectionState == global::System.Data.ConnectionState.Closed)) {
                    command.Connection.Close();
                }
            }
            if (((returnValue == null) 
                        || (returnValue.GetType() == typeof(global::System.DBNull)))) {
                return null;
            }
            else {
                return ((object)(returnValue));
            }
        }
   
        public void updateRow( Dictionary<string, object> row)
        {
            //dataTable.AddquestionarioRow(rowCurrent);
            //rowCurrent = dataTable.Rows[];


            rowCurrent.BeginEdit();
            foreach (String key in row.Keys.AsEnumerable<String>())
            {

                rowCurrent[key] = row[key];
            }
            rowCurrent.EndEdit();


            DataSet dsChanges =
                dataSet.GetChanges(DataRowState.Modified);

            // check for any changed rows with errors
            bool okayFlag = true;
            if (dsChanges.HasErrors)
            {
                okayFlag = false;
                string msg = "Erro na linha";

                // Look at each table in the dataSet
                foreach (DataTable currTable in dsChanges.Tables)
                {
                    // Find the rows with errors if any table has errors
                    if (currTable.HasErrors)
                    {
                        // fetch the error rows
                        DataRow[] errorRows = currTable.GetErrors();

                        // Go through the rows and identify the ones
                        // with errors
                        foreach (DataRow currRow in errorRows)
                        {
                            msg = msg + currRow["id"];
                        }
                    }
                }
                MessageBox.Show(msg);
            }

            // No errors -- all okay
            if (okayFlag)
            {
                // apply updates to the database
                adapter.Update(dsChanges, tableName);

                // tell the user
                //MessageBox.Show("Atualizado " + rowCurrent["id"]);
                //Application.DoEvents();

                // apply changes and refresh the listbox
                dataSet.AcceptChanges();
                //Fill_lb();
            }
            else // if any errors then throw out the changes
                dataSet.RejectChanges();
        
        }

        public void goToForm(MyForm mf)
        {
            this.lastID = (int)LastID();
            mf.lastID = lastID;
            initDB();
            //My.rowCurrent = rowCurrent;

            Dictionary<string,object> row = new Dictionary<string,object>();
            row[col_ultima] = this.Name;

            updateRow(row);
            Pilhas.Push(this);
            this.Hide();
            mf.Show();
        }

        public void backToForm()
        {
            MyForm backkers = Pilhas.Pop();
            this.lastID = (int)LastID();
            backkers.lastID = lastID;
            initDB();
            //My.rowCurrent = rowCurrent;

            Dictionary<string, object> row = new Dictionary<string, object>();
            row[col_ultima] = this.Name;

            updateRow(row);
            
            this.Hide();
            backkers.Show();
        }

        public void goToFormEncerrar()
        {
            MyForm mf = new Encerrado();

            mf.lastID = (int)LastID();
            //My.rowCurrent = rowCurrent;

            Dictionary<string, object> row = new Dictionary<string, object>();
            row[col_ultima] = this.Name;

            updateRow(row);
            Pilhas.Push(this);
            this.Hide();
            mf.Show();
        }



        public bool isPT()
        {
            if (System.Globalization.CultureInfo.CurrentCulture == null)
            {
                return true;
            }
            return System.Globalization.CultureInfo.CurrentCulture.Name.Equals("pt", StringComparison.Ordinal);
        }

        private void BuildCommands()
        {
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
        }
         /// <summary>
         /// Tenta criar uma coluna em tempo de execucao.
         /// </summary>
         /// <param name="colName">Nome da coluna (nao usar palavras reservadas do Banco de dados)</param>
         /// <param name="colType">Tipo da coluna</param>
        /// <exception cref="OleDbException">Normalmente quando o Banco de dados ja esta aberto!</exception>
        public void InsertColumnIFNotExist(string colName, string colType)
        {
            string cs = Properties.Settings.Default.bancoConnectionString;
            using (OleDbConnection con = new OleDbConnection(cs))
            {
                
                //String newColName = "minhaColunaNova";
                //String colType = "num";

                con.Open();

                //string drop = "ALTER TABLE "+tableName+" DROP COLUMN OldCol";
                DataTable info = con.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new Object[] { null, null, tableName, colName });

                if (info.Rows.Count == 0)
                {
                    string add = "ALTER TABLE " + tableName + " ADD COLUMN " + colName + " " + colType;

                    OleDbCommand cmd = new OleDbCommand(add, con);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (OleDbException)
                    {
                        //MessageBox.Show(ex.Message);
                        throw;
                        //MessageBox.Show(ex.ErrorCode.ToString());
                    }

                   
                }
                con.Close();
            }
        }
    }
}



namespace CustomExtensions
{
    public static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static class ThreadSafeRandom
        {
            [ThreadStatic]
            private static Random Local;

            public static Random ThisThreadsRandom
            {
                get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
            }
        }
    }
}
