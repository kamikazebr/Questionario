namespace Questionario
{
    partial class A12
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
            this.panel_A = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel_A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_A
            // 
            this.panel_A.Controls.Add(this.comboBox1);
            this.panel_A.Controls.Add(this.RadioButton3);
            this.panel_A.Controls.Add(this.RadioButton1);
            this.panel_A.Controls.Add(this.RadioButton2);
            this.panel_A.Location = new System.Drawing.Point(17, 208);
            this.panel_A.Name = "panel_A";
            this.panel_A.Size = new System.Drawing.Size(349, 100);
            this.panel_A.TabIndex = 157;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2009",
            "2010",
            "2011",
            "2012",
            "2013"});
            this.comboBox1.Location = new System.Drawing.Point(65, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 148;
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new System.Drawing.Point(21, 62);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(92, 17);
            this.RadioButton3.TabIndex = 147;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "Não responde";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(21, 22);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(47, 17);
            this.RadioButton1.TabIndex = 146;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Tag = "TextBox1";
            this.RadioButton1.Text = "Ano:";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(21, 43);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(71, 17);
            this.RadioButton2.TabIndex = 145;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Não sabe";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::Questionario.Properties.Resources.psyma_logo;
            this.PictureBox2.Location = new System.Drawing.Point(17, 25);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(186, 60);
            this.PictureBox2.TabIndex = 156;
            this.PictureBox2.TabStop = false;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(951, 599);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(254, 110);
            this.Button1.TabIndex = 145;
            this.Button1.Text = "Próxima questão";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(13, 162);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(21, 20);
            this.Label3.TabIndex = 139;
            this.Label3.Text = "...";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label2.Location = new System.Drawing.Point(13, 136);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(188, 13);
            this.Label2.TabIndex = 138;
            this.Label2.Text = "ENT: verifique documentos de registro";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 105);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(264, 24);
            this.Label1.TabIndex = 137;
            this.Label1.Text = "A.12.\t\t(A.11)\t Ano de registro";
            // 
            // A12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 730);
            this.Controls.Add(this.panel_A);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "A12";
            this.Text = "A12";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.A12_Load);
            this.panel_A.ResumeLayout(false);
            this.panel_A.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.Panel panel_A;
        internal System.Windows.Forms.RadioButton RadioButton3;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}