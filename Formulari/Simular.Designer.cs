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
            this.buttonMoure.Location = new System.Drawing.Point(32, 178);
            this.buttonMoure.Name = "buttonMoure";
            this.buttonMoure.Size = new System.Drawing.Size(200, 78);
            this.buttonMoure.TabIndex = 1;
            this.buttonMoure.Text = "Moure Un Cicle";
            this.buttonMoure.UseVisualStyleBackColor = true;
            this.buttonMoure.Click += new System.EventHandler(this.buttonMoure_Click);
            // 
            // Simular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMoure);
            this.Controls.Add(this.panelSimular);
            this.Name = "Simular";
            this.Text = "Simular";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSimular;
        private System.Windows.Forms.Button buttonMoure;
    }
}