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
    public partial class QuestionsMainForm : Form
    {
        private void QuestionsCallUpdates()
        {
            SqlCommand GetQuestions = new SqlCommand("SELECT * FROM dbo.Question", LogInForm.Connection);
            SqlDataReader QuestionsGridSource = GetQuestions.ExecuteReader();
            DataTable QuestionTable = new DataTable();
            QuestionTable.Load(QuestionsGridSource);
            QuestionsGrid.DataSource = QuestionTable;
        }
        public QuestionsMainForm()
        {
            InitializeComponent();
        }

        private void QuestionsGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Row = QuestionsGrid.Rows[e.RowIndex];

            ID.Text = Row.Cells["ID"].Value.ToString();
            Type.Text = Row.Cells["Type"].Value.ToString();
            Description.Text = Row.Cells["Description"].Value.ToString();
            Topic.Text = Row.Cells["Topic_FK"].Value.ToString();
        }

        private void QuestionsMainForm_Load(object sender, EventArgs e)
        {
            QuestionsCallUpdates();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if(ID.Text == null || Type.Text == null || Topic.Text == null || Description.Text == null)
            {
                MessageBox.Show("Fill in the text boxes first");
            }
            else
            {
                string UpdateQuestionCommand = "dbo.Question_Update " + ID.Text + ", '" + Type.Text + "', \'" + Description.Text + "\', " + Topic.Text;
                MessageBox.Show(UpdateQuestionCommand);
                SqlCommand UpdateQuestion = new SqlCommand(UpdateQuestionCommand,
                    LogInForm.Connection);
                SqlDataReader Uqr = UpdateQuestion.ExecuteReader();
                Uqr.Close();
                QuestionsCallUpdates();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (ID.Text == "" || Type.Text == "" || Topic.Text == "" || Description.Text == "")
            {
                MessageBox.Show("Fill in the text boxes first");
            }
            else
            {
                string DeleteQuestionCommand = "dbo.Question_Delete " + ID.Text;
                SqlCommand DeleteQuestion = new SqlCommand(DeleteQuestionCommand,
                    LogInForm.Connection);
                SqlDataReader Dqr = DeleteQuestion.ExecuteReader();
                Dqr.Close();

                string DeleteChoiceCommand = "dbo.Choice_Delete " + ID.Text;
                SqlCommand DeleteChoice = new SqlCommand(DeleteChoiceCommand,
                    LogInForm.Connection);
                SqlDataReader Dcr = DeleteChoice.ExecuteReader();
                Dcr.Close();

                QuestionsCallUpdates();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string InsertQuestionCommand = "dbo.Question_Insert '" + Type.Text + "', '" + Description.Text + "', " + Topic.Text;
            SqlCommand InsertQuestion = new SqlCommand(InsertQuestionCommand,
                LogInForm.Connection);
            SqlDataReader Dqr = InsertQuestion.ExecuteReader();
            Dqr.Close();
            
            QuestionsCallUpdates();
        }
    }
}
