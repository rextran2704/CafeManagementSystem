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
            ReceiptDetailDao rd = new ReceiptDetailDao();
            ReceiptDetail r = new ReceiptDetail(5, 7, 1, 15000);

            rd.AddReceiptDetail(r);
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
