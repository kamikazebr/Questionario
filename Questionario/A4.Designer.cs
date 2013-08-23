namespace Questionario
{
    partial class A4
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.panel_A = new System.Windows.Forms.Panel();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.class11 = new ClassLibrary1.Class1();
            this.panel_A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(18, 145);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(21, 20);
            this.Label3.TabIndex = 68;
            this.Label3.Text = "...";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(18, 109);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(307, 24);
            this.Label1.TabIndex = 66;
            this.Label1.Text = "A.4. Modelo do Veículo da Cota";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(947, 592);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(254, 110);
            this.Button1.TabIndex = 65;
            this.Button1.Text = "Próxima questão";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel_A
            // 
            this.panel_A.Controls.Add(this.class11);
            this.panel_A.Location = new System.Drawing.Point(22, 191);
            this.panel_A.Name = "panel_A";
            this.panel_A.Size = new System.Drawing.Size(530, 239);
            this.panel_A.TabIndex = 80;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::Questionario.Properties.Resources.psyma_logo;
            this.PictureBox2.Location = new System.Drawing.Point(22, 29);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(186, 60);
            this.PictureBox2.TabIndex = 79;
            this.PictureBox2.TabStop = false;
            // 
            // class11
            // 
            this.class11.Location = new System.Drawing.Point(3, 3);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(449, 233);
            this.class11.TabIndex = 0;
            // 
            // A4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 730);
            this.Controls.Add(this.panel_A);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button1);
            this.Name = "A4";
            this.Text = "A4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.A4_Load);
            this.panel_A.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Panel panel_A;
        private ClassLibrary1.Class1 class11;
        //private ClassLibrary1.Class1 class11;
    }
}