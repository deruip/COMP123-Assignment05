using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Aron Ly
 * Student #: 300932437
 * Date: August 15, 2017
 * Description: BMI Calculator Project
 * Version 0.3 - Added Calculate functions for both unit systems
 */
namespace Assignment05
{
    public partial class BMICalculator : Form
    {
        // private instance vars
        private double _height;
        private double _weight;
        private double _bmi;

        /// <summary>
        /// Main constructor for BMICalculator class
        /// </summary>
        public BMICalculator()
        {
            InitializeComponent();
            MetricRadioButton.Checked = true;
        }

        private void WeightInput_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(WeightInput.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Only numeric data is allowed");
            //    WeightInput.Clear();
            //}
        }

        private void HeightInput_TextChanged(object sender, EventArgs e)
        {
            //if (System.Text.RegularExpressions.Regex.IsMatch(HeightInput.Text, "[^0-9]"))
            //{
            //    MessageBox.Show("Only numeric data is allowed");
            //    HeightInput.Clear();
            //}
        }

        /// <summary>
        /// Changes the label of Height and Weight to Metric units when Metric radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightLabel.Text = "My Height (metres)";
            WeightLabel.Text = "My Weight (kgs)";
        }

        /// <summary>
        /// Changes the label of Height and Weight to Imperial units when Imperial radio button is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HeightLabel.Text = "My Height (inches)";
            WeightLabel.Text = "My Weight (lbs)";

        }

        /// <summary>
        /// Calls the appropriate function depending on the radio button that is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (MetricRadioButton.Checked)
            {
                CalculateBMIMetric();
            }
            else
            {
                CalculateBMIImperial();
            }
        }

        /// <summary>
        /// Calculates BMI using Metric formula and outputs result to BMIResultsTextBox
        /// </summary>
        private void CalculateBMIMetric()
        {
            _height = Convert.ToDouble(HeightInput.Text);
            _weight = Convert.ToDouble(WeightInput.Text);

            _bmi = _weight / (_height * _height);
            BMIResultsTextBox.Text = Convert.ToString(Math.Round(_bmi, 2));
        }

        /// <summary>
        /// Calculates BMI using Imperial formula and outputs result to BMIResultsTextBox
        /// </summary>
        private void CalculateBMIImperial()
        {
            _height = Convert.ToDouble(HeightInput.Text);
            _weight = Convert.ToDouble(WeightInput.Text);

            _bmi = (_weight * 703) / (_height * _height);
            BMIResultsTextBox.Text = Convert.ToString(Math.Round(_bmi, 2));
        }
    }
}
