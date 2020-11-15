using System;
using System.IO;

namespace CafeManagementSystem.dao
{
    class DatabaseInfo
    {
        private static string info;

        public static string Info()
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "database-info.txt"); 
            info = System.IO.File.ReadAllText(filePath);
            return info;
        }
    }
}
