
namespace WeatherLibrary.Controls
{
    partial class WeatherControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pBoxWeather = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWeatherInfo = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWeather)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pBoxWeather);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(212, 106);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pBoxWeather
            // 
            this.pBoxWeather.Location = new System.Drawing.Point(3, 3);
            this.pBoxWeather.Name = "pBoxWeather";
            this.pBoxWeather.Size = new System.Drawing.Size(100, 100);
            this.pBoxWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBoxWeather.TabIndex = 0;
            this.pBoxWeather.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblWeatherInfo);
            this.flowLayoutPanel2.Controls.Add(this.lblTemperature);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(106, 3);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(100, 100);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // lblWeatherInfo
            // 
            this.lblWeatherInfo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeatherInfo.Location = new System.Drawing.Point(0, 0);
            this.lblWeatherInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblWeatherInfo.Name = "lblWeatherInfo";
            this.lblWeatherInfo.Size = new System.Drawing.Size(100, 50);
            this.lblWeatherInfo.TabIndex = 0;
            this.lblWeatherInfo.Text = "BROKEN CLOUDS";
            this.lblWeatherInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperature
            // 
            this.lblTemperature.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(0, 50);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(100, 50);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "7°C";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeatherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "WeatherControl";
            this.Size = new System.Drawing.Size(212, 106);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWeather)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pBoxWeather;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblWeatherInfo;
        private System.Windows.Forms.Label lblTemperature;
    }
}
