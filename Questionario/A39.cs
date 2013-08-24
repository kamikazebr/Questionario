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
    public partial class A39 : MyForm
    {
        public A39()
        {
            InitializeComponent();
        }

        private void A39_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
          

            //string msg = isPT() ? String.Format("O motor a {0} veio de fábrica ou foi convertido posteriormente?", rowCurrent["A4_A_NOME"]) : String.Format("¿Sabe si el motor de {0} de su vehículo esde fábrica o lo adaptaron después?", rowCurrent["A4_A_NOME"]);
            //Label3.Text = msg;
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

                    goToForm(new A40());
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
