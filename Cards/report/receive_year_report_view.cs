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
    public partial class receive_year_report_view : Form
    {
        public receive_year_report_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("الرجاء تعبة السنة");
                
            }
            else
            {
                ReportDocument cryRpt = new ReportDocument();
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Cards;");
                report.receive_year_report rpt = new report.receive_year_report();
                rpt.SetDatabaseLogon("sa", "ali123", "localhost", "Cards");
                rpt.SetParameterValue("orderDate", textBox1.Text.ToString());
                crystalReportViewer1.ReportSource = rpt;
            }


        }

        private void receive_year_report_view_Load(object sender, EventArgs e)
        {

        }
    }
}
