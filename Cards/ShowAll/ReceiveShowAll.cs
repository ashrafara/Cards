using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards.ShowAll
{
    public partial class ReceiveShowAll : Form
    {
        Model1 db = new Model1();

        public ReceiveShowAll()
        {
            InitializeComponent();

            var emp = from p in db.ReceiveOrders
                      select new
                      {
                          receive_Id = p.receiveId,
                          order_Number = p.orderNumber,
                          supplier_Name = p.Supplier.supplierName == null ? "" : p.Supplier.supplierName,
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
            dataGridView1.Columns[1].HeaderText = "رقم امر التكليف";
            dataGridView1.Columns[2].HeaderText = "اسم المورد";
            dataGridView1.Columns[3].HeaderText = "تاريخ امر التكليف   ";
            dataGridView1.Columns[4].HeaderText = "اسم الصنف";
            dataGridView1.Columns[5].HeaderText = "الكمية المستلمة ";
            dataGridView1.Columns[6].HeaderText = "القيمة الاسمية للكمية ";
            dataGridView1.Columns[7].HeaderText = "القيمة السوقية للكمية ";
            dataGridView1.Columns[8].HeaderText = "الفئة1 ";
            dataGridView1.Columns[9].HeaderText = "الكمية1 ";
            dataGridView1.Columns[10].HeaderText = "الفئة2 ";
            dataGridView1.Columns[11].HeaderText = "الكمية2  ";
            dataGridView1.Columns[12].HeaderText = "ملاحظات  ";
        }

        private void ReceiveShowAll_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.ToString() == "")
            {
                var bind = (from p in db.ReceiveOrders
                            orderby p.orderNumber ascending
                            group p by new
                            {
                                receive_Id = p.receiveId,
                                order_Number = p.orderNumber,
                                supplier_Name = p.Supplier.supplierName == null ? "" : p.Supplier.supplierName,
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
                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
            else
            {
                var bind = (from p in db.ReceiveOrders
                            where p.Supplier.supplierName.ToLower().Contains(txt_search.Text.ToString().ToLower()) || p.orderNumber.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower())
                            || p.orderDate.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower()) || p.receiveDate.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower())
                            orderby p.orderNumber ascending
                            group p by new
                            {
                                receive_Id = p.receiveId,
                                order_Number = p.orderNumber,
                                supplier_Name = p.Supplier.supplierName == null ? "" : p.Supplier.supplierName,
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
                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string receiveId = dataGridView1.Rows[0].Cells[0].Value.ToString();
            receive_report_view frm = new receive_report_view(receiveId);
            frm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
