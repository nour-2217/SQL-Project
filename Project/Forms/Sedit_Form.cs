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

namespace Project.Forms
{
    public partial class Sedit_Form : Form
    {
        public Sedit_Form()
        {
            InitializeComponent();
        }

        private void load()
        {
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.Students_Takes_Topics", LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable CourseTable = new DataTable();
            CourseTable.Load(SqlOutput);
            StdEditGridView.DataSource = CourseTable;
        }

        private void Sedit_Form_Load(object sender, EventArgs e)
        {
            load();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "" || name_textBox.Text == "" || topic_textBox.Text == "" || grade_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the full data");
            }
            else
            {
                SqlCommand Insert_Std_Take = new SqlCommand("exec dbo.Students_Takes_Topics_Insert " +
                                                            id_textBox.Text + ",'" +
                                                            name_textBox.Text + "','" +
                                                            topic_textBox.Text + "','" +
                                                            grade_textBox.Text + "'", LogInForm.Connection);

                int Affected_Rows = Insert_Std_Take.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " Rows insertedd.");
                id_textBox.Text = name_textBox.Text = topic_textBox.Text = grade_textBox.Text = string.Empty;
                load();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the ID of the student");
            }
            else
            {
                SqlCommand Delete_Std_Take = new SqlCommand("exec dbo.Students_Takes_Topics_Delete" + int.Parse(id_textBox.Text), LogInForm.Connection);
                int Affected_Rows = Delete_Std_Take.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " Rows deleted.");
                id_textBox.Text = name_textBox.Text = topic_textBox.Text = grade_textBox.Text = string.Empty;
                load();
            }
        }
    }
}
