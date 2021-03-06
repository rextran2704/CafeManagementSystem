﻿
namespace CafeManagementSystem.model
{
    class Account
    {
        private int id;
        private string username;
        private string password;
        private int userRole;
        private int employeeId;

        public Account()
        {
        }

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Account(string username, string password, int userRole, int employeeId)
        {
            this.username = username;
            this.password = password;
            this.userRole = userRole;
            this.employeeId = employeeId;
        }
        public Account(int id, string username, string password, int userRole, int employeeId)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.userRole = userRole;
            this.employeeId = employeeId;
        }


        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int UserRole { get => userRole; set => userRole = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }

        public override string ToString()
        {
            return id + " " + username + " " + password + " " + userRole + " " + employeeId;
        }
    }
}
