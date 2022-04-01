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
    public partial class Idept_Form : Form
    {
        public Idept_Form()
        {
            InitializeComponent();
        }

        private void load()
        {
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.Department", LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable DepartmentTable = new DataTable();
            DepartmentTable.Load(SqlOutput);
            DepartmentGridView.DataSource = DepartmentTable;
        }

        private void Idept_Form_Load(object sender, EventArgs e)
        {
            load();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text == "" || loc_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the full data");
            }
            else
            {
                SqlCommand Insert_Department = new SqlCommand("exec dbo.Department_Insert '" +
                                                            name_textBox.Text + "','" +
                                                            loc_textBox.Text + "'", LogInForm.Connection);

                int Affected_Rows = Insert_Department.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " rows inserted.");
                id_textBox.Text = name_textBox.Text = loc_textBox.Text = string.Empty;
                load();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "" || name_textBox.Text == "" || loc_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the full data");
            }
            else
            {
                SqlCommand Update_Department = new SqlCommand("exec dbo.Department_Update '" +
                                                            id_textBox.Text + "','" +
                                                            name_textBox.Text + "','" +
                                                            loc_textBox.Text + "'", LogInForm.Connection);

                int Affected_Rows = Update_Department.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " rows updated.");
                id_textBox.Text = name_textBox.Text = loc_textBox.Text = string.Empty;
                load();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the ID of the department");
            }
            else
            {
                SqlCommand Delete_Department = new SqlCommand("exec dbo.Department_Delete '" + int.Parse(id_textBox.Text) + "'", LogInForm.Connection);
                int Affected_Rows = Delete_Department.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " rows deleted.");
                id_textBox.Text = name_textBox.Text = loc_textBox.Text = string.Empty;
                load();
            }
        }

        private void DepartmentGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Row = DepartmentGridView.Rows[e.RowIndex];
            id_textBox.Text = Row.Cells["ID"].Value.ToString();
            name_textBox.Text = Row.Cells["Name"].Value.ToString();
            loc_textBox.Text = Row.Cells["Location"].Value.ToString();
        }
    }
}
