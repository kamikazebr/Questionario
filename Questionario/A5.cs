using ClassLibrary1;
using Questionario.Banco_de_Dados1DataSetTableAdapters;
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
    public partial class A5 : MyForm
    {
        public A5()
        {
            InitializeComponent();
        }

        private void A5_Load(object sender, EventArgs e)
        {
             if (this.DesignMode)
            {
                return;
            }
             try
             {
                 string msg = isPT() ? String.Format("Qual é a linha de modelo do {0}?", rowCurrent["A4_A_NOME"]) : String.Format("¿Cuál es el la línea de modelo de su {0}?", rowCurrent["A4_A_NOME"]);
                 int A1 = (int)rowCurrent["A1_A"];
                 if (A1 == 1)
                 {
                     int A1_EXTRAS = convertStringToInt((string)rowCurrent["A1_A_EXTRAS"]);
                     if (A1_EXTRAS > 1)
                     {
                         //msg = isPT() ? "Qual é o modelo da sua van mais nova?" : "¿Cuál es el modelo de la camioneta que compró más recientemente?";
                     }
                 }
                 Label3.Text = msg;
             }
             catch(NullReferenceException exNull)
             {
                 MessageBox.Show(exNull.Message);
             }

            int A4_A = (int)rowCurrent["A4_A"];


             MyList<string> listVisiveis = new MyList<string>();

             
            switch (A4_A)
            {
                case 1:
                    listVisiveis.AddRange(new string[]{"1","2"});        
                    break;
                case 2:
                    listVisiveis.AddRange(new string[] { "54","55","56" });
                    break;
                case 3:
                    listVisiveis.AddRange(new string[] { "7", "8", "9", "10", "11", "12" });
                    break;
                case 4:
                    listVisiveis.AddRange(new string[] { "1", "2" });
                    break;
                case 5:
                    listVisiveis.AddRange(new string[] { "1", "2" });
                    break;
            }


            class_A.Visiveis = listVisiveis;   
        
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool onePanelFoi = false;
            Dictionary<string, object> row = new Dictionary<string, object>();
            try
            {

                onePanelFoi = findPanels(row, onePanelFoi);

                goToForm(new A6());
                
                if (onePanelFoi)
                {

                    updateRow(row);

                    //if (this.RadioButton11.Checked)
                    //{
                    //    MessageBox.Show("Salvo! - Encerrando");
                    //    Application.Exit();
                    //}
                    //else
                    //{
                    //MessageBox.Show("Salvo! - Passar implementacao para proxima tela");
                    goToForm(new A6());
                    //}
                }
                else
                {
                    MessageBox.Show("Selecione uma das opcoes antes de continuar!");
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(String.Format("Cod:{0}: {1}", ex.ErrorCode, ex.Message));
            }

            
        }
    }
}
