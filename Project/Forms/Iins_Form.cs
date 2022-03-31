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

        
    }
}
