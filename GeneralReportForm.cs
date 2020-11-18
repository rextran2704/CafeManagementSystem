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
            var curDate = l[0].PrintDate.Date;
            double TongNgay = 0, TongThang = 0, TongNam = 0;
            for (int i = 0; i < l.Count-1; i++)
            {
                if (l[i].PrintDate.Date == l[i + 1].PrintDate.Date) ;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 0: ; break;
                case 1: break;
                case 2: break;
            }
        }
    }
}
