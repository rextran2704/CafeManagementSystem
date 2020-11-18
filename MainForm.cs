using CafeManagementSystem.dao;
using CafeManagementSystem.model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeManagementSystem
{

    public partial class MainForm : Form
    {
        private Account User = null;

        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            txtUsername.Select();
            dashboardToolStripMenuItem.Enabled = false;
        }

        private void Login()
        {
            //MessageBox.Show("Login Action");
            AccountDao AcDAO = new AccountDao();
            bool LoginSuccess = AcDAO.CheckLogin(txtUsername.Text, txtPassword.Text);
            if (LoginSuccess) { 
                MessageBox.Show("LoginSuccess");
                User = AcDAO.GetAccountByUsername(txtUsername.Text);
                txtUsername.Text = "";
                txtPassword.Text = "";
                welcomeToolStripMenuItem.Text = "Xin chào " + User.Username;
                // chuyển đến form Order
            }
            else MessageBox.Show("LoginFailed");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }

        void openChildForm(Form orderForm){
            this.mainPanel.Controls.Clear();
            orderForm.TopLevel = false;
            orderForm.AutoScroll = true;
            this.mainPanel.Controls.Add(orderForm);
            orderForm.FormBorderStyle = FormBorderStyle.None;
            orderForm.Dock = DockStyle.Fill;
            orderForm.Show();
        }
        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ChangePassForm());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User = null;
            welcomeToolStripMenuItem.Text = "Xin Chào";
            // Chuyển về form đăng nhập
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new CategoryForm());
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new EmployeeForm());
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductForm());
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new AccountForm());
        }

        private void generalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new GeneralReportForm());
        }

        private void paymentReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new PaymentReportForm());
        }

        private void incomeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new IncomeReportForm());
        }
    }
}
