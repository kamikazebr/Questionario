namespace Questionario
{
    partial class A47
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A47));
            this.Button1 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel_A = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.panel_A.Controls.Add(this.radioButton2);
            this.panel_A.Controls.Add(this.radioButton1);
            this.panel_A.Controls.Add(this.class_A);
            resources.ApplyResources(this.panel_A, "panel_A");
            this.panel_A.Name = "panel_A";
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // class_A
            // 
            resources.ApplyResources(this.class_A, "class_A");
            this.class_A.Name = "class_A";
            this.class_A.Radios = ((System.Collections.Generic.Dictionary<string, System.Windows.Forms.RadioButton>)(resources.GetObject("class_A.Radios")));
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::Questionario.Properties.Resources.psyma_logo;
            resources.ApplyResources(this.PictureBox2, "PictureBox2");
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.TabStop = false;
            // 
            // A47
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_A);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "A47";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.A47_Load);
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
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private ClassLibrary1.Class1 class_A;
    }
}