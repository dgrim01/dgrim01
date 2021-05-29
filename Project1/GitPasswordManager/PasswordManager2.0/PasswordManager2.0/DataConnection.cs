using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager2._0
{
    public class DataConnection
    {
        SqlConnection cnn;
        public void open()
        {
            string connectionString;
            
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\dgrim\\Documents\\PersonalProjects1\\PasswordManager2.0\\PasswordManager2.0\\App_Data\\Accounts_Passwords.mdf;Integrated Security=True;";


            cnn = new SqlConnection(connectionString);
            cnn.Open();
        }

        public void close()
        {
            cnn.Close();
        }
    }
}
