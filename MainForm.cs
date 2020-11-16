using System;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
          
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
        }
    }
}
