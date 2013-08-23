using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionario
{
    public partial class A27 : MyForm
    {
        public A27()
        {
            InitializeComponent();
        }

        private void A27_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            String msg = isPT() ? String.Format("Quantas fileiras de assentos o seu {0} tem atrás dos assentos do motorista e dos passageiros dianteiros?", rowCurrent["A3_A"]) : String.Format("¿Cuántas filas de asientos en su {0} hay detrás del asiento del conductor y del asiento del copiloto?", rowCurrent["A3_A"]);
            Label3.Text = msg;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            goToForm(new A28());
        }
    }
}
