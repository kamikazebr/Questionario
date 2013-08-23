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
    public partial class A16 : MyForm
    {
        public A16()
        {
            InitializeComponent();
        }

        private void A16_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            string ent = isPT() ? "ENT: Anotar valor em uma faixa de: 1-9.999" : "ENT: Escribir el precio en un rango desde: 1-19.999";
            numericUpDown1.Maximum = isPT() ? 9999 : 19999 ;
            
            Label2.Text = ent;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            goToForm(new A17());
        }
    }
}
