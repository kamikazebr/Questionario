using ClassLibrary1;
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
    public partial class A43 : MyForm
    {
        public A43()
        {
            InitializeComponent();
        }

        private void A43_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            MyList<string> list = new MyList<string>();
            list.Add(isPT() ? "Gasolina" : "Nafta");
            list.Add(isPT() ? "Diesel" : "Diesel");
            list.Add(isPT() ? "GLP/ Gas Licuado de Petróleo más nafta" : "GLP/Gás de petróleo liquefeito mais gasolina");
            list.Add(isPT() ? "GNV/Gás Natural Veicular mais gasolina" : "GNC/ Gas Natural Comprimido más nafta");
            list.Add(isPT() ? "GNV/Gás Natural Veicular" : "GNC/ Gas natural Comprimido");
            list.Add(isPT() ? "GNV/Gás Natural Veicular mais diesel" : "GNC/ Gas Natural Comprimido másdiesel");
            list.Add(isPT() ? "Flex-fuel total flex: etanol e gasolina ou uma mistura dos dois" : "Combustible flexible (Flex Fuel)/vehículo totalflex: etanol y nafta ouna mezcla delas anteriores");
            list.Add(isPT() ? "Biodiesel" : "Biodiesel");
            list.Add(isPT() ? "Bioetanol" : "Bioetanol");

            list.Add(isPT() ? "Motor totalmente elétrico" : "Transmisióntotalmente eléctrica");
            list.Add(isPT() ? "Motor híbrido combinado com diesel" : "Motor híbrido combinado con diesel");
            list.Add(isPT() ? "Motor híbrido combinado com gasolina" : "Motor híbrido combinado con nafta");
            list.Add(isPT() ? "Célula de combustível" : "Pila de combustible");

            MyList<string> listVisiveis = new MyList<string>();

            listVisiveis.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14" });

            
            class_A.Lista = list;
            class_A.Visiveis = listVisiveis;
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

                    goToForm(new A44());
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
