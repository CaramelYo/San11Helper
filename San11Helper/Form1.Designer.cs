
namespace San11Helper
{
    partial class Form1
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
            this.nationMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nationMenuStrip
            // 
            this.nationMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.nationMenuStrip.Location = new System.Drawing.Point(0, 24);
            this.nationMenuStrip.Name = "nationMenuStrip";
            this.nationMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.nationMenuStrip.TabIndex = 0;
            this.nationMenuStrip.Text = "nationMenuStrip";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.addToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSkillsToolStripMenuItem});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // loadSkillsToolStripMenuItem
            // 
            this.loadSkillsToolStripMenuItem.Name = "loadSkillsToolStripMenuItem";
            this.loadSkillsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadSkillsToolStripMenuItem.Text = "LoadSkills";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nationToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // nationToolStripMenuItem
            // 
            this.nationToolStripMenuItem.Name = "nationToolStripMenuItem";
            this.nationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nationToolStripMenuItem.Text = "Nation";
            this.nationToolStripMenuItem.Click += new System.EventHandler(this.nationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nationMenuStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip nationMenuStrip;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSkillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nationToolStripMenuItem;
    }
}

