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
    public partial class AddReceiveOrder : Form
    {
        Model1 db = new Model1();

        public AddReceiveOrder()
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

        }

        private void ReceiveOrder_Load(object sender, EventArgs e)
        {
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

        private void btnexist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRec_Click(object sender, EventArgs e)
        {
            dynamic type = cbItemName.SelectedValue;
            dynamic supply = cbSupplierName.SelectedValue;

            var receive = new ReceiveOrder
            {
                receiveDate = Convert.ToDateTime(ReceiveDate.Text),
                orderDate = Convert.ToDateTime(Orderdate.Text),
                orderNumber = string.IsNullOrEmpty(txtReceiveNo.Text) ? null : txtReceiveNo.Text,
                supplierId = supply,
                itemId = type,
                receiveQuantity = string.IsNullOrEmpty(txtQuantityRec.Text) ? (float?)null : Convert.ToInt32(txtQuantityRec.Text),
                receiveTotalPrice = string.IsNullOrEmpty(txtRecPrice.Text) ? (float?)null : Convert.ToInt32(txtRecPrice.Text),
                receiveCommercialPrice = string.IsNullOrEmpty(txtPieceprice.Text) ? (float?)null : Convert.ToInt32(txtPieceprice.Text) ,
                receiveNotes = string.IsNullOrEmpty(txtNoteRec.Text) ? null :  txtNoteRec.Text,
                itemtype1 = string.IsNullOrEmpty(txttype1.Text) ? (int?)null : Convert.ToInt32(txttype1.Text),
                itemQuantity1 = string.IsNullOrEmpty(txtquantity1.Text) ? (int?)null : Convert.ToInt32(txtquantity1.Text),
                itemtype2 = string.IsNullOrEmpty(txttype2.Text) ? (int?)null : Convert.ToInt32(txttype2.Text),
                itemQuantity2 = string.IsNullOrEmpty(txtquantity2.Text) ? (int?)null : Convert.ToInt32(txtquantity2.Text)
            };
            db.ReceiveOrders.Add(receive);
            db.SaveChanges();
            MessageBox.Show("تم الاضافة");
            ClearTextBoxes();

        }

        private void cbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbItemName.SelectedIndex = cbSupplierName.SelectedIndex;
        }
    }
}
