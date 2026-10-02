namespace Formulari
{
    partial class D_Seguretat_T_Cicle
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
            this.afegir_seg_tem_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.seguretatBox = new System.Windows.Forms.TextBox();
            this.cicleBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // afegir_seg_tem_button
            // 
            this.afegir_seg_tem_button.Location = new System.Drawing.Point(323, 240);
            this.afegir_seg_tem_button.Name = "afegir_seg_tem_button";
            this.afegir_seg_tem_button.Size = new System.Drawing.Size(153, 69);
            this.afegir_seg_tem_button.TabIndex = 0;
            this.afegir_seg_tem_button.Text = "ACCEPTAR";
            this.afegir_seg_tem_button.UseVisualStyleBackColor = true;
            this.afegir_seg_tem_button.Click += new System.EventHandler(this.afegir_seg_tem_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DISTANCIA DE SEGURETAT";
            // 
            // seguretatBox
            // 
            this.seguretatBox.Location = new System.Drawing.Point(132, 129);
            this.seguretatBox.Name = "seguretatBox";
            this.seguretatBox.Size = new System.Drawing.Size(219, 26);
            this.seguretatBox.TabIndex = 2;
            // 
            // cicleBox
            // 
            this.cicleBox.Location = new System.Drawing.Point(457, 129);
            this.cicleBox.Name = "cicleBox";
            this.cicleBox.Size = new System.Drawing.Size(219, 26);
            this.cicleBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "TEMPS DE CICLE";
            // 
            // D_Seguretat_T_Cicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cicleBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seguretatBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.afegir_seg_tem_button);
            this.Name = "D_Seguretat_T_Cicle";
            this.Text = "D_Seguretat_T_Cicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button afegir_seg_tem_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox seguretatBox;
        private System.Windows.Forms.TextBox cicleBox;
        private System.Windows.Forms.Label label2;
    }
}