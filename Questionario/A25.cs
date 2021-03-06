﻿using System;
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
    public partial class A25 : MyForm
    {
        public A25()
        {
            InitializeComponent();
        }

        private void A25_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            String msg = isPT() ? String.Format("Agora, gostaria de falar sobre os assentos do {0}", rowCurrent["A3_A"]) : String.Format("Ahora quisiera hablar de los asientos en su {0}", rowCurrent ["A3_A"]);
            String msg1 = isPT() ? String.Format("Quantos assentos – incluindo o banco do motorista – o seu {0} tem, no total?", rowCurrent["A3_A"]) : String.Format("¿Cuántos asientos en total, incluyendo el del conductor, tiene su {0}?", rowCurrent["A3_A"]);
            Label3.Text = msg;
            label4.Text = msg1;
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
                    goToForm(new A26());
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

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                numericUpDown1.Enabled = true;
            }
            else {
                numericUpDown1.Enabled = false;
            }
        }
    }
}
