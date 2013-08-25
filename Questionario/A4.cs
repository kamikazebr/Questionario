using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionario
{
    public partial class A4 : MyForm
    {
        public A4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool onePanelFoi = false;
            Dictionary<string, object> row = new Dictionary<string, object>();
            try
            {

                onePanelFoi = findPanels(row, onePanelFoi);
                if (onePanelFoi)
                {

                    updateRow(row);

                    //if (this.RadioButton11.Checked)
                    //{
                    //    MessageBox.Show("Salvo! - Encerrando");
                    //    Application.Exit();
                    //}
                    //else
                    //{
                    //MessageBox.Show("Salvo! - Passar implementacao para proxima tela");
                    goToForm(new A5());
                    //}
                }
                else
                {
                    MessageBox.Show("Selecione uma das opcoes antes de continuar!");
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(String.Format("Cod:{0}: {1}", ex.ErrorCode, ex.Message));
            }
        }

        private void A4_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            string msg = isPT() ? "Qual é o modelo da sua van?" : "¿Cuál es el modelo es su camioneta?";
            int A1 = (int)rowCurrent["A1_A"];
            if (A1 == 1)
            {
                int A1_EXTRAS = convertStringToInt((string)rowCurrent["A1_A_EXTRAS"]);
                if (A1_EXTRAS > 1)
                {
                    msg = isPT() ? "Qual é o modelo da sua van mais nova?" : "¿Cuál es el modelo de la camioneta que compró más recientemente?";
                }
            }
            Label3.Text = msg;

            MyList<string> list = new MyList<string>();
            list.Add("Citroën Berlingo");
            list.Add("Citroën Jumper");
            list.Add("Fiat Qubo/ Fiat FiorinoQubo");
            list.Add("Fiat Doblo");
            list.Add("Fiat Ducato");
            list.Add("Fiat Fiorino");
            list.Add("Hyundai H1");
            list.Add("Ford Transit");
            list.Add("Iveco Daily");
            list.Add("JinbeiTopic");
            list.Add("MB Sprinter");
            list.Add("Peugeot Boxer");
            list.Add("Peugeot Expert");
            list.Add("Peugeot Partner");
            list.Add("Renault Kangoo");
            list.Add("Renault Master");
            list.Add("Volkswagen T2 ");

            list.Add(isPT() ? "Outro modelo/não sabe/não responde" : "Otromodelo/no sabe/no contesta");

            MyList<string> listVisiveis = new MyList<string>();

            int A3_A = (int)rowCurrent["A3_A"];

            switch (A3_A)
            {
                case 1:
                    listVisiveis.Add(isPT() ? "2" : "1");
                    break;
                case 2:
                    if (!isPT())
                    {
                        listVisiveis.Add("3");
                    }
                    listVisiveis.AddRange(new string[] { "4", "5", "6" });

                    break;

                case 3:
                    listVisiveis.Add("8");
                    break;

                case 4:
                    if (!isPT())
                    {
                        listVisiveis.Add("7");
                    }
                    break;
                case 5:
                    listVisiveis.Add("9");
                    break;
                case 6:
                    if (isPT())
                    {
                        listVisiveis.Add("10");
                    }
                    break;
                case 7:
                    listVisiveis.Add("11");
                    break;
                case 8:
                    if (!isPT())
                    {
                        listVisiveis.AddRange(new string[] { "13", "14" });
                    }
                    else
                    {
                        listVisiveis.AddRange(new string[] { "12", "14" });
                    }
                    break;
                case 9:
                    listVisiveis.AddRange(new string[] {"15", "16"});
                    break;
                case 10:
                    if(isPT()){
                        listVisiveis.Add("17");
                    }
                    
                    break;    
            }


            //listVisiveis.Shuffle();
            class_A.Lista = list;
            class_A.Visiveis = listVisiveis;


        }
    }
}
