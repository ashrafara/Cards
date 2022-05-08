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

namespace Cards.Edit
{
    public partial class EditEmployee : Form
    {
        Model1 db = new Model1();

        public EditEmployee()
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
            dataGridView1.Columns[5].HeaderText = "حصة النقال الشهرية ";
            dataGridView1.Columns[6].HeaderText = "ملاحظات ";
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                txtempName.Text = row.Cells[1].Value.ToString();
                txtPosit.Text = row.Cells[2].Value.ToString();
                txtfuel.Text = row.Cells[3].Value.ToString();
                txtnet.Text = row.Cells[4].Value.ToString();
                txtmobile.Text = row.Cells[5].Value.ToString();
                txtnote.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                employeeId= int.Parse(textBox1.Text),
                employeeName = txtempName.Text,
                employeePosition = txtPosit.Text,
                empFuelMonthly = int.Parse(txtfuel.Text),
                empInternetMonthly = int.Parse(txtnet.Text),
                empMobileMonthly = int.Parse(txtmobile.Text),
                employeeNotes = txtnote.Text,
            };
            db.Employees.AddOrUpdate(employee);
            db.SaveChanges();
            MessageBox.Show("تم التعديل");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var deletedemply = (from c in db.Employees
                                where c.employeeId == id
                                select c).Single();
            db.Employees.Remove(deletedemply);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");

        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
