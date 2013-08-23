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
    public partial class Encerrado : MyForm
    {
        public Encerrado()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Button1.Text = isPT() ? "Recomeçar" : "Reanudar";
            }
            else {
                Button1.Text = isPT() ? "Finalizar": "Terminar";
            }
        }

        private void Encerrado_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                goToForm(new Inicio());
            }
            else {
                Application.Exit();
            }
        }
    }
}
