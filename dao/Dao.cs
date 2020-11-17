using System;
using System.Data;
using System.Data.SqlClient;

namespace CafeManagementSystem.dao
{
    class Dao
    {
        private SqlConnection con = null;
        private string databaseInfo = "";
        public Dao() {
            databaseInfo = DatabaseInfo.Info();
        }

        public SqlConnection Con { get => con; set => con = value; }

        public SqlDataReader Get(string sqlStatement)
        {
            try
            {
                if (con == null)
                    con = new SqlConnection(databaseInfo);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sqlStatement;
                command.Connection = con;
                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public SqlCommand Select(string sqlStatement)
        {
            try
            {
                if (con == null)
                    con = new SqlConnection(databaseInfo);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string queryString = sqlStatement;
                SqlCommand command = con.CreateCommand();
                return command;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public SqlCommand Remove(string sqlStatement)
        {
            try
            {
                if (con == null)
                    con = new SqlConnection(databaseInfo);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string queryString = sqlStatement;
                SqlCommand command = con.CreateCommand();
                return command;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public SqlCommand Add(string sqlStatement)
        {
            try
            {
                if (con == null)
                    con = new SqlConnection(databaseInfo);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string queryString = sqlStatement;
                SqlCommand command = con.CreateCommand();
                return command;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null ;
            }
        }

        public SqlCommand Update(string sqlStatement)
        {
            try
            {
                if (con == null)
                    con = new SqlConnection(databaseInfo);
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string queryString = sqlStatement;
                SqlCommand command = con.CreateCommand();
                return command;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
