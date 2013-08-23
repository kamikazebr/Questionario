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
    public partial class A12 : MyForm
    {
        public A12()
        {
            InitializeComponent();
        }

        private void A12_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }

            string msg = isPT() ? String.Format("Em que ano o {0} foi registrado no seu nome/nome da sua empresa/organização?", rowCurrent["A4_A"]) : String.Format("¿En qué año se registró su {0} como particular o bajo el nombre de su compañía u organización?", rowCurrent["A4_A"]);
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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            goToForm(new A13());
        }
    }
}
