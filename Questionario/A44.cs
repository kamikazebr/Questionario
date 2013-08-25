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
    public partial class A44 : MyForm
    {
        public A44()
        {
            InitializeComponent();
        }

        private void A44_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            string msg = isPT() ? String.Format("Qual seria o motivo determinante para o(a) Sr(a). ter comprado o {0} com {1}?", rowCurrent["A4_A_NOME"], rowCurrent["A43_A"]) : String.Format("¿Cuál sería la razón determinante para comprar su {0} con {1}?", rowCurrent["A4_A_NOME"], rowCurrent["A43_A"]);
            Label3.Text = msg;

            checkedListBox1.Items.Add(isPT() ? "Foi recomendado por amigos/conhecidos" : "Recomendado por amigos/conocidos");
            checkedListBox1.Items.Add(isPT() ? "Meus clientes queriam" : "Mis clientes lo pidieron");
            checkedListBox1.Items.Add(isPT() ? "Eu sempre uso a última tecnologia" : "Siempre uso lo último en tecnología");
            checkedListBox1.Items.Add(isPT() ? "É adequado ao meu uso do veículo" : "Se adapta al uso de mi vehículo");
            checkedListBox1.Items.Add(isPT() ? "Menor consumo de combustível" : "Reduce el consumo de combustible");
            checkedListBox1.Items.Add(isPT() ? "Custo operacional mais baixo" : "Reduce los precios de operación");
            checkedListBox1.Items.Add(isPT() ? "Imagem ecológica" : "Imagen ambientalista");
            checkedListBox1.Items.Add(isPT() ? "Subsídio para a conversão" : "Subvencióncuando lo adaptan");
            checkedListBox1.Items.Add(isPT() ? "Oferta de crédito sem juros" : "Me ofrecen un crédito sin intereses");
            
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

                    goToForm(new A45());
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
