namespace Formulari
{
    partial class Distancia_Entre_Vols
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
            this.buttonTancar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.distanciaBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonTancar
            // 
            this.buttonTancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonTancar.Location = new System.Drawing.Point(588, 355);
            this.buttonTancar.Name = "buttonTancar";
            this.buttonTancar.Size = new System.Drawing.Size(142, 55);
            this.buttonTancar.TabIndex = 0;
            this.buttonTancar.Text = "TANCAR";
            this.buttonTancar.UseVisualStyleBackColor = false;
            this.buttonTancar.Click += new System.EventHandler(this.buttonTancar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distància Entre Vols";
            // 
            // distanciaBox
            // 
            this.distanciaBox.Location = new System.Drawing.Point(297, 188);
            this.distanciaBox.Name = "distanciaBox";
            this.distanciaBox.Size = new System.Drawing.Size(157, 26);
            this.distanciaBox.TabIndex = 2;
            // 
            // Distancia_Entre_Vols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.distanciaBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTancar);
            this.Name = "Distancia_Entre_Vols";
            this.Text = "Distancia_Entre_Vols";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTancar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox distanciaBox;
    }
}