namespace NoGateway
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
            this.lab_country = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lab_pressure = new System.Windows.Forms.Label();
            this.lab_windspeed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lab_detail = new System.Windows.Forms.Label();
            this.lab_condition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbCity = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_country
            // 
            this.lab_country.AutoSize = true;
            this.lab_country.Location = new System.Drawing.Point(157, 93);
            this.lab_country.Name = "lab_country";
            this.lab_country.Size = new System.Drawing.Size(0, 13);
            this.lab_country.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Country:";
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(354, 201);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(115, 50);
            this.picIcon.TabIndex = 29;
            this.picIcon.TabStop = false;
            // 
            // lab_pressure
            // 
            this.lab_pressure.AutoSize = true;
            this.lab_pressure.Location = new System.Drawing.Point(377, 155);
            this.lab_pressure.Name = "lab_pressure";
            this.lab_pressure.Size = new System.Drawing.Size(27, 13);
            this.lab_pressure.TabIndex = 28;
            this.lab_pressure.Text = "N/A";
            // 
            // lab_windspeed
            // 
            this.lab_windspeed.AutoSize = true;
            this.lab_windspeed.Location = new System.Drawing.Point(377, 125);
            this.lab_windspeed.Name = "lab_windspeed";
            this.lab_windspeed.Size = new System.Drawing.Size(27, 13);
            this.lab_windspeed.TabIndex = 27;
            this.lab_windspeed.Text = "N/A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Pressure:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Wind speed:";
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.Location = new System.Drawing.Point(155, 238);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(27, 13);
            this.lab_sunset.TabIndex = 24;
            this.lab_sunset.Text = "N/A";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.Location = new System.Drawing.Point(155, 198);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(27, 13);
            this.lab_sunrise.TabIndex = 23;
            this.lab_sunrise.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sunset:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sunrise:";
            // 
            // lab_detail
            // 
            this.lab_detail.AutoSize = true;
            this.lab_detail.Location = new System.Drawing.Point(67, 162);
            this.lab_detail.Name = "lab_detail";
            this.lab_detail.Size = new System.Drawing.Size(34, 13);
            this.lab_detail.TabIndex = 20;
            this.lab_detail.Text = "Detail";
            // 
            // lab_condition
            // 
            this.lab_condition.AutoSize = true;
            this.lab_condition.Location = new System.Drawing.Point(67, 125);
            this.lab_condition.Name = "lab_condition";
            this.lab_condition.Size = new System.Drawing.Size(56, 13);
            this.lab_condition.TabIndex = 19;
            this.lab_condition.Text = "Conditions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "City:";
            // 
            // TbCity
            // 
            this.TbCity.Location = new System.Drawing.Point(99, 43);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(228, 20);
            this.TbCity.TabIndex = 17;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(403, 41);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 315);
            this.Controls.Add(this.lab_country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lab_pressure);
            this.Controls.Add(this.lab_windspeed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lab_sunset);
            this.Controls.Add(this.lab_sunrise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_detail);
            this.Controls.Add(this.lab_condition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbCity);
            this.Controls.Add(this.btn_search);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_country;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lab_pressure;
        private System.Windows.Forms.Label lab_windspeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lab_detail;
        private System.Windows.Forms.Label lab_condition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.Button btn_search;
    }
}

