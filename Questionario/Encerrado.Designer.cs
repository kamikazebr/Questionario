namespace Questionario
{
    partial class Encerrado
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.panel_A = new System.Windows.Forms.Panel();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.panel_A.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::Questionario.Properties.Resources.psyma_logo;
            this.PictureBox2.Location = new System.Drawing.Point(23, 29);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(186, 60);
            this.PictureBox2.TabIndex = 127;
            this.PictureBox2.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(19, 163);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(813, 53);
            this.Label3.TabIndex = 126;
            this.Label3.Text = "Infelizmente o veículo sobre o qual falamos não pertence ao grupo alvo deste estu" +
    "do. O(a) Sr(a). possui alguma outra van em sua frota que tenha sido fabricada en" +
    "tre 2009 e 2013?";
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label2.Location = new System.Drawing.Point(19, 123);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(710, 40);
            this.Label2.TabIndex = 125;
            this.Label2.Text = "A.2.\tENT: Se a entrevista tiver de ser encerrada e A1>1, pergunte ao entrevistado" +
    " se ele possui uma outra van que tenha sido fabricada de 2009 a 2013 e recomece " +
    "a entrevista do início.";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(246, 235);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(162, 56);
            this.Button1.TabIndex = 123;
            this.Button1.Text = "Encerrar";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(22, 14);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(42, 17);
            this.RadioButton1.TabIndex = 98;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Sim";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // panel_A
            // 
            this.panel_A.Controls.Add(this.RadioButton1);
            this.panel_A.Controls.Add(this.RadioButton2);
            this.panel_A.Location = new System.Drawing.Point(23, 230);
            this.panel_A.Name = "panel_A";
            this.panel_A.Size = new System.Drawing.Size(186, 70);
            this.panel_A.TabIndex = 128;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(22, 33);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(45, 17);
            this.RadioButton2.TabIndex = 97;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Nao";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(19, 92);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(142, 24);
            this.Label1.TabIndex = 124;
            this.Label1.Text = "Encerramento";
            // 
            // Encerrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 730);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.panel_A);
            this.Name = "Encerrado";
            this.Text = "Encerrado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Encerrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.panel_A.ResumeLayout(false);
            this.panel_A.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.Panel panel_A;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.Label Label1;
    }
}