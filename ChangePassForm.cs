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
    public partial class ChangePassForm : Form
    {
        public ChangePassForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0&& textBox4.Text.Length > 0)
            {
                AccountDao account = new AccountDao();
                if (account.CheckLogin(textBox1.Text, textBox2.Text))
                {
                    bool Success = account.ChangePasswordAccount(textBox1.Text, textBox3.Text);
                    if (Success)
                    {
                        MessageBox.Show("Change Password Successful !");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        // Chuyển về form đăng nhập ???
                    }
                    else
                    {
                        MessageBox.Show("Sai ở đâu đó. Cái này không nên hiện ra !");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                    }
                }
                    else
                    {
                        MessageBox.Show("Change Password Failed !");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                    }
                
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text != textBox3.Text)
                {
                    textBox4.Text = "";
                }
            }
            catch (Exception) { }
            }
    }
}
