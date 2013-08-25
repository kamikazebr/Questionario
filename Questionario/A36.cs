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
    public partial class A36 : MyForm
    {
        public A36()
        {
            InitializeComponent();
        }

        private void A36_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            string msg = isPT() ? String.Format("Seu {0} é movido a que combustível?", rowCurrent["A4_A_NOME"]) : String.Format("¿Qué de combustible usa el motor de su {0}?", rowCurrent["A4_A_NOME"]);
            Label3.Text = msg;

            MyList<string> list = new MyList<string>();
            list.Add(isPT() ? "Gasolina" : "Nafta");
            list.Add(isPT() ? "Diesel" : "Diesel");
            list.Add(isPT() ? "GLP/ Gás de petróleo liquefeito mais gasolina " : "GLP/Gas Licuado de Petróleo más nafta");
            list.Add(isPT() ? "GNV ou Gás Natural Veicular mais gasolina" : "GNC/Gas Natural Comprimido más nafta");
            list.Add(isPT() ? "GNV ou Gás Natural Veicular" : "GNC/Gas Natural Comprimido");
            list.Add(isPT() ? "CNG/Compressed Natural Gasplus diesel" : "GNC/Gas Natural Comprimido");
            list.Add(isPT() ? "Flex / total flex: etanol e gasolina ou uma mistura dos dois" : "Combustible flexible (Flex fuel)/vehículo total flex: etanoly nafta o una mezcla de los mismos");
            list.Add(isPT() ? "Triflex/ Multiflex/ Nafta, gas más alcohol" : "Triflex/ Multiflex/ Nafta, gas más alcohol");

            MyList<string> listVisiveis = new MyList<string>();

            if (isPT())
            {
                listVisiveis.AddRange(new string[] { "1", "2", "4", "5", "7", "8", "9", "10", "11"});
            }
            else {
                listVisiveis.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" });
            }
            
               

            //listVisiveis.Shuffle();
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

                    goToForm(new A37());
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
