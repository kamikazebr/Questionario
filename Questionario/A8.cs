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
    public partial class A8 : MyForm
    {
        public A8()
        {
            InitializeComponent();
        }

        private void A8_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            goToForm(new A9());
        }
    }
}