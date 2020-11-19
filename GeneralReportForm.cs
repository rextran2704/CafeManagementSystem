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
    public partial class GeneralReportForm : Form
    {
        public GeneralReportForm()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReceiptDao r = new ReceiptDao();
            var l = r.GetReceiptList();
            var beginDate = l[0].PrintDate.Date;
            var endDate = DateTime.Now.Date;
            do
            {
                beginDate.AddDays(1);
                ListViewItem lvi = lsvGeneralReport.Items.Add("" + endDate);
            }
            while (beginDate < endDate);
                double TongNgay = 0, TongThang = 0, TongNam = 0;
            
            switch (comboBox1.SelectedIndex)
            {
                case 0: ; break;
                case 1: break;
                case 2: break;
            }
        }
    }
}
