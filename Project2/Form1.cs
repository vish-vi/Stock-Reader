using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Project2
{
    public partial class Form1 : Form
    {
        // Global list to store stock data
        List<aCandlestick> allData = new List<aCandlestick>();
        List<aRecognizer> recognizers = aRecognizer.InitializeRecognizer();

        /// Default constructor for the main form and custom initialization
        public Form1()
        {
            InitializeComponent();
            SetupEasyStart();
        }

        /// Configures initial application state
        private void SetupEasyStart()
        {
            // Sets default TabIndex
            Load_Stock.TabIndex = 0;

            // Sets required start and end dates
            dateTimePicker_Start.Value = new DateTime(2021, 1, 28);
            dateTimePicker_End.Value = new DateTime(2021, 2, 28);

            // Presets the OpenFileDialog
            openFileDialog_StockLoader.InitialDirectory = @"..\";
            openFileDialog_StockLoader.FileName = "ABBV_daily.csv";
            openFileDialog_StockLoader.Filter = "CSV Files (*.csv)|*.csv";

            // Automatically loads ABBV_daily.csv on startup
            LoadStock(@"..\ABBV_daily.csv");

            comboBox_Select_Pattern.Items.Clear();
            foreach (var r in recognizers)
                comboBox_Select_Pattern.Items.Add(r.pattern);
        }

        /// Reads a CSV file from the given path and converts each line
        /// into aCandlestick objects stored in memory.
        /// After loading, updates the chart display.
        private void LoadStock(string filePath)
        {
            string[] lines;
            // Reads lines
            try
            {
                lines = System.IO.File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading file: " + ex.Message);
                return;
            }

            allData.Clear();

            // Creates candlesticks
            for (int i = 1; i < lines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                {
                    allData.Add(new aCandlestick(lines[i]));
                    
                }
            }

            UpdateDisplay();
        }
        

        /// Converting to list using copy converter from aCandlestick to aSmartCandlestick for pattern recognition
        List<aSmartCandlestick> ConvertToList(List<aCandlestick> data)
        {
            List<aSmartCandlestick> smartCandlestickList = new List<aSmartCandlestick>();
            foreach (var c in data)
            {
                smartCandlestickList.Add(new aSmartCandlestick(c));
            }
            return smartCandlestickList;
        }


        /// Filters the loaded stock data based on the selected date range and sends the filtered list to the chart for display.
        private void UpdateDisplay()
        {
            DateTime start = dateTimePicker_Start.Value.Date;
            DateTime end = dateTimePicker_End.Value.Date;
            // Filters Data
            var filtered = allData
                .Where(c => c.date >= start && c.date <= end)
                .ToList();

            BindChart(filtered);
        }

        /// Bind chart using DataSource
        private void BindChart(List<aCandlestick> data)
        {
            aCandlestickBindingSource.DataSource = null;
            aCandlestickBindingSource.DataSource = data;

            // Chart binding 
            chart1.DataSource = aCandlestickBindingSource;
            chart1.DataBind();
        }

        /// Load button (supports multiple files)
        private void Load_Stock_Click(object sender, EventArgs e)
        {
            //

            if (openFileDialog_StockLoader.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog_StockLoader.FileNames.Length; i++)
                {
                    if (i == 0)
                    {
                        // First file on main form
                        LoadStock(openFileDialog_StockLoader.FileNames[i]);
                    }
                    else
                    {
                        // Other files to new forms
                        StockForm newForm = new StockForm(openFileDialog_StockLoader.FileNames[i]);
                        newForm.Show();
                    }
                }
            }
        }

        /// Update button
        private void Update_Click(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // accidental click handler, no action needed
        }

        private void comboBox_Select_Pattern_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Clear annotations if "Keep Annotations" is unchecked
            if (!checkBox_KeepAnnotations.Checked)
                chart1.Annotations.Clear();

            if (comboBox_Select_Pattern.SelectedIndex < 0 || comboBox_Select_Pattern.SelectedIndex >= recognizers.Count) return;

            var recognizer = recognizers[comboBox_Select_Pattern.SelectedIndex];


            // Convert and recognize
            var losc = ConvertToList(allData
                .Where(c => c.date >= dateTimePicker_Start.Value && c.date <= dateTimePicker_End.Value)
                .ToList());

            List<int> indices = recognizer.recognize_pattern(losc);

            // Annotate — index in losc maps to chart point index
            foreach (int idx in indices)
            {
                TextAnnotation annotation = new TextAnnotation();
                annotation.Text = recognizer.pattern;
                annotation.AnchorDataPoint = chart1.Series[0].Points[idx];
                chart1.Annotations.Add(annotation);
            }

            chart1.Invalidate(); // force redraw
        }


        /// Clearing annotations from the chart when the "Clear Annotations" button is clicked. This allows users to remove all pattern annotations from the chart at once.
        private void button_Clear_Click(object sender, EventArgs e)
        {
            chart1.Annotations.Clear(); 
        }
    }
}