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
    public partial class A9 : MyForm
    {
        public A9()
        {
            InitializeComponent();
        }

        private void A9_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            if (rowCurrent == null){
                return;
            }
            string msg = isPT() ? String.Format("Em que porcentagens o {0} é usado para fins comerciais, para ir e voltar do trabalho, e para fins particulares?", rowCurrent["A4_A_NOME"]) : String.Format("¿En qué porcentaje se utiliza el {0} confines empresariales, para trasladarse al lugar de trabajo y confines particulares?", rowCurrent["A4_A_NOME"]);
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
        //FAzer ARRAY para implementar com checkees
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int totalPercent = (int)(numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value);
            if (totalPercent > 100){
               int diff =  totalPercent - 100;

               if (diff > 1)
               {
                   if (diff % 2 == 0)
                   {
                       int diffPCada = diff / 2;
                       numericUpDown2.Value -= diff;
                       // numericUpDown1.ValueChanged -= numericUpDown1_ValueChanged;
                       //numericUpDown1.Value += diffPCada;
                       //numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
                       numericUpDown3.Value += diffPCada;
                   }
                   else
                   {
                       int diffPCada = diff / 2;
                       numericUpDown2.Value -= diff;
                       //numericUpDown1.ValueChanged -= numericUpDown1_ValueChanged;
                       //numericUpDown1.Value += diffPCada;
                       //numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
                       
                       numericUpDown3.Value += diffPCada;
                   }
               }
               else
               {
                   numericUpDown2.Value -= diff;
                    //numericUpDown1.ValueChanged -= numericUpDown1_ValueChanged;
                    //   numericUpDown1.Value += diff;
                    //   numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
                   //numericUpDown3.Value += diffPCada;
               }

            }
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
                    goToForm(new A10());
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
