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
        public QuestionsMainForm()
        {
            InitializeComponent();
        }

        private void QuestionsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuestionsMainForm_Load(object sender, EventArgs e)
        {
            SqlCommand GetQuestions = new SqlCommand("SELECT * FROM dbo.Question", LogInForm.Connection);
            SqlDataReader QuestionGridSource = GetQuestions.ExecuteReader();
            QuestionsGrid.DataSource = QuestionGridSource;
        }
    }
}
