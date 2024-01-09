using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lakopark
{
    class Adatbazis
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "lakopark";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ConnectionString);

            try
            {
                kapcsolatNyit();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                kapcsolatZar();
            }
        }


        private void kapcsolatZar()
        {
            if ( connection.State != System.Data.ConnectionState.Closed )
            {
                connection.Close();
            }
        }

        private void kapcsolatNyit()
        {
            if ( connection.State != System.Data.ConnectionState.Open ) connection.Open();
        }
    }
}
