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
    public partial class A15 : MyForm
    {
        public A15()
        {
            InitializeComponent();
        }

        private void A15_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            string ent = isPT() ? "ENT: Anotar valor numérico em uma faixa de 1-9.999" : "ENT: Escriba el valor numérico en un rango desde: 1-19.999";
            string msg = isPT() ? "Qual é o valor mensal da prestação do seu consórcio?" : "¿Cuál es el pago mensual al Plan de Ahorro?";
           
            Label3.Text = msg;
            Label2.Text = ent;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            goToForm(new A16());
        }
    }
}
