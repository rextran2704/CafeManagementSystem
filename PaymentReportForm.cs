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
    public partial class PaymentReportForm : Form
    {

        List<Payment> paymentList = new List<Payment>();
        PaymentDao paymentDao = new PaymentDao();
        public PaymentReportForm()
        {
            InitializeComponent();
        }


        private void PaymentReportForm_Load(object sender, EventArgs e)
        {
            dtmStartDate.Format = DateTimePickerFormat.Custom;
            dtmStartDate.CustomFormat = "yyyy-MMMM-dd";
            dtmEndDate.Format = DateTimePickerFormat.Custom;
            dtmEndDate.CustomFormat = "yyyy-MMMM-dd";

            paymentList = paymentDao.GetPaymentList();
            foreach (Payment payment in paymentList)
            {
                string[] row = { payment.PaymentID.ToString(), payment.PayDate.ToString(), payment.EmployeeID.ToString(), payment.Detail.ToString(), payment.TotalFee.ToString() };
                ListViewItem item = new ListViewItem(row);
                lsvGeneralReport.Items.Add(item);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lsvGeneralReport.Items.Clear();
            DateTime startDate = dtmStartDate.Value;
            DateTime endDate = dtmEndDate.Value;
            if (startDate >= endDate)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc");
            }
            paymentList = paymentDao.GetPaymentByDate(startDate.ToString(), endDate.ToString());
            foreach (Payment payment in paymentList)
            {
                string[] row = { payment.PaymentID.ToString(), payment.PayDate.ToString(), payment.EmployeeID.ToString(), payment.Detail.ToString(), payment.TotalFee.ToString() };
                ListViewItem item = new ListViewItem(row);
                lsvGeneralReport.Items.Add(item);
            }
        }
    }
}
