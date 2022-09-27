using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SerialsForm
{
    internal class Connect
    {
        public MySqlConnection connect;
        private string server;
        private string database;
        private string user;
        private string password;
        private string connectionstring;

        public Connect()
        {
           
            try
            {
                server = "localhost";
                database = "serials";
                user = "root";
                password = "";

                connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";" + "SslMode=None;";

                connect = new MySqlConnection(connectionstring);
                connect.Open();
                Console.WriteLine("Sikeres csatlakozás!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
