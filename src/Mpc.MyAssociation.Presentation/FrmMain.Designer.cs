namespace Mpc.MyAssociation.Presentation
{
    partial class FrmMain
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
            this.mnuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.quotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMembers
            // 
            this.mnuMembers.Name = "mnuMembers";
            this.mnuMembers.Size = new System.Drawing.Size(53, 20);
            this.mnuMembers.Text = "Sócios";
            this.mnuMembers.Click += new System.EventHandler(this.MnuMembers_Click);
            // 
            // quotasToolStripMenuItem
            // 
            this.quotasToolStripMenuItem.Name = "quotasToolStripMenuItem";
            this.quotasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.quotasToolStripMenuItem.Text = "Quotas";
            this.quotasToolStripMenuItem.Click += new System.EventHandler(this.quotasToolStripMenuItem_Click);
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pagamentosToolStripMenuItem.Text = "Pagamentos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMembers,
            this.quotasToolStripMenuItem,
            this.pagamentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 602);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "My Association";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuMembers;
        private System.Windows.Forms.ToolStripMenuItem quotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

