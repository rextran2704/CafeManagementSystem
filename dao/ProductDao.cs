using CafeManagementSystem.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CafeManagementSystem.dao
{
    class ProductDao
    {
        public Product GetProductByName(string Name)
        {
            Product Product = null;
            Dao dao = new Dao();
            string sqlStatement = "SELECT ProductID, Price, Quantity, Image, Description, CategoryID FROM Product WHERE ProductName='" + Name + "'";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                double price = (double)reader.GetDecimal(1);
                int quantity = reader.GetInt32(2);
                string image = reader.GetString(3);
                string description = reader.GetString(4);
                int categoryID = reader.GetInt32(5);
                Product = new Product(id, Name, price, quantity, image, description, categoryID);
            }
            dao.Con.Close();
            return Product;
        }
        public string GetProductNameByID(int productId)
        {
            string name = "";
            Dao dao = new Dao();
            string sqlStatement = "SELECT ProductName FROM Product WHERE ProductID='" + productId + "'";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader.Read())
            {
                name = reader.GetString(0);
            }
            dao.Con.Close();
            return name;
        }
        public List<Product> GetProductList()
        {
            List<Product> ProductList = new List<Product>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT ProductID, ProductName, Price, Quantity, Image, Description, CategoryID FROM Product";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader == null) return null;
            while (reader.Read())
            {
                try
                {

                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    double price = (double)reader.GetDecimal(2);
                    int quantity = reader.GetInt32(3);
                    string image = reader.GetString(4);
                    string description = reader.IsDBNull(5) ? null : reader.GetString(5);
                    int categoryID = reader.GetInt32(6);

                    ProductList.Add(new Product(id, name, price, quantity, image, description, categoryID));
                }
                catch (Exception)
                {
                }

            }
            dao.Con.Close();
            return ProductList;
        }
        public List<Product> SearchProductListByName(string searchvalue)
        {
            List<Product> ProductList = new List<Product>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT ProductID, ProductName, Price, Quantity, Image, Description, CategoryID FROM Product where ProductName Like N'%" + searchvalue + "%'";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader == null) return null;
            while (reader.Read())
            {
                try
                {

                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    double price = (double)reader.GetDecimal(2);
                    int quantity = reader.GetInt32(3);
                    string image = reader.GetString(4);
                    string description = "sss";
                    int categoryID = reader.GetInt32(6);

                    ProductList.Add(new Product(id, name, price, quantity, image, description, categoryID));
                }
                catch (Exception)
                {
                }

            }
            dao.Con.Close();
            return ProductList;
        }
        public bool RemoveProductByName(string name)
        {
            try
            {
                int nRows;
                Dao dao = new Dao();
                string sqlStatement = "DELETE FROM Product WHERE ProductName=@name";
                using (SqlCommand command = dao.Remove(sqlStatement))
                {
                    command.CommandText = sqlStatement;
                    command.Parameters.AddWithValue("@name", name);
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
        public bool AddProduct(Product Product)
        {
            try
            {
                int nRows;
                Dao dao = new Dao();
                string sqlStatement = "INSERT INTO Product(ProductName, Price, Quantity, Image, Description, CategoryID) VALUES (@name, @price, @quantity, @image, @description, @categoryID)";
                using (SqlCommand command = dao.Add(sqlStatement))
                {
                    command.CommandText = sqlStatement;
                    command.Parameters.AddWithValue("@name", Product.ProductName);
                    command.Parameters.AddWithValue("@price", Product.Price);
                    command.Parameters.AddWithValue("@quantity", Product.Quantity);
                    command.Parameters.AddWithValue("@image", Product.Image);
                    command.Parameters.AddWithValue("@description", Product.Description);
                    command.Parameters.AddWithValue("@categoryID", Product.CategoryID);
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

        public bool UpdateProduct(Product Product)
        {
            try
            {
                int nRows;
                Dao dao = new Dao();
                string sqlStatement = "UPDATE Product SET Price=@price, Quantity=@quantity, Image= @image, Description= @description, CategoryID= @categoryID WHERE ProductName=@name";
                using (SqlCommand command = dao.Update(sqlStatement))
                {
                    command.CommandText = sqlStatement;
                    command.Parameters.AddWithValue("@name", Product.ProductName);
                    command.Parameters.AddWithValue("@price", Product.Price);
                    command.Parameters.AddWithValue("@quantity", Product.Quantity);
                    command.Parameters.AddWithValue("@image", Product.Image);
                    command.Parameters.AddWithValue("@description", Product.Description);
                    command.Parameters.AddWithValue("@categoryID", Product.CategoryID);
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
