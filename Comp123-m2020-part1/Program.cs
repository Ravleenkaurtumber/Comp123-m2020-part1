using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp123_m2020_part1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Step1 -declare my form
            HelloWorldForm helloWorldForm;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Step 2-Instantiate Form
             helloWorldForm = new HelloWorldForm();
             //Step 3- pass reference to the application
            Application.Run(helloWorldForm);
        }
    }
}
