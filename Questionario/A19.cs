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
    public partial class A19 : MyForm
    {
        public A19()
        {
            InitializeComponent();
        }

        private void A19_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            string msg = isPT() ? String.Format("O(a) Sr(a). consideraria fazer um consórcio / financiamento com uma concessionária {0}", rowCurrent["A3_A"]) : String.Format("¿Podría imaginarse estableciendo un consorcio / un financiamiento conel vendedor de una {0}", rowCurrent["A3_A"]);
            Label3.Text = msg;
        }
    }
}
