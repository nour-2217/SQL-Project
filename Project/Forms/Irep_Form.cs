using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class Irep_Form : Form
    {
        public Irep_Form()
        {
            InitializeComponent();
        }

        private void rep1_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = "http://localhost/Reports/report/ExamReports/CourseTopics";
            p.Start();
        }

        private void rep2_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = "http://localhost/Reports/report/ExamReports/ExamDetails";
            p.Start();
        }

        private void rep3_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = "http://localhost/Reports/report/ExamReports/InstructorCourses";
            p.Start();
        }

        private void rep4_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = "http://localhost/Reports/report/ExamReports/StudentsAnswer";
            p.Start();
        }

        private void rep5_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = "http://localhost/Reports/report/ExamReports/StudentsGrade";
            p.Start();
        }

        private void rep6_btn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = "http://localhost/Reports/report/ExamReports/StudentDept";
            p.Start();
        }
    }
}
