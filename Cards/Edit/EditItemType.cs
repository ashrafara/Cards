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
    public partial class EditItemType : Form
    {
        Model1 db = new Model1();

        public EditItemType()
        {
            InitializeComponent();

            var ite = from p in db.ItemTypes
                      select new
                      {
                          item_Id = p.itemTypeId,
                          item_Name = p.itemTypeName == null ? "" : p.itemTypeName
                      };
            dataGridView1.DataSource = ite.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم نوع الصنف";
        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var itemtype = new ItemType
            {
                itemTypeId=int.Parse(textBox1.Text),
                itemTypeName = txtItemType.Text
            };
            db.ItemTypes.AddOrUpdate(itemtype);
            db.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var deletedemply = (from c in db.ItemTypes
                                where c.itemTypeId == id
                                select c).Single();
            db.ItemTypes.Remove(deletedemply);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                txtItemType.Text = row.Cells[1].Value.ToString();
            }
        }
    }
}
