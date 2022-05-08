using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine; 

namespace Cards.ShowAll
{
    public partial class receive_report_view : Form
    {
        Model1 db = new Model1();

        public receive_report_view(string receiveId)
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Cards;User ID=sa;Password=ali123");
            receive_report rpt = new receive_report();
            rpt.SetDatabaseLogon("sa", "ali123", "localhost", "Cards");
            rpt.SetParameterValue("receiveId", receiveId.ToString());
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();

        }

        private void receive_report_view_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            receive_report rpt = new receive_report();
            rpt.SetDatabaseLogon("sa", "ali123", "localhost", "Cards");
            //rpt.SetParameterValue("receiveId", receiveId.ToString());
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
