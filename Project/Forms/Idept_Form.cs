﻿using System;
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
            if (id_textBox.Text == "" || name_textBox.Text == "" || loc_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the full data");
            }
            else
            {
                SqlCommand Insert_Department = new SqlCommand("exec dbo.Department_Insert " +
                                                            id_textBox.Text + ",'" +
                                                            name_textBox.Text + "','" +
                                                            loc_textBox + "'", LogInForm.Connection);

                int Affected_Rows = Insert_Department.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " Rows insertedd.");
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
                SqlCommand Update_Department = new SqlCommand("exec dbo.Department_Update " +
                                                            id_textBox.Text + ",'" +
                                                            name_textBox.Text + "','" +
                                                            loc_textBox + "'", LogInForm.Connection);

                int Affected_Rows = Update_Department.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " Rows updated.");
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
                SqlCommand Delete_Department = new SqlCommand("exec dbo.Department_Delete" + int.Parse(id_textBox.Text), LogInForm.Connection);
                int Affected_Rows = Delete_Department.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " Rows deleted.");
                id_textBox.Text = name_textBox.Text = loc_textBox.Text = string.Empty;
                load();
            }
        }

        
    }
}