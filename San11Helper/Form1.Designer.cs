
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
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genaralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.addToolStripMenuItem,
            this.settingToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nationToolStripMenuItem,
            this.genaralToolStripMenuItem});
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
            // genaralToolStripMenuItem
            // 
            this.genaralToolStripMenuItem.Name = "genaralToolStripMenuItem";
            this.genaralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genaralToolStripMenuItem.Text = "Genaral";
            this.genaralToolStripMenuItem.Click += new System.EventHandler(this.genaralToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSkillsToolStripMenuItem,
            this.editSkillsToolStripMenuItem,
            this.saveSkillsToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // loadSkillsToolStripMenuItem
            // 
            this.loadSkillsToolStripMenuItem.Name = "loadSkillsToolStripMenuItem";
            this.loadSkillsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadSkillsToolStripMenuItem.Text = "LoadSkills";
            this.loadSkillsToolStripMenuItem.Click += new System.EventHandler(this.loadSkillsToolStripMenuItem_Click);
            // 
            // editSkillsToolStripMenuItem
            // 
            this.editSkillsToolStripMenuItem.Name = "editSkillsToolStripMenuItem";
            this.editSkillsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editSkillsToolStripMenuItem.Text = "EditSkills";
            this.editSkillsToolStripMenuItem.Click += new System.EventHandler(this.editSkillsToolStripMenuItem_Click);
            // 
            // saveSkillsToolStripMenuItem
            // 
            this.saveSkillsToolStripMenuItem.Name = "saveSkillsToolStripMenuItem";
            this.saveSkillsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveSkillsToolStripMenuItem.Text = "SaveSkills";
            this.saveSkillsToolStripMenuItem.Click += new System.EventHandler(this.saveSkillsToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 387);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nationMenuStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip nationMenuStrip;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genaralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSkillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSkillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSkillsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

