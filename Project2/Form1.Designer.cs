namespace Project2
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
            this.Load_Stock = new System.Windows.Forms.Button();
            this.openFileDialog_StockLoader = new System.Windows.Forms.OpenFileDialog();
            this.Update = new System.Windows.Forms.Button();
            this.comboBox_Select_Pattern = new System.Windows.Forms.ComboBox();
            this.checkBox_KeepAnnotations = new System.Windows.Forms.CheckBox();
            this.button_Clear = new System.Windows.Forms.Button();
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
            this.chart1.Location = new System.Drawing.Point(218, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=SpringGreen";
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
            this.chart1.Size = new System.Drawing.Size(663, 480);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Location = new System.Drawing.Point(12, 120);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_Start.TabIndex = 1;
            this.dateTimePicker_Start.Value = new System.DateTime(2021, 1, 28, 0, 0, 0, 0);
            // 
            // dateTimePicker_End
            // 
            this.dateTimePicker_End.Location = new System.Drawing.Point(12, 162);
            this.dateTimePicker_End.Name = "dateTimePicker_End";
            this.dateTimePicker_End.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_End.TabIndex = 2;
            this.dateTimePicker_End.Value = new System.DateTime(2021, 2, 28, 0, 0, 0, 0);
            // 
            // Load_Stock
            // 
            this.Load_Stock.Location = new System.Drawing.Point(13, 34);
            this.Load_Stock.Name = "Load_Stock";
            this.Load_Stock.Size = new System.Drawing.Size(119, 23);
            this.Load_Stock.TabIndex = 3;
            this.Load_Stock.Text = "Load Stock";
            this.Load_Stock.UseVisualStyleBackColor = true;
            this.Load_Stock.Click += new System.EventHandler(this.Load_Stock_Click);
            // 
            // openFileDialog_StockLoader
            // 
            this.openFileDialog_StockLoader.FileName = "openFileDialog1";
            this.openFileDialog_StockLoader.Multiselect = true;
            // 
            // Update
            // 
            this.Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Update.Location = new System.Drawing.Point(12, 396);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // comboBox_Select_Pattern
            // 
            this.comboBox_Select_Pattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Select_Pattern.FormattingEnabled = true;
            this.comboBox_Select_Pattern.Items.AddRange(new object[] {
            "\"Maribozu\"",
            "\"aaaaa\"",
            "\"bbbbb\"",
            "\"ccccc\"",
            "\"ddddd\""});
            this.comboBox_Select_Pattern.Location = new System.Drawing.Point(13, 250);
            this.comboBox_Select_Pattern.Name = "comboBox_Select_Pattern";
            this.comboBox_Select_Pattern.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Select_Pattern.TabIndex = 5;
            this.comboBox_Select_Pattern.SelectedIndexChanged += new System.EventHandler(this.comboBox_Select_Pattern_SelectedIndexChanged);
            // 
            // checkBox_KeepAnnotations
            // 
            this.checkBox_KeepAnnotations.AutoSize = true;
            this.checkBox_KeepAnnotations.Location = new System.Drawing.Point(13, 299);
            this.checkBox_KeepAnnotations.Name = "checkBox_KeepAnnotations";
            this.checkBox_KeepAnnotations.Size = new System.Drawing.Size(127, 20);
            this.checkBox_KeepAnnotations.TabIndex = 6;
            this.checkBox_KeepAnnotations.Text = "Keep Annotation";
            this.checkBox_KeepAnnotations.UseVisualStyleBackColor = true;
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(13, 340);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 488);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.checkBox_KeepAnnotations);
            this.Controls.Add(this.comboBox_Select_Pattern);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Load_Stock);
            this.Controls.Add(this.dateTimePicker_End);
            this.Controls.Add(this.dateTimePicker_Start);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "ABBVdaily";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCandlestickBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.Button Load_Stock;
        private System.Windows.Forms.OpenFileDialog openFileDialog_StockLoader;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.BindingSource aCandlestickBindingSource;
        private System.Windows.Forms.ComboBox comboBox_Select_Pattern;
        private System.Windows.Forms.CheckBox checkBox_KeepAnnotations;
        private System.Windows.Forms.Button button_Clear;
    }
}

