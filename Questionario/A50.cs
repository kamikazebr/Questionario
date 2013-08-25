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
    public partial class A50 : MyForm
    {
        public A50()
        {
            InitializeComponent();
        }

        private void A50_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            string msg = isPT() ? String.Format("Seu veículo {0} tem uma ou mais portas laterais deslizantes ou basculantes na lateral, excluindo as portas do motorista e copiloto?", rowCurrent["A4_A_NOME"]) : String.Format("¿Su {0} tiene una o más puertas corredizas o abatibles en los laterales excluyendo las puertas del conductor y el copiloto?", rowCurrent["A4_A_NOME"]);
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

                    goToForm(new A51());
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
