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
 * Version 0.2 - Added label changing according to radio buttons
 */
namespace Assignment05
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
            MetricRadioButton.Checked = true;
        }

        private void WeightInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void HeightInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Results_TextChanged(object sender, EventArgs e)
        {

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
    }
}
