using System;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            //AccountDao dao = new AccountDao();

            //string result = dao.RemoveAccount("testuser").ToString();
            //MessageBox.Show(result);
            //List<Account> accountList = dao.GetAccountList();
            //string s = "";
            //accountList.ForEach(curaccount =>
            //{
            //    s += curaccount.ToString() + "\n";
            //});
            //MessageBox.Show(s);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AccountDao ad = new AccountDao();
            //Account a = new Account("dung ngu", "123", 2, 6);

            //if (ad.CheckLogin("hai", "123") == true) { MessageBox.Show("oke nha"); }
            //else { MessageBox.Show("ko oke nha"); }

        }
    }
}
