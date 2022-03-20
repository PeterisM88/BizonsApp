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
using Microsoft.Reporting.WinForms;

namespace BizonsApp
{
    public partial class ViewReports : Form
    {
        public ViewReports()
        {
            InitializeComponent();
            this.CenterToScreen();
            comboBox1.SelectedIndex = 0;
            lblracenr.Visible = false;
            comboBox1.Visible = false;
            reportViewer1.LocalReport.DataSources.Clear();
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ParticipantDetails;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        private void Load_data()
        {
            cmd = new SqlCommand("Select * from ParticipantForm", con);
            con.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            reportViewer1.LocalReport.DataSources.Clear();

        }

        private void ViewReports_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you shure you whant to logout?", "LOGOUT CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sUMMARYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblracenr.Visible = false;
            comboBox1.Visible = false;
            Load_data();

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("SUMMARYLIST", dt);
            reportViewer1.LocalReport.ReportPath = "Summary.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();

            con.Close();
        }

        private void bYRACENRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblracenr.Visible = true;
            comboBox1.Visible = true;
        }

        private void sortbyRaceNr()
        {
            // Order by Age group asc and Points desc, with chosen races nr.
            cmd = new SqlCommand("Select * from ParticipantForm where Race_nr = @RaceNr order by Age_group asc, Distance_result asc", con);
            string raceNrtxt = comboBox1.GetItemText(comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("RaceNr", raceNrtxt);
            con.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("SUMMARYLIST", dt);
            reportViewer1.LocalReport.ReportPath = "Summary.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();

            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortbyRaceNr();
        }

        private void bYAGEGROUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblracenr.Visible = false;
            comboBox1.Visible = false;

            //cmd = new SqlCommand("Select * from ParticipantForm order by Age_group asc ", con);
            cmd = new SqlCommand("Select * from ParticipantForm order by Age_group asc, Race_nr asc, Distance_result asc", con);
            con.Open();
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("SUMMARYLIST", dt);
            reportViewer1.LocalReport.ReportPath = "Summary.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();

            con.Close();
        }
    }
}
