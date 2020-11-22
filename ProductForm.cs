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
        Dictionary<int, int> CategoryMap = new Dictionary<int, int>();
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
            cboCategory.SelectedIndex = CategoryMap[prodl.CategoryID];

        }
        void loadProductsToSearch(List<Product> products) {

            monAnLayoutPanel.Controls.Clear();
            if (products.Count <= 0) return;
            foreach (Product item in products)
            {
                monAnLayoutPanel.Controls.Add(customButton("", item.ProductName));

            }
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            productList = new ProductDao().GetProductList();
            loadProductsToSearch(productList);
            List<Category> ls = new CategoryDao().GetCategoryList();
            for (int i = 0; i < ls.Count; i++)
            {
                cboCategory.Items.Add(ls[i].CategoryName);
                CategoryMap.Add(ls[i].CategoryID, i);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Product> prods = new ProductDao().SearchProductListByName(txtSearch.Text);
            loadProductsToSearch(prods);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                try
                {
                    if (new ProductDao().RemoveProductByName(txtName.Text))
                    {
                        productList = new ProductDao().GetProductList();
                        loadProductsToSearch(productList);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message);
                }
            }
            txtName.Text = "";
            txtPrice.Text = "";
            txtImage.Text = "";
            txtQuantity.Text = "";
            txtDescription.Text = "";
        }

        

        private void monAnLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private int GetKeyByValueFromDictionary(int value) {
            foreach (KeyValuePair<int, int> p in CategoryMap)
            {
                if (p.Value == value) return p.Key;
            }
            return -1;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 && txtPrice.Text.Length > 0 && txtQuantity.Text.Length > 0)
            {

                try
                {
                    if (new ProductDao().UpdateProduct(new Product(txtName.Text, Double.Parse(txtPrice.Text), Convert.ToInt32(txtQuantity.Text), txtImage.Text, txtDescription.Text, GetKeyByValueFromDictionary(cboCategory.SelectedIndex))))
                    {
                        productList = new ProductDao().GetProductList();
                        loadProductsToSearch(productList);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message);
                }

            }
            txtName.Text = "";
            txtPrice.Text = "";
            txtImage.Text = "";
            txtQuantity.Text = "";
            txtDescription.Text = "";
            loadProductsToSearch(new ProductDao().GetProductList());

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 && txtPrice.Text.Length > 0 && txtQuantity.Text.Length > 0)
            {

                try
                {
                    if (new ProductDao().AddProduct(new Product(txtName.Text, Double.Parse(txtPrice.Text), Convert.ToInt32(txtQuantity.Text), txtImage.Text, txtDescription.Text, GetKeyByValueFromDictionary(cboCategory.SelectedIndex))))
                    {
                        productList = new ProductDao().GetProductList();
                        loadProductsToSearch(productList);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message);
                }
                txtName.Text = "";
                txtPrice.Text = "";
                txtImage.Text = "";
                txtQuantity.Text = "";
                txtDescription.Text = "";
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
