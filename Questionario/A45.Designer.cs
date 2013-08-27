namespace Questionario
{
    partial class A45
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A45));
            this.Button1 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel_A = new System.Windows.Forms.Panel();
            this.class_A = new ClassLibrary1.Class1();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.RadioButton8 = new System.Windows.Forms.RadioButton();
            this.RadioButton7 = new System.Windows.Forms.RadioButton();
            this.RadioButton6 = new System.Windows.Forms.RadioButton();
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
            this.panel_A.Controls.Add(this.class_A);
            this.panel_A.Controls.Add(this.TextBox1);
            this.panel_A.Controls.Add(this.RadioButton8);
            this.panel_A.Controls.Add(this.RadioButton7);
            this.panel_A.Controls.Add(this.RadioButton6);
            this.panel_A.Name = "panel_A";
            // 
            // class_A
            // 
            resources.ApplyResources(this.class_A, "class_A");
            this.class_A.Name = "class_A";
            this.class_A.Radios = ((System.Collections.Generic.Dictionary<string, System.Windows.Forms.RadioButton>)(resources.GetObject("class_A.Radios")));
            // 
            // TextBox1
            // 
            resources.ApplyResources(this.TextBox1, "TextBox1");
            this.TextBox1.Name = "TextBox1";
            // 
            // RadioButton8
            // 
            resources.ApplyResources(this.RadioButton8, "RadioButton8");
            this.RadioButton8.Name = "RadioButton8";
            this.RadioButton8.TabStop = true;
            this.RadioButton8.UseVisualStyleBackColor = true;
            // 
            // RadioButton7
            // 
            resources.ApplyResources(this.RadioButton7, "RadioButton7");
            this.RadioButton7.Name = "RadioButton7";
            this.RadioButton7.TabStop = true;
            this.RadioButton7.UseVisualStyleBackColor = true;
            // 
            // RadioButton6
            // 
            resources.ApplyResources(this.RadioButton6, "RadioButton6");
            this.RadioButton6.Name = "RadioButton6";
            this.RadioButton6.TabStop = true;
            this.RadioButton6.Tag = "TextBox1";
            this.RadioButton6.UseVisualStyleBackColor = true;
            // 
            // PictureBox2
            // 
            resources.ApplyResources(this.PictureBox2, "PictureBox2");
            this.PictureBox2.Image = global::Questionario.Properties.Resources.psyma_logo;
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.TabStop = false;
            // 
            // A45
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_A);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "A45";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.A45_Load);
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
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.RadioButton RadioButton8;
        internal System.Windows.Forms.RadioButton RadioButton7;
        internal System.Windows.Forms.RadioButton RadioButton6;
        private ClassLibrary1.Class1 class_A;
    }
}