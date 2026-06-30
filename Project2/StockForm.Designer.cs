namespace Project2
{
    partial class StockForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aCandlestickBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.button_Update = new System.Windows.Forms.Button();
            this.comboBox_SelectPatternSF = new System.Windows.Forms.ComboBox();
            this.checkBoxSF_KeepAnnotations = new System.Windows.Forms.CheckBox();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.aCandlestickBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(233, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "date";
            series1.YValueMembers = "high, low, open, close";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.XValueMember = "date";
            series2.YValueMembers = "volume";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(606, 424);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // aCandlestickBindingSource
            // 
            this.aCandlestickBindingSource.DataSource = typeof(Project2.aCandlestick);
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Start.TabIndex = 1;
            this.dateTimePicker_Start.ValueChanged += new System.EventHandler(this.dateTimePicker_Start_ValueChanged);
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Location = new System.Drawing.Point(12, 78);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_End.TabIndex = 2;
            // 
            // button_Update
            // 
            this.button_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Update.Location = new System.Drawing.Point(12, 413);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // comboBox_SelectPatternSF
            // 
            this.comboBox_SelectPatternSF.FormattingEnabled = true;
            this.comboBox_SelectPatternSF.Items.AddRange(new object[] {
            "aaaa",
            "bbbbb",
            "ccccc",
            "ddddd"});
            this.comboBox_SelectPatternSF.Location = new System.Drawing.Point(12, 177);
            this.comboBox_SelectPatternSF.Name = "comboBox_SelectPatternSF";
            this.comboBox_SelectPatternSF.Size = new System.Drawing.Size(121, 24);
            this.comboBox_SelectPatternSF.TabIndex = 4;
            this.comboBox_SelectPatternSF.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectPatternSF_SelectedIndexChanged);
            // 
            // checkBoxSF_KeepAnnotations
            // 
            this.checkBoxSF_KeepAnnotations.AutoSize = true;
            this.checkBoxSF_KeepAnnotations.Location = new System.Drawing.Point(13, 208);
            this.checkBoxSF_KeepAnnotations.Name = "checkBoxSF_KeepAnnotations";
            this.checkBoxSF_KeepAnnotations.Size = new System.Drawing.Size(134, 20);
            this.checkBoxSF_KeepAnnotations.TabIndex = 5;
            this.checkBoxSF_KeepAnnotations.Text = "Keep Annotations";
            this.checkBoxSF_KeepAnnotations.UseVisualStyleBackColor = true;
            this.checkBoxSF_KeepAnnotations.CheckedChanged += new System.EventHandler(this.checkBoxSF_KeepAnnotations_CheckedChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(13, 270);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 481);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.checkBoxSF_KeepAnnotations);
            this.Controls.Add(this.comboBox_SelectPatternSF);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.dateTimePicker_End);
            this.Controls.Add(this.dateTimePicker_Start);
            this.Controls.Add(this.chart1);
            this.Name = "StockForm";
            this.Text = "StockForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource aCandlestickBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.ComboBox comboBox_SelectPatternSF;
        private System.Windows.Forms.CheckBox checkBoxSF_KeepAnnotations;
        private System.Windows.Forms.Button Clear;
    }
}