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
    public partial class Inicio : MyForm
    {
        public Inicio()
        {
            InitializeComponent();
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("pt", true);
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = ci;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = ci;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo((string)((Control)sender).Tag,true);
            //System.Threading.Thread.CurrentThread.Def CurrentCulture = ci;
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = ci;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture= ci;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            RefreshResources(this, resources, ci);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new A0().Show();
        }
        private void RefreshResources(Control ctrl, ComponentResourceManager res, System.Globalization.CultureInfo CurrentLocale)
        {
            ctrl.SuspendLayout();
            res.ApplyResources(ctrl, ctrl.Name, CurrentLocale);
            foreach (Control control in ctrl.Controls)
                RefreshResources(control, res,CurrentLocale); // recursion
            ctrl.ResumeLayout(false);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }

    }
}
