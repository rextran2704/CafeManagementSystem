using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem.dao
{
    class DatabaseInfo
    {
        private static string dbInfo;

        public static string DbInfo()
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "database-info.txt"); 
            dbInfo = System.IO.File.ReadAllText(filePath);
            return dbInfo;
        }
    }
}
