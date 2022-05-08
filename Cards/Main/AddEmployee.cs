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
    public partial class AddEmployee : Form
    {
        Model1 db = new Model1();

        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtempName.Text))
            {
                MessageBox.Show("الرجاء ادخال اسم الموظف");
                return;
            }
            if (string.IsNullOrEmpty(txtPosit.Text))
            {
                MessageBox.Show("الرجاء ادخال اسم الوظيفة/جهة العمل");
                return;
            }

            var employee = new Employee
            {
                employeeName = string.IsNullOrEmpty(txtempName.Text) ? null :  txtempName.Text,
                employeePosition = string.IsNullOrEmpty(txtPosit.Text) ? null : txtPosit.Text,
                employeeNotes = string.IsNullOrEmpty(txtnote.Text) ? null :  txtnote.Text,
                empFuelMonthly =  float.Parse(txtfuel.Text),
                empInternetMonthly = float.Parse(txtnet.Text),
                empMobileMonthly= float.Parse(txtmobile.Text)
                
            };
            db.Employees.Add(employee);
            db.SaveChanges();
            MessageBox.Show("تم الاضافة");
            ClearTextBoxes();
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
