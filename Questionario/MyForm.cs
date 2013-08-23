using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
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

        public Stack<MyForm> pilhas { get; set; }
        public int lastID { get; set; }


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
        private void MyForm_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            //initDB();
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
                String[] partes = panel.Name.Split("_".ToCharArray());
                onePanelFoi = findRadioButtons(row,panel, partes);
                onePanelFoi |= findCheckBoxs(row, panel, partes);
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
                        row[col] = cb.Checked?1:0;
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
            mf.lastID = (int)LastID();
            //My.rowCurrent = rowCurrent;
            this.Hide();
            mf.Show();
        }



        public bool isPT()
        {
            return System.Globalization.CultureInfo.CurrentCulture.Name.Equals("pt", StringComparison.Ordinal);
        }

        private void BuildCommands()
        {

            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            //Console.WriteLine(builder.GetInsertCommand().CommandText);

            // Use the select command's connection again
            OleDbConnection connection =
                (OleDbConnection)adapter.SelectCommand.Connection;



            //this._commandCollection[0] = new global::System.Data.OleDb.OleDbCommand();
            //this._commandCollection[0].Connection = this.conn;
            //this._commandCollection[0].CommandText = "SELECT id FROM questionario ORDER BY id DESC";
            //this._commandCollection[0].CommandType = global::System.Data.CommandType.Text;
            // Declare a reusable insert command with parameters
            //dataAdapter.InsertCommand = connection.CreateCommand();
            //dataAdapter.InsertCommand.CommandText =
            //    "insert into PhoneNumbers " +
            //    "(Phonenum,Phonenu, Subscriber) " +
            //    "values " +
            //    "('kjhk',?, ?)";
            ////dataAdapter.InsertCommand.Parameters.Add("Phonenum", OleDbType.Char, 0, "Phonenum");
            //dataAdapter.InsertCommand.Parameters.Add("Phonenum", OleDbType.Char, 0, "Phonenu");
            //dataAdapter.InsertCommand.Parameters.Add("Subscriber", OleDbType.Char, 0, "Subscriber");

            //// Declare a reusable update command with parameters
            //dataAdapter.UpdateCommand = connection.CreateCommand();
            //dataAdapter.UpdateCommand.CommandText = "update PhoneNumbers " +
            //    "set Subscriber = ? " +
            //    "where Phonenum = ? ";
            //dataAdapter.UpdateCommand.Parameters.Add("Subscriber", OleDbType.Char, 0, "Subscriber");
            //dataAdapter.UpdateCommand.Parameters.Add("Phonenum", OleDbType.Char, 0, "Phonenum");

            //// Declare a reusable delete command with parameters
            //dataAdapter.DeleteCommand = connection.CreateCommand();
            //dataAdapter.DeleteCommand.CommandText =
            //    "delete from PhoneNumbers where Phonenum = ?";
            //dataAdapter.DeleteCommand.Parameters.Add("Phonenum", OleDbType.Char, 0, "Phonenum");

        }

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
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
