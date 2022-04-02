using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class Iins_Form : Form
    {
        public Iins_Form()
        {
            InitializeComponent();
        }
        public string ID
        {
            get
            {
                return id_textBox.Text;
            }
        }

        private void load()
        {
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.Instructor", LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable InstructorTable = new DataTable();
            InstructorTable.Load(SqlOutput);
            InstructorGridView.DataSource = InstructorTable;
        }

        private void Iins_Form_Load(object sender, EventArgs e)
        {
            load();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (fname_textBox.Text == "" || Lname_textBox.Text == "" || dob_textBox.Text == ""
                 || gender_textBox.Text == "" || phone_textBox.Text == "" || password_textBox.Text == "" || dept_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the full data");
            }
            else
            {
                SqlCommand Insert_Instructor = new SqlCommand("exec dbo.Instructor_Insert '" +
                                                            fname_textBox.Text + "','" +
                                                            Lname_textBox.Text + "','" +
                                                            gender_textBox.Text + "','" +
                                                            phone_textBox.Text + "','" +
                                                            password_textBox.Text + "','" +
                                                            Convert.ToDateTime(dob_textBox.Text) + "','" +
                                                            dept_textBox.Text + "'", LogInForm.Connection);

                int Affected_Rows = Insert_Instructor.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " rows inserted.");
                id_textBox.Text = fname_textBox.Text = Lname_textBox.Text = dob_textBox.Text = gender_textBox.Text
                     = phone_textBox.Text = password_textBox.Text = age_textBox.Text = dept_textBox.Text = string.Empty;
                load();
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Iedit_Form Iedit_form = new Iedit_Form();
            Iedit_form.Show();
            Iedit_form.setID = id_textBox.Text;
            Iedit_form.name = fname_textBox.Text;
            SqlCommand Command1 = new SqlCommand("Topic_SelectAll", LogInForm.Connection);
            SqlDataReader SqlOutput1 = Command1.ExecuteReader();
            DataTable ID_TopicTable = new DataTable();
            ID_TopicTable.Load(SqlOutput1);
            foreach (DataRow dr in ID_TopicTable.Rows)
            {
                Iedit_form.cid.Items.Add(dr[0]);
            }
            SqlOutput1.Close();
            SqlCommand Command = new SqlCommand("Instructor_Topic '" + id_textBox.Text + "'", LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable Instructor_TopicTable = new DataTable();
            Instructor_TopicTable.Load(SqlOutput);
            Iedit_form.iedit.DataSource = Instructor_TopicTable;
            //SqlOutput.Close();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "" || fname_textBox.Text == "" || Lname_textBox.Text == "" || dob_textBox.Text == ""
                 || gender_textBox.Text == "" || phone_textBox.Text == "" || password_textBox.Text == "" || dept_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the full data");
            }
            else
            {
                SqlCommand Update_Instructor = new SqlCommand("exec dbo.Instructor_Update '" +
                                                            id_textBox.Text + "','" +
                                                            fname_textBox.Text + "','" +
                                                            Lname_textBox.Text + "','" +
                                                            dob_textBox.Text + "','" +
                                                            gender_textBox.Text + "','" +
                                                            phone_textBox.Text + "','" +
                                                            password_textBox.Text + "','" +
                                                            dept_textBox.Text + "'", LogInForm.Connection);

                int Affected_Rows = Update_Instructor.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " rows updated.");
                id_textBox.Text = fname_textBox.Text = Lname_textBox.Text = dob_textBox.Text = gender_textBox.Text
                     = phone_textBox.Text = password_textBox.Text = age_textBox.Text = dept_textBox.Text = string.Empty;
                load();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the ID of the instructor");
            }
            else
            {
                SqlCommand Delete_Instructor = new SqlCommand("exec dbo.Instructor_Delete '" + int.Parse(id_textBox.Text) + "'", LogInForm.Connection);
                int Affected_Rows = Delete_Instructor.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " rows deleted.");
                id_textBox.Text = fname_textBox.Text = Lname_textBox.Text = dob_textBox.Text = gender_textBox.Text
                     = phone_textBox.Text = password_textBox.Text = age_textBox.Text = dept_textBox.Text = string.Empty;
                load();
            }
        }
        
        private void InstructorGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Row = InstructorGridView.Rows[e.RowIndex];
            id_textBox.Text = Row.Cells["ID"].Value.ToString();
            fname_textBox.Text = Row.Cells["FName"].Value.ToString();
            Lname_textBox.Text = Row.Cells["LName"].Value.ToString();
            gender_textBox.Text = Row.Cells["Gender"].Value.ToString() + " mins";
            phone_textBox.Text = Row.Cells["Phone"].Value.ToString();
            password_textBox.Text = Row.Cells["Pass"].Value.ToString();
            dob_textBox.Text = Row.Cells["DoB"].Value.ToString();
            age_textBox.Text = Row.Cells["Age"].Value.ToString();
            dept_textBox.Text = Row.Cells["Department_FK"].Value.ToString();

        }
    }
}
