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
    public partial class A5 : MyForm
    {
        public A5()
        {
            InitializeComponent();
        }

        private void A5_Load(object sender, EventArgs e)
        {
             if (this.DesignMode)
            {
                return;
            }

             string msg = isPT() ? String.Format("Qual é a linha de modelo do {0}",rowCurrent["A4_A"]) : "¿Cuál es el la línea de modelo de su ";
            int A1 = (int)rowCurrent["A1_A"];
            if (A1 == 1)
            {
                int A1_EXTRAS = convertStringToInt((string)rowCurrent["A1_A_EXTRAS"]);
                if (A1_EXTRAS > 1)
                {
                    //msg = isPT() ? "Qual é o modelo da sua van mais nova?" : "¿Cuál es el modelo de la camioneta que compró más recientemente?";
                }
            }
            Label3.Text = msg;

            List<string> list = new List<string>();
            list.Add("Citroën Berlingo");
            list.Add("Citroën Jumper");
            list.Add("Fiat Qubo/ Fiat FiorinoQubo");
            list.Add("Fiat Doblo");
            list.Add("Fiat Ducato");
            list.Add("Fiat Fiorino");
            list.Add("Hyundai H1");
            list.Add("Ford Transit");
            list.Add("IvecoDaily");
            list.Add("JinbeiTopic");
            list.Add("MB Sprinter");
            list.Add("Peugeot Boxer");
            list.Add("Peugeot Expert");
            list.Add("Peugeot Partner");
            list.Add("Renault Kangoo");
            list.Add("Renault Master");
            list.Add("Volkswagen T2 ");

            list.Add(isPT() ? "Outro modelo/não sabe/não responde" : "Otromodelo/no sabe/no contesta");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            goToForm(new A6());
        }
    }
}
