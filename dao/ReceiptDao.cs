﻿using CafeManagementSystem.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CafeManagementSystem.dao
{
    class ReceiptDao
    {
        public Receipt GetReceiptByReceiptID(int id)
        {
            Receipt Receipt= null;
            Dao dao = new Dao();
            string sqlStatement = "SELECT EmployeeID, TableNumber, PrintDate, Total, AdditionalFee FROM Receipt WHERE ReceiptID='" + id + "'";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader.Read())
            {
                int emID = reader.GetInt32(0);
                int tablenumber= reader.GetInt32(1);
                DateTime date= reader.GetDateTime(2);
                double total= (double)reader.GetDecimal(3);
                double addFee = (double)reader.GetDecimal(4);
                Receipt = new Receipt(id, emID, tablenumber, date, total, addFee);
            }
            dao.Con.Close();
            return Receipt;
        }

        public List<Receipt> GetReceiptListByDate(string startDate, string endDate)
        {
            List<Receipt> ReceiptList = new List<Receipt>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT ReceiptID, EmployeeID, TableNumber, PrintDate, Total, AdditionalFee FROM Receipt WHERE PrintDate <= " + "'" + endDate + "'" + " AND PrintDate >=" + "'" + startDate + "'";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader == null) return null;
            while (reader.Read())
            {
                int reID = reader.GetInt32(0);
                int emID = reader.GetInt32(1);
                int tablenumber = reader.GetInt32(2);
                DateTime date = reader.GetDateTime(3);
                double total = (double)reader.GetDecimal(4);
                double addFee = (double)reader.GetDecimal(5);
                ReceiptList.Add(new Receipt(reID, emID, tablenumber, date, total, addFee));
            }
            dao.Con.Close();
            return ReceiptList;
        }

        public List<Receipt> GetReceiptList()
        {
            List<Receipt> ReceiptList = new List<Receipt>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT ReceiptID, EmployeeID, TableNumber, PrintDate, Total, AdditionalFee FROM Receipt";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader == null) return null;
            while (reader.Read())
            {
                int reID = reader.GetInt32(0);
                int emID = reader.GetInt32(1);
                int tablenumber = reader.GetInt32(2);
                DateTime date = reader.GetDateTime(3);
                double total = (double)reader.GetDecimal(4);
                double addFee = (double)reader.GetDecimal(5);
                ReceiptList.Add(new Receipt(reID, emID, tablenumber, date, total, addFee));
            }
            dao.Con.Close();
            return ReceiptList;
        }

        public bool RemoveReceiptByID(int id)
        {
            try
            {
                int nRows;
                Dao dao = new Dao();
                string sqlStatement = "DELETE FROM Receipt WHERE ReceiptID=@id";
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
        public int AddReceipt(Receipt Receipt)
        {
            try
            {
                int nRows;
                Dao dao = new Dao();
                string sqlStatement = "INSERT INTO Receipt(EmployeeID, TableNumber, Total, AdditionalFee) output INSERTED.ReceiptID VALUES (@emID, @tablenumber, @total, @addfee)";
                using (SqlCommand command = dao.Add(sqlStatement))
                {
                    command.CommandText = sqlStatement;
                    command.Parameters.AddWithValue("@emID", Receipt.EmployeeID);
                    command.Parameters.AddWithValue("@tablenumber", Receipt.TableNumber);
                    command.Parameters.AddWithValue("@total", Receipt.Total);
                    command.Parameters.AddWithValue("@addfee", Receipt.AdditionalFee);

                    nRows = (int)command.ExecuteScalar();
                }
                dao.Con.Close();
                return nRows;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

        public bool UpdateReceipt(Receipt Receipt)
        {
            try
            {
                int nRows;
                Dao dao = new Dao();
                string sqlStatement = "UPDATE Receipt SET EmployeeID=@emID, TableNumber=@tablenumber, PrintDate= @date, Total= @total, AdditionalFee= @addFee WHERE ReceiptID=@id";
                using (SqlCommand command = dao.Update(sqlStatement))
                {
                    command.CommandText = sqlStatement;
                    command.Parameters.AddWithValue("@id", Receipt.ReceiptID);
                    command.Parameters.AddWithValue("@emID", Receipt.EmployeeID);
                    command.Parameters.AddWithValue("@tablenumber", Receipt.TableNumber);
                    command.Parameters.AddWithValue("@date", Receipt.PrintDate);
                    command.Parameters.AddWithValue("@total", Receipt.Total);
                    command.Parameters.AddWithValue("@addFee", Receipt.AdditionalFee);
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

        public double GetByMonth(string month)
        {
            double all = 0;
            List<Receipt> ReceiptList = new List<Receipt>();
            Dao dao = new Dao();
            try
            {
                string sqlStatement = "SELECT SUM(Total) FROM Receipt where FORMAT(PrintDate,'MM')= '" + month + "'";
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
                string sqlStatement = "SELECT SUM(Total) FROM Receipt where FORMAT(PrintDate,'yyyy')= '" + year + "'";
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
