using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void الموظفToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Main.AddEmployee addEmployee = new Main.AddEmployee();
            addEmployee.ShowDialog();
        }

        private void اضافةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.AddItemType addItemType = new Main.AddItemType();
            addItemType.ShowDialog();
        }

        private void اضافةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Main.AddItem addItem = new Main.AddItem();
            addItem.ShowDialog();

        }

        private void اضافةToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Main.AddSupplier addSupplier = new Main.AddSupplier();
            addSupplier.ShowDialog();
        }

        private void اضافةToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Main.DispatchOrder dispatchOrder = new Main.DispatchOrder();
            dispatchOrder.ShowDialog();
        }

        private void اضافةToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Main.AddReceiveOrder receiveOrder = new Main.AddReceiveOrder();
            receiveOrder.ShowDialog();
              
        }

        private void تعديلToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Edit.EditEmployee editEmployee = new Edit.EditEmployee();
            editEmployee.ShowDialog();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit.EditItemType editItemType = new Edit.EditItemType();
            editItemType.ShowDialog();
        }

        private void تعديلToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Edit.EditItem editItem = new Edit.EditItem();
            editItem.ShowDialog();
        }

        private void تعديلToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Edit.EditSupplier editSupplier = new Edit.EditSupplier();
            editSupplier.ShowDialog();

        }

        private void تعديلToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Edit.EditDispatchOrder editDispatchOrder = new Edit.EditDispatchOrder();
            editDispatchOrder.ShowDialog();
        }

        private void تعديلToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Edit.EditReceiveOrder editReceiveOrder = new Edit.EditReceiveOrder();
            editReceiveOrder.ShowDialog();
        }

        private void عرضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAll.ReceiveShowAll receiveShowAll = new ShowAll.ReceiveShowAll();
            receiveShowAll.ShowDialog();
        }

        private void عرضToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowAll.DispatchShowAll dispatchShowAll = new ShowAll.DispatchShowAll();
            dispatchShowAll.ShowDialog();

        }

        private void عرضToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowAll.EmployeeShowAll employeeShowAll = new ShowAll.EmployeeShowAll();
            employeeShowAll.ShowDialog();
        }

        private void جرداستلامالكمياتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void جرداستلامسنويToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report.receive_year_report_view frm = new report.receive_year_report_view();
            frm.ShowDialog();

        }

        private void جردحسبالسنةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report.disp_year_view frm = new report.disp_year_view();
            frm.ShowDialog();
        }

        private void جردحسبالموظفسنوياToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void جردحسبالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report.disp_item_view frm = new report.disp_item_view();
            frm.ShowDialog();
        }

        private void سنوياToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void فرديToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report.disp_employeyearly_view frm = new report.disp_employeyearly_view();
            frm.ShowDialog();
        }

        private void سنويةToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }

        private void جرداستلامالصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report.receiveitem_view frm = new report.receiveitem_view();
            frm.ShowDialog();
        }

        private void صرففرديToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report.alone_view frm = new report.alone_view();
            frm.ShowDialog();
        }

        private void لابلToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void المتبقيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            report.residue_view frm = new report.residue_view();
            frm.ShowDialog();
        }
    }
}
