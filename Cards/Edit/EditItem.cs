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
    public partial class EditItem : Form
    {
        Model1 db = new Model1();

        public EditItem()
        {
            InitializeComponent();

            var supplier = (from c in db.Suppliers
                            select new { c.supplierName, c.supplierId }).ToList();
            cbsupplierId.DataSource = supplier.ToList();
            cbsupplierId.DisplayMember = "supplierName";
            cbsupplierId.ValueMember = "supplierId";


            var ite = from p in db.Items
                      select new
                      {
                          item_Id = p.itemId,
                          item_Name = p.itemName == null ? "" : p.itemName,
                          supplier_Id = p.Supplier.supplierName == null ? "" : p.Supplier.supplierName,
                          item_Notes = p.itemNotes == null ? "" : p.itemNotes
                      };
            dataGridView1.DataSource = ite.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم الصنف ";
            dataGridView1.Columns[2].HeaderText = "المورد";
            dataGridView1.Columns[3].HeaderText = " ملاحظات ";

        }

        private void EditItem_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dynamic supply = cbsupplierId.SelectedValue;

            var item = new Item
            {
                itemId = int.Parse(textBox1.Text),
                itemName = txtItemName.Text,
                itemNotes = txtnotes.Text,
                supplierId = supply
            };
            db.Items.AddOrUpdate(item);
            db.SaveChanges();
            MessageBox.Show("تم الاضافة");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row= this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text= row.Cells[0].Value.ToString();
                txtItemName.Text= row.Cells[1].Value.ToString();
                cbsupplierId.Text= row.Cells[2].Value.ToString();
                txtnotes.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var deletedemply = (from c in db.Items
                                where c.itemId == id
                                select c).Single();
            db.Items.Remove(deletedemply);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");
        }

        private void btnexist_Click(object sender, EventArgs e)
        {

        }
    }
}
