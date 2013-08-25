using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
    {

        [Browsable(false)]
        Dictionary<string, RadioButton> radios { get; set; }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            //this.radioButton1 = new System.Windows.Forms.RadioButton();
            //this.radioButton1.AutoSize = true;
            //this.radioButton1.Location = new System.Drawing.Point(27, 46);
            //this.radioButton1.Name = "radioButton1";
            //this.radioButton1.Size = new System.Drawing.Size(85, 17);
            //this.radioButton1.TabIndex = 0;
            //this.radioButton1.TabStop = true;
            //this.radioButton1.Text = "radioButton1";
            //this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 

            this.Controls.Clear();

            //listVis.Clear();
            radios = new Dictionary<string, RadioButton>();

            int w = 104;
            int h = 24;

            for (int i = 0; i < _lista.Count; i++)
            {
                string posString = String.Format("{0}", i + 1);
                Point p = new System.Drawing.Point(0, 0);
                Size s = new System.Drawing.Size(w, h);
                string name = String.Format("RadioButton{0}", i + 1);
                RadioButton rb = criarRadioButton(name, _lista.ElementAt<string>(i), p, s);
                radios.Add(posString, rb);
            }

            //if (this.DesignMode)
            //{
            //    return;
            //}
            for (int i = 0; i < _visiveis.Count; i++)
            {
                //string posString = String.Format("{0}",i+1);
                Point p = new System.Drawing.Point(0, i * h);
                RadioButton rb = radios[_visiveis[i]];
                rb.Location = p;
                this.Controls.Add(rb);
            }
            this.PerformLayout();
            this.ResumeLayout(true);


            //this.Controls.Add(this.radioButton1);
            this.Name = "UserControl1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public RadioButton criarRadioButton(string name, string text, Point point, Size size)
        {
            RadioButton radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton1.AutoSize = true;
            radioButton1.Location = point;
            radioButton1.Name = name;
            radioButton1.Size = size;
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = text;
            radioButton1.UseVisualStyleBackColor = true;
            return radioButton1;
        }
        #endregion


        

       
        //private System.Windows.Forms.RadioButton radioButton1;
    }
}
