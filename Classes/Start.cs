using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Create new login page
            Login_Form fLogin = new Login_Form();
            if (fLogin.ShowDialog() == DialogResult.OK) //if login successful
            {
                Application.Run(new MainForm()); //run program
            }
            else
            {
                Application.Exit(); 
            }
        }
    }
}
