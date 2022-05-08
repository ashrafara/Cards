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
    public partial class EditSupplier : Form
    {
        Model1 db = new Model1();

        public EditSupplier()
        {
            InitializeComponent();

            var supply = from p in db.Suppliers
                      select new
                      {
                          supplier_Id = p.supplierId,
                          supplier_Name = p.supplierName == null ? "" : p.supplierName,
                          supplier_Address = p.supplierAddress == null ? "" : p.supplierAddress,
                          supplier_Notes = p.supplierNotes == null ? "" : p.supplierNotes
                      };
            dataGridView1.DataSource = supply.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم المورد ";
            dataGridView1.Columns[2].HeaderText = "العنوان";
            dataGridView1.Columns[3].HeaderText =  " ملاحظات ";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                txtSupplierName.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtnotes.Text = row.Cells[3].Value.ToString();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var supply = new Supplier
            {
                supplierId= int.Parse(textBox1.Text),
                supplierName = txtSupplierName.Text,
                supplierAddress = txtAddress.Text,
                supplierNotes = txtnotes.Text
            };
            db.Suppliers.AddOrUpdate(supply);
            db.SaveChanges();
            MessageBox.Show("تم التعديل");
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var deletedemply = (from c in db.Suppliers
                                where c.supplierId == id
                                select c).Single();
            db.Suppliers.Remove(deletedemply);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");

        }
    }
}
