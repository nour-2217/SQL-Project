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
    public partial class Icourse_Form : Form
    {
        public Icourse_Form()
        {
            InitializeComponent();
        }

        private void load()
        {
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.Course", LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable CourseTable = new DataTable();
            CourseTable.Load(SqlOutput);
            CourseGridView.DataSource = CourseTable;
        }

        private void Icourse_Form_Load(object sender, EventArgs e)
        {
            load();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the name of the course.");
            }
            else
            {
                SqlCommand Insert_Course = new SqlCommand("exec dbo.Course_Insert '" +
                                                            name_textBox.Text + "'", LogInForm.Connection);

                int Affected_Rows = Insert_Course.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " rows inserted.");
                id_textBox.Text = name_textBox.Text = duration_textBox.Text = string.Empty;
                load();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the name of the course.");
            }
            else
            {
                SqlCommand Update_Course = new SqlCommand("exec dbo.Course_Update '" +
                                                            id_textBox.Text + "','" +
                                                            name_textBox.Text + "'", LogInForm.Connection);

                int Affected_Rows = Update_Course.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " rows updated.");
                id_textBox.Text = name_textBox.Text = duration_textBox.Text = string.Empty;
                load();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the ID of the course");
            }
            else
            {
                SqlCommand Delete_Course = new SqlCommand("exec dbo.Course_Delete '" + int.Parse(id_textBox.Text) + "'", LogInForm.Connection);
                int Affected_Rows = Delete_Course.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " rows deleted.");
                id_textBox.Text = name_textBox.Text = duration_textBox.Text = string.Empty;
                load();
            }
        }

        private void CourseGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Row = CourseGridView.Rows[e.RowIndex];
            id_textBox.Text = Row.Cells["ID"].Value.ToString();
            name_textBox.Text = Row.Cells["Name"].Value.ToString();
            duration_textBox.Text = Row.Cells["Duration"].Value.ToString() + " mins";
        }
    }
}
