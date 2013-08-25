using ClassLibrary1;
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
    public partial class A45 : MyForm
    {
        public A45()
        {
            InitializeComponent();
        }

        private void A45_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            MyList<string> list = new MyList<string>();
            list.Add(isPT() ? "4 cilindros" : "Motor de 4cilindros");
            list.Add(isPT() ? "5 cilindros" : "Motor de 5 cilindros");
            list.Add(isPT() ? "6 cilindros" : "Motor de 6 cilindros");
            list.Add(isPT() ? "8 cilindros" : "Motor de 8 cilindros");
            list.Add(isPT() ? "10 cilindros" : "Motor de 10 cilindros");
            
            //List<string> listVisiveis = new List<string>();

            //listVisiveis.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14" });


            class_A.Lista = list;
            //class_A.Visiveis = listVisiveis;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool onePanelFoi = false;
            Dictionary<string, object> row = new Dictionary<string, object>();
            try
            {

                onePanelFoi = findPanels(row, onePanelFoi);
                if (onePanelFoi)
                {

                    updateRow(row);

                    goToForm(new A46());
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
