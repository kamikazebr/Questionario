﻿using System;
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
    public partial class A28 : MyForm
    {
        public A28()
        {
            InitializeComponent();
        }

        private void A28_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            String msg = isPT() ? String.Format("Exatamente quantos assentos inteiriços (= banco único) ou assentos individuais o seu {0} tem na parte de trás (atrás do motorista)?", rowCurrent["A3_A"]) : String.Format("Exactamente,  ¿cuántos asientos corridos y cuántos individuales (=sencillos-) tiene su {0} en la parte trasera (detrás del conductor)?", rowCurrent["A3_A"]);
            Label3.Text = msg;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            goToForm(new A29());
        }
    }
}
