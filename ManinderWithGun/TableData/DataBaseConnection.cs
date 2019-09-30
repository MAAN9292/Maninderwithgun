using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManinderWithGun.TableData
{
    public class DataBaseConnection
    {
        private static MySqlConnection con = null;

        private DataBaseConnection() { }

        //Connection with Database
        public static MySqlConnection GetConnection()
        {
            if (con == null)
            {
                con = new MySqlConnection();
                con.ConnectionString = "server=localhost;user id=root;password=rahul@123;database=RussianRouletteGun;SslMode=none;";
                con.Open();
            }

            return con; 
        }

        //Close the Connection from database
        public static void CloseConnection()
        {
            if (con != null)
            {
                con.Dispose();
            }
            con = null;
        }

    }
}
