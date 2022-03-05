using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace administrare_hotel
{
    internal class Database
    {
        public MySqlConnection conn = new MySqlConnection();
        public bool connection()
        {
            Form1 principal = new Form1();
            string server = "localhost", db = "hotel_database", user = "root", password = "";
            string connection_string = "server = " + server + ";database = " + db + ";user = " + user + ";password = " + password;
            conn.ConnectionString = connection_string;
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
