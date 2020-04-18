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
            DialogResult result = fLogin.ShowDialog();
            if (result == DialogResult.OK) //if admin login is ok
            {

                Application.Run(new MainForm()); //run program
            }
            else if (result == DialogResult.Yes) //if user login is ok
            {
                Application.Run(new FormUser()); //run program
            }
            else
            {
                Application.Exit();  //exit program
            }
        }
    }
}
