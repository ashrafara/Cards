using CrystalDecisions.CrystalReports.Engine;
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

namespace Cards.report
{
    public partial class alone_view : Form
    {
        Model1 db = new Model1();

        public alone_view()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                MessageBox.Show("الرجاء تعبئة نوع الخدمة");
            }
            else
            {
                ReportDocument cryRpt = new ReportDocument();
                SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=Cards;User ID=sa;Password=ali123");
                ShowAll.dispatch_EmployeeAlone_report rpt = new ShowAll.dispatch_EmployeeAlone_report();
                rpt.SetDatabaseLogon("sa", "ali123", "localhost", "Cards");
                rpt.SetParameterValue("disptachId", textBox1.Text.ToString());
                crystalReportViewer1.ReportSource = rpt;
            }

        }

        private void alone_view_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
