using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager2._0
{
    class Account
    {
        private int id;
        private string email;
        private string username;
        private string passwordText;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string PasswordText
        {
            get
            {
                return passwordText;
            }
            set
            {
                passwordText = value;
            }
        }

        public void Find(int Id)
        {
            DataConnection dbconnection = new DataConnection();

            dbconnection.AddParameter("@id", Id);
            dbconnection.Execute("sproc_Accounts_FilterByID");

            if (dbconnection.Count == 1)
            {
                Id = Convert.ToInt32(dbconnection.DataTable.Rows[0]["Id"]);
                Email = Convert.ToString(dbconnection.DataTable.Rows[0]["Email"]);
                Username = Convert.ToString(dbconnection.DataTable.Rows[0]["Username"]);
                PasswordText = Convert.ToString(dbconnection.DataTable.Rows[0]["PasswordText"]);
            }
        }
    }
}
