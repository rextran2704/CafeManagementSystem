using System;

namespace CafeManagementSystem.model
{
    class Payment
    {
        private int paymentID;
        private int employeeID;
        private DateTime payDate;
        private double totalFee;
        private string detail;

        public Payment(int employeeID, DateTime payDate, double totalFee, string detail)
        {
            this.employeeID = employeeID;
            this.payDate = payDate;
            this.totalFee = totalFee;
            this.detail = detail;
        }

        public Payment(int paymentID, int employeeID, DateTime payDate, double totalFee, string detail)
        {
            this.paymentID = paymentID;
            this.employeeID = employeeID;
            this.payDate = payDate;
            this.totalFee = totalFee;
            this.detail = detail;
        }

        public int PaymentID { get => paymentID; set => paymentID = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public DateTime PayDate { get => payDate; set => payDate = value; }
        public double TotalFee { get => totalFee; set => totalFee = value; }
        public string Detail { get => detail; set => detail = value; }
    }
}
