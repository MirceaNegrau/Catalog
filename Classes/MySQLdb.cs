using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Catalog
{
    class MY_DB
    {
        //---To be swapped during testing---//
        //private MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=zau8zrjjn;database=csharp_student_db");
        private MySqlConnection con = new MySqlConnection("datasource=86.122.176.241;port=3306;username=root;password=zau8zrjjn;database=csharp_student_db");
        //------------------------------------

        public MySqlConnection getConnection //Connection info obtainer
        {
            get
            {
                return con;
            }
        }

        public void openConnection() //Connection opener
        {
            if(con.State==System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection() //Connection closer
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
