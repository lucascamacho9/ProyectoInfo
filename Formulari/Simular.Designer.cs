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
            this.buttonAutomatic = new System.Windows.Forms.Button();
            this.buttonDades = new System.Windows.Forms.Button();
            this.PredecirButton = new System.Windows.Forms.Button();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.buttonGuardarFlights = new System.Windows.Forms.Button();
            this.nomfitxerBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRetroceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelSimular
            // 
            this.panelSimular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panelSimular.Location = new System.Drawing.Point(270, 21);
            this.panelSimular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSimular.Name = "panelSimular";
            this.panelSimular.Size = new System.Drawing.Size(444, 400);
            this.panelSimular.TabIndex = 0;
            this.panelSimular.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSimular_Paint);
            // 
            // buttonMoure
            // 
            this.buttonMoure.Location = new System.Drawing.Point(35, 10);
            this.buttonMoure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMoure.Name = "buttonMoure";
            this.buttonMoure.Size = new System.Drawing.Size(169, 58);
            this.buttonMoure.TabIndex = 1;
            this.buttonMoure.Text = "Moure Un Cicle";
            this.buttonMoure.UseVisualStyleBackColor = true;
            this.buttonMoure.Click += new System.EventHandler(this.buttonMoure_Click);
            // 
            // buttonAutomatic
            // 
            this.buttonAutomatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAutomatic.Location = new System.Drawing.Point(35, 72);
            this.buttonAutomatic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAutomatic.Name = "buttonAutomatic";
            this.buttonAutomatic.Size = new System.Drawing.Size(169, 45);
            this.buttonAutomatic.TabIndex = 4;
            this.buttonAutomatic.Text = "Cicle Automàtic";
            this.buttonAutomatic.UseVisualStyleBackColor = false;
            this.buttonAutomatic.Click += new System.EventHandler(this.buttonAutomatic_Click);
            // 
            // buttonDades
            // 
            this.buttonDades.Location = new System.Drawing.Point(35, 170);
            this.buttonDades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDades.Name = "buttonDades";
            this.buttonDades.Size = new System.Drawing.Size(169, 46);
            this.buttonDades.TabIndex = 5;
            this.buttonDades.Text = "Dades dels Vols";
            this.buttonDades.UseVisualStyleBackColor = true;
            this.buttonDades.Click += new System.EventHandler(this.buttonDades_Click);
            // 
            // PredecirButton
            // 
            this.PredecirButton.BackColor = System.Drawing.Color.White;
            this.PredecirButton.Location = new System.Drawing.Point(35, 121);
            this.PredecirButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PredecirButton.Name = "PredecirButton";
            this.PredecirButton.Size = new System.Drawing.Size(169, 45);
            this.PredecirButton.TabIndex = 6;
            this.PredecirButton.Text = "Comprobar conflictes";
            this.PredecirButton.UseVisualStyleBackColor = false;
            this.PredecirButton.Click += new System.EventHandler(this.PredecirButton_Click);
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.Location = new System.Drawing.Point(265, 775);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Size = new System.Drawing.Size(0, 16);
            this.lblAlerta.TabIndex = 7;
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(35, 307);
            this.Restart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(169, 43);
            this.Restart.TabIndex = 8;
            this.Restart.Text = "RESTART";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // buttonGuardarFlights
            // 
            this.buttonGuardarFlights.Location = new System.Drawing.Point(24, 262);
            this.buttonGuardarFlights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardarFlights.Name = "buttonGuardarFlights";
            this.buttonGuardarFlights.Size = new System.Drawing.Size(194, 41);
            this.buttonGuardarFlights.TabIndex = 9;
            this.buttonGuardarFlights.Text = "Guardar Vols en un Fitxer";
            this.buttonGuardarFlights.UseVisualStyleBackColor = true;
            this.buttonGuardarFlights.Click += new System.EventHandler(this.buttonGuardarFlights_Click);
            // 
            // nomfitxerBOX
            // 
            this.nomfitxerBOX.Location = new System.Drawing.Point(55, 236);
            this.nomfitxerBOX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomfitxerBOX.Name = "nomfitxerBOX";
            this.nomfitxerBOX.Size = new System.Drawing.Size(123, 22);
            this.nomfitxerBOX.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nom del FITXER";
            // 
            // buttonRetroceder
            // 
            this.buttonRetroceder.Location = new System.Drawing.Point(35, 355);
            this.buttonRetroceder.Name = "buttonRetroceder";
            this.buttonRetroceder.Size = new System.Drawing.Size(169, 39);
            this.buttonRetroceder.TabIndex = 12;
            this.buttonRetroceder.Text = "Retrocedir un cicle";
            this.buttonRetroceder.UseVisualStyleBackColor = true;
            this.buttonRetroceder.Click += new System.EventHandler(this.buttonRetroceder_Click);
            // 
            // Simular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 550);
            this.Controls.Add(this.buttonRetroceder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomfitxerBOX);
            this.Controls.Add(this.buttonGuardarFlights);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.lblAlerta);
            this.Controls.Add(this.buttonAutomatic);
            this.Controls.Add(this.PredecirButton);
            this.Controls.Add(this.buttonDades);
            this.Controls.Add(this.buttonMoure);
            this.Controls.Add(this.panelSimular);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Simular";
            this.Text = "Simular";
            this.Load += new System.EventHandler(this.Simular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSimular;
        private System.Windows.Forms.Button buttonMoure;
        private System.Windows.Forms.Button buttonAutomatic;
        private System.Windows.Forms.Button buttonDades;
        private System.Windows.Forms.Button PredecirButton;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button buttonGuardarFlights;
        private System.Windows.Forms.TextBox nomfitxerBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRetroceder;
    }
}