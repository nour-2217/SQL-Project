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
    public partial class Choices : Form
    {
        private void QuestionsCallUpdates()
        {
            SqlCommand GetQuestions = new SqlCommand("SELECT * FROM dbo.Question", LogInForm.Connection);
            SqlDataReader QuestionsGridSource = GetQuestions.ExecuteReader();
            DataTable QuestionTable = new DataTable();
            QuestionTable.Load(QuestionsGridSource);
            QuestionsGrid.DataSource = QuestionTable;
        }
        private void ChoicesCallUpdates()
        {
            SqlCommand GetChoices = new SqlCommand("SELECT * FROM dbo.Choice", LogInForm.Connection);
            SqlDataReader ChoicesGridSource = GetChoices.ExecuteReader();
            DataTable ChoiceTable = new DataTable();
            ChoiceTable.Load(ChoicesGridSource);
            ChoicesGrid.DataSource = ChoiceTable;
        }
        public Choices()
        {
            InitializeComponent();
        }

        private void Choices_Load(object sender, EventArgs e)
        {
            QuestionsCallUpdates();
            ChoicesCallUpdates();
        }

        private void QuestionsGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Row = QuestionsGrid.Rows[e.RowIndex];

            QuestionID.Text = Row.Cells["ID"].Value.ToString();
        }

        private void ChoicesGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Row = ChoicesGrid.Rows[e.RowIndex];

            ChoiceID.Text = Row.Cells["ID"].Value.ToString();
            Flag.Text = Row.Cells["Flag"].Value.ToString();
            Description.Text = Row.Cells["Description"].Value.ToString();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string UpdateChoiceCommand = "dbo.Choice_Update " + ChoiceID.Text + ", " + Flag.Text + ", \'" + Description.Text + "\', " + QuestionID.Text;
            MessageBox.Show(UpdateChoiceCommand);
            SqlCommand UpdateChoice = new SqlCommand(UpdateChoiceCommand,
                LogInForm.Connection);
            SqlDataReader Ucr = UpdateChoice.ExecuteReader();
            Ucr.Close();

            ChoicesCallUpdates();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string InsertChoiceCommand = "dbo.Choice_Update " + Flag.Text + ", \'" + Description.Text + "\', " + QuestionID.Text;
            MessageBox.Show(InsertChoiceCommand);
            SqlCommand InsertChoice = new SqlCommand(InsertChoiceCommand,
                LogInForm.Connection);
            SqlDataReader Icr = InsertChoice.ExecuteReader();
            Icr.Close();

            ChoicesCallUpdates();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string DeleteChoiceCommand = "dbo.ChoiceChoice_Delete " + ChoiceID.Text;
            MessageBox.Show(DeleteChoiceCommand);
            SqlCommand DeleteChoice = new SqlCommand(DeleteChoiceCommand,
                LogInForm.Connection);
            SqlDataReader Dcr = DeleteChoice.ExecuteReader();
            Dcr.Close();

            ChoicesCallUpdates();
        }
    }
}
