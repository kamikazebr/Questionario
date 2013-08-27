using ClassLibrary1;
using Questionario.Banco_de_Dados1DataSetTableAdapters;
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
    public partial class A6 : MyForm
    {
        public A6()
        {
            InitializeComponent();
        }

        private void A6_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            string msg = isPT() ? String.Format("Qual é o tipo de carroceria do seu {0}", rowCurrent["A4_A_NOME"]) : "¿Qué tipo de carrocería tienesu ";
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

            string nome = (string)rowCurrent["A4_A_NOME"];


            MyList<string> list = new MyList<string>();

            MyList<string> listVisiveis = new MyList<string>();


            list.AddRange(new string[] { 
                "Veículo sem bancos traseiros, geralmente chamado van de carga – utilizado para transporte de cargas (não um chassi com carroceria)\n\nENT: possui apenas os bancos dianteiros; geralmente (mas nem sempre) não tem janelas atrás e é chamado de furgão ou van de carga",
                "Veículo com exatamente uma fileira de bancos traseiros atrás do motorista, geralmente chamado de van mista",
            "Van de passeio com mais de uma fileira de bancos traseiros (inteiriços ou individuais), usada principalmente para transporte de passageiros",
            "Chassi com carroceria, p. ex. carroceria aberta, caixa fechada, freezer, basculante, etc.",
            "Trailer/caravana",
            "Outro",
            "Não sabe",
            "Não responde"
            });

            BrasilTableAdapter brasilAdapter = new Banco_de_Dados1DataSetTableAdapters.BrasilTableAdapter();
            Questionario.Banco_de_Dados1DataSet.BrasilDataTable table = brasilAdapter.GetDataA6By(nome);

            foreach(Questionario.Banco_de_Dados1DataSet.BrasilRow row in table.Rows){
                Console.WriteLine("Modelo: {0}",row.Cod_A6);
                listVisiveis.Add(row.Cod_A6.ToString());
            }

            listVisiveis.AddRange(new string[]{"6","7","8"});
            class_A.Lista = list;
            class_A.Visiveis = listVisiveis;
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool onePanelFoi = false;
            Dictionary<string, object> row = new Dictionary<string, object>();
            try
            {

                onePanelFoi = findPanels(row, onePanelFoi);

                goToForm(new A6());

                if (onePanelFoi)
                {

                    updateRow(row);

                    if (class_A.Radios["6"].Checked || class_A.Radios["7"].Checked || class_A.Radios["8"].Checked)
                    {
                        goToFormEncerrar();
                    }
                    else if (class_A.Radios["1"].Checked || class_A.Radios["2"].Checked || class_A.Radios["3"].Checked)
                    {
                        goToForm(new A8());
                    }
                    else if (class_A.Radios["4"].Checked)
                    {
                        goToForm(new A7());
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
    }
}
