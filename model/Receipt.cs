using System;

namespace CafeManagementSystem.model
{
    class Receipt
    {
        private int receiptID;
        private int employeeID;
        private int tableNumber;
        private DateTime printDate;
        private double total;
        private double additionalFee;

        public Receipt(int employeeID, int tableNumber, DateTime printDate, double total, double additionalFee)
        {
            this.employeeID = employeeID;
            this.tableNumber = tableNumber;
            this.printDate = printDate;
            this.total = total;
            this.additionalFee = additionalFee;
        }
        public Receipt(int receiptID, int employeeID, int tableNumber, DateTime printDate, double total, double additionalFee)
        {
            this.receiptID = receiptID;
            this.employeeID = employeeID;
            this.tableNumber = tableNumber;
            this.printDate = printDate;
            this.total = total;
            this.additionalFee = additionalFee;
        }

        public int ReceiptID { get => receiptID; set => receiptID = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public int TableNumber { get => tableNumber; set => tableNumber = value; }
        public DateTime PrintDate { get => printDate; set => printDate = value; }
        public double Total { get => total; set => total = value; }
        public double AdditionalFee { get => additionalFee; set => additionalFee = value; }
    }
}
