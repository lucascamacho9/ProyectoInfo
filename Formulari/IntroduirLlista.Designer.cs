namespace Formulari
{
    partial class IntroduirLlista
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
            this.buttonAcceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomFitxer = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAcceptar
            // 
            this.buttonAcceptar.BackColor = System.Drawing.Color.Lime;
            this.buttonAcceptar.Location = new System.Drawing.Point(418, 336);
            this.buttonAcceptar.Name = "buttonAcceptar";
            this.buttonAcceptar.Size = new System.Drawing.Size(200, 50);
            this.buttonAcceptar.TabIndex = 0;
            this.buttonAcceptar.Text = "ACCEPTAR";
            this.buttonAcceptar.UseVisualStyleBackColor = false;
            this.buttonAcceptar.Click += new System.EventHandler(this.buttonAcceptar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(81, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubicació del fitxer / Introduir nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNomFitxer
            // 
            this.textBoxNomFitxer.Location = new System.Drawing.Point(468, 238);
            this.textBoxNomFitxer.Name = "textBoxNomFitxer";
            this.textBoxNomFitxer.Size = new System.Drawing.Size(481, 26);
            this.textBoxNomFitxer.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClose.Location = new System.Drawing.Point(432, 434);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(175, 48);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "TANCAR";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(81, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccionador de fitxers";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "OBRIR BUSCADOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IntroduirLlista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxNomFitxer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAcceptar);
            this.Name = "IntroduirLlista";
            this.Text = "IntroduirLlista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAcceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomFitxer;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}