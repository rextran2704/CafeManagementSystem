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
    public partial class ProductForm : Form
    {
        Dictionary<Product, int> productsMap = new Dictionary<Product, int>();
        List<Product> productList = new List<Product>();

        public ProductForm()
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
            txtName.Text = prodl.ProductName;
            txtPrice.Text = prodl.Price.ToString();
            txtQuantity.Text = prodl.Quantity.ToString();
            txtImage.Text = prodl.Image;
            txtDescription.Text = prodl.Description;

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

      
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Product> prods = new ProductDao().SearchProductListByName(txtSearch.Text);
            loadProductsToSearch(prods);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
 
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {

          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
