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
    public partial class Iedit_Form : Form
    {
        public Iedit_Form()
        {
            InitializeComponent();
        }
        public DataGridView iedit
        {
            get
            {
                return InsEditGridView;
            }
        }
        public string setID
        {
            get
            {
                return id_textBox.Text;
            }
            set
            {
                id_textBox.Text = value;
            }
        }
        public ComboBox cid
        {
            get
            {
                return comboBox1;
            }
        }
        public string name
        {
            get
            {
                return name_textBox.Text;
            }
            set
            {
                name_textBox.Text = value;
            }
        }

        private void load()
        {
            SqlCommand Command = new SqlCommand("Instructor_Topic '" +
                                                            id_textBox.Text + "'" 
                                                            
                                                            , LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable Instructor_TopicTable = new DataTable();
            Instructor_TopicTable.Load(SqlOutput);
            InsEditGridView.DataSource = Instructor_TopicTable;
        }

        private void Iedit_Form_Load(object sender, EventArgs e)
        {           
            load();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please, Enter the full data");
            }
            else
            {
                SqlCommand Command = new SqlCommand("Instructors_Teaches_Topics_Insert '" +
                                                                id_textBox.Text + "','" +
                                                                comboBox1.SelectedItem.ToString() + "'"
                                                                , LogInForm.Connection);
                SqlDataReader SqlOutput = Command.ExecuteReader();
                DataTable Instructors_Teaches_Topics_TopicTable = new DataTable();
                Instructors_Teaches_Topics_TopicTable.Load(SqlOutput);
                InsEditGridView.DataSource = Instructors_Teaches_Topics_TopicTable;
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
                SqlCommand Delete_Inst_Teach = new SqlCommand("exec dbo.Instructors_Teaches_Topics_Delete '" + id_textBox.Text + "','"+ comboBox1.SelectedItem.ToString()+"'", LogInForm.Connection);
                int Affected_Rows = Delete_Inst_Teach.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " Rows deleted.");
                comboBox1.Text = string.Empty;
                load();
            }
        }
    }
}
