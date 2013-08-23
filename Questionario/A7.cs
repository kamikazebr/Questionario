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
    public partial class A7 : MyForm
    {
        public A7()
        {
            InitializeComponent();
        }

        private void A7_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }         
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            goToForm(new A8());
        }
    }
}
