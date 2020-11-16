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
            //ReceiptDao dao = new ReceiptDao();
            //Receipt a = new Receipt(3, 4, 1, DateTime.Today, 123, 100000);

            //Receipt b = dao.GetReceiptByName("123");
            //List<Receipt> l = dao.GetReceiptList();
            //bool b = dao.RemoveReceiptByName("123");

            //MessageBox.Show("as " + dao.UpdateReceipt(a));






            //List<Account> accountList = dao.GetAccountList();
            //string s = "";
            //accountList.ForEach(curaccount =>
            //{
            //    s += curaccount.ToString() + "\n";
            //});
            //MessageBox.Show(s);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AccountDao ad = new AccountDao();
            //Account a = new Account("dung ngu", "123", 2, 6);

            //if (ad.CheckLogin("hai", "123") == true) { MessageBox.Show("oke nha"); }
            //else { MessageBox.Show("ko oke nha"); }

        }
    }
}
