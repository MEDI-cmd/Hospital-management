﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bardha
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RoleCb.SelectedIndex = 0;
            UnameTb.Text = "";
            PassTb.Text = "";
        }

        private void RoleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-P5OFD15\SQLEXPRESS;Integrated Security=True");
        public static string Role;
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select Your Position");
            }
            else if (RoleCb.SelectedIndex == 0)
            {
                if (UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Admin Name and Passwprd");

                }
                else if(UnameTb.Text == "Admin" && PassTb.Text == "Password")
                {
                    Role = "Admin";
                    Pacients Obj = new Pacients();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Enter Both Doctor Name andPassword");
                }


            }
            else if (RoleCb.SelectedIndex == 1)
            {
                if (UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Doctor Name and Passwprd");

                }

                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DoctorTbl where DocName='" + UnameTb.Text + "' and DocPass='" + PassTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Doctor";
                        Presciptions obj = new Presciptions();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Doctor Not found");
                    }
                    Con.Close();

                }
            }
            else
            {
                if (UnameTb.Text == "" || PassTb.Text == "")
                {
                    MessageBox.Show("Enter Both Receptionist Name and Passwprd");

                }

                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from ReceptionistTbl where RecepName='" + UnameTb.Text + "' and RecepPass='" + PassTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Receptionist";
                        Home obj = new Home();
                        obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Receptionist Not found");
                    }
                    Con.Close();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
