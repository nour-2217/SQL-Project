using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class Ins_MainForm : Form
    {
        Color color;
        private Button currentButton;
        private Form activeForm;
        public Ins_MainForm()
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
        private void Ins_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Iins_Form(), sender);
        }

        private void Std_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Istd_Form(), sender);
        }

        private void Department_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Idept_Form(), sender);
        }

        private void Course_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Icourse_Form(), sender);
        }

        private void Topic_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Itopic_Form(), sender);
        }

        private void Exam_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Iexam_Form(), sender);
        }

        private void Rep_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Irep_Form(), sender);
        }

        private void CloseAppbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Questions_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.QuestionsMainForm(), sender);
        }

        private void Choices_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.Choices(), sender);
        }
    }
}
