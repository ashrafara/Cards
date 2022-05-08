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
    public partial class residue_view : Form
    {
        public residue_view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text== "")
            {
                MessageBox.Show("الرجاء كتابة السنة");
            }
            else
            {
                ReportDocument cryRpt = new ReportDocument();
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Cards;User ID=sa;Password=ali123");
                residual rpt = new residual();
                rpt.SetDatabaseLogon("sa", "ali123", "localhost", "Cards");
                rpt.SetParameterValue("year", textBox1.Text.ToString());
                crystalReportViewer1.ReportSource = rpt;
            }

        }
    }
}
