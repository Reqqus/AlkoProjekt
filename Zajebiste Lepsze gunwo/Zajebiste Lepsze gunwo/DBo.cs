using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajebiste_Lepsze_gunwo
{
    public class DBo
    {


        public static void Connect()
        {
            string ConString = @"Data Source=sqltester2018.wwsi.edu.pl;Initial Catalog=TestLosek;Persist Security Info=True;User ID=tlosek;Password=Ulaniec!@#";
            SqlConnection con;

            con = new SqlConnection(ConString);

            con.Open();

            Console.WriteLine("Jest połączone kurdebele");

            con.Close();
            

        }




    }
}
