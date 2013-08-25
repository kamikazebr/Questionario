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
    public partial class A48 : MyForm
    {
        public A48()
        {
            InitializeComponent();
        }

        private void A48_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            MyList<string> list = new MyList<string>();
            list.Add(isPT() ? "Transmissão manual de 4 marchas" : "Transmisión manual de 4 velocidades");
            list.Add(isPT() ? "Transmissão manual de 5 marchas" : "Transmisión manual de 5 velocidades");
            list.Add(isPT() ? "Transmissão manual de 6 marchas" : "Transmisión manual de 6 velocidades");
            list.Add(isPT() ? "Transmissão automática" : "Transmisión automática");
            list.Add(isPT() ? "Transmissão semiautomática / manual automatizada / " + "Dual-clutch" + "" : "Semiautomática /manual automatizada/Transmisión de doble embrague");
            list.Add(isPT() ? "GNV/Gás Natural Veicular mais diesel" : "GNC/ Gas Natural Comprimido másdiesel");
            
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

                    goToForm(new A49());
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
