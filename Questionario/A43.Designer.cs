namespace Questionario
{
    partial class A43
    {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A43));
            this.Button1 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel_A = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.class_A = new ClassLibrary1.Class1();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            resources.ApplyResources(this.Button1, "Button1");
            this.Button1.Name = "Button1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label5.Name = "Label5";
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.Name = "Label3";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Name = "Label1";
            // 
            // panel_A
            // 
            resources.ApplyResources(this.panel_A, "panel_A");
            this.panel_A.Controls.Add(this.textBox1);
            this.panel_A.Controls.Add(this.radioButton18);
            this.panel_A.Controls.Add(this.radioButton17);
            this.panel_A.Controls.Add(this.radioButton16);
            this.panel_A.Controls.Add(this.radioButton15);
            this.panel_A.Controls.Add(this.class_A);
            this.panel_A.Name = "panel_A";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // radioButton18
            // 
            resources.ApplyResources(this.radioButton18, "radioButton18");
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.TabStop = true;
            this.radioButton18.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            resources.ApplyResources(this.radioButton17, "radioButton17");
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.TabStop = true;
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            resources.ApplyResources(this.radioButton16, "radioButton16");
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.TabStop = true;
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            resources.ApplyResources(this.radioButton15, "radioButton15");
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.TabStop = true;
            this.radioButton15.Tag = "textBox1";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // class_A
            // 
            resources.ApplyResources(this.class_A, "class_A");
            this.class_A.Name = "class_A";
            this.class_A.Radios = ((System.Collections.Generic.Dictionary<string, System.Windows.Forms.RadioButton>)(resources.GetObject("class_A.Radios")));
            // 
            // PictureBox2
            // 
            resources.ApplyResources(this.PictureBox2, "PictureBox2");
            this.PictureBox2.Image = global::Questionario.Properties.Resources.psyma_logo;
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.TabStop = false;
            // 
            // A43
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_A);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "A43";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.A43_Load);
            this.panel_A.ResumeLayout(false);
            this.panel_A.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Panel panel_A;
        private ClassLibrary1.Class1 class_A;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton16;
    }
}