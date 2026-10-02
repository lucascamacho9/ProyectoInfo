namespace Formulari
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPCIONSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORMULARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPCIONSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPCIONSToolStripMenuItem
            // 
            this.oPCIONSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fORMULARIToolStripMenuItem,
            this.fToolStripMenuItem,
            this.simularToolStripMenuItem});
            this.oPCIONSToolStripMenuItem.Name = "oPCIONSToolStripMenuItem";
            this.oPCIONSToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.oPCIONSToolStripMenuItem.Text = "OPCIONS";
            // 
            // fORMULARIToolStripMenuItem
            // 
            this.fORMULARIToolStripMenuItem.Name = "fORMULARIToolStripMenuItem";
            this.fORMULARIToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.fORMULARIToolStripMenuItem.Text = "NOU FLIGHT PLAN";
            this.fORMULARIToolStripMenuItem.Click += new System.EventHandler(this.fORMULARIToolStripMenuItem_Click);
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.fToolStripMenuItem.Text = "D_Seguretat / T_Cicle";
            this.fToolStripMenuItem.Click += new System.EventHandler(this.fToolStripMenuItem_Click);
            // 
            // simularToolStripMenuItem
            // 
            this.simularToolStripMenuItem.Name = "simularToolStripMenuItem";
            this.simularToolStripMenuItem.Size = new System.Drawing.Size(279, 34);
            this.simularToolStripMenuItem.Text = "Simular";
            this.simularToolStripMenuItem.Click += new System.EventHandler(this.simularToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPCIONSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORMULARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simularToolStripMenuItem;
    }
}

