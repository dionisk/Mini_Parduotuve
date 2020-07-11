using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Parduotuve
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DuomenuBaze duomenuBaze = new DuomenuBaze();
            Main_Form main_Form = new Main_Form();
            Application.Run(main_Form);           
        }
    }
}
