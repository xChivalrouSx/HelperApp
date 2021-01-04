
namespace HelperApp
{
    partial class SettingsForm
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
            this.listBoxMain = new System.Windows.Forms.ListBox();
            this.pnlWeather = new System.Windows.Forms.Panel();
            this.lblWeatherShow = new System.Windows.Forms.Label();
            this.checkBoxWeatherShow = new System.Windows.Forms.CheckBox();
            this.lblWeatherAlwaysTop = new System.Windows.Forms.Label();
            this.checkBoxWeatherAlwaysTop = new System.Windows.Forms.CheckBox();
            this.cBoxWeatherScreen = new System.Windows.Forms.ComboBox();
            this.lblWeatherScreen = new System.Windows.Forms.Label();
            this.cBoxWeatherLocation = new System.Windows.Forms.ComboBox();
            this.lblWeatherLocation = new System.Windows.Forms.Label();
            this.cBoxWeatherRefresh = new System.Windows.Forms.ComboBox();
            this.lblWeatherRefresh = new System.Windows.Forms.Label();
            this.pnlWeather.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMain
            // 
            this.listBoxMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBoxMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxMain.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMain.ForeColor = System.Drawing.Color.White;
            this.listBoxMain.FormattingEnabled = true;
            this.listBoxMain.ItemHeight = 23;
            this.listBoxMain.Items.AddRange(new object[] {
            "Weather"});
            this.listBoxMain.Location = new System.Drawing.Point(0, 0);
            this.listBoxMain.Name = "listBoxMain";
            this.listBoxMain.Size = new System.Drawing.Size(172, 450);
            this.listBoxMain.TabIndex = 0;
            this.listBoxMain.SelectedValueChanged += new System.EventHandler(this.listBoxMain_SelectedValueChanged);
            // 
            // pnlWeather
            // 
            this.pnlWeather.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlWeather.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlWeather.Controls.Add(this.cBoxWeatherRefresh);
            this.pnlWeather.Controls.Add(this.lblWeatherRefresh);
            this.pnlWeather.Controls.Add(this.cBoxWeatherLocation);
            this.pnlWeather.Controls.Add(this.lblWeatherLocation);
            this.pnlWeather.Controls.Add(this.lblWeatherShow);
            this.pnlWeather.Controls.Add(this.checkBoxWeatherShow);
            this.pnlWeather.Controls.Add(this.lblWeatherAlwaysTop);
            this.pnlWeather.Controls.Add(this.checkBoxWeatherAlwaysTop);
            this.pnlWeather.Controls.Add(this.cBoxWeatherScreen);
            this.pnlWeather.Controls.Add(this.lblWeatherScreen);
            this.pnlWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWeather.Location = new System.Drawing.Point(172, 0);
            this.pnlWeather.Name = "pnlWeather";
            this.pnlWeather.Size = new System.Drawing.Size(733, 450);
            this.pnlWeather.TabIndex = 1;
            // 
            // lblWeatherShow
            // 
            this.lblWeatherShow.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherShow.Location = new System.Drawing.Point(10, 182);
            this.lblWeatherShow.Name = "lblWeatherShow";
            this.lblWeatherShow.Size = new System.Drawing.Size(200, 23);
            this.lblWeatherShow.TabIndex = 5;
            this.lblWeatherShow.Text = "Show Weather:";
            this.lblWeatherShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxWeatherShow
            // 
            this.checkBoxWeatherShow.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxWeatherShow.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWeatherShow.Location = new System.Drawing.Point(209, 182);
            this.checkBoxWeatherShow.Name = "checkBoxWeatherShow";
            this.checkBoxWeatherShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWeatherShow.Size = new System.Drawing.Size(15, 23);
            this.checkBoxWeatherShow.TabIndex = 4;
            this.checkBoxWeatherShow.UseVisualStyleBackColor = false;
            // 
            // lblWeatherAlwaysTop
            // 
            this.lblWeatherAlwaysTop.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherAlwaysTop.Location = new System.Drawing.Point(10, 139);
            this.lblWeatherAlwaysTop.Name = "lblWeatherAlwaysTop";
            this.lblWeatherAlwaysTop.Size = new System.Drawing.Size(200, 23);
            this.lblWeatherAlwaysTop.TabIndex = 3;
            this.lblWeatherAlwaysTop.Text = "Show Weather Always Top:";
            this.lblWeatherAlwaysTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxWeatherAlwaysTop
            // 
            this.checkBoxWeatherAlwaysTop.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxWeatherAlwaysTop.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWeatherAlwaysTop.Location = new System.Drawing.Point(209, 139);
            this.checkBoxWeatherAlwaysTop.Name = "checkBoxWeatherAlwaysTop";
            this.checkBoxWeatherAlwaysTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWeatherAlwaysTop.Size = new System.Drawing.Size(15, 23);
            this.checkBoxWeatherAlwaysTop.TabIndex = 2;
            this.checkBoxWeatherAlwaysTop.UseVisualStyleBackColor = false;
            // 
            // cBoxWeatherScreen
            // 
            this.cBoxWeatherScreen.BackColor = System.Drawing.SystemColors.Menu;
            this.cBoxWeatherScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWeatherScreen.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWeatherScreen.FormattingEnabled = true;
            this.cBoxWeatherScreen.Location = new System.Drawing.Point(210, 10);
            this.cBoxWeatherScreen.Name = "cBoxWeatherScreen";
            this.cBoxWeatherScreen.Size = new System.Drawing.Size(180, 23);
            this.cBoxWeatherScreen.TabIndex = 1;
            // 
            // lblWeatherScreen
            // 
            this.lblWeatherScreen.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherScreen.Location = new System.Drawing.Point(10, 10);
            this.lblWeatherScreen.Name = "lblWeatherScreen";
            this.lblWeatherScreen.Size = new System.Drawing.Size(200, 23);
            this.lblWeatherScreen.TabIndex = 0;
            this.lblWeatherScreen.Text = "Start Screen (Left to Right):";
            this.lblWeatherScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cBoxWeatherLocation
            // 
            this.cBoxWeatherLocation.BackColor = System.Drawing.SystemColors.Menu;
            this.cBoxWeatherLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWeatherLocation.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWeatherLocation.FormattingEnabled = true;
            this.cBoxWeatherLocation.Items.AddRange(new object[] {
            "Top Left",
            "Top Right",
            "Bottom Right",
            "Bottom Left"});
            this.cBoxWeatherLocation.Location = new System.Drawing.Point(210, 53);
            this.cBoxWeatherLocation.Name = "cBoxWeatherLocation";
            this.cBoxWeatherLocation.Size = new System.Drawing.Size(180, 23);
            this.cBoxWeatherLocation.TabIndex = 7;
            // 
            // lblWeatherLocation
            // 
            this.lblWeatherLocation.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherLocation.Location = new System.Drawing.Point(10, 53);
            this.lblWeatherLocation.Name = "lblWeatherLocation";
            this.lblWeatherLocation.Size = new System.Drawing.Size(200, 23);
            this.lblWeatherLocation.TabIndex = 6;
            this.lblWeatherLocation.Text = "Window Location:";
            this.lblWeatherLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cBoxWeatherRefresh
            // 
            this.cBoxWeatherRefresh.BackColor = System.Drawing.SystemColors.Menu;
            this.cBoxWeatherRefresh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWeatherRefresh.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxWeatherRefresh.FormattingEnabled = true;
            this.cBoxWeatherRefresh.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60"});
            this.cBoxWeatherRefresh.Location = new System.Drawing.Point(210, 96);
            this.cBoxWeatherRefresh.Name = "cBoxWeatherRefresh";
            this.cBoxWeatherRefresh.Size = new System.Drawing.Size(180, 23);
            this.cBoxWeatherRefresh.TabIndex = 9;
            // 
            // lblWeatherRefresh
            // 
            this.lblWeatherRefresh.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherRefresh.Location = new System.Drawing.Point(10, 96);
            this.lblWeatherRefresh.Name = "lblWeatherRefresh";
            this.lblWeatherRefresh.Size = new System.Drawing.Size(200, 23);
            this.lblWeatherRefresh.TabIndex = 8;
            this.lblWeatherRefresh.Text = "Refresh Rate (Minute):";
            this.lblWeatherRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.pnlWeather);
            this.Controls.Add(this.listBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.pnlWeather.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMain;
        private System.Windows.Forms.Panel pnlWeather;
        private System.Windows.Forms.ComboBox cBoxWeatherScreen;
        private System.Windows.Forms.Label lblWeatherScreen;
        private System.Windows.Forms.Label lblWeatherAlwaysTop;
        private System.Windows.Forms.CheckBox checkBoxWeatherAlwaysTop;
        private System.Windows.Forms.Label lblWeatherShow;
        private System.Windows.Forms.CheckBox checkBoxWeatherShow;
        private System.Windows.Forms.ComboBox cBoxWeatherLocation;
        private System.Windows.Forms.Label lblWeatherLocation;
        private System.Windows.Forms.ComboBox cBoxWeatherRefresh;
        private System.Windows.Forms.Label lblWeatherRefresh;
    }
}