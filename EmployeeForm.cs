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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void lsvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvEmployee.SelectedItems.Count > 0)
            {
                EmployeeDao EmDao = new EmployeeDao();
                Employee emp = EmDao.GetEmployeeByID(Convert.ToInt32(lsvEmployee.SelectedItems[0].SubItems[0].Text));
                txtName.Text = emp.EmployeeName;
                txtAddress.Text = emp.Address;
                txtPhoneNumber.Text = emp.PhoneNumber;
                txtPosition.Text = emp.Position;
                txtStartDate.Text = emp.StartDate.ToShortDateString();
                if (emp.Gender) cboGender.SelectedIndex = 0;
                else cboGender.SelectedIndex = 1;

            }
        }

        private void LoadTable()
        {
            lsvEmployee.Items.Clear();
            EmployeeDao EmDao = new EmployeeDao();
            List<Employee> ls = EmDao.GetEmployeeList();
            foreach (Employee a in ls)
            {
                ListViewItem item = lsvEmployee.Items.Add(a.EmployeeID.ToString());
                item.SubItems.Add(a.EmployeeName);
                item.SubItems.Add(a.Position);
            }

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadTable();
            cboGender.Items.AddRange(new string[] { "Nữ", "Nam" });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lsvEmployee.SelectedItems.Count > 0)
            {

                EmployeeDao emDao = new EmployeeDao();
                if (emDao.RemoveEmployeeById(lsvEmployee.SelectedItems[0].SubItems[0].Text))
                {
                    lsvEmployee.Items.Remove(lsvEmployee.SelectedItems[0]);
                }
                txtName.Text = "";
                txtAddress.Text = "";
                txtPhoneNumber.Text = "";
                txtPosition.Text = "";
                txtStartDate.Text = "";
            }
            else
                MessageBox.Show("Bạn chưa chọn dòng để xóa");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeDao emDao = new EmployeeDao();
            if (txtName.Text.Length > 0 && txtAddress.Text.Length > 0 && txtPhoneNumber.Text.Length > 0 && txtPosition.Text.Length > 0 )
            {
                try
                {
                    emDao.AddEmployee(new Employee(txtName.Text, cboGender.SelectedIndex == 0, txtPosition.Text, txtAddress.Text, txtPhoneNumber.Text));
                }catch(Exception ex) {
                    MessageBox.Show("Failed : " + ex.Message);
                        }
                 LoadTable();
                txtName.Text = "";
                txtAddress.Text = "";
                txtPhoneNumber.Text = "";
                txtPosition.Text = "";
                txtStartDate.Text = "";
            }
        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lsvEmployee.SelectedItems.Count > 0)
            {
                EmployeeDao emDao = new EmployeeDao();
                Employee emp = emDao.GetEmployeeByID(Convert.ToInt32(lsvEmployee.SelectedItems[0].SubItems[0].Text));
                emp.EmployeeName = txtName.Text;
                emp.Address = txtAddress.Text;
                emp.Position = txtPosition.Text;
                emp.PhoneNumber = txtPhoneNumber.Text;
                emp.Gender = (cboGender.SelectedIndex == 0);
                try
                {
                    emDao.UpdateEmployee(emp);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message);
                }
                txtName.Text = "";
                txtAddress.Text = "";
                txtPhoneNumber.Text = "";
                txtPosition.Text = "";
                txtStartDate.Text = "";
                LoadTable();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
