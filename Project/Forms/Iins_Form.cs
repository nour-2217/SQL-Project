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
    public partial class Iins_Form : Form
    {
        private void InstructorCallUpdates()
        {
            SqlCommand GetInstructors = new SqlCommand("SELECT * FROM dbo.Instructor", LogInForm.Connection);
            SqlDataReader InstructorsGridSource = GetInstructors.ExecuteReader();
            DataTable InstructorTable = new DataTable();
            InstructorTable.Load(InstructorsGridSource);
            dgv_instructors.DataSource = InstructorTable;
        }
        public Iins_Form()
        {
            InitializeComponent();
        }

        

        private void Iins_Form_Load(object sender, EventArgs e)
        {
            InstructorCallUpdates();
        }


        private void dgv_instructors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowIndex = e.RowIndex;
            DataGridViewRow Row = dgv_instructors.Rows[RowIndex];
            txb_insID.Text = Row.Cells[0].Value.ToString();
            txb_insFname.Text = Row.Cells[1].Value.ToString();
            txb_insLname.Text = Row.Cells[2].Value.ToString();
            txb_insGender.Text = Row.Cells[3].Value.ToString();
            txb_insPhone.Text = Row.Cells[4].Value.ToString();
            txb_insPass.Text = Row.Cells[5].Value.ToString();
            txb_insDOB.Text = Row.Cells[6].Value.ToString();
            txb_insAge.Text = Row.Cells[7].Value.ToString();
            txb_insDept.Text = Row.Cells[8].Value.ToString();
            txb_insUsername.Text = Row.Cells[9].Value.ToString();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string UpdateInstructorCommand = "dbo.Instructor_Update " + txb_insID.Text + ", " 
                                            + txb_insFname.Text + ", " + txb_insLname.Text + ", " 
                                            + txb_insDOB.Text + ", " + txb_insGender.Text + ", " + txb_insPhone.Text + ", " 
                                            + txb_insPass.Text + ", " + txb_insDept.Text;
            MessageBox.Show(UpdateInstructorCommand);
            SqlCommand UpdateInstructor = new SqlCommand(UpdateInstructorCommand,
                LogInForm.Connection);
            SqlDataReader Ucr = UpdateInstructor.ExecuteReader();
            Ucr.Close();

            InstructorCallUpdates();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string InsertInstructorCommand = "dbo.Instructor_Insert " + txb_insID.Text + ", "
                                            + txb_insFname.Text + ", " + txb_insLname.Text + ", "
                                            + txb_insDOB.Text + ", " + txb_insGender.Text + ", " + txb_insPhone.Text + ", "
                                            + txb_insPass.Text + ", " + txb_insDept.Text;
            MessageBox.Show(InsertInstructorCommand);
            SqlCommand InsertInstructor = new SqlCommand(InsertInstructorCommand,
                LogInForm.Connection);
            SqlDataReader Icr = InsertInstructor.ExecuteReader();
            Icr.Close();

            InstructorCallUpdates();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string DeleteInstructorCommand = "dbo.Instructor_Delete " + txb_insID.Text;
            MessageBox.Show(DeleteInstructorCommand);
            SqlCommand DeleteInstructor = new SqlCommand(DeleteInstructorCommand,
                LogInForm.Connection);
            SqlDataReader Dcr = DeleteInstructor.ExecuteReader();
            Dcr.Close();

            InstructorCallUpdates();

        }
    }
}
