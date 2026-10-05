namespace Formulari
{
    partial class Simular
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
            this.panelSimular = new System.Windows.Forms.Panel();
            this.buttonMoure = new System.Windows.Forms.Button();
            this.buttonLinia = new System.Windows.Forms.Button();
            this.buttonElipse = new System.Windows.Forms.Button();
            this.buttonAutomatic = new System.Windows.Forms.Button();
            this.buttonDades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelSimular
            // 
            this.panelSimular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelSimular.Location = new System.Drawing.Point(276, 12);
            this.panelSimular.Name = "panelSimular";
            this.panelSimular.Size = new System.Drawing.Size(500, 426);
            this.panelSimular.TabIndex = 0;
            this.panelSimular.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSimular_Paint);
            // 
            // buttonMoure
            // 
            this.buttonMoure.Location = new System.Drawing.Point(39, 26);
            this.buttonMoure.Name = "buttonMoure";
            this.buttonMoure.Size = new System.Drawing.Size(190, 73);
            this.buttonMoure.TabIndex = 1;
            this.buttonMoure.Text = "Moure Un Cicle";
            this.buttonMoure.UseVisualStyleBackColor = true;
            this.buttonMoure.Click += new System.EventHandler(this.buttonMoure_Click);
            // 
            // buttonLinia
            // 
            this.buttonLinia.Location = new System.Drawing.Point(39, 105);
            this.buttonLinia.Name = "buttonLinia";
            this.buttonLinia.Size = new System.Drawing.Size(190, 63);
            this.buttonLinia.TabIndex = 2;
            this.buttonLinia.Text = "LÍNIA (inici-final)";
            this.buttonLinia.UseVisualStyleBackColor = true;
            this.buttonLinia.Click += new System.EventHandler(this.buttonLinia_Click);
            // 
            // buttonElipse
            // 
            this.buttonElipse.Location = new System.Drawing.Point(39, 174);
            this.buttonElipse.Name = "buttonElipse";
            this.buttonElipse.Size = new System.Drawing.Size(190, 72);
            this.buttonElipse.TabIndex = 3;
            this.buttonElipse.Text = "El·lipse de Seguretat";
            this.buttonElipse.UseVisualStyleBackColor = true;
            this.buttonElipse.Click += new System.EventHandler(this.buttonElipse_Click);
            // 
            // buttonAutomatic
            // 
            this.buttonAutomatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAutomatic.Location = new System.Drawing.Point(39, 271);
            this.buttonAutomatic.Name = "buttonAutomatic";
            this.buttonAutomatic.Size = new System.Drawing.Size(190, 56);
            this.buttonAutomatic.TabIndex = 4;
            this.buttonAutomatic.Text = "Cicle Automàtic";
            this.buttonAutomatic.UseVisualStyleBackColor = false;
            this.buttonAutomatic.Click += new System.EventHandler(this.buttonAutomatic_Click);
            // 
            // buttonDades
            // 
            this.buttonDades.Location = new System.Drawing.Point(39, 346);
            this.buttonDades.Name = "buttonDades";
            this.buttonDades.Size = new System.Drawing.Size(190, 58);
            this.buttonDades.TabIndex = 5;
            this.buttonDades.Text = "Dades dels Vols";
            this.buttonDades.UseVisualStyleBackColor = true;
            this.buttonDades.Click += new System.EventHandler(this.buttonDades_Click);
            // 
            // Simular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDades);
            this.Controls.Add(this.buttonAutomatic);
            this.Controls.Add(this.buttonElipse);
            this.Controls.Add(this.buttonLinia);
            this.Controls.Add(this.buttonMoure);
            this.Controls.Add(this.panelSimular);
            this.Name = "Simular";
            this.Text = "Simular";
            this.Load += new System.EventHandler(this.Simular_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSimular;
        private System.Windows.Forms.Button buttonMoure;
        private System.Windows.Forms.Button buttonLinia;
        private System.Windows.Forms.Button buttonElipse;
        private System.Windows.Forms.Button buttonAutomatic;
        private System.Windows.Forms.Button buttonDades;
    }
}