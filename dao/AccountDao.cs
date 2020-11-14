using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.dao
{
    class AccountDao
    {
        private SqlConnection con = null;
        private string databaseInfo = "";
        public AccountDao()
        {
            databaseInfo = DatabaseInfo.Info();
        }

        public Boolean CheckLogin(string username, string password)
        {
            if (con == null)
                con = new SqlConnection(databaseInfo);
            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT password FROM Account WHERE username='" + username + "'";
            command.Connection = con;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string dbPassword = reader.GetString(0);
                return (password.Equals(dbPassword));
            }
            return false;
        }
    }
}
