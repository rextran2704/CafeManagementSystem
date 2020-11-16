using System;

namespace CafeManagementSystem.model
{
    class Employee
    {
        private int employeeID;
        private string employeeName;
        private bool gender;
        private string position;
        private DateTime startDate;
        private string address;
        private string phoneNumber;

        public Employee(string employeeName, bool gender, string position, DateTime startDate, string address, string phoneNumber)
        {
            this.employeeName = employeeName;
            this.gender = gender;
            this.position = position;
            this.startDate = startDate;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }
        public Employee(int employeeID, string employeeName, bool gender, string position, DateTime startDate, string address, string phoneNumber)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.gender = gender;
            this.position = position;
            this.startDate = startDate;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public bool Gender { get => gender; set => gender = value; }
        public string Position { get => position; set => position = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
