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
    public partial class A37 : MyForm
    {
        public A37()
        {
            InitializeComponent();
        }

        private void A37_Load(object sender, EventArgs e)
        {

            if (this.DesignMode)
            {
                return;
            }
            string msg = isPT() ? String.Format("Com que tipo de gasolina o(a) Sr(a). geralmente abastece seu {0}?", rowCurrent["A4_A_NOME"]) : String.Format("¿Con qué tipo de nafta reabastece normalmente su {0}?", rowCurrent["A4_A_NOME"]);
            Label3.Text = msg;

            List<string> list = new List<string>();
            list.Add(isPT() ? "Petrobras: 101.5 octanas" : "Petrobras: 101.5 octanos");
            list.Add(isPT() ? "YPF fangio XXI: 98 octanas" : "YPF fangio XXI: 98 octanos");
            list.Add(isPT() ? "SHELL V-Power: 97,5 octanas" : "SHELL V-Power: 97.5 octanos");
            list.Add(isPT() ? "SUPER: 93,5 a 95 octanas" : "SUPER: 93.5 a 95 octanos");
            list.Add(isPT() ? "Comum: 83 a 85 octanas" : "Común: 83 a85 octanos");
            list.Add(isPT() ? "Gasolina comum: 87 octanas" : "Nafta común: 87 octanos");
            list.Add(isPT() ? "Gasolina Aditiva Supra: 87 octanas (+ aditivos)" : "Nafta Aditiva Supra: 87 octanos (+ aditivitos)");
            list.Add(isPT() ? "Gasolina Premium: 91 octanas" : "Nafta Premium: 91 octanos");
            list.Add(isPT() ? "Gasolina Podium: 95 octanas" : "NaftaPodium: 95 octanos");

            List<string> listVisiveis = new List<string>();

            if (isPT())
            {
                listVisiveis.AddRange(new string[] { "6", "7", "8", "9"});
            }
            else
            {
                listVisiveis.AddRange(new string[] { "1", "2", "3", "4", "5"});
            }



            //listVisiveis.Shuffle();
            class_A.Lista = list;
            class_A.Visiveis = listVisiveis;
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

                    goToForm(new A39());
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
