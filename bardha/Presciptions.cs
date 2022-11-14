using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bardha
{
    public partial class Presciptions : Form
    {
        public Presciptions()
        {
            InitializeComponent();
            DisplayPrescription();
            GetDocId();
            GetPatId();
            GetDocName();
            GetPatName();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-P5OFD15\SQLEXPRESS;Integrated Security=True");
        private void DisplayPrescription()
        {
            Con.Open();
            string Query = "Select * from PrescriptionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PrescriptionDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DocIdCb.SelectedIndex = 0;
            PatIdCb.SelectedIndex = 0;

            DocNameTb.Text = "";
            PatNameTb.Text = "";

            // Key = 0;
        }

        private void GetDocName()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl where DocId=" + DocIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DocNameTb.Text = dr["DocName"].ToString();
            }
            Con.Close();
        }

        private void GetPatName()
        {
            Con.Open();
            string Query = "Select * from PatientTbl where PatId=" + PatIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PatNameTb.Text = dr["PatName"].ToString();
            }
            Con.Close();
        }
        private void GetDocId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select DocId from DoctorTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DocId", typeof(int));
            dt.Load(rdr);
            DocIdCb.ValueMember = "DocId";
            DocIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetPatId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select PatId from PatientTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PatId", typeof(int));
            dt.Load(rdr);
            PatIdCb.ValueMember = "PatId";
            PatIdCb.DataSource = dt;
            Con.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Presciptions_Load(object sender, EventArgs e)
        {

        }

        private void DocIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDocName();
        }

        private void PatIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPatName();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "" || DocNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into PrescriptionTbl(DocId,DocName,PatId,PatName,Medicines,Cost)values(@DI,@DN,@PI,@PN,@Med,@Co)", Con);
                    cmd.Parameters.AddWithValue("@DI", DocIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", DocNameTb.Text);
                    cmd.Parameters.AddWithValue("@PI", PatIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PatNameTb.Text);
                    cmd.Parameters.AddWithValue("@Med", MedTb.Text);
                    cmd.Parameters.AddWithValue("@Co", CostTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Prescription Added");
                    Con.Close();
                    DisplayPrescription();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PrescriptionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrescSumTab.Text = "";
            PrescSumTab.Text = "                            PhysionLine\n\n" + "                            PRESCRIPTION                           " + "\n*********************************************" + "\n" + DateTime.Today.Date + "\n\n\n\n             Doctor:  " + PrescriptionDGV.SelectedRows[0].Cells[2].Value.ToString() + "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    } 
}

