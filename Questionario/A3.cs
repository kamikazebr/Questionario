using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionario
{

    using CustomExtensions;
    using System.Data.OleDb;
    public partial class A3 : MyForm
    {
        public A3()
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

                    if (this.class_A.Radios["11"].Checked)
                    {
                        MessageBox.Show("Salvo! - Encerrando");
                        Application.Exit();
                    }
                    else
                    {

                        goToForm(new A4());
                    }
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

        private void A3_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            string msg = "De que marca é sua van?";
            int A1 = (int)rowCurrent["A1_A"];
            if (A1 == 1)
            {
                int A1_EXTRAS = convertStringToInt((string)rowCurrent["A1_A_EXTRAS"]);
                if (A1_EXTRAS > 1)
                {
                    msg = "De que marca é a sua van mais nova, <b>cujo ano modelo seja 2009 ou mais recente?</b>";
                }
            }
            Label3.Text = msg;

            List<string> list = new List<string>();
            list.Add("Citroën");
            list.Add("Fiat");
            list.Add("Ford");
            list.Add("Hyundai");
            list.Add("Iveco");
            list.Add("Jinbei");
            list.Add("Mercedes-Benz");
            list.Add("Peugeot");
            list.Add("Renault");
            list.Add("VW");

            List<string> listVisiveis = new List<string>();



            listVisiveis.Add("1");
            listVisiveis.Add("2");
            listVisiveis.Add("3");
            if (!isPT())
                listVisiveis.Add("4");
            listVisiveis.Add("5");
            if (isPT())
                listVisiveis.Add("6");
            listVisiveis.Add("7");
            listVisiveis.Add("8");
            listVisiveis.Add("9");
            if (isPT())
                listVisiveis.Add("10");



            listVisiveis.Shuffle();


            list.Add("Outros/Não sabe/Não responde");
            listVisiveis.Add("11");

            class_A.Lista = list;
            class_A.Visiveis = listVisiveis;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

namespace CustomExtensions
{
    public static class MyExtensions
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static class ThreadSafeRandom
        {
            [ThreadStatic]
            private static Random Local;

            public static Random ThisThreadsRandom
            {
                get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
            }
        }
    }
}


