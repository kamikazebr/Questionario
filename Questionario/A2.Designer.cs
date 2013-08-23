namespace Questionario
{
    partial class A2
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
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_A = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.panel_A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::Questionario.Properties.Resources.psyma_logo;
            this.PictureBox2.Location = new System.Drawing.Point(20, 22);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(186, 60);
            this.PictureBox2.TabIndex = 122;
            this.PictureBox2.TabStop = false;
            // 
            // panel_A
            // 
            this.panel_A.Controls.Add(this.numericUpDown1);
            this.panel_A.Controls.Add(this.RadioButton1);
            this.panel_A.Controls.Add(this.RadioButton2);
            this.panel_A.Location = new System.Drawing.Point(20, 194);
            this.panel_A.Name = "panel_A";
            this.panel_A.Size = new System.Drawing.Size(218, 100);
            this.panel_A.TabIndex = 48;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(139, 26);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 45;
            this.numericUpDown1.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(12, 26);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(115, 17);
            this.RadioButton1.TabIndex = 43;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Tag = "numericUpDown1";
            this.RadioButton1.Text = "1 - Ano declarado: ";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(11, 49);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(165, 17);
            this.RadioButton2.TabIndex = 44;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "2 - Não Sabe/Não Responde";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(948, 609);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(254, 110);
            this.Button1.TabIndex = 45;
            this.Button1.Text = "Próxima questão";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(16, 158);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(21, 20);
            this.Label3.TabIndex = 41;
            this.Label3.Text = "...";
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label2.Location = new System.Drawing.Point(17, 127);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(800, 31);
            this.Label2.TabIndex = 40;
            this.Label2.Text = "ENT: Se o ano modelo não estiver nos documentos de registro do veículo, verifique" +
    " nos documentos o ano do 1º emplacamento do veículo, que lhe dará uma ideia de q" +
    "uando o veículo foi fabricado. ";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(16, 94);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(351, 24);
            this.Label1.TabIndex = 39;
            this.Label1.Text = "A.2. Ano Modelo do Veículo da Cota";
            // 
            // A2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 741);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.panel_A);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "A2";
            this.Text = "A2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.A2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.panel_A.ResumeLayout(false);
            this.panel_A.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel_A;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        internal System.Windows.Forms.PictureBox PictureBox2;
    }
}