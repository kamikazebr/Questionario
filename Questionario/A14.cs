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
    public partial class A14 : MyForm
    {
        public A14()
        {
            InitializeComponent();
        }

        private void A14_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            string ent = isPT() ? "ENT: Anotar valor em uma faixa de: 1-999.999" : "ENT: Escribir el precio en un rango desde: 1-1.500.000";
            Label2.Text = ent;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            goToForm(new A15());
                        
        }
    }
}
