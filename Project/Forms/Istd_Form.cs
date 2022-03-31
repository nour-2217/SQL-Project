using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class Istd_Form : Form
    {
        public Istd_Form()
        {
            InitializeComponent();
        }
        public string stid
        {
            get
            {
                return id_textBox.Text;
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Sedit_Form Sedit_form = new Sedit_Form();
            Sedit_form.Show();
            
        }
    }
}
