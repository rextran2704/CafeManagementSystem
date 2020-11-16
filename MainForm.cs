using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class MainForm : Form
    {
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
            MessageBox.Show("Login Action");
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

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            Form orderForm = new OrderForm();
            orderForm.TopLevel = false;
            orderForm.AutoScroll = true;
            this.mainPanel.Controls.Add(orderForm);
            orderForm.FormBorderStyle = FormBorderStyle.None;
            orderForm.Dock = DockStyle.Fill;
            orderForm.Show();
        }
    }
}
