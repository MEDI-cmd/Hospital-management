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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            if(Login.Role == "Receptionist")
            {
                ReceLbl.Enabled = false;
                DoctorLbl.Enabled = false;
            }
            CountPatients();
            CountDoctors();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-P5OFD15\SQLEXPRESS;Integrated Security=True");
        private void CountPatients()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from PatientTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatNumLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountDoctors()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from DoctorTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DoctorLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Doctors obj = new Doctors();
            obj.Show();
            this.Hide();
        }

        private void PatLbl_Click(object sender, EventArgs e)
        {
            Pacients obj = new Pacients();
            obj.Show();
            this.Hide();
        }

        private void ReceLbl_Click(object sender, EventArgs e)
        {
            Receptionists obj = new Receptionists();
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
