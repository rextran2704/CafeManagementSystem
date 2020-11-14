using CafeManagementSystem.model;
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

        public Account GetAccount(string username)
        {
            Account account = null;
            try
            {
                if (con == null)
                    con = new SqlConnection(databaseInfo);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT AccountID, Password, UserRole, EmployeeID FROM Account WHERE username='" + username + "'";
                command.Connection = con;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string password = reader.GetString(1);
                    int role = reader.GetInt32(2);
                    int employeeId = reader.GetInt32(3);
                    account = new Account(id, username, password, role, employeeId);
                }
                con.Close();
                return account;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Boolean AddAccount(Account account)
        {
            try
            {
                int nRows;
                if (con == null)
                    con = new SqlConnection(databaseInfo);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string queryString = "INSERT INTO Account(Username, Password, Userrole, EmployeeID) VALUES (@username, @password, @userRole, @employeeId)";
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandText = queryString;
                    command.Parameters.AddWithValue("@username", account.Username);
                    command.Parameters.AddWithValue("@password", account.Password);
                    command.Parameters.AddWithValue("@userRole", account.UserRole);
                    command.Parameters.AddWithValue("@employeeId", account.EmployeeId);
                    nRows = command.ExecuteNonQuery();
                }
                con.Close();
                return nRows > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public List<Account> GetAccountList()
        {
            List<Account> accountList = new List<Account>();
            try
            {
                if (con == null)
                    con = new SqlConnection(databaseInfo);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT AccountID, Username, Password, UserRole, EmployeeID FROM Account";
                command.Connection = con;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string username = reader.GetString(1);
                    string password = reader.GetString(2);
                    int role = reader.GetInt32(3);
                    int employeeId = reader.GetInt32(4);
                    accountList.Add(new Account(id, username, password, role, employeeId));
                }
                con.Close();
                return accountList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public Boolean UpdateAccount(Account account)
        {
            try
            {
                int nRows;
                if (con == null)
                    con = new SqlConnection(databaseInfo);
                if (con.State == ConnectionState.Closed)
                    con.Open();

                string queryString = "UPDATE Account SET Password=@password, UserRole=@userRole, EmployeeID=@employeeId WHERE Username=@username";
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandText = queryString;
                    command.Parameters.AddWithValue("@username", account.Username);
                    command.Parameters.AddWithValue("@password", account.Password);
                    command.Parameters.AddWithValue("@userRole", account.UserRole);
                    command.Parameters.AddWithValue("@employeeId", account.EmployeeId);
                    nRows = command.ExecuteNonQuery();
                }
                con.Close();
                return (nRows > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Boolean RemoveAccount(string username)
        {
            try
            {
                int nRows;
                if (con == null)
                    con = new SqlConnection(databaseInfo);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string queryString = "DELETE FROM Account WHERE Username=@username";
                using (SqlCommand command = con.CreateCommand())
                {
                    command.CommandText = queryString;
                    command.Parameters.AddWithValue("@username", username);
                    nRows = command.ExecuteNonQuery();
                }
                con.Close();
                return nRows > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public Boolean CheckLogin(string username, string password)
        {
            try
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
                con.Close();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
