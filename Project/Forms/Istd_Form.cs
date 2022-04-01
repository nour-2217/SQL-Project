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
