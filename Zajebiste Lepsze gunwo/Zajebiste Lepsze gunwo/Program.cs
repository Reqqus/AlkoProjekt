using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zajebiste_Lepsze_gunwo
{
    class Program : DBo
    {
        static void Main(string[] args)
        {
            //Connect();

             OdczytywanieDanych();

            //dodawanie();
            
            
        }


        public static void Connect()
        {
            string ConString = @"Data Source=sqltester2018.wwsi.edu.pl;Initial Catalog=TestLosek;Persist Security Info=True;User ID=tlosek;Password=Ulaniec!@#";
            SqlConnection con;

            con = new SqlConnection(ConString);

            con.Open();

            Console.WriteLine("Jest połączone kurdebele");

            con.Close();


        }


        public static void OdczytywanieDanych ()
        {
            string ConString = @"Data Source=sqltester2018.wwsi.edu.pl;Initial Catalog=TestLosek;Persist Security Info=True;User ID=tlosek;Password=Ulaniec!@#";

            SqlConnection con;

            con = new SqlConnection(ConString);

            con.Open();

            SqlCommand cmd;
            SqlDataReader reader;

            string sql, output = "";

            sql = "select * from Imiona";

            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();

            while (reader.Read())

            {
                output = output + reader.GetValue(0) + " - "   + reader.GetValue(1) + "\n";
                

            }
            Console.WriteLine(output);
            Console.ReadLine();
            reader.Close();
            cmd.Dispose();
            con.Close();


        }

        public static void dodawanie()
        {
            string conString = @"Data Source=sqltester2018.wwsi.edu.pl;Initial Catalog=TestLosek;Persist Security Info=True;User ID=tlosek;Password=Ulaniec!@#";
            SqlConnection con;
            con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter;
            string sql = "insert into imiona values('3','2')";
            cmd = new SqlCommand(sql, con);
            adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        }
}
