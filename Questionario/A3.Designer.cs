namespace Questionario
{
    partial class A3
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
            this.RadioButton11 = new System.Windows.Forms.RadioButton();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.class11 = new ClassLibrary1.Class1();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.panel_A.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::Questionario.Properties.Resources.psyma_logo;
            this.PictureBox2.Location = new System.Drawing.Point(26, 25);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(186, 60);
            this.PictureBox2.TabIndex = 123;
            this.PictureBox2.TabStop = false;
            // 
            // panel_A
            // 
            this.panel_A.Controls.Add(this.class11);
            this.panel_A.Controls.Add(this.RadioButton11);
            this.panel_A.Location = new System.Drawing.Point(12, 198);
            this.panel_A.Name = "panel_A";
            this.panel_A.Size = new System.Drawing.Size(397, 265);
            this.panel_A.TabIndex = 69;
            this.panel_A.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RadioButton11
            // 
            this.RadioButton11.AutoSize = true;
            this.RadioButton11.Location = new System.Drawing.Point(16, 233);
            this.RadioButton11.Name = "RadioButton11";
            this.RadioButton11.Size = new System.Drawing.Size(172, 17);
            this.RadioButton11.TabIndex = 75;
            this.RadioButton11.TabStop = true;
            this.RadioButton11.Text = "Outro/Não sabe/não responde";
            this.RadioButton11.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(942, 598);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(254, 110);
            this.Button1.TabIndex = 66;
            this.Button1.Text = "Próxima questão";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(22, 155);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(21, 20);
            this.Label3.TabIndex = 55;
            this.Label3.Text = "...";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label2.Location = new System.Drawing.Point(24, 130);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(256, 13);
            this.Label2.TabIndex = 54;
            this.Label2.Text = "ENT: verifique os documentos de registro do veículo";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(22, 97);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(294, 24);
            this.Label1.TabIndex = 53;
            this.Label1.Text = "A.3. Marca do Veículo da Cota";
            // 
            // class11
            // 
            this.class11.Location = new System.Drawing.Point(14, 3);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(364, 224);
            this.class11.TabIndex = 76;
            // 
            // A3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 721);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.panel_A);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "A3";
            this.Text = "A3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.A3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.panel_A.ResumeLayout(false);
            this.panel_A.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel_A;
        internal System.Windows.Forms.RadioButton RadioButton11;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private ClassLibrary1.Class1 class11;
        //private ClassLibrary1.Class1 class11;
    }
}