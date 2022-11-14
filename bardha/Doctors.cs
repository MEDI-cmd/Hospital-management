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
    public partial class Doctors : Form
    {
        private Button EditBtn;
        private Button AddBtn;
        private Button DelBtn;
        private Label label14;
        private Label label13;
        private TextBox DocAddTb;
        private Label label9;
        private TextBox DocPhoneTb;
        private Label label8;
        private TextBox DocExpTb;
        private DateTimePicker DOcDOB;
        private ComboBox DocGenCb;
        private TextBox DNameTb;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox1;
        private PictureBox pictureBox9;
        private PictureBox pictureBox5;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox11;
        private Label label12;
        private PictureBox pictureBox12;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private DataGridView DoctorsDGV;
        private TextBox DocPassWordTb;

        public Doctors()
        {
            InitializeComponent();
            DisplayDoc();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-P5OFD15\SQLEXPRESS;Integrated Security=True");
        private void DisplayDoc()
        {
            Con.Open();
            string Query = "Select * from DoctorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DoctorsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DNameTb.Text = "";
            DocPhoneTb.Text = "";
            DocAddTb.Text = "";
            DocExpTb.Text = "";
            DocPassWordTb.Text = "";
            DocGenCb.SelectedIndex = 0;
            Key = 0;
        }

        private void Doctors_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DocAddTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DocPhoneTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DocExpTb = new System.Windows.Forms.TextBox();
            this.DOcDOB = new System.Windows.Forms.DateTimePicker();
            this.DocGenCb = new System.Windows.Forms.ComboBox();
            this.DNameTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DocPassWordTb = new System.Windows.Forms.TextBox();
            this.DoctorsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Green;
            this.EditBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.ForeColor = System.Drawing.Color.White;
            this.EditBtn.Location = new System.Drawing.Point(712, 261);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(94, 39);
            this.EditBtn.TabIndex = 91;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Black;
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(610, 261);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 39);
            this.AddBtn.TabIndex = 90;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.Blue;
            this.DelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(508, 261);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(94, 39);
            this.DelBtn.TabIndex = 89;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = false;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(867, 85);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 21);
            this.label14.TabIndex = 87;
            this.label14.Text = "Notes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(629, 85);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 21);
            this.label13.TabIndex = 86;
            this.label13.Text = "Experience";
            // 
            // DocAddTb
            // 
            this.DocAddTb.Location = new System.Drawing.Point(867, 112);
            this.DocAddTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DocAddTb.Multiline = true;
            this.DocAddTb.Name = "DocAddTb";
            this.DocAddTb.Size = new System.Drawing.Size(261, 119);
            this.DocAddTb.TabIndex = 85;
            this.DocAddTb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(407, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 21);
            this.label9.TabIndex = 84;
            this.label9.Text = "DOB";
            // 
            // DocPhoneTb
            // 
            this.DocPhoneTb.Location = new System.Drawing.Point(222, 177);
            this.DocPhoneTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DocPhoneTb.Name = "DocPhoneTb";
            this.DocPhoneTb.Size = new System.Drawing.Size(151, 23);
            this.DocPhoneTb.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(219, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 82;
            this.label8.Text = "Phones";
            // 
            // DocExpTb
            // 
            this.DocExpTb.Location = new System.Drawing.Point(629, 112);
            this.DocExpTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DocExpTb.Name = "DocExpTb";
            this.DocExpTb.Size = new System.Drawing.Size(177, 23);
            this.DocExpTb.TabIndex = 81;
            // 
            // DOcDOB
            // 
            this.DOcDOB.Location = new System.Drawing.Point(407, 177);
            this.DOcDOB.Name = "DOcDOB";
            this.DOcDOB.Size = new System.Drawing.Size(200, 23);
            this.DOcDOB.TabIndex = 80;
            // 
            // DocGenCb
            // 
            this.DocGenCb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DocGenCb.FormattingEnabled = true;
            this.DocGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.DocGenCb.Location = new System.Drawing.Point(407, 106);
            this.DocGenCb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DocGenCb.Name = "DocGenCb";
            this.DocGenCb.Size = new System.Drawing.Size(124, 29);
            this.DocGenCb.TabIndex = 79;
            this.DocGenCb.Text = "Gender";
            // 
            // DNameTb
            // 
            this.DNameTb.Location = new System.Drawing.Point(222, 112);
            this.DNameTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DNameTb.Name = "DNameTb";
            this.DNameTb.Size = new System.Drawing.Size(151, 23);
            this.DNameTb.TabIndex = 78;
            this.DNameTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(219, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 77;
            this.label7.Text = "Doctor Name";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(63, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Logout";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 592);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(3, 260);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(45, 33);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 197);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(54, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Doctors";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(54, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 24);
            this.label11.TabIndex = 12;
            this.label11.Text = "Receptionists";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(3, 137);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(45, 33);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(54, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 24);
            this.label12.TabIndex = 10;
            this.label12.Text = "Pacients";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(4, 3);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(190, 80);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 4;
            this.pictureBox12.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.pictureBox12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 671);
            this.panel1.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(541, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 40);
            this.label2.TabIndex = 75;
            this.label2.Text = "PhysionLine";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1129, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(629, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 93;
            this.label1.Text = "Password";
            // 
            // DocPassWordTb
            // 
            this.DocPassWordTb.Location = new System.Drawing.Point(629, 177);
            this.DocPassWordTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DocPassWordTb.Name = "DocPassWordTb";
            this.DocPassWordTb.Size = new System.Drawing.Size(177, 23);
            this.DocPassWordTb.TabIndex = 92;
            // 
            // DoctorsDGV
            // 
            this.DoctorsDGV.AllowUserToAddRows = false;
            this.DoctorsDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DoctorsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorsDGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.DoctorsDGV.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.DoctorsDGV.Location = new System.Drawing.Point(200, 332);
            this.DoctorsDGV.Name = "DoctorsDGV";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DoctorsDGV.RowTemplate.Height = 25;
            this.DoctorsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorsDGV.Size = new System.Drawing.Size(944, 327);
            this.DoctorsDGV.TabIndex = 109;
            this.DoctorsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorsDGV_CellContentClick);
            // 
            // Doctors
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1156, 671);
            this.Controls.Add(this.DoctorsDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DocPassWordTb);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DocAddTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DocPhoneTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DocExpTb);
            this.Controls.Add(this.DOcDOB);
            this.Controls.Add(this.DocGenCb);
            this.Controls.Add(this.DNameTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Doctors_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Doctors_Load_1(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DocPassWordTb.Text == "" || DocPhoneTb.Text == "" || DocAddTb.Text == "" || DocGenCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DoctorTbl(DocName,DOCDOB,DOCGEN,DOCEXP,DOCPHONE,DOCADD,DOCPASS)values(@DN,@DD,@DG,@DE,@DP,@DA,@DPA)", Con);
                    cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    cmd.Parameters.AddWithValue("@DD", DOcDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", DocGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                    cmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                    cmd.Parameters.AddWithValue("@DPA", DocPassWordTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Added");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int Key = 0;
        private void DoctorsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DNameTb.Text = DoctorsDGV.SelectedRows[0].Cells[1].Value.ToString();
            DOcDOB.Text = DoctorsDGV.SelectedRows[0].Cells[2].Value.ToString();
            DocGenCb.SelectedItem = DoctorsDGV.SelectedRows[0].Cells[3].Value.ToString();
            DocExpTb.Text = DoctorsDGV.SelectedRows[0].Cells[4].Value.ToString();
            DocPhoneTb.Text = DoctorsDGV.SelectedRows[0].Cells[5].Value.ToString();
            DocPassWordTb.Text = DoctorsDGV.SelectedRows[0].Cells[6].Value.ToString();
            if (DNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DoctorsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            if (DNameTb.Text == "" || DocPassWordTb.Text == "" || DocPhoneTb.Text == "" || DocAddTb.Text == "" || DocGenCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update DoctorTbl set DocName=@DN,DOCDOB=@DD,DOCGEN=@DG,DOCEXP=@DE,DOCPHONE=@DP,DOCADD=@DA,DOCPASS=@DPA where DOCID=@DKey", Con);
                    cmd.Parameters.AddWithValue("@DN", DNameTb.Text);
                    cmd.Parameters.AddWithValue("@DD", DOcDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DG", DocGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DocExpTb.Text);
                    cmd.Parameters.AddWithValue("@DP", DocPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAddTb.Text);
                    cmd.Parameters.AddWithValue("@DPA", DocPassWordTb.Text);
                    cmd.Parameters.AddWithValue("@Dkey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Edit");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select The Doctor");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Delete from DoctorTbl Where DocId=@DKey", Con);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doctor Deleted");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
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
    }
}
