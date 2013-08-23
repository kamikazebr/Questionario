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
    public partial class A0 : MyForm
    {
        public A0()
        {
            InitializeComponent();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            Dictionary<String, Object> row = new Dictionary<string, object>();
            try
            {


                //rowCurrent = dataTable.NewRow();
                //dataTable.Rows.Add(rowCurrent);
                row["data"] = DateTime.Now;

                bool onePanelFoi = false;

                onePanelFoi = findPanels(row, onePanelFoi);
                if (onePanelFoi)
                {
                    updateRow(row);
                    goToForm(new A1());
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
        private void A0_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoDataSet.questionario' table. You can move, or remove it, as needed.
            if (this.DesignMode)
            {
                return;
            }
            Console.WriteLine("Native lingua: {0}", System.Globalization.CultureInfo.CurrentCulture.Name);

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
