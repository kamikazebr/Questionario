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
    public partial class A30 : MyForm
    {
        public A30()
        {
            InitializeComponent();
        }

        private void A30_Load(object sender, EventArgs e)
        {
             if (this.DesignMode)
            {
                return;
            }

            String msg = isPT() ? String.Format("Qual é a tara do veículo {0}, ou seja, o peso do veículo vazio, sem carga e sem passageiros?", rowCurrent["A3_A"]) : String.Format("¿Cuál es el peso neto de {0},es decir, el peso del vehículo vacíosin pasajeros ni carga?", rowCurrent["A3_A"]);
            String msg1 = isPT() ? "ENT: verifique documentos de registro para saber a tara.":"";
            Label3.Text = msg;  
            Label2.Text = msg1;
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
                    MessageBox.Show("Salvo! - Implementando outras telas.");
                    //goToForm(new A9());
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
