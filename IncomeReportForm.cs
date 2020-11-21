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
    public partial class IncomeReportForm : Form
    {
        public IncomeReportForm()
        {
            InitializeComponent();
        }

        private void IncomeReportForm_Load(object sender, EventArgs e)
        {
            dtmStartDate.Format = DateTimePickerFormat.Custom;
            dtmStartDate.CustomFormat = "yyyy-MMMM-dd";
            dtmEndDate.Format = DateTimePickerFormat.Custom;
            dtmEndDate.CustomFormat = "yyyy-MMMM-dd";
            LoadReceipsToForm();
        }

        private void LoadReceipsToForm()
        {
            ReceiptDao dao = new ReceiptDao();
            List<Receipt> receipts = dao.GetReceiptList();
            receipts.ForEach(receipt =>
            {
                string[] row = { receipt.ReceiptID.ToString(), receipt.PrintDate.ToString(), receipt.EmployeeID.ToString(), receipt.Total.ToString() };
                ListViewItem item = new ListViewItem(row);
                lsvReceipt.Items.Add(item);
            });
        }

        private void lsvReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvReceipt.SelectedItems.Count > 0)
            {
                lsvReceiptDetail.Items.Clear();
                ReceiptDetailDao dao = new ReceiptDetailDao();
                int receiptId = Int32.Parse(lsvReceipt.SelectedItems[0].SubItems[0].Text);
                List<ReceiptDetail> receiptDetails = dao.GetReceiptDetailByReceiptId(receiptId);
                receiptDetails.ForEach(receiptDetail =>
                {
                    ProductDao productDao = new ProductDao();
                    string productName = productDao.GetProductNameByID(receiptDetail.ProductID);
                    string[] row = { productName, receiptDetail.Quantity.ToString(), receiptDetail.Total.ToString() };
                    ListViewItem item = new ListViewItem(row);
                    lsvReceiptDetail.Items.Add(item);
                });
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lsvReceipt.Items.Clear();
            lsvReceiptDetail.Items.Clear();
            DateTime startDate = dtmStartDate.Value;
            DateTime endDate = dtmEndDate.Value;
            if (startDate >= endDate)
            {
                MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc");
            }
            ReceiptDao dao = new ReceiptDao();

            List<Receipt> receipts = dao.GetReceiptListByDate(startDate.ToString(), endDate.ToString());
            if (receipts.Count > 0)
            {
                receipts.ForEach(receipt =>
                {
                    string[] row = { receipt.ReceiptID.ToString(), receipt.PrintDate.ToString(), receipt.EmployeeID.ToString(), receipt.Total.ToString() };
                    ListViewItem item = new ListViewItem(row);
                    lsvReceipt.Items.Add(item);
                });
            }
        }
    }
}
