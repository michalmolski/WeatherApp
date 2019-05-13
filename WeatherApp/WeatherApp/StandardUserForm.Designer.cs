namespace WeatherApp
{
    partial class StandardUserForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnShowWeather = new System.Windows.Forms.Button();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewWeather = new System.Windows.Forms.DataGridView();
            this.historyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weatherDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWeatherHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWeatherHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowWeather
            // 
            this.btnShowWeather.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnShowWeather.ForeColor = System.Drawing.Color.White;
            this.btnShowWeather.Location = new System.Drawing.Point(542, 21);
            this.btnShowWeather.Name = "btnShowWeather";
            this.btnShowWeather.Size = new System.Drawing.Size(235, 66);
            this.btnShowWeather.TabIndex = 0;
            this.btnShowWeather.Text = "Show Weather";
            this.btnShowWeather.UseVisualStyleBackColor = false;
            this.btnShowWeather.Click += new System.EventHandler(this.btnShowWeather_Click);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cityBindingSource, "Cityid", true));
            this.comboBoxCity.DataSource = this.cityBindingSource;
            this.comboBoxCity.DisplayMember = "CityName";
            this.comboBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(329, 37);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(146, 33);
            this.comboBoxCity.TabIndex = 1;
            this.comboBoxCity.ValueMember = "Cityid";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(WeatherApp.City);
            // 
            // dataGridViewWeather
            // 
            this.dataGridViewWeather.AutoGenerateColumns = false;
            this.dataGridViewWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeather.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.historyidDataGridViewTextBoxColumn,
            this.cityNameDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.weatherDateDataGridViewTextBoxColumn,
            this.pressureDataGridViewTextBoxColumn,
            this.humidityDataGridViewTextBoxColumn,
            this.windSpeedDataGridViewTextBoxColumn});
            this.dataGridViewWeather.DataSource = this.vWeatherHistoryBindingSource;
            this.dataGridViewWeather.Location = new System.Drawing.Point(12, 105);
            this.dataGridViewWeather.Name = "dataGridViewWeather";
            this.dataGridViewWeather.RowTemplate.Height = 24;
            this.dataGridViewWeather.Size = new System.Drawing.Size(916, 129);
            this.dataGridViewWeather.TabIndex = 2;
            // 
            // historyidDataGridViewTextBoxColumn
            // 
            this.historyidDataGridViewTextBoxColumn.DataPropertyName = "Historyid";
            this.historyidDataGridViewTextBoxColumn.HeaderText = "Historyid";
            this.historyidDataGridViewTextBoxColumn.Name = "historyidDataGridViewTextBoxColumn";
            this.historyidDataGridViewTextBoxColumn.Visible = false;
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "CityName";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            this.cityNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature [Celsius]";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            // 
            // weatherDateDataGridViewTextBoxColumn
            // 
            this.weatherDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.weatherDateDataGridViewTextBoxColumn.DataPropertyName = "WeatherDate";
            this.weatherDateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.weatherDateDataGridViewTextBoxColumn.Name = "weatherDateDataGridViewTextBoxColumn";
            // 
            // pressureDataGridViewTextBoxColumn
            // 
            this.pressureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pressureDataGridViewTextBoxColumn.DataPropertyName = "Pressure";
            this.pressureDataGridViewTextBoxColumn.HeaderText = "Pressure [hPa]";
            this.pressureDataGridViewTextBoxColumn.Name = "pressureDataGridViewTextBoxColumn";
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "Humidity [%]";
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            // 
            // windSpeedDataGridViewTextBoxColumn
            // 
            this.windSpeedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.windSpeedDataGridViewTextBoxColumn.DataPropertyName = "WindSpeed";
            this.windSpeedDataGridViewTextBoxColumn.HeaderText = "WindSpeed [m/s]";
            this.windSpeedDataGridViewTextBoxColumn.Name = "windSpeedDataGridViewTextBoxColumn";
            // 
            // vWeatherHistoryBindingSource
            // 
            this.vWeatherHistoryBindingSource.DataSource = typeof(WeatherApp.vWeatherHistory);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.BackgroundImage = global::WeatherApp.Properties.Resources.icons8_return_40;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(54, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 67);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(130, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose city:";
            // 
            // chartTemperature
            // 
            this.chartTemperature.BackColor = System.Drawing.Color.Teal;
            this.chartTemperature.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisY.Title = "Celsius degree";
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BorderWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend1);
            this.chartTemperature.Location = new System.Drawing.Point(232, 253);
            this.chartTemperature.Name = "chartTemperature";
            this.chartTemperature.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chartTemperature.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Brown};
            series1.BackImage = "C:\\Users\\User\\Desktop\\DesktopApi\\WeatherApp\\WeatherApp\\Resources\\58676720_5821742" +
    "48933845_5894671111420903424_n.png";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Name = "Temperature";
            series1.SmartLabelStyle.CalloutLineWidth = 4;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chartTemperature.Series.Add(series1);
            this.chartTemperature.Size = new System.Drawing.Size(639, 257);
            this.chartTemperature.TabIndex = 7;
            this.chartTemperature.Text = "chart1";
            // 
            // StandardUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::WeatherApp.Properties.Resources._58676720_582174248933845_5894671111420903424_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 532);
            this.Controls.Add(this.chartTemperature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewWeather);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.btnShowWeather);
            this.Name = "StandardUserForm";
            this.Text = "StandardUserForm";
            this.Load += new System.EventHandler(this.StandardUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWeatherHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowWeather;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.DataGridView dataGridViewWeather;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.BindingSource vWeatherHistoryBindingSource;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weatherDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
    }
}