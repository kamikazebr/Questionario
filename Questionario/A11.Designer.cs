namespace Questionario
{
    partial class A11
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel_A = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(951, 597);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(254, 110);
            this.Button1.TabIndex = 143;
            this.Button1.Text = "Próxima questão";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(13, 141);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(21, 20);
            this.Label3.TabIndex = 138;
            this.Label3.Text = "...";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 102);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(312, 24);
            this.Label1.TabIndex = 136;
            this.Label1.Text = "A.11.\t(A.12a)\tQuilometragem total";
            // 
            // panel_A
            // 
            this.panel_A.Controls.Add(this.Label4);
            this.panel_A.Controls.Add(this.TextBox1);
            this.panel_A.Controls.Add(this.RadioButton1);
            this.panel_A.Location = new System.Drawing.Point(17, 183);
            this.panel_A.Name = "panel_A";
            this.panel_A.Size = new System.Drawing.Size(323, 100);
            this.panel_A.TabIndex = 156;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(241, 36);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(21, 13);
            this.Label4.TabIndex = 145;
            this.Label4.Text = "km";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(135, 33);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 144;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(19, 34);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(121, 17);
            this.RadioButton1.TabIndex = 143;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Tag = "TextBox1";
            this.RadioButton1.Text = "Quilometragem total:";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::Questionario.Properties.Resources.psyma_logo;
            this.PictureBox2.Location = new System.Drawing.Point(17, 28);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(186, 60);
            this.PictureBox2.TabIndex = 155;
            this.PictureBox2.TabStop = false;
            // 
            // A11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 730);
            this.Controls.Add(this.panel_A);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "A11";
            this.Text = "A11";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.A11_Load);
            this.panel_A.ResumeLayout(false);
            this.panel_A.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Panel panel_A;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.RadioButton RadioButton1;
    }
}