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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        public void load()
        {
            CategoryDao c = new CategoryDao();
            List<Category> l = c.GetCategoryList();
            lsvCategory.Items.Clear();
            for (int i = 0; i < l.Count; i++)
            {
                ListViewItem lvi = lsvCategory.Items.Add("" + l[i].CategoryID);
                lvi.SubItems.Add(l[i].CategoryName);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvCategory.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose the item to edit");
            }
            else if (txtName.Text=="")
            {
                MessageBox.Show("Please enter category name");
            }
            else
            {
                CategoryDao cd = new CategoryDao();
                Category c = new Category(Int32.Parse(txtId.Text), txtName.Text);
                if (cd.UpdateCategory(c))
                {
                    MessageBox.Show("Update successful.");
                    lsvCategory.SelectedItems[0].SubItems[1].Text = txtName.Text;
                }
                else MessageBox.Show("Update fail.");
            }
        }
        private void lsvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCategory.SelectedItems.Count > 0)
            {
                txtId.Text = lsvCategory.SelectedItems[0].SubItems[0].Text;
                txtName.Text = lsvCategory.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter category name");
            }
            else
            {
                CategoryDao cd = new CategoryDao();
                if (cd.AddCategory(txtName.Text)) MessageBox.Show("Add successful");
                load();
            }

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CategoryDao cd = new CategoryDao();
            if (lsvCategory.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Please choose the item to delete");
            }
            else
            {
                if (cd.RemoveCategory(txtName.Text))
                {
                    MessageBox.Show("Delete Successful");
                    lsvCategory.SelectedItems[0].SubItems[0].Text = "";
                    lsvCategory.SelectedItems[0].SubItems[1].Text = "";
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CategoryDao cd = new CategoryDao();
            if (txtSearch.Text == "") load();
            else
            {
                lsvCategory.Items.Clear();
                List<Category> l = cd.GetCategoryByName(txtSearch.Text);
                for (int i = 0; i < l.Count; i++)
                {
                    ListViewItem lvi = lsvCategory.Items.Add("" + l[i].CategoryID);
                    lvi.SubItems.Add(l[i].CategoryName);
                }
            }
        }
    }
}
