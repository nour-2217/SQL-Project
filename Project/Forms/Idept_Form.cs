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
    public partial class Idept_Form : Form
    {
        private void DepartmentCallUpdates()
        {
            SqlCommand GetDepartments = new SqlCommand("SELECT * FROM dbo.Department", LogInForm.Connection);
            SqlDataReader ChoicesGridSource = GetDepartments.ExecuteReader();
            DataTable DepartmentTable = new DataTable();
            DepartmentTable.Load(ChoicesGridSource);
            dgv_departments.DataSource = DepartmentTable;
        }
        public Idept_Form()
        {
            InitializeComponent();
        }

        private void Idept_Form_Load(object sender, EventArgs e)
        {
            DepartmentCallUpdates();
        }

        private void dgv_departments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowIndex = e.RowIndex;
            DataGridViewRow Row = dgv_departments.Rows[RowIndex];
            txb_deptId.Text = Row.Cells[0].Value.ToString();
            txb_deptName.Text = Row.Cells[1].Value.ToString();
            txb_deptLocation.Text = Row.Cells[2].Value.ToString();
        }

        private void btn_updateDept_Click(object sender, EventArgs e)
        {
            string UpdateDepartmentCommand = "dbo.Department_Update " + txb_deptId.Text + ", "
                                            + txb_deptName.Text + ", " + txb_deptLocation.Text;
            MessageBox.Show(UpdateDepartmentCommand);
            SqlCommand UpdateDepartment = new SqlCommand(UpdateDepartmentCommand,
                LogInForm.Connection);
            SqlDataReader Ucr = UpdateDepartment.ExecuteReader();
            Ucr.Close();

            DepartmentCallUpdates();
        }

        private void btn_addDept_Click(object sender, EventArgs e)
        {
            string InsertDepartmentCommand = "dbo.Department_Insert " + txb_deptId.Text + ", "
                                            + txb_deptName.Text + ", " + txb_deptLocation.Text;
            MessageBox.Show(InsertDepartmentCommand);
            SqlCommand InsertDepartment = new SqlCommand(InsertDepartmentCommand,
                LogInForm.Connection);
            SqlDataReader Icr = InsertDepartment.ExecuteReader();
            Icr.Close();

            DepartmentCallUpdates();
        }

        private void btn_deleteDept_Click(object sender, EventArgs e)
        {
            string DeleteDepartmentCommand = "dbo.Department_Delete " + txb_deptId.Text;
            MessageBox.Show(DeleteDepartmentCommand);
            SqlCommand DeleteDepartment = new SqlCommand(DeleteDepartmentCommand,
                LogInForm.Connection);
            SqlDataReader Dcr = DeleteDepartment.ExecuteReader();
            Dcr.Close();

            DepartmentCallUpdates();
        }
    }
}
