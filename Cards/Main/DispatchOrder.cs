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

namespace Cards.Main
{
    public partial class DispatchOrder : Form
    {
        Model1 db = new Model1();

        public DispatchOrder()
        {
            InitializeComponent();

            var tem = (from c in db.Items
                            select new { c.itemName, c.itemId}).ToList();
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

        }

        private void DispatchOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            dynamic name = cbEmployeeName.SelectedItem;
            dynamic iteme = cbItemName.SelectedItem;

            var dispatch = new Disptach
            {
                disptachDate = Convert.ToDateTime(dateDispatch.Text),
                disptachNotes = string.IsNullOrEmpty(txtNoteDisp.Text) ? null : txtNoteDisp.Text,
                disptachTotal = string.IsNullOrEmpty(txtQuantityDisp.Text) ? (int?)null : Convert.ToInt32(txtQuantityDisp.Text),
                employeeId = name.employeeId,
                itemId = iteme.itemId,
                type1 = string.IsNullOrEmpty(txttype1.Text) ? (int?)null : Convert.ToInt32(txttype1.Text),
                quantity1 = string.IsNullOrEmpty(txtquantity1.Text) ? (int?)null : Convert.ToInt32(txtquantity1.Text),
                type2 = string.IsNullOrEmpty(txttype2.Text) ? (int?)null : Convert.ToInt32(txttype2.Text),
                quantity2 = string.IsNullOrEmpty(txtquantity2.Text) ? (int?)null : Convert.ToInt32(txtquantity2.Text)
                //dispmonth = string.IsNullOrEmpty(month.Text) ? null : month.Text,
                //dispyear = string.IsNullOrEmpty(year.Text) ? null : year.Text
            };
            db.Disptaches.Add(dispatch);
            db.SaveChanges();
            MessageBox.Show("تم الاضافة");
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void cbEmployeePost_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEmployeeName.SelectedItem = cbEmployeePost.SelectedItem;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEmployeePost.SelectedItem = cbEmployeeName.SelectedItem;
        }

        private void cbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
