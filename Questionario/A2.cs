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
    public partial class A2 : MyForm
    {
        public A2()
        {
            InitializeComponent();
        }

        private void A2_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;

            }


            //if (System.Globalization.CultureInfo.DefaultThreadCurrentCulture)

            string msg = isPT() ? "Pode me dizer em que ano sua van foi fabricada, ou seja, qual o ano modelo do seu veículo?" : "Por favor, dígame el año de fabricación de su camioneta, así como el año del modelo de su vehículo?";
            int A1 = (int)rowCurrent["A1_A"];
            if (A1 == 1)
            {
                int A1_EXTRAS = convertStringToInt((string)rowCurrent["A1_A_EXTRAS"]);
                if (A1_EXTRAS > 1)
                {
                    msg = isPT() ? "Pode me dizer em que ano sua van mais nova, dentre os modelos que listamos, foi fabricada, ou seja, qual o ano modelo desse veículo?" : "De los modelos que están en la lista, por favor, dígame el año en que se fabricó la camioneta más reciente que haya comprado, así como el año del modelo de su vehículo?";
                }
            }
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

                    if (this.numericUpDown1.Value < 2009)
                    {
                        goToForm(new Encerrado());
                    }
                    else
                    {
                        //MessageBox.Show("Salvo! - Passar implementacao para proxima tela");
                        goToForm(new A3());
                    }
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

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //TODO pegar componente via TAG futuramente, para metodo e componente dinamicamente!
            numericUpDown1.Enabled = ((RadioButton)sender).Checked;
        }
    }
}
