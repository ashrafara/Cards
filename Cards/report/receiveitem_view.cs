using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Cards.report
{
    public partial class receiveitem_view : Form
    {
        Model1 db = new Model1();

        public receiveitem_view()
        {
            InitializeComponent();

            var tem = (from c in db.Items
                       select new { c.itemName, c.itemId }).ToList();
            comboBox1.DataSource = tem;
            comboBox1.DisplayMember = "itemName";
            comboBox1.ValueMember = "itemId";

        }

        private void receiveitem_view_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Cards;");
            receiveitem_report rpt = new receiveitem_report();
            rpt.SetDatabaseLogon("sa", "ali123", "localhost", "Cards");
            rpt.SetParameterValue("orderDate", textBox1.Text.ToString());
            rpt.SetParameterValue("itemId", comboBox1.SelectedValue);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
