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
    public partial class EditDispatchOrder : Form
    {
        Model1 db = new Model1();

        public EditDispatchOrder()
        {
            InitializeComponent();

            var tem = (from c in db.Items
                       select new { c.itemName, c.itemId }).ToList();
            cbItemName.DataSource = tem.ToList();
            cbItemName.DisplayMember = "itemName";
            cbItemName.ValueMember = "itemId";

            var emp = (from c in db.Employees
                       select new { c.employeeName, c.employeePosition, c.employeeId }).ToList();
            cbEmployeeName.DataSource = emp.ToList();
            cbEmployeeName.DisplayMember = "employeeName";
            cbEmployeeName.ValueMember = "employeeId";

            cbEmployeePost.DataSource = emp.ToList();
            cbEmployeePost.DisplayMember = "employeePosition";
            cbEmployeePost.ValueMember = "employeeId";

            var disp = from p in db.Disptaches
                      select new
                      {
                          disptach_Id = p.disptachId,
                          employee_Id = p.Employee.employeeName == null ? "" : p.Employee.employeeName,
                          disptach_Date = p.disptachDate,
                          item_Name = p.Item.itemName == null ? "" : p.Item.itemName,
                          disptach_Total = p.disptachTotal == null ? 0 : p.disptachTotal,
                          employee_Notes = p.disptachNotes == null ? "" : p.disptachNotes,
                          type_1= p.type1 == null ? 0 : p.type1,
                          quantity_1= p.quantity1 == null ? 0 : p.quantity1,
                          type_2 = p.type2 == null ? 0 : p.type2,
                          quantity_2 = p.quantity2 == null ? 0 : p.quantity2,

                      };
            dataGridView1.DataSource = disp.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم الموظف ";
            dataGridView1.Columns[2].HeaderText = "تاريخ الصرف ";
            dataGridView1.Columns[3].HeaderText = " اسم الصنف ";
            dataGridView1.Columns[4].HeaderText = "الكمية المصروفة ";
            dataGridView1.Columns[5].HeaderText = "ملاحظات ";
            dataGridView1.Columns[6].HeaderText = "النوع ";
            dataGridView1.Columns[7].HeaderText = "الكمية ";
            dataGridView1.Columns[8].HeaderText = "النوع ";
            dataGridView1.Columns[9].HeaderText = "الكمية ";


        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditDispatchOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dynamic name = cbEmployeeName.SelectedValue;
            dynamic iteme = cbItemName.SelectedValue;

            var dispatch = new Disptach
            {
                disptachId = int.Parse(textBox5.Text),
                disptachDate = Convert.ToDateTime(dateDispatch.Text),
                disptachNotes = txtNoteDisp.Text,
                disptachTotal = int.Parse(txtQuantityDisp.Text),
                employeeId = name,
                itemId = iteme,
                type1 = int.Parse(txttype1.Text),
                quantity1 = int.Parse(txtquantity1.Text),
                type2 = int.Parse(txttype2.Text),
                quantity2 = int.Parse(txtquantity2.Text),
                //dispmonth = month.Text,
                //dispyear = year.Text
            };
            db.Disptaches.AddOrUpdate(dispatch);
            db.SaveChanges();
            MessageBox.Show("تم التعديل");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox5.Text);
            var deletedemply = (from c in db. Disptaches
                                where c.disptachId == id
                                select c).Single();
            db.Disptaches.Remove(deletedemply);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox5.Text = row.Cells[0].Value.ToString();
                cbEmployeeName.Text = row.Cells[1].Value.ToString();
                dateDispatch.Text = row.Cells[2].Value.ToString();
                cbItemName.Text = row.Cells[3].Value.ToString();
                txtQuantityDisp.Text = row.Cells[4].Value.ToString();
                txtNoteDisp.Text = row.Cells[5].Value.ToString();
                txttype1.Text= row.Cells[6].Value.ToString();
                txtquantity1.Text = row.Cells[7].Value.ToString();
                txttype2.Text = row.Cells[8].Value.ToString();
                txtquantity2.Text = row.Cells[9].Value.ToString();
            }
        }
    }
}
