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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }
        private void LoadTable()
        {
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            lsvAccount.Items.Clear();
            AccountDao AcDao = new AccountDao();
            List<Account> ls = AcDao.GetAccountList();
            foreach (Account a in ls)
            {
                ListViewItem item = lsvAccount.Items.Add(a.Id.ToString());
                item.SubItems.Add(a.Username);
                if (a.UserRole == 1) item.SubItems.Add("Nhân Viên");
                else item.SubItems.Add("Quản Lý");
                item.SubItems.Add(a.EmployeeId.ToString());
            }

        }
        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadTable();
            cboRole.Items.AddRange(new string[] { "Nhân Viên", "Quản Lý" });
        }

        private void lsvAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvAccount.SelectedItems.Count > 0)
            {
                txtUsername.Text = lsvAccount.SelectedItems[0].SubItems[1].Text;
                if (lsvAccount.SelectedItems[0].SubItems[2].Text == "Nhân Viên") cboRole.SelectedIndex = 0;
                if (lsvAccount.SelectedItems[0].SubItems[2].Text == "Quản Lý") cboRole.SelectedIndex = 1;
                txtEmployeeId.Text = lsvAccount.SelectedItems[0].SubItems[3].Text;
         

            }
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvAccount.SelectedItems.Count > 0)
            {
                
                AccountDao acDao = new AccountDao();
                if (acDao.RemoveAccountByUsername(lsvAccount.SelectedItems[0].SubItems[1].Text))
                {
                    LoadTable();
                    txtEmployeeId.Text = "";
                    txtUsername.Text = "";
                } else 
                MessageBox.Show("Xóa thất bại");

            }
            else
                MessageBox.Show("Bạn chưa chọn dòng để xóa");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvAccount.SelectedItems.Count > 0)
            {
                AccountDao acDao = new AccountDao();
                Account a = acDao.GetAccountByUsername(lsvAccount.SelectedItems[0].SubItems[1].Text);
                a.Username = txtUsername.Text;
                a.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
                a.UserRole = cboRole.SelectedIndex+1;
                lsvAccount.SelectedItems[0].SubItems[1].Text = txtUsername.Text;
                lsvAccount.SelectedItems[0].SubItems[3].Text = txtEmployeeId.Text;
                lsvAccount.SelectedItems[0].SubItems[2].Text = cboRole.SelectedItem.ToString();
                acDao.UpdateAccount(a);
                txtEmployeeId.Text = "";
                txtUsername.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AccountDao acDao = new AccountDao();
            if (txtEmployeeId.Text.Length > 0 && txtUsername.Text.Length > 0)
            {
                acDao.AddAccount(new Account(txtUsername.Text, txtUsername.Text, cboRole.SelectedIndex + 1, Convert.ToInt32(txtEmployeeId.Text)));
                LoadTable();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
            {

                lsvAccount.Items.Clear();
                AccountDao AcDao = new AccountDao();
                List<Account> ls = AcDao.SearchAccountByName(txtSearch.Text);
                foreach (Account a in ls)
                {
                    ListViewItem item = lsvAccount.Items.Add(a.Id.ToString());
                    item.SubItems.Add(a.Username);
                    if (a.UserRole == 1) item.SubItems.Add("Nhân Viên");
                    else item.SubItems.Add("Quản Lý");
                    item.SubItems.Add(a.EmployeeId.ToString());
                }
            }
        }
    }
}
