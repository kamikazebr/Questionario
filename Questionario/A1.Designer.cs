namespace Questionario
{
    partial class A1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A1));
            this.Button1 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel_A = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button1.Location = new System.Drawing.Point(933, 595);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(254, 110);
            this.Button1.TabIndex = 35;
            this.Button1.Text = "Próxima questão";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label3.Location = new System.Drawing.Point(12, 146);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(1058, 70);
            this.Label3.TabIndex = 34;
            this.Label3.Text = resources.GetString("Label3.Text");
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label2.Location = new System.Drawing.Point(11, 168);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(16, 13);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "...";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label1.Location = new System.Drawing.Point(12, 109);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(329, 24);
            this.Label1.TabIndex = 32;
            this.Label1.Text = "A.1. Número de vans na empresa ";
            // 
            // panel_A
            // 
            this.panel_A.Controls.Add(this.numericUpDown1);
            this.panel_A.Controls.Add(this.RadioButton1);
            this.panel_A.Controls.Add(this.RadioButton2);
            this.panel_A.Location = new System.Drawing.Point(16, 259);
            this.panel_A.Name = "panel_A";
            this.panel_A.Size = new System.Drawing.Size(234, 76);
            this.panel_A.TabIndex = 41;
            this.panel_A.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_A_Paint);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(153, 18);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 42;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RadioButton1.Location = new System.Drawing.Point(14, 18);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(133, 17);
            this.RadioButton1.TabIndex = 40;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Tag = "numericUpDown1";
            this.RadioButton1.Text = "1 - Número declarado: ";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RadioButton2.Location = new System.Drawing.Point(14, 41);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(165, 17);
            this.RadioButton2.TabIndex = 41;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "2 - Não Sabe/Não Responde";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = global::Questionario.Properties.Resources.psyma_logo;
            this.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PictureBox2.Location = new System.Drawing.Point(15, 26);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(186, 60);
            this.PictureBox2.TabIndex = 302;
            this.PictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(13, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(710, 40);
            this.label4.TabIndex = 303;
            this.label4.Text = "ENT: Anote o número de vans no local de trabalho. Favor anotar número exato. Se o" +
    " respondente tiver dificuldade de fornecer um número exato, peça a sua melhor es" +
    "timativa. ";
            // 
            // A1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 749);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.panel_A);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "A1";
            this.Text = "A1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.A1_Load);
            this.panel_A.ResumeLayout(false);
            this.panel_A.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel_A;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.Label label4;
    }
}