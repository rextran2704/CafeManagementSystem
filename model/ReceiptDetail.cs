using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.model
{
    class ReceiptDetail
    {
        private int receiptID;
        private int productID;
        private int quantity;
        private double total;

        public ReceiptDetail(int receiptID, int productID, int quantity, double total)
        {
            this.receiptID = receiptID;
            this.productID = productID;
            this.quantity = quantity;
            this.total = total;
        }

        public int ReceiptID { get => receiptID; set => receiptID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Total { get => total; set => total = value; }
    }
}
