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
    public partial class loginForm : Form
    {
        MainForm form=null;

        public loginForm( )
        {
            InitializeComponent();
        }
        internal loginForm(MainForm form)
        {
            InitializeComponent();
            txtUsername.Select();
            this.form = form;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text)) {
                label3.Text = "Vui Long Nhap Day Du Thong tin";
                return;
            }
            if (form.Login(txtUsername.Text, txtPassword.Text))
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}
