using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Aron Ly
 * Student #: 300932437
 * Date: August 4, 2017
 * Description: BMI Calculator Project
 * Version 0.1 - Project created
 */
namespace Assignment05
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
