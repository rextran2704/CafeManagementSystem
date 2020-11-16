using CafeManagementSystem.dao;
using CafeManagementSystem.model;
using System;
using System.Collections.Generic;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountDao ad = new AccountDao();

            ad.ChangePasswordAccount("hai","123");
        }
    }
}
