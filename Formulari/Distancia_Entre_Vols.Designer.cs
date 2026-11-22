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
            this.distanciaGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.distanciaGridView)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(233, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distància Entre Vols";
            // 
            // distanciaGridView
            // 
            this.distanciaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distanciaGridView.Location = new System.Drawing.Point(84, 96);
            this.distanciaGridView.Name = "distanciaGridView";
            this.distanciaGridView.RowHeadersWidth = 62;
            this.distanciaGridView.RowTemplate.Height = 28;
            this.distanciaGridView.Size = new System.Drawing.Size(584, 253);
            this.distanciaGridView.TabIndex = 2;
            // 
            // Distancia_Entre_Vols
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.distanciaGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTancar);
            this.Name = "Distancia_Entre_Vols";
            this.Text = "Distancia_Entre_Vols";
            this.Load += new System.EventHandler(this.Distancia_Entre_Vols_Load);
            ((System.ComponentModel.ISupportInitialize)(this.distanciaGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTancar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView distanciaGridView;
    }
}