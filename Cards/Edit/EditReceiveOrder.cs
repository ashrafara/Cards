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
    public partial class EditReceiveOrder : Form
    {
        Model1 db = new Model1();

        public EditReceiveOrder()
        {
            InitializeComponent();


            var itemtype = (from c in db.Items
                            join s in db.Suppliers on c.supplierId equals s.supplierId
                            select new { c.itemName, s.supplierName, s.supplierId, c.itemId }).ToList();
            cbItemName.DataSource = itemtype.ToList();
            cbItemName.DisplayMember = "itemName";
            cbItemName.ValueMember = "itemId";

            cbSupplierName.DataSource = itemtype.ToList();
            cbSupplierName.DisplayMember = "supplierName";
            cbSupplierName.ValueMember = "supplierId";


            var emp = from p in db.ReceiveOrders
                      select new
                      {
                          employee_Id = p.receiveId,
                          supplier_Name = p.Supplier.supplierName == null ? "" : p.Supplier.supplierName,
                          order_Number = p.orderNumber == null ? "" : p.orderNumber,
                          order_Date = p.orderDate,
                          receive_Date = p.receiveDate,
                          item_Name = p.Item.itemName == null ? "" : p.Item.itemName,
                          receive_Quantity = p.receiveQuantity == null ? 0 : p.receiveQuantity,
                          receiveTota_lPrice = p.receiveTotalPrice == null ? 0 : p.receiveTotalPrice,
                          receiveCommercial_Price = p.receiveCommercialPrice == null ? 0 : p.receiveCommercialPrice,
                          item_type1 = p.itemtype1 == null ? 0 : p.itemtype1,
                          item_Quantity1 = p.itemQuantity1 == null ? 0 : p.itemQuantity1,
                          item_type2 = p.itemtype2 == null ? 0 : p.itemtype2,
                          item_Quantity2 = p.itemQuantity2 == null ? 0 : p.itemQuantity2,
                          receive_Notes = p.receiveNotes == null ? "" : p.receiveNotes
                      };
            dataGridView1.DataSource = emp.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم المورد ";
            dataGridView1.Columns[2].HeaderText = "رقم امر التكليف ";
            dataGridView1.Columns[3].HeaderText = "تاريخ امر التكليف   ";
            dataGridView1.Columns[4].HeaderText = "تاريخ الاستلام   ";
            dataGridView1.Columns[5].HeaderText = "اسم الصنف";
            dataGridView1.Columns[6].HeaderText = "الكمية المستلمة ";
            dataGridView1.Columns[7].HeaderText = "القيمة الاسمية للكمية ";
            dataGridView1.Columns[8].HeaderText = "القيمة السوقية للكمية ";
            dataGridView1.Columns[9].HeaderText = "الفئة1 ";
            dataGridView1.Columns[10].HeaderText = "الكمية1 ";
            dataGridView1.Columns[11].HeaderText = "الفئة2 ";
            dataGridView1.Columns[12].HeaderText = "الكمية2  ";
            dataGridView1.Columns[13].HeaderText = "ملاحظات  ";

        }

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dynamic type = cbItemName.SelectedValue;
            dynamic supply = cbSupplierName.SelectedValue;

            var receive = new ReceiveOrder
            {
                receiveId= int.Parse(textBox1.Text),
                supplierId = supply,
                orderNumber = txtReceiveNo.Text,
                orderDate = Convert.ToDateTime(Orderdate.Text),
                receiveDate = Convert.ToDateTime(ReceiveDate.Text),
                itemId = type,
                receiveQuantity = float.Parse(txtQuantityRec.Text),
                receiveTotalPrice = float.Parse(txtRecPrice.Text),
                receiveCommercialPrice = float.Parse(txtPieceprice.Text),
                receiveNotes = txtNoteRec.Text,
                itemtype1 = float.Parse(txttype1.Text),
                itemQuantity1 = float.Parse(txtquantity1.Text),
                itemtype2 = float.Parse(txttype2.Text),
                itemQuantity2 = float.Parse(txtquantity2.Text)
            };
            db.ReceiveOrders.AddOrUpdate(receive);
            db.SaveChanges();
            MessageBox.Show("تم التعديل");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                cbSupplierName.Text = row.Cells[1].Value.ToString();
                txtReceiveNo.Text = row.Cells[2].Value.ToString();
                Orderdate.Text = row.Cells[3].Value.ToString();
                ReceiveDate.Text = row.Cells[4].Value.ToString();
                cbItemName.Text = row.Cells[5].Value.ToString();
                txtQuantityRec.Text = row.Cells[6].Value.ToString();
                txtRecPrice.Text = row.Cells[7].Value.ToString();
                txtPieceprice.Text = row.Cells[8].Value.ToString();
                txttype1.Text = row.Cells[9].Value.ToString();
                txtquantity1.Text = row.Cells[10].Value.ToString();
                txttype2.Text = row.Cells[11].Value.ToString();
                txtquantity2.Text = row.Cells[12].Value.ToString();
                txtNoteRec.Text = row.Cells[13].Value.ToString();


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            var deletedemply = (from c in db.ReceiveOrders
                                where c.receiveId == id
                                select c).Single();
            db.ReceiveOrders.Remove(deletedemply);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");


        }

        private void EditReceiveOrder_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int RowIndex = dataGridView1.SelectedCells[0].RowIndex;
            //    textBox1.Text = dataGridView1.Rows[RowIndex].Cells[0].Value.ToString();
            //    txtReceiveNo.Text = dataGridView1.Rows[RowIndex].Cells[2].Value.ToString(); ;
            //    DateTime Orderdate = DateTime.Parse(dataGridView1.Rows[RowIndex].Cells[3].Value.ToString());
            //    DateTime ReceiveDate = DateTime.Parse(dataGridView1.Rows[RowIndex].Cells[4].Value.ToString());
            //    cbItemName.SelectedItem = Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells[5].Value.ToString());
            //    txtQuantityRec.Text = dataGridView1.Rows[RowIndex].Cells[6].Value.ToString();
            //    txtRecPrice.Text = dataGridView1.Rows[RowIndex].Cells[7].Value.ToString();
            //    txtPieceprice.Text = dataGridView1.Rows[RowIndex].Cells[8].Value.ToString();
            //    txttype1.Text = dataGridView1.Rows[RowIndex].Cells[9].Value.ToString();
            //    txtquantity1.Text = dataGridView1.Rows[RowIndex].Cells[10].Value.ToString();
            //    txttype2.Text = dataGridView1.Rows[RowIndex].Cells[11].Value.ToString();
            //    txtquantity2.Text = dataGridView1.Rows[RowIndex].Cells[12].Value.ToString();
            //    txtNoteRec.Text = dataGridView1.Rows[RowIndex].Cells[13].Value.ToString();
            //    cbSupplierName.SelectedValue = Convert.ToInt32(dataGridView1.Rows[RowIndex].Cells[1].Value.ToString());

            //}
            //catch
            //{

            //}

        }
    }
}
