namespace _15_02_trikampis
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxsStatinis = new System.Windows.Forms.TextBox();
            this.textBoxKrastine = new System.Windows.Forms.TextBox();
            this.textBoxPlotas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSkaiciuoti = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSkaiciuoti);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPlotas);
            this.groupBox1.Controls.Add(this.textBoxKrastine);
            this.groupBox1.Controls.Add(this.textBoxsStatinis);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trikampio plotas";
            // 
            // textBoxsStatinis
            // 
            this.textBoxsStatinis.Location = new System.Drawing.Point(6, 36);
            this.textBoxsStatinis.Name = "textBoxsStatinis";
            this.textBoxsStatinis.Size = new System.Drawing.Size(132, 20);
            this.textBoxsStatinis.TabIndex = 0;
            // 
            // textBoxKrastine
            // 
            this.textBoxKrastine.Location = new System.Drawing.Point(6, 76);
            this.textBoxKrastine.Name = "textBoxKrastine";
            this.textBoxKrastine.Size = new System.Drawing.Size(132, 20);
            this.textBoxKrastine.TabIndex = 1;
            // 
            // textBoxPlotas
            // 
            this.textBoxPlotas.Location = new System.Drawing.Point(6, 118);
            this.textBoxPlotas.Name = "textBoxPlotas";
            this.textBoxPlotas.ReadOnly = true;
            this.textBoxPlotas.Size = new System.Drawing.Size(132, 20);
            this.textBoxPlotas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trikampio statinis cm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trikampio kraštinė cm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trikampio plotas cm2";
            // 
            // buttonSkaiciuoti
            // 
            this.buttonSkaiciuoti.Location = new System.Drawing.Point(152, 12);
            this.buttonSkaiciuoti.Name = "buttonSkaiciuoti";
            this.buttonSkaiciuoti.Size = new System.Drawing.Size(75, 23);
            this.buttonSkaiciuoti.TabIndex = 6;
            this.buttonSkaiciuoti.Text = "Skaičiuoti";
            this.buttonSkaiciuoti.UseVisualStyleBackColor = true;
            this.buttonSkaiciuoti.Click += new System.EventHandler(this.buttonSkaiciuoti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSkaiciuoti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlotas;
        private System.Windows.Forms.TextBox textBoxKrastine;
        private System.Windows.Forms.TextBox textBoxsStatinis;
    }
}

