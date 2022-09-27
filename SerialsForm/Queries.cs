using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SerialsForm
{
    internal class Queries
    {
        public void dbSelect(ListBox listBox1)
        {
            Connect c = new Connect();
            string query = "SELECT `id`,`razon`,`active`,`ban` FROM `datas`;";

            MySqlCommand cmd = new MySqlCommand(query, c.connect);

            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            do
            {
                listBox1.Items.Add(reader.GetValue(0) + "-" + reader.GetValue(1) + "-" + reader.GetValue(2));

            } while (reader.Read());
            reader.Close();
        }
        
        public void dbDelete(int identity)
        {
            Connect c = new Connect();
            string query = "DELETE FROM `datas` WHERE `id`=" + identity + ";";
            MySqlCommand cmd = new MySqlCommand(query, c.connect);
            MySqlDataReader delete = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();
        }

        public void dbInsert(ListBox lista)
        {
            Random random = new Random();
            int razon = random.Next(100000, 999999);
            int active = 1;
            int ban = 1;
            Connect c = new Connect();
            string query = "INSERT INTO `datas`(`razon`,`active`,`ban`) " + "VALUES('" + razon + "','" + active + "','" + ban + "');";
            MySqlCommand cmd = new MySqlCommand(query, c.connect);
            MySqlDataReader insert = cmd.ExecuteReader();
            //cmd.ExecuteNonQuery();
        }

        public void dbUpdate(int razon, int active, int ban, int identity, ListBox lista)
        {
            Connect c = new Connect();
            string query = "UPDATE `datas` SET `azon`='" + razon + "',`azon`='" + active + "',`ban`='" + ban + "' WHERE `id`=" + identity + ";";
            MySqlCommand cmd = new MySqlCommand(query, c.connect);
            //MySqlDataReader insert = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
        }
    }
}
