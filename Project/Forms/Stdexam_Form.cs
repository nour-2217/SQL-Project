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

namespace Project.Forms
{
    public partial class Stdexam_Form : Form
    {
        DataTable Exams;
        Examination ExamForm;
        List<int> ChoiceIndex;
        List<CheckedListBox> ChoiceContainer;
        int ExamID;
        int TimeElapsed;
        public Stdexam_Form()
        {
            InitializeComponent();
            Exams = new DataTable();
            ChoiceIndex = new List<int>();
            ChoiceContainer = new List<CheckedListBox>();
        }
        private void GetAvailableExams()
        {
            flowLayoutPanel1.Controls.Clear();
            string Statement = $"GetAvailableExam {LogInForm.ID}";
            SqlCommand Command = new SqlCommand(Statement, LogInForm.Connection);
            Exams.Load(Command.ExecuteReader());
            foreach(DataRow Exam in Exams.Rows)
            {
                Button ExamBtn = new Button();
                ExamBtn.Text = $"Examine {Exam["Name"].ToString()}";
                ExamBtn.Width = 200;
                ExamBtn.Height = 50;
                ExamBtn.Left = 100;
                flowLayoutPanel1.Controls.Add(ExamBtn);
                ExamBtn.Click += (S, E) =>
                {
                    int ID = int.Parse(Exams.Rows[flowLayoutPanel1.Controls.IndexOf(((Button)S))]["ID"].ToString());
                    int Duration = int.Parse(Exams.Rows[flowLayoutPanel1.Controls.IndexOf(((Button)S))]["Duration"].ToString());
                    string Topic = Exams.Rows[flowLayoutPanel1.Controls.IndexOf(((Button)S))]["Name"].ToString();
                    Examine(ID, Duration, Topic);
                };
            }
        }

        private void sexam_Form_Load(object sender, EventArgs e)
        {
            GetAvailableExams();
        }

        private void Examine(int ID, int Duration, string Topic)
        {
            TimeElapsed = 0;
            ExamID = ID;
            ChoiceIndex.Clear();
            ChoiceIndex.Clear();
            ChoiceContainer.Clear();
            ExamForm = new Examination();
            string Statement = $"GetQuestions {ID}";
            SqlCommand Command = new SqlCommand(Statement, LogInForm.Connection);
            DataTable Questions = new DataTable();
            Questions.Load(Command.ExecuteReader());
            int QID = 0;
            Label ClockLabel = new Label();
            ClockLabel.Text = "0 mins";
            ExamForm.flowLayoutPanel1.Controls.Add(ClockLabel);
            ExamForm.flowLayoutPanel1.Controls.Add(new Label() { Text = $"{Topic} - Exam - {Duration} mins", Width = 700, Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point) });
            foreach(DataRow Question in Questions.Rows)
            {
                DataTable Choices = new DataTable();
                Statement = $"Choice_Select null, {Question["ID"].ToString()}";
                Command = new SqlCommand(Statement, LogInForm.Connection);
                Choices.Load(Command.ExecuteReader());
                ExamForm.flowLayoutPanel1.Controls.Add(new Label() { Text = $"{++QID}- {Question["Description"].ToString()}", Width = 700 });
                CheckedListBox Box= new CheckedListBox()
                {   
                    Width = 700, 
                    BackColor = Color.FromArgb(247, 175, 157), 
                    BorderStyle = BorderStyle.None
                };
                Box.SelectedIndexChanged += (Sender, Event) =>
                {
                    if(Box.SelectedIndex != -1)
                    {
                        int ID = Box.SelectedIndex;
                        int Count = Box.Items.Count;
                        for(int i =0; i<Count; i++)
                        {
                            Box.SetItemCheckState(i, CheckState.Unchecked);
                        }
                        Box.SetItemCheckState(ID, CheckState.Checked);
                    }
                };
                Box.Width = 550;
                int CID = 0;
                foreach (DataRow Choice in Choices.Rows)
                {
                    Box.Items.Add($"{++CID}- {Choice["Description"].ToString()}");
                    ChoiceIndex.Add(int.Parse(Choice["ID"].ToString()));
                }
                ChoiceContainer.Add(Box);
                ExamForm.flowLayoutPanel1.Controls.Add(Box);
            }
            Button Submit = new Button() { Text = "Submit", Width = 100 };
            Submit.Click += (Obj, Event) => 
            {   
                int ID = 0;
                foreach(CheckedListBox Box in ChoiceContainer)
                {
                    foreach(int CheckedInd in Box.CheckedIndices)
                    {
                        Statement = $"AnswerExam {LogInForm.ID}, {ExamID}, {ChoiceIndex[ID + CheckedInd]}";
                        Command = new SqlCommand(Statement, LogInForm.Connection);
                        Command.ExecuteNonQuery();
                    }
                    ID += Box.Items.Count;
                }
                flowLayoutPanel1.Controls.Clear();
                ExamForm.Close();
            };
            ExamForm.flowLayoutPanel1.Controls.Add(Submit);
            ExamForm.Show();
            Timer Clock = new Timer();
            Clock.Interval = 60000;
            Clock.Enabled = true;
            Clock.Tick += (S, E) =>
            {
                TimeElapsed++;
                ClockLabel.Text = $"{TimeElapsed} mins";
                if (TimeElapsed >= Duration)
                {
                    Clock.Stop();
                    Clock.Enabled = false;
                    Submit.PerformClick();
                }
            };
            Clock.Start();
        }
    }
}
