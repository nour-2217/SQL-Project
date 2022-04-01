using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class StTopics : Form
    {
        public StTopics()
        {
            InitializeComponent();
        }
        public DataGridView std
        {
            get
            {
                return dataGridView1;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Row = dataGridView1.Rows[e.RowIndex];
            Sname.Text = Row.Cells["Student's name"].Value.ToString();
            Tname.Text = Row.Cells["Topic's name"].Value.ToString();
            Grade.Text = Row.Cells["Grade"].Value.ToString();          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
