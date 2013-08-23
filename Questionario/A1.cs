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
    public partial class A1 : MyForm
    {
        public A1()
        {
            InitializeComponent();
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

                    if (this.numericUpDown1.Value == 0 || RadioButton2.Checked)
                    {
                        goToForm(new Encerrado());
                    }
                    else
                    {
                        //MessageBox.Show("Salvo! - Passar implementacao para proxima tela");
                        //goToForm(new A3());
                        goToForm(new A2());
                    }


                    //MessageBox.Show("Salvo! - Passar implementacao para proxima tela");
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

        private void A1_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(A0.rowCurrent.A0);
            if (this.DesignMode)
            {
                return;
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //TODO pegar componente via TAG futuramente, para metodo e componente dinamicamente!
            numericUpDown1.Enabled = ((RadioButton)sender).Checked;
        }

        private void panel_A_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
