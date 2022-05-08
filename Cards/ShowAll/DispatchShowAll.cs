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
    public partial class DispatchShowAll : Form
    {
        Model1 db = new Model1();

        public DispatchShowAll()
        {
            InitializeComponent();


            var disp = from p in db.Disptaches
                       select new
                       {
                            disptach_Id = p.disptachId,
                           employee_Id = p.Employee.employeeName == null ? "" : p.Employee.employeeName,
                           disptach_Date = p.disptachDate,
                           item_Name = p.Item.itemName == null ? "" : p.Item.itemName,
                           disptach_Total = p.disptachTotal == null ? 0 : p.disptachTotal,
                           employee_Notes = p.disptachNotes == null ? "" : p.disptachNotes,
                       };
            dataGridView1.DataSource = disp.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم الموظف";
            dataGridView1.Columns[2].HeaderText = "تاريخ الصرف ";
            dataGridView1.Columns[3].HeaderText = " اسم الصنف";
            dataGridView1.Columns[4].HeaderText = "الكمية المصروفة";
            dataGridView1.Columns[5].HeaderText = "ملاحظات";
        }

        private void DispatchShowAll_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.ToString() == "")
            {
                var bind = (from p in db.Disptaches
                            orderby p.disptachId ascending
                            group p by new
                            {
                                disptach_Id = p.disptachId,
                                employee_Id = p.Employee.employeeName == null ? "" : p.Employee.employeeName,
                                disptach_Date = p.disptachDate,
                                item_Name = p.Item.itemName == null ? "" : p.Item.itemName,
                                disptach_Total = p.disptachTotal == null ? 0 : p.disptachTotal,
                                disptach_Notes = p.disptachNotes == null ? "" : p.disptachNotes,
                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
            else
            {
                var bind = (from p in db.Disptaches
                            where p.Employee.employeeName.ToLower().Contains(txt_search.Text.ToString().ToLower()) || p.disptachDate.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower())
                            || p.Item.itemName.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower())
                            orderby p.disptachId ascending
                            group p by new
                            {
                                disptach_Id = p.disptachId,
                                employee_Id = p.Employee.employeeName == null ? "" : p.Employee.employeeName,
                                disptach_Date = p.disptachDate,
                                item_Name = p.Item.itemName == null ? "" : p.Item.itemName,
                                disptach_Total = p.disptachTotal == null ? 0 : p.disptachTotal,
                                disptach_Notes = p.disptachNotes == null ? "" : p.disptachNotes,
                            } into res
                            select res.Key).ToList();
                dataGridView1.DataSource = bind.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
