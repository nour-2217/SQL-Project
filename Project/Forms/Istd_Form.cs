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
    public partial class Istd_Form : Form
    {
        public Istd_Form()
        {
            InitializeComponent();
            pass_textBox.Enabled = false;
        }
        private void load ()
        {
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.Student", LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable StudentTable = new DataTable();
            StudentTable.Load(SqlOutput);
            StudentGridView.DataSource = StudentTable;
        }
        private void Istd_Form_Load(object sender, EventArgs e)
        {
            load();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (fname_textBox.Text == "" || Lname_textBox.Text == "" || gender_textBox.Text == "" || phone_textBox.Text == "" || pass_textBox.Text == "")
                MessageBox.Show("Please , Enter The data");
            else
            {
                SqlCommand InsertStudents = new SqlCommand("exec dbo.Student_Insert '" +
                                                       fname_textBox.Text + "','" +
                                                       Lname_textBox.Text + "','" +
                                                       dateTimePicker1.Value.Date + "','" +
                                                       gender_textBox.Text + "','" +
                                                       phone_textBox.Text + "','" +
                                                       pass_textBox.Text + "'", LogInForm.Connection);

                int affectedRows = InsertStudents.ExecuteNonQuery();
                MessageBox.Show(affectedRows.ToString() + " Rows Inserted");
                id_textBox.Text =
                fname_textBox.Text =
                Lname_textBox.Text =
                gender_textBox.Text =
                phone_textBox.Text =
                pass_textBox.Text = string.Empty;
                load();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "")
                MessageBox.Show("Please , Enter The id");
            else
            {
                SqlCommand DeleteStudents = new SqlCommand("exec dbo.Student_Delete " + int.Parse(id_textBox.Text), LogInForm.Connection);
                int affectedRows = DeleteStudents.ExecuteNonQuery();
                MessageBox.Show(affectedRows.ToString() + " Rows Deleted");
                id_textBox.Text = string.Empty;
                load();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text==""|| fname_textBox.Text == "" || Lname_textBox.Text == "" || gender_textBox.Text == "" || phone_textBox.Text == "" || pass_textBox.Text == "")
                MessageBox.Show("Please , Enter The data");
            else
            {
                SqlCommand UpadteStudents = new SqlCommand("exec dbo.Student_Update " +
                                                      id_textBox.Text + ",'" +
                                                      fname_textBox.Text + "','" +
                                                      Lname_textBox.Text + "','" +
                                                      dateTimePicker1.Value.Date + "','" +
                                                      gender_textBox.Text + "','" +
                                                      phone_textBox.Text + "','" +
                                                      pass_textBox.Text + "'", LogInForm.Connection);

                int affectedRows = UpadteStudents.ExecuteNonQuery();
                MessageBox.Show(affectedRows.ToString() + " Rows Updated");
                id_textBox.Text =
                fname_textBox.Text =
                Lname_textBox.Text =
                gender_textBox.Text =
                phone_textBox.Text =
                pass_textBox.Text = string.Empty;
                load();
            }
           
        }

        private void StudentGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = StudentGridView.CurrentCell.RowIndex;

            id_textBox.Text = StudentGridView.Rows[rowindex].Cells[0].Value.ToString();
            fname_textBox.Text = StudentGridView.Rows[rowindex].Cells[1].Value.ToString();
            Lname_textBox.Text = StudentGridView.Rows[rowindex].Cells[2].Value.ToString();
            gender_textBox.Text = StudentGridView.Rows[rowindex].Cells[4].Value.ToString();
            phone_textBox.Text = StudentGridView.Rows[rowindex].Cells[5].Value.ToString();
            pass_textBox.Text = StudentGridView.Rows[rowindex].Cells[6].Value.ToString();
            age_textBox.Text = StudentGridView.Rows[rowindex].Cells[7].Value.ToString();
        }
        public string stid
        {
            get
            {
                return id_textBox.Text;
            }
        }
       

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Sedit_Form Sedit_form = new Sedit_Form();
            Sedit_form.Show();
            Sedit_form.setid = id_textBox.Text;
            Sedit_form.name = fname_textBox.Text;
            SqlCommand Command1 = new SqlCommand("Topic_SelectAll", LogInForm.Connection);
            SqlDataReader SqlOutput1 = Command1.ExecuteReader();
            DataTable ID_TopicTable = new DataTable();
            ID_TopicTable.Load(SqlOutput1);
            foreach (DataRow dr in ID_TopicTable.Rows)
            {
                Sedit_form.cid.Items.Add(dr[0]);
            }
            SqlOutput1.Close();
            SqlCommand Command = new SqlCommand("exec dbo.Student_Topic '" +
                                                            id_textBox.Text + "'"
                                                            , LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable Student_TopicTable = new DataTable();
            Student_TopicTable.Load(SqlOutput);
            Sedit_form.studatagrid.DataSource = Student_TopicTable;
        }
    }
}
