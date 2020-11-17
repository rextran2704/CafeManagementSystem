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
            //ReceiptDetailDao rd = new ReceiptDetailDao();
            //ReceiptDetail r = new ReceiptDetail(5, 7, 1, 20000);

            //rd.AddReceiptDetail(r);
            //List<ReceiptDetail> rdList = rd.GetReceiptDetailList();
            //MessageBox.Show(rdList.Count.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<Product, int> productsMap = new Dictionary<Product, int>();
            List<Product> products = new ProductDao().SearchProductListByName("b");
            MessageBox.Show(products[0].ProductName);

            foreach (Product item in products)
            {
                productsMap.Add(item, 0);
            }
        }
    }
}
