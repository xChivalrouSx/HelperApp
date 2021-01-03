namespace HelperApp
{
    partial class MainForm
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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon();
            this.contextMenuMain = new System.Windows.Forms.ContextMenu();
            this.itemClose = new System.Windows.Forms.MenuItem();
            this.itemSettings = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = System.Drawing.SystemIcons.Application;
            this.notifyIcon.Text = "ChivalrouS - HelperApp";
            this.notifyIcon.Visible = true;
            this.notifyIcon.ContextMenu = contextMenuMain;
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.itemSettings,
            this.itemClose});
            // 
            // itemSettings
            // 
            this.itemSettings.Index = 0;
            this.itemSettings.Text = "Settings";
            this.itemSettings.Click += new System.EventHandler(this.itemSettings_Click);
            // 
            // itemClose
            // 
            this.itemClose.Index = 1;
            this.itemClose.Text = "Exit";
            this.itemClose.Click += new System.EventHandler(this.itemClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 146);
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenu contextMenuMain;
        private System.Windows.Forms.MenuItem itemClose;
        private System.Windows.Forms.MenuItem itemSettings;
    }
}