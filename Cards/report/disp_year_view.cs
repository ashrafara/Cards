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
    public partial class disp_year_view : Form
    {
        public disp_year_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog= Cards;User ID=sa;Password=ali123");
            disp_year_report rpt = new disp_year_report();
            rpt.SetDatabaseLogon("sa", "ali123", "localhost", "Cards");
            rpt.SetParameterValue("dispyear", textBox2.Text.ToString());
            crystalReportViewer1.ReportSource = rpt;
        }

        private void disp_year_view_Load(object sender, EventArgs e)
        {

        }
    }
}
