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
            byDay();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: byDay(); break;
                case 1: byMonth(); break;
                case 2: byYear(); break;
            }
        }

        public void byDay()
        {

            lsvGeneralReport.Items.Clear();
            //in
            ReceiptDao r = new ReceiptDao();
            var incomes = r.GetReceiptList();
            IDictionary<DateTime, double> list = new Dictionary<DateTime, double>();
            list.Add(incomes[0].PrintDate.Date, incomes[0].Total + incomes[0].AdditionalFee);
            for (int i = 1; i < incomes.Count; i++)
            {
                if (!list.ContainsKey(incomes[i].PrintDate.Date)) list.Add(incomes[i].PrintDate.Date, incomes[i].Total + incomes[i].AdditionalFee);
                else
                {
                    list[incomes[i].PrintDate.Date] += incomes[i].Total + incomes[i].AdditionalFee;
                }
            }

            //out
            PaymentDao p = new PaymentDao();
            var outcomes = p.GetPaymentList();
            IDictionary<DateTime, double> list1 = new Dictionary<DateTime, double>();
            list1.Add(outcomes[0].PayDate.Date, outcomes[0].TotalFee);
            for (int i = 1; i < outcomes.Count; i++)
            {
                if (!list1.ContainsKey(outcomes[i].PayDate.Date)) list1.Add(outcomes[i].PayDate.Date, outcomes[i].TotalFee);
                else
                {
                    list1[outcomes[i].PayDate.Date] += outcomes[i].TotalFee;
                }
            }


            foreach (KeyValuePair<DateTime, double> kvp in list)
            {

                string[] row = { kvp.Key.ToString(), kvp.Value.ToString(), "", (kvp.Value - 0).ToString() };
                ListViewItem item = new ListViewItem(row);
                lsvGeneralReport.Items.Add(item);
                foreach (KeyValuePair<DateTime, double> kvp1 in list1)
                {

                    if (kvp1.Key.Date == kvp.Key.Date)
                    {
                        string[] rows = { kvp.Key.ToString(), kvp.Value.ToString(), kvp1.Value.ToString(), (kvp.Value - kvp1.Value).ToString() };
                        item = new ListViewItem(rows);
                        lsvGeneralReport.Items.RemoveAt(lsvGeneralReport.Items.Count - 1);
                        lsvGeneralReport.Items.Add(item);
                    }

                }


            }
        }

        public void byMonth()
        {
            lsvGeneralReport.Items.Clear();
            ReceiptDao r = new ReceiptDao();
            PaymentDao p = new PaymentDao();
            var incomes = r.GetReceiptList();
            for (int i = 1; i <= 12; i++)
            {
                if (i >= 10)
                {
                    string[] rows = { "Tháng " + i, "" + r.GetByMonth(i.ToString()), "" + p.GetByMonth(i.ToString()), (r.GetByMonth(i.ToString()) - p.GetByMonth(i.ToString())).ToString() };
                    ListViewItem item = new ListViewItem(rows);
                    lsvGeneralReport.Items.Add(item);
                }
                else
                {
                    string[] rowss = { "Tháng " + i, "" + r.GetByMonth("0" + i.ToString()), "" + p.GetByMonth("0" + i.ToString()), (r.GetByMonth("0" + i.ToString()) - p.GetByMonth("0" + i.ToString())).ToString() };
                    var item = new ListViewItem(rowss);
                    lsvGeneralReport.Items.Add(item);
                }
            }
        }



        public void byYear()
        {
            lsvGeneralReport.Items.Clear();
            //in
            ReceiptDao r = new ReceiptDao();
            var incomes = r.GetReceiptList();
            IDictionary<int, double> list = new Dictionary<int, double>();
            list.Add(incomes[0].PrintDate.Year, r.GetByYear(incomes[0].PrintDate.Year));
            for (int i = 1; i < incomes.Count; i++)
            {
                if (!list.ContainsKey(incomes[i].PrintDate.Year)) list.Add(incomes[i].PrintDate.Year, incomes[i].Total + incomes[i].AdditionalFee);
                else
                {
                    list[incomes[i].PrintDate.Year] += incomes[i].Total + incomes[i].AdditionalFee;
                }
            }

            //out
            PaymentDao p = new PaymentDao();
            var outcomes = p.GetPaymentList();
            IDictionary<int, double> list1 = new Dictionary<int, double>();
            list1.Add(outcomes[0].PayDate.Year, outcomes[0].TotalFee);
            for (int i = 1; i < outcomes.Count; i++)
            {
                if (!list1.ContainsKey(outcomes[i].PayDate.Year)) list1.Add(outcomes[i].PayDate.Year, outcomes[i].TotalFee);
                else
                {
                    list1[outcomes[i].PayDate.Year] += outcomes[i].TotalFee;
                }
            }


            foreach (KeyValuePair<int, double> kvp in list)
            {

                string[] row = { kvp.Key.ToString(), kvp.Value.ToString(), "", (kvp.Value - 0).ToString() };
                ListViewItem item = new ListViewItem(row);
                lsvGeneralReport.Items.Add(item);
                foreach (KeyValuePair<int, double> kvp1 in list1)
                {

                    if (kvp1.Key == kvp.Key)
                    {
                        string[] rows = { kvp.Key.ToString(), kvp.Value.ToString(), kvp1.Value.ToString(), (kvp.Value - kvp1.Value).ToString() };
                        item = new ListViewItem(rows);
                        lsvGeneralReport.Items.RemoveAt(lsvGeneralReport.Items.Count - 1);
                        lsvGeneralReport.Items.Add(item);
                    }

                }


            }
        }
    }
}
