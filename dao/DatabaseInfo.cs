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
        private static string info;

        public static string Info()
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "database-info.txt"); 
            info = System.IO.File.ReadAllText(filePath);
            return info;
        }
    }
}
