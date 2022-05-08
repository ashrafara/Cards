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
    public partial class AddItem : Form
    {
        Model1 db = new Model1();
        public AddItem()
        {
            InitializeComponent();

            var supplier = (from c in db.Suppliers
                            select new { c.supplierName, c.supplierId }).ToList();
            cbsupplierId.DataSource = supplier.ToList();
            cbsupplierId.DisplayMember = "supplierName";
            cbsupplierId.ValueMember = "supplierId";
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

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            dynamic supply = cbsupplierId.SelectedValue;

            var item = new Item
            {
                itemName = string.IsNullOrEmpty(txtItemName.Text) ? null : txtItemName.Text,
                itemNotes = string.IsNullOrEmpty(txtnotes.Text) ? null : txtnotes.Text,
                supplierId =supply
            };
            db.Items.Add(item);
            db.SaveChanges();
            MessageBox.Show("تم الاضافة");
            ClearTextBoxes();
        }
    }
}
