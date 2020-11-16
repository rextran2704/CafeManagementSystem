using CafeManagementSystem.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CafeManagementSystem.dao
{
    class CategoryDao
    {
        public List<Category> GetCategoryByName(string categoryName)
        {
            List<Category> categoryList = new List<Category>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT CategoryID,CategoryName FROM Category WHERE CategoryName LIKE N'%" + categoryName + "%'";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                categoryList.Add(new Category(id, name));
            }
            dao.Con.Close();
            return categoryList;
        }
        public List<Category> GetCategoryList()
        {
            List<Category> categoryList = new List<Category>();
            Dao dao = new Dao();
            string sqlStatement = "SELECT CategoryID,CategoryName FROM Category";
            System.Data.SqlClient.SqlDataReader reader = dao.Get(sqlStatement);
            if (reader == null) return null;
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                categoryList.Add(new Category(id,name));
            }
            dao.Con.Close();
            return categoryList;
        }

        public bool RemoveCategory(string categoryName)
        {
            try
            {
                int nRows;
                Dao dao = new Dao();
                string sqlStatement = "DELETE FROM Category WHERE CategoryName=@categoryName";
                using (SqlCommand command = dao.Remove(sqlStatement))
                {
                    command.CommandText = sqlStatement;
                    command.Parameters.AddWithValue("@categoryName", categoryName);
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
        public bool AddCategory(string categoryName)
        {
            int nRows;
            Dao dao = new Dao();
            string sqlStatement = "INSERT INTO Category(CategoryName) VALUES (@categoryName)";
            using (SqlCommand command = dao.Add(sqlStatement))
            {
                command.CommandText = sqlStatement;
                command.Parameters.AddWithValue("@categoryName", categoryName);
                nRows = command.ExecuteNonQuery();
            }
            dao.Con.Close();
            return nRows > 0;
        }

        public bool UpdateCategory(Category category)
        {
            int nRows;
            Dao dao = new Dao();
            string sqlStatement = "UPDATE Category SET Categoryname=@categoryname WHERE CategoryID=@categoryID";
            using (SqlCommand command = dao.Update(sqlStatement))
            {
                command.CommandText = sqlStatement;
                command.Parameters.AddWithValue("@categoryID", category.CategoryID);
                command.Parameters.AddWithValue("@categoryName", category.CategoryName);
                nRows = command.ExecuteNonQuery();
            }
            dao.Con.Close();
            return (nRows > 0);
        }
    }
}
