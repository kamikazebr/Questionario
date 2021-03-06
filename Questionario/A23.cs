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
    public partial class A23 : MyForm
    {
        public A23()
        {
            InitializeComponent();
        }

        private void A23_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            String msg = isPT() ? String.Format ("O(A) Sr(a). adquiriu seus serviços adicionais por meio da concessionária {0} ou por meio de um fornecedor de serviços independente?", rowCurrent["A3_A"]) : String.Format("¿Negoció los servicios adicionales conun vendedor de la {0} o un proveedor de servicios independiente?", rowCurrent["A3_A"]);
            Label3.Text = msg;
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
                    goToForm(new A24());
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
    }
}
