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
            this.SuspendLayout();
            // 
            // buttonAcceptar
            // 
            this.buttonAcceptar.BackColor = System.Drawing.Color.Lime;
            this.buttonAcceptar.Location = new System.Drawing.Point(403, 271);
            this.buttonAcceptar.Name = "buttonAcceptar";
            this.buttonAcceptar.Size = new System.Drawing.Size(200, 50);
            this.buttonAcceptar.TabIndex = 0;
            this.buttonAcceptar.Text = "ACCEPTAR";
            this.buttonAcceptar.UseVisualStyleBackColor = false;
            this.buttonAcceptar.Click += new System.EventHandler(this.buttonAcceptar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOM DEL FITXER";
            // 
            // textBoxNomFitxer
            // 
            this.textBoxNomFitxer.Location = new System.Drawing.Point(549, 201);
            this.textBoxNomFitxer.Name = "textBoxNomFitxer";
            this.textBoxNomFitxer.Size = new System.Drawing.Size(142, 26);
            this.textBoxNomFitxer.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClose.Location = new System.Drawing.Point(823, 463);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(175, 48);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "TANCAR";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // IntroduirLlista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 560);
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
    }
}