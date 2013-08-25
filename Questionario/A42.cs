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
    public partial class A42 : MyForm
    {
        public A42()
        {
            InitializeComponent();
        }

        private void A42_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            string msg = isPT() ? String.Format("É possível rodar seu veículo {0} exclusivamente a gás, ou é somente possível rodar com uma mistura de gás / diesel?", rowCurrent["A4_A_NOME"]) : String.Format("¿Es posible que su {0} funcione solamente con gas o sololo hace con una combinación de gas/diesel?", rowCurrent["A4_A_NOME"]);
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

                    goToForm(new A43());
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
