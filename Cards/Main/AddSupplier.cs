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
    public partial class AddSupplier : Form
    {
        Model1 db = new Model1();

        public AddSupplier()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var supply = new Supplier
            {
                supplierName = txtSupplierName.Text,
                supplierAddress = txtAddress.Text,
                supplierNotes = txtnotes.Text

            };
            db.Suppliers.Add(supply);
            db.SaveChanges();
            MessageBox.Show("تم الاضافة");
            ClearTextBoxes();
        }
    }
}
