using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionario
{
    public partial class Inicio : MyForm
    {

        

        public Inicio()
        {
            InitializeComponent();
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("pt", true);
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = ci;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = ci;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo((string)((Control)sender).Tag,true);
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = ci;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture= ci;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            RefreshResources(this, resources, ci);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();

            row[col_idioma] = System.Globalization.CultureInfo.DefaultThreadCurrentCulture.Name;

            newRow(row);
            goToForm(new A0());
        }
        private void RefreshResources(Control ctrl, ComponentResourceManager res, System.Globalization.CultureInfo CurrentLocale)
        {
            ctrl.SuspendLayout();
            res.ApplyResources(ctrl, ctrl.Name, CurrentLocale);
            foreach (Control control in ctrl.Controls)
                RefreshResources(control, res,CurrentLocale); // recursion
            ctrl.ResumeLayout(false);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            try
            {
                InsertColumnIFNotExist(col_idioma, col_idioma_type);
                InsertColumnIFNotExist(col_encerrado, col_encerrado_type);
                InsertColumnIFNotExist(col_ultima, col_ultima_type);
            }catch(OleDbException ex){
                MessageBox.Show(String.Format("Cod:{0}: {1}", ex.ErrorCode, ex.Message));
                Application.DoEvents();
                Application.Exit();
            }
            object t = LastIDNaoEncerrado();
            this.lastID = t==null ?-1:(int)t;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ultimaTela = (string)rowCurrent[col_ultima];
            if (ultimaTela != null){
                Console.WriteLine();
                MyForm mf = (MyForm)Activator.CreateInstance(Type.GetType("Questionario." + ultimaTela, true));
               goToForm(mf);
            }
        }

        private void Inicio_Shown(object sender, EventArgs e)
        {
            try
            {
                string lll = (string)rowCurrent[col_idioma];
                System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo(lll, true);
                System.Globalization.CultureInfo.DefaultThreadCurrentCulture = ci;
                System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = ci;
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
                RefreshResources(this, resources, ci);
                //idiomaPanel.Visible = false;
            }catch(NullReferenceException){
                button3.Enabled = false;
            }
            
        }

    }
}
