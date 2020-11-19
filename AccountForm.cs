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

        private void AccountForm_Load(object sender, EventArgs e)
        {
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
            cboRole.Items.AddRange(new string[] { "Nhân  Viên", "Quản Lý" });
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
                    lsvAccount.Items.Remove(lsvAccount.SelectedItems[0]);
                }
                txtEmployeeId.Text = "";
                txtUsername.Text = "";
            }
            else
                MessageBox.Show("Bạn chưa chọn dòng để xóa");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvAccount.SelectedItems.Count > 0)
            {
                lsvAccount.SelectedItems[0].SubItems[1].Text = txtUsername.Text;
                lsvAccount.SelectedItems[0].SubItems[3].Text = txtEmployeeId.Text;
                lsvAccount.SelectedItems[0].SubItems[2].Text = ""+cboRole.SelectedIndex;
                AccountDao acDao = new AccountDao();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
        }
    }
}
