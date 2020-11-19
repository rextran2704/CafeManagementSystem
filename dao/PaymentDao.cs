using CafeManagementSystem.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CafeManagementSystem.dao
{
    class PaymentDao
    {
        public Payment GetPaymentByEmpID(int employeeID)
        {
            Payment payment = null;
            Dao dao = new Dao();
            string sqlStatement = "SELECT PaymentID, EmployeeID, PayDate, TotalFee, Detail FROM Payment WHERE EmployeeID='" + employeeID + "'";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader.Read())
            {
                int pID = reader.GetInt32(0);
                int eID = reader.GetInt32(1);
                DateTime pD = reader.GetDateTime(2);
                decimal tF = reader.GetDecimal(3);
                string de = reader.GetString(4);
                payment = new Payment(pID, eID, pD, Decimal.ToDouble(tF), de);
            }
            dao.Con.Close();
            return payment;
        }

        public List<Payment> GetPaymentByDate(string startDate, string endDate)
        {
            List<Payment> paymentList = new List<Payment>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT PaymentID, EmployeeID, PayDate, TotalFee, Detail FROM Payment WHERE PayDate < " + "'" + endDate + "'" + " and PayDate >= " + "'" + startDate + "'";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader == null) return null;
            while (reader.Read())
            {
                int pID = reader.GetInt32(0);
                int eID = reader.GetInt32(1);
                DateTime pD = reader.GetDateTime(2);
                decimal tF = reader.GetDecimal(3);
                string de = reader.GetString(4);
                paymentList.Add(new Payment(pID, eID, pD, Decimal.ToDouble(tF), de));
            }
            dao.Con.Close();
            return paymentList;
        }
        public List<Payment> GetPaymentList()
        {
            List<Payment> paymentList = new List<Payment>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT PaymentID, EmployeeID, PayDate, TotalFee, Detail FROM Payment";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader == null) return null;
            while (reader.Read())
            {
                int pID = reader.GetInt32(0);
                int eID = reader.GetInt32(1);
                DateTime pD = reader.GetDateTime(2);
                decimal tF = reader.GetDecimal(3);
                string de = reader.GetString(4);
                paymentList.Add(new Payment(pID, eID, pD, Decimal.ToDouble(tF), de));
            }
            dao.Con.Close();
            return paymentList;
        }

        public bool AddPayment(Payment payment)
        {
            int nRows;
            Dao dao = new Dao();
            string sqlStatement = "INSERT into Payment( EmployeeID, PayDate, TotalFee, Detail) VALUES (@employeeID, @payDate, @totalFee, @detail)";
            using (SqlCommand command = dao.Add(sqlStatement))
            {
                command.CommandText = sqlStatement;
                command.Parameters.AddWithValue("@employeeID", payment.EmployeeID);
                command.Parameters.AddWithValue("@payDate", payment.PayDate);
                command.Parameters.AddWithValue("@totalFee", payment.TotalFee);
                command.Parameters.AddWithValue("@detail", payment.Detail);
                nRows = command.ExecuteNonQuery();
            }
            dao.Con.Close();
            return nRows > 0;
        }

        public bool UpdatePayment(Payment payment)
        {
            int nRows;
            Dao dao = new Dao();
            string sqlStatement = "UPDATE Payment SET EmployeeID=@employeeID, PayDate=@payDate, TotalFee=@totalFee ,Detail=@detail WHERE PaymentID=@paymentID";
            using (SqlCommand command = dao.Update(sqlStatement))
            {
                command.CommandText = sqlStatement;
                command.Parameters.AddWithValue("@employeeID", payment.EmployeeID);
                command.Parameters.AddWithValue("@payDate", payment.PayDate);
                command.Parameters.AddWithValue("@totalFee", payment.TotalFee);
                command.Parameters.AddWithValue("@detail", payment.Detail);
                command.Parameters.AddWithValue("@paymentID", payment.PaymentID);
                nRows = command.ExecuteNonQuery();
            }
            dao.Con.Close();
            return (nRows > 0);
        }

        public double GetByMonth(string month)
        {
            double all = 0;
            List<Payment> ReceiptList = new List<Payment>();
            Dao dao = new Dao();
            try
            {
                string sqlStatement = "SELECT SUM(TotalFee) FROM Payment where FORMAT(PayDate,'MM')= '" + month + "'";
                System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
                if (reader.Read())
                {
                    all = (double)reader.GetDecimal(0);
                }
            }
            catch (Exception e)
            {
                return 0;
            }

            dao.Con.Close();
            return all;
        }

        public double GetByYear(int year)
        {
            double all = 0;
            List<Receipt> ReceiptList = new List<Receipt>();
            Dao dao = new Dao();
            try
            {
                string sqlStatement = "SELECT SUM(TotalFee) FROM Payment where FORMAT(PayDate,'yyyy')= '" + year + "'";
                System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
                if (reader.Read())
                {
                    all = (double)reader.GetDecimal(0);
                }
            }
            catch (Exception e)
            {
                return 0;
            }

            dao.Con.Close();
            return all;
        }
    }
}
