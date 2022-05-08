using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace Cards.ShowAll
{
    public partial class EmployeeShowAll : Form
    {
        Model1 db = new Model1();

        public EmployeeShowAll()
        {
            InitializeComponent();

            var emp = from p in db.Employees
                      select new
                      {
                          employee_Id = p.employeeId,
                          employee_Name = p.employeeName == null ? "" : p.employeeName,
                          employee_Position = p.employeePosition == null ? "" : p.employeePosition,
                          empFuel_Monthly = p.empFuelMonthly == null ? 0 : p.empFuelMonthly,
                          empInternet_Monthly = p.empInternetMonthly == null ? 0 : p.empInternetMonthly,
                          empMobile_Monthly = p.empMobileMonthly == null ? 0 : p.empMobileMonthly,
                          employee_Notes = p.employeeNotes == null ? "" : p.employeeNotes,
                      };
            dataGridView1.DataSource = emp.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم الموظف ";
            dataGridView1.Columns[2].HeaderText = "الوظيفة";
            dataGridView1.Columns[3].HeaderText = "حصة الوقود الشهرية ";
            dataGridView1.Columns[4].HeaderText = " حصة الانترنت الشهرية ";
            dataGridView1.Columns[5].HeaderText = "حصة النقال الشهرة ";
            dataGridView1.Columns[6].HeaderText = "ملاحظات ";
        }

        private void EmployeeShowAll_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.ToString() == "")
            {
                var bind = (from p in db.Employees
                            orderby p.employeeId ascending
                            group p by new
                            {
                                employee_Id = p.employeeId,
                                employee_Name = p.employeeName == null ? "" : p.employeeName,
                                employee_Position = p.employeePosition == null ? "" : p.employeePosition,
                                empFuel_Monthly = p.empFuelMonthly == null ? 0 : p.empFuelMonthly,
                                empInternet_Monthly = p.empInternetMonthly == null ? 0 : p.empInternetMonthly,
                                empMobile_Monthly = p.empMobileMonthly == null ? 0 : p.empMobileMonthly,
                                employee_Notes = p.employeeNotes == null ? "" : p.employeeNotes,
                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
            else
            {
                var bind = (from p in db.Employees
                            where p.employeeName.ToLower().Contains(txt_search.Text.ToString().ToLower()) || p.empFuelMonthly.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower())
                            || p.empMobileMonthly.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower()) || p.empInternetMonthly.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower())
                            orderby p.employeeId ascending
                            group p by new
                            {
                                employee_Id = p.employeeId,
                                employee_Name = p.employeeName == null ? "" : p.employeeName,
                                employee_Position = p.employeePosition == null ? "" : p.employeePosition,
                                empFuel_Monthly = p.empFuelMonthly == null ? 0 : p.empFuelMonthly,
                                empInternet_Monthly = p.empInternetMonthly == null ? 0 : p.empInternetMonthly,
                                empMobile_Monthly = p.empMobileMonthly == null ? 0 : p.empMobileMonthly,
                                employee_Notes = p.employeeNotes == null ? "" : p.employeeNotes,
                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
        }
    }
}
