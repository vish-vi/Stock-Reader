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
    /// Represents a separate form for displaying an individual stock's candlestick chart.
    /// Allows filtering by date range and updating the chart.

    public partial class StockForm : Form
    {
        List<aRecognizer> recognizers = aRecognizer.InitializeRecognizer();
        // Global list to store all candlestick data for this stock
        List<aCandlestick> allData = new List<aCandlestick>();

        /// Constructor for StockForm.
        /// Loads the stock data from the specified CSV file and initializes the chart.
        public StockForm(string filePath)
        {
            InitializeComponent();
            LoadStock(filePath);

            comboBox_SelectPatternSF.Items.Clear();
            foreach (var r in recognizers)
                comboBox_SelectPatternSF.Items.Add(r.pattern);
        }

        /// Loads the CSV file into memory, parses it into candlestick objects
        private void LoadStock(string filePath)
        {
            allData.Clear();

            var lines = System.IO.File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                {
                    allData.Add(new aCandlestick(lines[i]));
                }
            }

            // Sets the default date range, and updates the chart display.
            dateTimePicker_Start.Value = new DateTime(2021, 1, 28);
            dateTimePicker_End.Value = new DateTime(2021, 2, 28);

            UpdateDisplay(); // bind chart with filtered data
        }

        List<aSmartCandlestick> ConvertToList(List<aCandlestick> data)
        {
            List<aSmartCandlestick> smartCandlestickList = new List<aSmartCandlestick>();
            foreach (var c in data)
            {
                smartCandlestickList.Add(new aSmartCandlestick(c));
            }
            return smartCandlestickList;
        }
      

        /// Filters the loaded stock data according to the selected start and end dates
        /// Binds the resulting list to the chart.
        private void UpdateDisplay()
        {
            var filtered = allData
                .Where(c => c.date >= dateTimePicker_Start.Value &&
                            c.date <= dateTimePicker_End.Value)
                .ToList();

            aCandlestickBindingSource.DataSource = null;
            aCandlestickBindingSource.DataSource = filtered;

            chart1.DataSource = aCandlestickBindingSource;
            chart1.DataBind();
        }

        /// Handles the Click event of the Update button and refreshes the display with the latest data.
        private void button_Update_Click(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void dateTimePicker_Start_ValueChanged(object sender, EventArgs e)
        {
            // Update the display when the start date changes
        }

        private void comboBox_SelectPatternSF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SelectPatternSF.SelectedIndex < 0) return;

            // Clear annotations if "Keep Annotations" is unchecked
            if (!checkBoxSF_KeepAnnotations.Checked)
                chart1.Annotations.Clear();

            var recognizer = recognizers[comboBox_SelectPatternSF.SelectedIndex];

            // Convert and recognize
            var losc = ConvertToList(allData
                .Where(c => c.date >= dateTimePicker_Start.Value && c.date <= dateTimePicker_End.Value)
                .ToList());

            List<int> indices = recognizer.recognize_pattern(losc);

            foreach (int idx in indices)
            {
                TextAnnotation annotation = new TextAnnotation();
                annotation.Text = recognizer.pattern;
                annotation.AnchorDataPoint = chart1.Series[0].Points[idx];
                chart1.Annotations.Add(annotation);
            }

            chart1.Invalidate(); // force redraw
        }

        /// checkBoxSF_KeepAnnotations_CheckedChanged is an event handler for the "Keep Annotations" checkbox.
        private void checkBoxSF_KeepAnnotations_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// clears all annotations from the chart when the "Clear" button is clicked, allowing the user to remove any pattern annotations and start fresh with a clean chart.
        private void Clear_Click(object sender, EventArgs e)
        {
            chart1.Annotations.Clear();
        }
    }
}
