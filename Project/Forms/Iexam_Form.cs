using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project.Forms
{
    public partial class Iexam_Form : Form
    {
        List<int> EIndex = new List<int>();
        List<int> TIndex = new List<int>();

        public Iexam_Form()
        {
            InitializeComponent();
            ExamTimeInput.Format = DateTimePickerFormat.Custom;
            ExamTimeInput.CustomFormat = "HH:mm:ss tt";
        }

        private void Iexam_Form_Load(object sender, EventArgs e)
        {
            GetExam("GetExam null, null");
            EIndex.Clear();
            TIndex.Clear();
            TopicExamList.Items.Clear();
            TopicExamFilter.Items.Clear();
            TopicExamFilter.Items.Add("All");
            SqlCommand Command = new SqlCommand("SELECT ID FROM Exam", LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable AllTable = new DataTable();
            AllTable.Load(SqlOutput);
            foreach (DataRow Row in AllTable.Rows)
            {
                EIndex.Add(int.Parse(Row["ID"].ToString()));
            }
            Command = new SqlCommand("SELECT ID, Name FROM Topic", LogInForm.Connection);
            SqlOutput = Command.ExecuteReader();
            AllTable = new DataTable();
            AllTable.Load(SqlOutput);
            foreach(DataRow Row in AllTable.Rows)
            {
                TIndex.Add(int.Parse(Row["ID"].ToString()));
                TopicExamList.Items.Add(Row["Name"].ToString());
                TopicExamFilter.Items.Add(Row["Name"].ToString());
            }
        }

        private void GetExam(string Statement)
        {
            SqlCommand Command = new SqlCommand(Statement, LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable ExamTable = new DataTable();
            ExamTable.Load(SqlOutput);
            dataGridView1.DataSource = ExamTable;
            dataGridView1.Columns["ID"].Visible = dataGridView1.Columns["Topic_FK"].Visible = false;
            ExamIDOutput.Text =
            DateTimeOutput.Text =
            DurationExamOutput.Text =
            QuestionExamOutput.Text =
            TopicExamOutput.Text =
            TopicExamList.Text =
            McQExamInput.Text =
            ToFExamInput.Text =
            DurationExamInput.Text =
            ExamTimeInput.Text = 
            ExamDateInput.Text = String.Empty;
            dataGridView2.DataSource = null;
        }

        private void GetQuestions(string ID)
        {
            SqlCommand Command = new SqlCommand("GetQuestions "+ID, LogInForm.Connection);
            SqlDataReader SqlOutput = Command.ExecuteReader();
            DataTable QuestionTable = new DataTable();
            QuestionTable.Load(SqlOutput);
            dataGridView2.DataSource = QuestionTable;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Row = dataGridView1.Rows[e.RowIndex];
            ExamIDOutput.Text = Row.Cells["ID"].Value.ToString();
            TopicExamOutput.Text = Row.Cells["Topic_Name"].Value.ToString();
            QuestionExamOutput.Text = Row.Cells["QNo"].Value.ToString();
            DurationExamOutput.Text = Row.Cells["Duration"].Value.ToString() + " mins";
            DateTimeOutput.Text = Row.Cells["Date"].Value.ToString();
            GetQuestions(ExamIDOutput.Text);
        }

        private void TopicExamFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox List = (ComboBox)sender;
            string Statement = List.SelectedIndex == 0 ? "GetExam null, null" : $"GetExam null, {TIndex[List.SelectedIndex - 1]}";
            GetExam(Statement);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string Time = String.Join("", ExamTimeInput.Text.Split(new String[] { " PM" }, StringSplitOptions.RemoveEmptyEntries));
                string Statement = $"GenerateExam {TIndex[TopicExamList.SelectedIndex]}, {McQExamInput.Text}, {ToFExamInput.Text}, {DurationExamInput.Text}, '{ExamDateInput.Value.ToShortDateString()} {Time}'";
                MessageBox.Show(Statement);
                SqlCommand Command = new SqlCommand(Statement, LogInForm.Connection);
                int Flag = int.Parse(Command.ExecuteScalar().ToString());
                switch (Flag)
                {
                    case 1:
                        MessageBox.Show("Added Successfully!");
                        break;
                    case 0:
                        MessageBox.Show("McQ or ToF Amount Exceeds Available Bank!");
                        break;
                    case -1:
                        MessageBox.Show("Please check your Input Fields!");
                        break;
                }
                GetExam("GetExam null, null");
            }
            catch(Exception Obj)
            {
                MessageBox.Show(Obj.Message);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string Statement = $"CheckExamFK {ExamIDOutput.Text}";
                SqlCommand Command = new SqlCommand(Statement, LogInForm.Connection);
                int Flag = int.Parse(Command.ExecuteScalar().ToString());
                Statement = $"Exam_Delete {ExamIDOutput.Text}";
                Command = new SqlCommand(Statement, LogInForm.Connection);
                switch (Flag)
                {
                    case 0:
                        Command.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully!");
                        GetExam("GetExam null, null");
                        break;
                    case 1:
                        DialogResult Action = MessageBox.Show("Warning!", "This Exam has been taken by one or more students!", MessageBoxButtons.OKCancel);
                        switch (Action)
                        {
                            case DialogResult.OK:
                                Command.ExecuteNonQuery();
                                MessageBox.Show("Deleted Successfully!");
                                GetExam("GetExam null, null");
                                break;
                        }
                        break;
                }
            }
            catch (Exception Obj)
            {
                MessageBox.Show(Obj.Message);
            }
        }
    }
}
