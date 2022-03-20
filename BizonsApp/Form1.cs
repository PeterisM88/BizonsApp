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

namespace BizonsApp
{
    public partial class ParticipantInfo : Form
    {
        public ParticipantInfo()
        {
            InitializeComponent();
            this.CenterToScreen();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=ParticipantDetails;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int ID = 0;

        private void Load_data()
        {
            cmd = new SqlCommand("Select * from ParticipantForm", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NClear()
        {
            txtStartNr.Text = txtFirstName.Text = txtLastName.Text = txtResult.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            ID = 0;
        }

        private void ParticipantInfo_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtStartNr.Text = selectedrow.Cells[1].Value.ToString();
            txtFirstName.Text = selectedrow.Cells[2].Value.ToString();
            txtLastName.Text = selectedrow.Cells[3].Value.ToString();
            comboBox2.SelectedItem = selectedrow.Cells[4].Value.ToString();
            txtResult.Text = selectedrow.Cells[5].Value.ToString();
            comboBox1.SelectedItem = selectedrow.Cells[6].Value.ToString();
        }

        private void Parameters()
        {
            cmd.Parameters.AddWithValue("StartNr", txtStartNr.Text); 
            cmd.Parameters.AddWithValue("FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("LastName", txtLastName.Text);
            String age_grouptxt = comboBox2.GetItemText(comboBox2.SelectedItem);
            cmd.Parameters.AddWithValue("Age", age_grouptxt);
            cmd.Parameters.AddWithValue("Result", txtResult.Text);
            String raceNrtxt = comboBox1.GetItemText(comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("RaceNr", raceNrtxt);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtStartNr.Text) || String.IsNullOrEmpty(txtFirstName.Text) ||
                String.IsNullOrEmpty(txtLastName.Text) || comboBox2.SelectedIndex == 0 ||
                comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Complete all the required filds!");
                return;
            }
            else
            {
                cmd = new SqlCommand("Insert into ParticipantForm values (@StartNr,@FirstName,@LastName,@Age,@Result,@RaceNr)", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Load_data();
                MessageBox.Show("Record Added Successfully");
                NClear();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStartNr.Text) || String.IsNullOrEmpty(txtFirstName.Text) ||
                String.IsNullOrEmpty(txtLastName.Text) || comboBox2.SelectedIndex == 0 ||
                String.IsNullOrEmpty(txtResult.Text) || comboBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Complete all the required filds!");
                return;
            }
            else
            {
                cmd = new SqlCommand("Update ParticipantForm set Start_number = @StartNr,First_name = @FirstName,Last_name = @LastName," +
                    "Age_group = @Age,Distance_result = @Result,Race_nr = @RaceNr where ID=@id", con);
                Parameters();
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                Load_data();
                MessageBox.Show("Record Updated Successfully");
                NClear();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Delete ParticipantForm where ID=@id", con);
            Parameters();
            con.Open();
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            con.Close();
            Load_data();
            MessageBox.Show("Record Deleted Successfully");
            NClear();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            NClear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // cmd = new SqlCommand("Select * from ParticipantForm order by Points desc", con);
            //cmd = new SqlCommand("Select * from ParticipantForm order by First_name asc", con);
            cmd = new SqlCommand("Select * from ParticipantForm order by Age_group asc", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Load_data();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from ParticipantForm where Start_number Like @search + '%'or First_name Like @search + '%'or" +
                " Last_name Like @search + '%'or Age_group Like @search + '%'or Race_nr Like @search + '%'or Distance_result Like @search + '%'", con);
            cmd.Parameters.AddWithValue("search",txtSearch.Text);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            new ViewReports().Show();
            this.Hide();
        }
    }
}