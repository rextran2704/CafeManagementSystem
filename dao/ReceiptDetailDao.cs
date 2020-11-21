using CafeManagementSystem.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CafeManagementSystem.dao
{
    class ReceiptDetailDao
    {
        public List<ReceiptDetail> GetReceiptDetailByReceiptId(int receiptId)
        {
            List<ReceiptDetail> receiptDetailList = new List<ReceiptDetail>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT ProductID, Quantity, Total FROM ReceiptDetail WHERE ReceiptID='" + receiptId + "'";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            while (reader.Read())
            {
                int productID = reader.GetInt32(0);
                int quantity = reader.GetInt32(1);
                decimal total = reader.GetDecimal(2);
                receiptDetailList.Add(new ReceiptDetail(productID, quantity, Decimal.ToDouble(total)));
            }
            dao.Con.Close();
            return receiptDetailList;
        }
        public List<ReceiptDetail> GetReceiptDetailList()
        {
            List<ReceiptDetail> receiptDetailList = new List<ReceiptDetail>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT ReceiptID, ProductID, Quantity, Total FROM ReceiptDetail";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader == null) return null;
            while (reader.Read())
            {
                int rID = reader.GetInt32(0);
                int pID = reader.GetInt32(1);
                int q = reader.GetInt32(2);
                decimal t = reader.GetDecimal(3);
                receiptDetailList.Add(new ReceiptDetail(rID, pID, q, Decimal.ToDouble(t)));
            }
            dao.Con.Close();
            return receiptDetailList;
        }

        public bool AddReceiptDetail(ReceiptDetail receiptDetail)
        {
            int nRows;
            Dao dao = new Dao();
            string sqlStatement = "INSERT INTO ReceiptDetail(ReceiptID,ProductID, Quantity, Total) VALUES (@receiptID,@productID, @quantity, @total)";
            using (SqlCommand command = dao.Add(sqlStatement))
            {
                command.CommandText = sqlStatement;
                command.Parameters.AddWithValue("@receiptID", receiptDetail.ReceiptID);
                command.Parameters.AddWithValue("@productID", receiptDetail.ProductID);
                command.Parameters.AddWithValue("@quantity", receiptDetail.Quantity);
                command.Parameters.AddWithValue("@total", receiptDetail.Total);
                nRows = command.ExecuteNonQuery();
            }
            dao.Con.Close();
            return nRows > 0;
        }

        //public bool UpdateReceiptDetail(ReceiptDetail receiptDetail)
        //{
        //    int nRows;
        //    Dao dao = new Dao();
        //    string sqlStatement = "UPDATE ReceiptDetail SET ProductID=@productID, Quantity=@quantity, Total=@total WHERE ReceiptID=@receiptID";
        //    using (SqlCommand command = dao.Update(sqlStatement))
        //    {
        //        command.CommandText = sqlStatement;
        //        command.Parameters.AddWithValue("@productID", receiptDetail.ProductID);
        //        command.Parameters.AddWithValue("@quantity", receiptDetail.Quantity);
        //        command.Parameters.AddWithValue("@total", receiptDetail.Total);
        //        command.Parameters.AddWithValue("@receiptID", receiptDetail.ReceiptID);
        //        nRows = command.ExecuteNonQuery();
        //    }
        //    dao.Con.Close();
        //    return (nRows > 0);
        //}
    }
}
