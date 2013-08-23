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
    public partial class A26 : MyForm
    {
        public A26()
        {
            InitializeComponent();
        }

        private void A26_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            goToForm(new A27());
        }
    }
}
