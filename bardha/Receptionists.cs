using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace bardha
{
    public partial class Receptionists : Form
    {
        public Receptionists()
        {
            InitializeComponent();
            DisplayRec();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-P5OFD15\SQLEXPRESS;Integrated Security=True");
        private void Receptionists_Load(object sender, EventArgs e)

        {

        }
        private void DisplayRec()
        {
            Con.Open();
            string Query = "Select * from ReceptionistTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            RecepsionistDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void DelBtn_Click(object sender, EventArgs  e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Receptionist");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from ReceptionistTbl Where RecepId=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Deleted");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (RNameTb.Text == "" || RPassword.Text == "" || RPhoneTb.Text == "" || RAddressTb.Text == "")
                {
                MessageBox.Show("Missing Information");
           }else
           {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ReceptionistTbl(RecepName,Recepphone,RecepAdd,RecepPass)values(@RN,@RP,@RA,@RPA)", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RA", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Added");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }
        int Key = 0;
        private void RecepsionistDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RNameTb.Text = RecepsionistDGV.SelectedRows[0].Cells[1].Value.ToString();
            RPhoneTb.Text = RecepsionistDGV.SelectedRows[0].Cells[2].Value.ToString();
            RAddressTb.Text = RecepsionistDGV.SelectedRows[0].Cells[3].Value.ToString();
            RPassword.Text = RecepsionistDGV.SelectedRows[0].Cells[4].Value.ToString();
            if(RNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32( RecepsionistDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (RNameTb.Text == "" || RPassword.Text == "" || RPhoneTb.Text == "" || RAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update ReceptionistTbl set RecepName=@RN,Recepphone=@RP,RecepAdd=@RA,RecepPass=@RPA where RecepId=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RN", RNameTb.Text);
                    cmd.Parameters.AddWithValue("@RP", RPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@RA", RAddressTb.Text);
                    cmd.Parameters.AddWithValue("@RPA", RPassword.Text);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receptionist Updated");
                    Con.Close();
                    DisplayRec();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void Clear()
        {
            RNameTb.Text = "";
            RPassword.Text = "";
            RPhoneTb.Text = "";
            RAddressTb.Text = "";
            Key = 0;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
