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
    public partial class A21 : MyForm
    {
        public A21()
        {
            InitializeComponent();
        }

        private void A21_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            goToForm(new A22());
        }
    }
}
