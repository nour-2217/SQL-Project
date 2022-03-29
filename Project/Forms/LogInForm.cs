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
                Ins_MainForm I_mainForm = new Ins_MainForm();
                I_mainForm.Show();
                this.Hide();
            }

            else if (Std_radioButton.Checked == true)
            {
                Std_MainForm S_mainForm = new Std_MainForm();
                S_mainForm.Show();
                this.Hide();
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
