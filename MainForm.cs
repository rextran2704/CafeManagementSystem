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
        private Form activeForm = null;
        void openChildForm(Form childForm) {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
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
=======
            panelProductSubmenu.Visible = false;
            panelReportSubmenu.Visible = false;
            panelUserSubmenu.Visible = false;

        }
        void toggleSubmenu(Panel submenu) {
            if (submenu.Visible == true)
                submenu.Visible = false;
            else
                submenu.Visible = true;
        }
        private void btnCurrentUser_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelUserSubmenu);
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelProductSubmenu);
        }

        private void btnBaoCAo_Click(object sender, EventArgs e)
        {
            toggleSubmenu(panelReportSubmenu);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new FormTaiKhoan());
>>>>>>> f4cd1fe66cabe61a8ae10b4a5abef44a80395bb4
        }
    }
}
