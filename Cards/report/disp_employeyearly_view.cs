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
using System.Globalization;

namespace Cards.report
{
    public partial class disp_employeyearly_view : Form
    {
        Model1 db = new Model1();

        public disp_employeyearly_view(  )
        {
            InitializeComponent();

            var emp = (from c in db.Employees
                       select new { c.employeeName, c.employeeId }).ToList();
            comboBox1.DataSource = emp.ToList();
            comboBox1.DisplayMember = "employeeName";
            comboBox1.ValueMember = "employeeId";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ReportDocument cryRpt = new ReportDocument();
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Cards;User ID=sa;Password=ali123");
            employeeannual_report rpt = new employeeannual_report();
            rpt.SetDatabaseLogon("sa", "ali123", "localhost", "Cards");
            rpt.SetParameterValue("dispyear", textBox2.Text.ToString());
            rpt.SetParameterValue("employeeId", comboBox1.SelectedValue);
            crystalReportViewer1.ReportSource = rpt;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void disp_employeyearly_view_Load(object sender, EventArgs e)
        {

        }
    }
}
