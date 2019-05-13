namespace WeatherApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelCity = new System.Windows.Forms.Label();
            this.btnCallApi = new System.Windows.Forms.Button();
            this.dataGridViewHistoryWeather = new System.Windows.Forms.DataGridView();
            this.historyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weatherDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWeatherHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryWeather)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWeatherHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.Color.Transparent;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCity.ForeColor = System.Drawing.Color.White;
            this.labelCity.Location = new System.Drawing.Point(23, 111);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(165, 25);
            this.labelCity.TabIndex = 1;
            this.labelCity.Text = "Data in database:";
            // 
            // btnCallApi
            // 
            this.btnCallApi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCallApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCallApi.ForeColor = System.Drawing.Color.White;
            this.btnCallApi.Location = new System.Drawing.Point(332, 40);
            this.btnCallApi.Name = "btnCallApi";
            this.btnCallApi.Size = new System.Drawing.Size(380, 79);
            this.btnCallApi.TabIndex = 2;
            this.btnCallApi.Text = "REFRESH WEATHER DATA";
            this.btnCallApi.UseVisualStyleBackColor = false;
            this.btnCallApi.Click += new System.EventHandler(this.btnCallApi_Click);
            // 
            // dataGridViewHistoryWeather
            // 
            this.dataGridViewHistoryWeather.AutoGenerateColumns = false;
            this.dataGridViewHistoryWeather.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoryWeather.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.historyidDataGridViewTextBoxColumn,
            this.cityNameDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.weatherDateDataGridViewTextBoxColumn,
            this.pressureDataGridViewTextBoxColumn,
            this.humidityDataGridViewTextBoxColumn,
            this.windSpeedDataGridViewTextBoxColumn});
            this.dataGridViewHistoryWeather.DataSource = this.vWeatherHistoryBindingSource;
            this.dataGridViewHistoryWeather.Location = new System.Drawing.Point(26, 148);
            this.dataGridViewHistoryWeather.Name = "dataGridViewHistoryWeather";
            this.dataGridViewHistoryWeather.RowTemplate.Height = 24;
            this.dataGridViewHistoryWeather.Size = new System.Drawing.Size(762, 150);
            this.dataGridViewHistoryWeather.TabIndex = 3;
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
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "CityName";
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            // 
            // weatherDateDataGridViewTextBoxColumn
            // 
            this.weatherDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.weatherDateDataGridViewTextBoxColumn.DataPropertyName = "WeatherDate";
            this.weatherDateDataGridViewTextBoxColumn.HeaderText = "WeatherDate";
            this.weatherDateDataGridViewTextBoxColumn.Name = "weatherDateDataGridViewTextBoxColumn";
            // 
            // pressureDataGridViewTextBoxColumn
            // 
            this.pressureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pressureDataGridViewTextBoxColumn.DataPropertyName = "Pressure";
            this.pressureDataGridViewTextBoxColumn.HeaderText = "Pressure";
            this.pressureDataGridViewTextBoxColumn.Name = "pressureDataGridViewTextBoxColumn";
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "Humidity";
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            // 
            // windSpeedDataGridViewTextBoxColumn
            // 
            this.windSpeedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.windSpeedDataGridViewTextBoxColumn.DataPropertyName = "WindSpeed";
            this.windSpeedDataGridViewTextBoxColumn.HeaderText = "WindSpeed";
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
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(28, 350);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 66);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(WeatherApp.City);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherApp.Properties.Resources._58676720_582174248933845_5894671111420903424_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridViewHistoryWeather);
            this.Controls.Add(this.btnCallApi);
            this.Controls.Add(this.labelCity);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryWeather)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWeatherHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Button btnCallApi;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewHistoryWeather;
        private System.Windows.Forms.DataGridViewTextBoxColumn historyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weatherDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vWeatherHistoryBindingSource;
        private System.Windows.Forms.Button btnClose;
    }
}

