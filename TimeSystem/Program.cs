using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSystem.View;

namespace TimeSystem
{
    static class Program
    {
        static Factory factory;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            factory = new Factory();

            Application.Run(factory.mainForm);
        }
    }
}
