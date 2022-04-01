﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class Itopic_Form : Form
    {
        public Itopic_Form()
        {
            InitializeComponent();
        }

        private void load()
        {
            SqlCommand Command = new SqlCommand("SELECT * FROM dbo.Topic", LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable TopicTable = new DataTable();
            TopicTable.Load(SqlOutput);
            TopicGridView.DataSource = TopicTable;
        }

        private void Itopic_Form_Load(object sender, EventArgs e)
        {
            load();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "" || name_textBox.Text == "" || course_textBox.Text == "" || duration_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the full data");
            }
            else
            {
                SqlCommand Insert_Topic = new SqlCommand("exec dbo.Topic_Insert " +
                                                            id_textBox.Text + ",'" +
                                                            name_textBox.Text + "','" +
                                                            course_textBox.Text + "','" +
                                                            duration_textBox + "'", LogInForm.Connection);

                int Affected_Rows = Insert_Topic.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " Rows insertedd.");
                id_textBox.Text = name_textBox.Text = course_textBox.Text = duration_textBox.Text = string.Empty;
                load();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "" || name_textBox.Text == "" || course_textBox.Text == "" || duration_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the full data");
            }
            else
            {
                SqlCommand Update_Topic = new SqlCommand("exec dbo.Topic_Update " +
                                                            id_textBox.Text + ",'" +
                                                            name_textBox.Text + "','" +
                                                            course_textBox.Text + "','" +
                                                            duration_textBox + "'", LogInForm.Connection);

                int Affected_Rows = Update_Topic.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " Rows updated.");
                id_textBox.Text = name_textBox.Text = course_textBox.Text = duration_textBox.Text = string.Empty;
                load();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (id_textBox.Text == "")
            {
                MessageBox.Show("Please, Enter the ID of the topic");
            }
            else
            {
                SqlCommand Delete_Topic = new SqlCommand("exec dbo.Topic_Delete" + int.Parse(id_textBox.Text) , LogInForm.Connection);
                int Affected_Rows = Delete_Topic.ExecuteNonQuery();
                MessageBox.Show(Affected_Rows.ToString() + " Rows deleted.");
                id_textBox.Text = name_textBox.Text = course_textBox.Text = duration_textBox.Text = string.Empty;
                load();
            }
            
        }

       
    }
}