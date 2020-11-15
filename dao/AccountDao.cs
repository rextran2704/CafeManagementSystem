using CafeManagementSystem.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CafeManagementSystem.dao
{
    class AccountDao
    {
        public Account GetAccount(string username)
        {
            Account account = null;
            Dao dao = new Dao();
            string sqlStatement = "SELECT AccountID, Password, UserRole, EmployeeID FROM Account WHERE username='" + username + "'";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                string password = reader.GetString(1);
                int role = reader.GetInt32(2);
                int employeeId = reader.GetInt32(3);
                account = new Account(id, username, password, role, employeeId);
            }
            dao.Con.Close();
            return account;
        }
        public List<Account> GetAccountList()
        {
            List<Account> accountList = new List<Account>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT AccountID, Username, Password, UserRole, EmployeeID FROM Account";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader == null) return null;
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string username = reader.GetString(1);
                string password = reader.GetString(2);
                int role = reader.GetInt32(3);
                int employeeId = reader.GetInt32(4);
                accountList.Add(new Account(id, username, password, role, employeeId));
            }
            dao.Con.Close();
            return accountList;
        }

        public bool RemoveAccount(string username)
        {
            try
            {
                int nRows;
                Dao dao = new Dao();
                string sqlStatement = "DELETE FROM Account WHERE Username=@username";
                using (SqlCommand command = dao.Remove(sqlStatement))
                {
                    command.CommandText = sqlStatement;
                    command.Parameters.AddWithValue("@username", username);
                    nRows = command.ExecuteNonQuery();
                }
                dao.Con.Close();
                return nRows > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool AddAccount(Account account)
        {
                int nRows;
                Dao dao = new Dao();
                string sqlStatement = "INSERT INTO Account(Username, Password, Userrole, EmployeeID) VALUES (@username, @password, @userRole, @employeeId)";
                using (SqlCommand command = dao.Add(sqlStatement))
                {
                    command.CommandText = sqlStatement;
                    command.Parameters.AddWithValue("@username", account.Username);
                    command.Parameters.AddWithValue("@password", account.Password);
                    command.Parameters.AddWithValue("@userRole", account.UserRole);
                    command.Parameters.AddWithValue("@employeeId", account.EmployeeId);
                    nRows = command.ExecuteNonQuery();
                }
                dao.Con.Close();
                return nRows > 0;
        }

        public bool UpdateAccount(Account account)
        {
                int nRows;
                Dao dao = new Dao();
                string sqlStatement = "UPDATE Account SET Password=@password, UserRole=@userRole, EmployeeID=@employeeId WHERE Username=@username";
                using (SqlCommand command = dao.Update(sqlStatement))
                {
                    command.CommandText = sqlStatement;
                    command.Parameters.AddWithValue("@username", account.Username);
                    command.Parameters.AddWithValue("@password", account.Password);
                    command.Parameters.AddWithValue("@userRole", account.UserRole);
                    command.Parameters.AddWithValue("@employeeId", account.EmployeeId);
                    nRows = command.ExecuteNonQuery();
                }
                dao.Con.Close();
                return (nRows > 0);
        }

        public bool CheckLogin(string username, string password)
        {
                Dao dao = new Dao();
                string sqlStatement = "SELECT password FROM Account WHERE username='" + username + "'";
                System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
                if (reader.Read())
                {
                    string dbPassword = reader.GetString(0);
                    return (password.Equals(dbPassword));
                }
                dao.Con.Close();
                return false;
        }
    }
}
