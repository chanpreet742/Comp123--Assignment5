using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Chanpreet Mudhar
 * Student Number - 300932732
 * Description: Comp123- Assignment6- BMI Calculator
 * Date: August 15, 2017
 * */
namespace Comp123__Assignment5
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
            Application.Run(new formBMICalculator());
        }
    }
}
