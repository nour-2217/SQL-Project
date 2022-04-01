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
    public partial class Std_MainForm : Form
    {
        Color color;
        private Button currentButton;
        private Form activeForm;
        public Std_MainForm()
        {
            InitializeComponent();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelmenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(255, 107, 107);
                    previousBtn.ForeColor = Color.FromArgb(128, 0, 0);
                    previousBtn.Font = new Font("Trebuchet MS", 12.25F, FontStyle.Bold, GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktop_panel.Controls.Add(childForm);
            this.desktop_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Exam_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Stdexam_Form(), sender);
        }

        private void Topic_btn_Click(object sender, EventArgs e)
        {
            StTopics sto = new StTopics();
            sto.Show();
            SqlCommand Command = new SqlCommand("exec dbo.Student_Topic_Grade '" +
                                                            LogInForm.ID + "'"
                                                            , LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable Student_Topic_GradeTable = new DataTable();
            Student_Topic_GradeTable.Load(SqlOutput);
            sto.std.DataSource = Student_Topic_GradeTable;
        }

        private void CloseAppbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
