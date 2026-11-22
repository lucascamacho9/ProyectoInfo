namespace Formulari
{
    partial class Entrada
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
            this.buttonRegistre = new System.Windows.Forms.Button();
            this.buttonAccedir = new System.Windows.Forms.Button();
            this.nomBox = new System.Windows.Forms.TextBox();
            this.ContrassenyaBox1 = new System.Windows.Forms.TextBox();
            this.EDATBox = new System.Windows.Forms.TextBox();
            this.ContrassenyaBox2 = new System.Windows.Forms.TextBox();
            this.NOM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegistre
            // 
            this.buttonRegistre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonRegistre.Location = new System.Drawing.Point(174, 437);
            this.buttonRegistre.Name = "buttonRegistre";
            this.buttonRegistre.Size = new System.Drawing.Size(227, 58);
            this.buttonRegistre.TabIndex = 0;
            this.buttonRegistre.Text = "REGISTAR-SE";
            this.buttonRegistre.UseVisualStyleBackColor = false;
            this.buttonRegistre.Click += new System.EventHandler(this.buttonRegistre_Click);
            // 
            // buttonAccedir
            // 
            this.buttonAccedir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAccedir.Location = new System.Drawing.Point(625, 437);
            this.buttonAccedir.Name = "buttonAccedir";
            this.buttonAccedir.Size = new System.Drawing.Size(227, 58);
            this.buttonAccedir.TabIndex = 1;
            this.buttonAccedir.Text = "ACCEDIR";
            this.buttonAccedir.UseVisualStyleBackColor = false;
            this.buttonAccedir.Click += new System.EventHandler(this.buttonAccedir_Click);
            // 
            // nomBox
            // 
            this.nomBox.Location = new System.Drawing.Point(391, 97);
            this.nomBox.Name = "nomBox";
            this.nomBox.Size = new System.Drawing.Size(224, 26);
            this.nomBox.TabIndex = 2;
            // 
            // ContrassenyaBox1
            // 
            this.ContrassenyaBox1.Location = new System.Drawing.Point(391, 298);
            this.ContrassenyaBox1.Name = "ContrassenyaBox1";
            this.ContrassenyaBox1.Size = new System.Drawing.Size(224, 26);
            this.ContrassenyaBox1.TabIndex = 3;
            // 
            // EDATBox
            // 
            this.EDATBox.Location = new System.Drawing.Point(391, 208);
            this.EDATBox.Name = "EDATBox";
            this.EDATBox.Size = new System.Drawing.Size(224, 26);
            this.EDATBox.TabIndex = 4;
            // 
            // ContrassenyaBox2
            // 
            this.ContrassenyaBox2.Location = new System.Drawing.Point(391, 369);
            this.ContrassenyaBox2.Name = "ContrassenyaBox2";
            this.ContrassenyaBox2.Size = new System.Drawing.Size(224, 26);
            this.ContrassenyaBox2.TabIndex = 5;
            // 
            // NOM
            // 
            this.NOM.AutoSize = true;
            this.NOM.Location = new System.Drawing.Point(478, 62);
            this.NOM.Name = "NOM";
            this.NOM.Size = new System.Drawing.Size(49, 20);
            this.NOM.TabIndex = 6;
            this.NOM.Text = "NOM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "EDAT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contrassenya";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Repetiex la Contrassenya";
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 597);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NOM);
            this.Controls.Add(this.ContrassenyaBox2);
            this.Controls.Add(this.EDATBox);
            this.Controls.Add(this.ContrassenyaBox1);
            this.Controls.Add(this.nomBox);
            this.Controls.Add(this.buttonAccedir);
            this.Controls.Add(this.buttonRegistre);
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Entrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistre;
        private System.Windows.Forms.Button buttonAccedir;
        private System.Windows.Forms.TextBox nomBox;
        private System.Windows.Forms.TextBox ContrassenyaBox1;
        private System.Windows.Forms.TextBox EDATBox;
        private System.Windows.Forms.TextBox ContrassenyaBox2;
        private System.Windows.Forms.Label NOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}