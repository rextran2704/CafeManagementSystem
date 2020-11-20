using CafeManagementSystem.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CafeManagementSystem.dao
{
    class EmployeeDao
    {
        public Employee GetEmployeeByID(int id)
        {
            Employee employee= null;
            Dao dao = new Dao();
            string sqlStatement = "SELECT EmployeeName, Gender, Position, StartDate, Address, PhoneNumber FROM Employee WHERE EmployeeID='" + id + "'";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader.Read())
            {
                string name = reader.GetString(0);
                bool gender = reader.GetBoolean(1);
                string position = reader.GetString(2);
                DateTime date = reader.GetDateTime(3);
                string address = reader.GetString(4);
                string phone = reader.GetString(5);
                employee = new Employee(id, name, gender, position, date, address, phone);
            }
            dao.Con.Close();
            return employee;
        }

        public List<Employee> SearchEmployeeByName(string name)
        {
            List<Employee> employeeList = new List<Employee>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT EmployeeID, Gender, Position, StartDate, Address, PhoneNumber From Employee WHERE EmployeeName LIKE N'%" + name + "%'";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                bool gender = reader.GetBoolean(1);
                string position = reader.GetString(2);
                DateTime date = reader.GetDateTime(3);
                string address = reader.GetString(4);
                string phone = reader.GetString(5);
                employeeList.Add(new Employee(id, name, gender, position, date, address, phone));
            }
            dao.Con.Close();
            return employeeList;
        }
        public List<Employee> GetEmployeeList()
        {
            List<Employee> employeeList = new List<Employee>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT EmployeeID, EmployeeName, Gender, Position, StartDate, Address, PhoneNumber FROM Employee";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader == null) return null;
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                bool gender = reader.GetBoolean(2);
                string position = reader.GetString(3);
                DateTime date = reader.GetDateTime(4);
                string address = reader.GetString(5);
                string phone = reader.GetString(6);
                employeeList.Add(new Employee(id, name, gender, position, date, address, phone));
            }
            dao.Con.Close();
            return employeeList;
        }

        public bool RemoveEmployeeById(string id)
        {
            try
            {
                int nRows;
                Dao dao = new Dao();
                string sqlStatement = "DELETE FROM Employee WHERE EmployeeID=@id";
                using (SqlCommand command = dao.Remove(sqlStatement))
                {
                    command.CommandText = sqlStatement;
                    command.Parameters.AddWithValue("@id", id);
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
        public bool AddEmployee(Employee employee)
        {
            try
            {
                int nRows;
                Dao dao = new Dao();
                //string sqlStatement = "INSERT INTO Employee(EmployeeName, Gender, Position, StartDate, Address, PhoneNumber) VALUES (@name, @gender, @position, @date, @address, @phone)";
                string sqlStatement = "INSERT INTO Employee(EmployeeName, Gender, Position, StartDate, Address, PhoneNumber) VALUES (@name, @gender, @position,GetDate(), @address, @phone)";
                using (SqlCommand command = dao.Add(sqlStatement))
                {
                    command.CommandText = sqlStatement;
                    command.Parameters.AddWithValue("@name", employee.EmployeeName);
                    command.Parameters.AddWithValue("@gender", employee.Gender);
                    command.Parameters.AddWithValue("@position", employee.Position);
                    //command.Parameters.AddWithValue("@date", employee.StartDate);
                    command.Parameters.AddWithValue("@address", employee.Address);
                    command.Parameters.AddWithValue("@phone", employee.PhoneNumber);
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

        public bool UpdateEmployee(Employee employee)
        {
            try
            {
                int nRows;
                Dao dao = new Dao();
                string sqlStatement = "UPDATE Employee SET EmployeeName=@name, Gender=@gender, Position=@position, StartDate = @date, Address = @address, PhoneNumber = @Phone WHERE EmployeeId=@Id";
                using (SqlCommand command = dao.Update(sqlStatement))
                {
                    command.CommandText = sqlStatement;
                    command.Parameters.AddWithValue("@Id", employee.EmployeeID);
                    command.Parameters.AddWithValue("@name", employee.EmployeeName);
                    command.Parameters.AddWithValue("@gender", employee.Gender);
                    command.Parameters.AddWithValue("@position", employee.Position);
                    command.Parameters.AddWithValue("@date", employee.StartDate);
                    command.Parameters.AddWithValue("@address", employee.Address);
                    command.Parameters.AddWithValue("@phone", employee.PhoneNumber);
                    nRows = command.ExecuteNonQuery();
                }
                dao.Con.Close();
                return (nRows > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
