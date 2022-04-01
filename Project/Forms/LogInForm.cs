using Project.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public enum Role {Admin, Instructor, Student, none };
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            Connection.Open();
        }

        private void logIn_btn_Click(object sender, EventArgs e)
        {
            if (Ins_radioButton.Checked == true)
            {
                string Statement = $"CheckPassword {1}, '{textBox1.Text}', '{textBox2.Text}'";
                SqlCommand Command = new SqlCommand(Statement, LogInForm.Connection);
                SqlDataReader SqlOutput = Command.ExecuteReader();
                DataTable UserLogin = new DataTable();
                UserLogin.Load(SqlOutput);
                if(UserLogin.Rows.Count == 1)
                {
                    Ins_MainForm I_mainForm = new Ins_MainForm();
                    I_mainForm.Show();
                    LoggedInRole = UserLogin.Rows[0]["Admin"].ToString() == "True" ? Role.Admin : Role.Instructor;
                    ID = int.Parse(UserLogin.Rows[0]["ID"].ToString());
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                }
            }

            else if (Std_radioButton.Checked == true)
            {
                string Statement = $"CheckPassword {2}, '{textBox1.Text}', '{textBox2.Text}'";
                SqlCommand Command = new SqlCommand(Statement, LogInForm.Connection);
                SqlDataReader SqlOutput = Command.ExecuteReader();
                DataTable UserLogin = new DataTable();
                UserLogin.Load(SqlOutput);
                if (UserLogin.Rows.Count == 1)
                {
                    Std_MainForm S_mainForm = new Std_MainForm();
                    S_mainForm.Show();
                    ID = int.Parse(UserLogin.Rows[0]["ID"].ToString());
                    LoggedInRole = Role.Student;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!");
                }
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
