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
    public partial class A18 : MyForm
    {
        public A18()
        {
            InitializeComponent();
        }

        private void A18_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            string msg = isPT() ? String.Format("O(a) Sr(a). fez o financiamento / consórcio para {0} por meio de uma concessionária {1} ou por um modelo de serviço independente?", rowCurrent["A4_A"], rowCurrent["A3_A"]) : String.Format("¿Ustedsolicitóel financiamiento / plan de ahorro para su {0} por intermedio de un vendedor de {1} o de un proveedor de servicios independiente?  ", rowCurrent["A4_A"], rowCurrent["A3_A"]);
            string msg1 = isPT() ? String.Format("Por meio de uma concessionária {0}", rowCurrent["A3_A"]) : String.Format("Por intermedio de un vendedor de {0}", rowCurrent["A3_A"]);
            CheckBox1.Text = msg1;
            Label3.Text = msg;
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

                    //if (this.RadioButton11.Checked)
                    //{
                    //    MessageBox.Show("Salvo! - Encerrando");
                    //    Application.Exit();
                    //}
                    //else
                    //{
                    //MessageBox.Show("Salvo! - Passar implementacao para proxima tela");
                    goToForm(new A19());
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
