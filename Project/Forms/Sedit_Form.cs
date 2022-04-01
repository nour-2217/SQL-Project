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
        public string setid
        {
            set
            {
                id_textBox.Text = value;
            }
            get
            {
                return id_textBox.Text;
            }
        }
        public  DataGridView studatagrid
        {
            get
            {
                return StdEditGridView;
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
        }

        private void Sedit_Form_Load(object sender, EventArgs e)
        {
            id_textBox.Enabled = false;
            name_textBox.Enabled = false;
            load();

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the full data");
            }
            else
            {
                SqlCommand Insert_Std_Take = new SqlCommand("exec dbo.Students_Takes_Topics_Insert '" +
                                                            id_textBox.Text + "','" +
                                                            comboBox1.SelectedItem.ToString() + "'"
                                                            , LogInForm.Connection);

                int Affected_Rows = Insert_Std_Take.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " Rows insertedd.");
                comboBox1.Text = grade_textBox.Text = string.Empty;
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
                name_textBox.Text = comboBox1.Text = grade_textBox.Text = string.Empty;
                load();
            }
        }
    }
}
