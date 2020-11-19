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

            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            dashboardToolStripMenuItem.Enabled = false;
            openChildForm(new loginForm(this));
            ResetUserLogin();

        }

        private void Mi_Click(object sender, EventArgs e)
        {
            new loginForm(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
        public bool Login(string username,string password)
        {
            //MessageBox.Show("Login Action");
            AccountDao AcDAO = new AccountDao();
            bool LoginSuccess = AcDAO.CheckLogin(username, password);
            if (LoginSuccess)
            {
                MessageBox.Show("LoginSuccess");
                User = AcDAO.GetAccountByUsername(username);
                welcomeToolStripMenuItem.Text = "Xin chào " + username;
                // chuyển đến form Order
                this.mainPanel.Controls.Clear();

                ResetUserLogin();
                return true;

            }
            else {
            MessageBox.Show("LoginFailed");
                return false;
            }
        }
         void ResetUserLogin() {
            if (User != null)
            {
                welcomeToolStripMenuItem.DropDownItems.Clear();

                ToolStripMenuItem mi1 = new ToolStripMenuItem("Đổi Mật Khẩu");
                mi1.Click += đổiMậtKhẩuToolStripMenuItem_Click;
                welcomeToolStripMenuItem.DropDownItems.Add(mi1);

                ToolStripMenuItem mi2 = new ToolStripMenuItem("Đăng Xuất");
                mi2.Click += đăngXuấtToolStripMenuItem_Click;
                welcomeToolStripMenuItem.DropDownItems.Add(mi2);
            }
            else {
                welcomeToolStripMenuItem.DropDownItems.Clear();

                ToolStripMenuItem mi = new ToolStripMenuItem("Đăng Nhập");
                mi.Click += Mi_Click;
                welcomeToolStripMenuItem.DropDownItems.Add(mi);

                openChildForm(new loginForm(this));
            }
        }


        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ChangePassForm(User.Username));
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User = null;
            welcomeToolStripMenuItem.Text = "Xin Chào";
            ResetUserLogin();
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

        private void welcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
