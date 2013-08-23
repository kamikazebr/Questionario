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
    public partial class A29 : MyForm
    {
        public A29()
        {
            InitializeComponent();
        }

        private void A29_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            String msg = isPT() ? String.Format("Qual é o peso bruto máximo do veículo {0}, ou seja, o peso líquido do veículo, mais o peso máximo possível de passageiros e carga?", rowCurrent["A3_A"]) : String.Format("¿Cuál es el máximo del CPBV del {0}, es decir, el peso neto del vehículomás el peso máximo posible de pasajeros y carga?", rowCurrent["A3_A"]);
            String msg1 = isPT() ? "ENT: verifique documentos de registro para saber o peso bruto técnico do veículo (PBT)":"";
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
                    //MessageBox.Show("Salvo! - Passar implementacao para proxima tela");
                    goToForm(new A30());
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
