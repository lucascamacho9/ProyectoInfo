namespace Formulari
{
    partial class Dades
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
            this.avionsView = new System.Windows.Forms.DataGridView();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avionsView)).BeginInit();
            this.SuspendLayout();
            // 
            // avionsView
            // 
            this.avionsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avionsView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.avionsView.Location = new System.Drawing.Point(112, 40);
            this.avionsView.Name = "avionsView";
            this.avionsView.RowHeadersWidth = 62;
            this.avionsView.RowTemplate.Height = 28;
            this.avionsView.Size = new System.Drawing.Size(526, 281);
            this.avionsView.TabIndex = 0;
            this.avionsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.avionsView_CellContentClick);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClose.Location = new System.Drawing.Point(296, 353);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(154, 53);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "TANCAR";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Dades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.avionsView);
            this.Name = "Dades";
            this.Text = "Dades";
            this.Load += new System.EventHandler(this.Dades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avionsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView avionsView;
        private System.Windows.Forms.Button buttonClose;
    }
}