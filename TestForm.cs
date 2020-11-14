using CafeManagementSystem.dao;
using CafeManagementSystem.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            AccountDao dao = new AccountDao();
            
            string result = dao.RemoveAccount("testuser").ToString();
            MessageBox.Show(result);
            List<Account> accountList = dao.GetAccountList();
            string s = "";
            accountList.ForEach(curaccount =>
            {
                s += curaccount.ToString() + "\n";
            });
            MessageBox.Show(s);
            
        }
    }
}
