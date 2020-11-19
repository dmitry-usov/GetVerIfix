namespace GetVerIfix
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.picBuildsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangerZoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPicBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBuildsComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.lblFixBuild = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPicBuilds = new System.Windows.Forms.ListBox();
            this.label0 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Enabled = false;
            this.lblVersion.Font = new System.Drawing.Font("Consolas", 26F);
            this.lblVersion.Location = new System.Drawing.Point(118, 17);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(0, 41);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPath
            // 
            this.lblPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPath.Location = new System.Drawing.Point(15, 28);
            this.lblPath.MaximumSize = new System.Drawing.Size(309, 50);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(309, 42);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Нажми или перетащи картинку *.grf на область ниже";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.picBuildsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.dangerZoneToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // picBuildsToolStripMenuItem
            // 
            this.picBuildsToolStripMenuItem.Name = "picBuildsToolStripMenuItem";
            this.picBuildsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.picBuildsToolStripMenuItem.Text = "pic builds";
            this.picBuildsToolStripMenuItem.Click += new System.EventHandler(this.picBuildsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::GetVerIfix.Properties.Resources.github_mark;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.aboutToolStripMenuItem.Text = "git";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dangerZoneToolStripMenuItem
            // 
            this.dangerZoneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPicBuildToolStripMenuItem});
            this.dangerZoneToolStripMenuItem.Name = "dangerZoneToolStripMenuItem";
            this.dangerZoneToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.dangerZoneToolStripMenuItem.Text = "danger zone";
            // 
            // setPicBuildToolStripMenuItem
            // 
            this.setPicBuildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.picBuildsComboBox});
            this.setPicBuildToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.setPicBuildToolStripMenuItem.Name = "setPicBuildToolStripMenuItem";
            this.setPicBuildToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.setPicBuildToolStripMenuItem.Text = "set pic build";
            // 
            // picBuildsComboBox
            // 
            this.picBuildsComboBox.Name = "picBuildsComboBox";
            this.picBuildsComboBox.Size = new System.Drawing.Size(121, 23);
            this.picBuildsComboBox.SelectedIndexChanged += new System.EventHandler(this.picBuildsComboBox_SelectedIndexChanged);
            // 
            // lblFixBuild
            // 
            this.lblFixBuild.AutoSize = true;
            this.lblFixBuild.Enabled = false;
            this.lblFixBuild.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.lblFixBuild.Location = new System.Drawing.Point(93, 62);
            this.lblFixBuild.Name = "lblFixBuild";
            this.lblFixBuild.Size = new System.Drawing.Size(0, 13);
            this.lblFixBuild.TabIndex = 4;
            this.lblFixBuild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(471, 27);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(14, 135);
            this.btnHide.TabIndex = 600;
            this.btnHide.Text = "<";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblFixBuild);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Location = new System.Drawing.Point(18, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 89);
            this.panel1.TabIndex = 7;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // lbPicBuilds
            // 
            this.lbPicBuilds.FormattingEnabled = true;
            this.lbPicBuilds.Location = new System.Drawing.Point(346, 41);
            this.lbPicBuilds.Name = "lbPicBuilds";
            this.lbPicBuilds.Size = new System.Drawing.Size(119, 121);
            this.lbPicBuilds.TabIndex = 9;
            // 
            // label0
            // 
            this.label0.Location = new System.Drawing.Point(372, 28);
            this.label0.MaximumSize = new System.Drawing.Size(309, 50);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(68, 16);
            this.label0.TabIndex = 10;
            this.label0.Text = "pic builds";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 173);
            this.Controls.Add(this.lbPicBuilds);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblFixBuild;
        private System.Windows.Forms.ToolStripMenuItem picBuildsToolStripMenuItem;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.ToolStripMenuItem dangerZoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPicBuildToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox picBuildsComboBox;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbPicBuilds;
        private System.Windows.Forms.Label label0;
    }
}

