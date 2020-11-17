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
    public partial class OrderForm : Form
    {
        Dictionary<Product, int> productsMap = new Dictionary<Product, int>();
        List<Product> productList = new List<Product>();

        public OrderForm()
        {
            InitializeComponent();
        }
        Button customButton(string image, string text) {
            Button button3 = new Button();
            button3.Image = Image.FromFile("../../images/icon-account.png");
            button3.Location = new System.Drawing.Point(2, 171);
            button3.Margin = new System.Windows.Forms.Padding(2);
            //button3.Name = "button3";
            button3.Size = new System.Drawing.Size(162, 165);
            button3.Text = text;
            button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            button3.Click += EventAddVaoBtn;
            return button3;
        }
        void EventAddVaoBtn(object sender, EventArgs e)
        {
            Button button = sender as Button;

            Product prodl = productList.Find(x => x.ProductName == button.Text);

            if (productsMap.ContainsKey(prodl))
            {
                //Product prod = productsMap.Keys.First(x => x.ProductName == button.Text);
                productsMap[prodl]++;
            }
            else
                productsMap.Add(prodl, 1);

            int quantity = productsMap[prodl];
            double price = quantity * prodl.Price;

            string[] row = { button.Text, quantity.ToString(), price.ToString() };
            ListViewItem listViewItem = new ListViewItem(row);
            var item = lsvOrder.FindItemWithText(listViewItem.Text);

            if (item != null)
            {
                item.SubItems[1].Text = quantity.ToString();
                item.SubItems[2].Text = price.ToString();
            }
            else
                lsvOrder.Items.Add(listViewItem);
        }
        void loadProductsToSearch(List<Product> products) {

            monAnLayoutPanel.Controls.Clear();
            if (products.Count<= 0) return;
            foreach (Product item in products)
            {
                monAnLayoutPanel.Controls.Add(customButton("", item.ProductName));
            }
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            productList = new ProductDao().GetProductList();
            loadProductsToSearch(productList);
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Product> prods = new ProductDao().SearchProductListByName(txtSearch.Text);
            loadProductsToSearch(prods);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvOrder.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvOrder.SelectedItems[0];

                foreach (var myitem in productsMap.Keys)
                {
                    if (myitem.ProductName == item.Text)
                    {
                        productsMap.Remove(myitem);
                        item.Remove();
                        return;
                    }
                }
                //rest of your logic
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            btnDatBan.Enabled=true;
            double sum = 0;
            foreach (var myitem in productsMap)
            {
                sum += myitem.Key.Price * myitem.Value;
            }
            txtTotal.Text = sum.ToString();
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTotal.Text)&& string.IsNullOrEmpty(txtTableNumber.Text)) {
                MessageBox.Show("Vui lòng điền số bàn và chọn sản phẩm và nhấn tính tiền!");
                return;
            }
            double total = double.Parse(txtTotal.Text);

            if (total<=0) {
                MessageBox.Show("Vui lòng chọn sản phẩm và nhấn tính tiền");
                return;
            }
            int index = new ReceiptDao().AddReceipt(new Receipt(1, int.Parse(txtTableNumber.Text), new DateTime().Date, total, 0));
            if (index > 0)
            {
                foreach (var myitem in productsMap)
                {
                    new ReceiptDetailDao().AddReceiptDetail(new ReceiptDetail(index,myitem.Key.ProductID,myitem.Value, total));
                }

                MessageBox.Show("Đặt Bàn Thành Công");
            }
            else
                MessageBox.Show("thất bại rồi");
        }
    }
}
