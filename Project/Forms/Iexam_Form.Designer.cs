
namespace Project.Forms
{
    partial class Iexam_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.TopicExamList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.McQExamInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ToFExamInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DurationExamInput = new System.Windows.Forms.TextBox();
            this.DurationExamOutput = new System.Windows.Forms.TextBox();
            this.TopicExamOutput = new System.Windows.Forms.TextBox();
            this.ExamIDOutput = new System.Windows.Forms.TextBox();
            this.QuestionExamOutput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.TopicExamFilter = new System.Windows.Forms.ComboBox();
            this.DateTimeOutput = new System.Windows.Forms.DateTimePicker();
            this.ExamDateInput = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.ExamTimeInput = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(565, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(354, 219);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(166, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(136, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 33;
            this.label4.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(32, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Questions No. :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(92, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 35;
            this.label6.Text = "Duration :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(129, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 29);
            this.label7.TabIndex = 36;
            this.label7.Text = "Topic : ";
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.Color.Maroon;
            this.add_btn.Location = new System.Drawing.Point(256, 585);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(233, 47);
            this.add_btn.TabIndex = 40;
            this.add_btn.Text = "Generate";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_btn.ForeColor = System.Drawing.Color.Maroon;
            this.delete_btn.Location = new System.Drawing.Point(256, 250);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(233, 47);
            this.delete_btn.TabIndex = 42;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // TopicExamList
            // 
            this.TopicExamList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.TopicExamList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopicExamList.FormattingEnabled = true;
            this.TopicExamList.Location = new System.Drawing.Point(256, 328);
            this.TopicExamList.Name = "TopicExamList";
            this.TopicExamList.Size = new System.Drawing.Size(233, 28);
            this.TopicExamList.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(61, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 46;
            this.label2.Text = "McQ Amount:";
            // 
            // McQExamInput
            // 
            this.McQExamInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.McQExamInput.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.McQExamInput.Location = new System.Drawing.Point(256, 371);
            this.McQExamInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.McQExamInput.Multiline = true;
            this.McQExamInput.Name = "McQExamInput";
            this.McQExamInput.Size = new System.Drawing.Size(233, 28);
            this.McQExamInput.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(68, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 29);
            this.label3.TabIndex = 48;
            this.label3.Text = "ToF Amount:";
            // 
            // ToFExamInput
            // 
            this.ToFExamInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.ToFExamInput.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToFExamInput.Location = new System.Drawing.Point(256, 412);
            this.ToFExamInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToFExamInput.Multiline = true;
            this.ToFExamInput.Name = "ToFExamInput";
            this.ToFExamInput.Size = new System.Drawing.Size(233, 28);
            this.ToFExamInput.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(106, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 29);
            this.label9.TabIndex = 50;
            this.label9.Text = "Duration:";
            // 
            // DurationExamInput
            // 
            this.DurationExamInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.DurationExamInput.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DurationExamInput.Location = new System.Drawing.Point(256, 455);
            this.DurationExamInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DurationExamInput.Multiline = true;
            this.DurationExamInput.Name = "DurationExamInput";
            this.DurationExamInput.Size = new System.Drawing.Size(233, 28);
            this.DurationExamInput.TabIndex = 49;
            // 
            // DurationExamOutput
            // 
            this.DurationExamOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.DurationExamOutput.Enabled = false;
            this.DurationExamOutput.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DurationExamOutput.Location = new System.Drawing.Point(256, 120);
            this.DurationExamOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DurationExamOutput.Multiline = true;
            this.DurationExamOutput.Name = "DurationExamOutput";
            this.DurationExamOutput.Size = new System.Drawing.Size(233, 28);
            this.DurationExamOutput.TabIndex = 53;
            // 
            // TopicExamOutput
            // 
            this.TopicExamOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.TopicExamOutput.Enabled = false;
            this.TopicExamOutput.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopicExamOutput.Location = new System.Drawing.Point(256, 78);
            this.TopicExamOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopicExamOutput.Multiline = true;
            this.TopicExamOutput.Name = "TopicExamOutput";
            this.TopicExamOutput.Size = new System.Drawing.Size(233, 28);
            this.TopicExamOutput.TabIndex = 52;
            // 
            // ExamIDOutput
            // 
            this.ExamIDOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.ExamIDOutput.Enabled = false;
            this.ExamIDOutput.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExamIDOutput.Location = new System.Drawing.Point(256, 37);
            this.ExamIDOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExamIDOutput.Multiline = true;
            this.ExamIDOutput.Name = "ExamIDOutput";
            this.ExamIDOutput.Size = new System.Drawing.Size(233, 28);
            this.ExamIDOutput.TabIndex = 51;
            // 
            // QuestionExamOutput
            // 
            this.QuestionExamOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.QuestionExamOutput.Enabled = false;
            this.QuestionExamOutput.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionExamOutput.Location = new System.Drawing.Point(256, 163);
            this.QuestionExamOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuestionExamOutput.Multiline = true;
            this.QuestionExamOutput.Name = "QuestionExamOutput";
            this.QuestionExamOutput.Size = new System.Drawing.Size(233, 28);
            this.QuestionExamOutput.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(136, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 29);
            this.label10.TabIndex = 57;
            this.label10.Text = "Topic : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(143, 500);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 29);
            this.label11.TabIndex = 58;
            this.label11.Text = "Date :";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(565, 328);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(354, 304);
            this.dataGridView2.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(566, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 29);
            this.label12.TabIndex = 62;
            this.label12.Text = "Topic : ";
            // 
            // TopicExamFilter
            // 
            this.TopicExamFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.TopicExamFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopicExamFilter.FormattingEnabled = true;
            this.TopicExamFilter.Location = new System.Drawing.Point(686, 37);
            this.TopicExamFilter.Name = "TopicExamFilter";
            this.TopicExamFilter.Size = new System.Drawing.Size(233, 28);
            this.TopicExamFilter.TabIndex = 61;
            this.TopicExamFilter.SelectionChangeCommitted += new System.EventHandler(this.TopicExamFilter_SelectionChangeCommitted);
            // 
            // DateTimeOutput
            // 
            this.DateTimeOutput.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.DateTimeOutput.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.DateTimeOutput.CustomFormat = "\"MM/dd/yyyy hh:mm:ss\"; ";
            this.DateTimeOutput.Location = new System.Drawing.Point(256, 207);
            this.DateTimeOutput.Name = "DateTimeOutput";
            this.DateTimeOutput.Size = new System.Drawing.Size(233, 27);
            this.DateTimeOutput.TabIndex = 63;
            // 
            // ExamDateInput
            // 
            this.ExamDateInput.CustomFormat = "";
            this.ExamDateInput.Location = new System.Drawing.Point(256, 502);
            this.ExamDateInput.Name = "ExamDateInput";
            this.ExamDateInput.Size = new System.Drawing.Size(233, 27);
            this.ExamDateInput.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(143, 545);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 29);
            this.label13.TabIndex = 65;
            this.label13.Text = "Time:";
            // 
            // ExamTimeInput
            // 
            this.ExamTimeInput.CustomFormat = "";
            this.ExamTimeInput.Location = new System.Drawing.Point(256, 547);
            this.ExamTimeInput.Name = "ExamTimeInput";
            this.ExamTimeInput.ShowUpDown = true;
            this.ExamTimeInput.Size = new System.Drawing.Size(233, 27);
            this.ExamTimeInput.TabIndex = 66;
            // 
            // Iexam_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 645);
            this.Controls.Add(this.ExamTimeInput);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ExamDateInput);
            this.Controls.Add(this.DateTimeOutput);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TopicExamFilter);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.QuestionExamOutput);
            this.Controls.Add(this.DurationExamOutput);
            this.Controls.Add(this.TopicExamOutput);
            this.Controls.Add(this.ExamIDOutput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DurationExamInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToFExamInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.McQExamInput);
            this.Controls.Add(this.TopicExamList);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Iexam_Form";
            this.Text = "Iins_Form";
            this.Load += new System.EventHandler(this.Iexam_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ComboBox TopicExamList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox McQExamInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ToFExamInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DurationExamInput;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DurationExamOutput;
        private System.Windows.Forms.TextBox TopicExamOutput;
        private System.Windows.Forms.TextBox ExamIDOutput;
        private System.Windows.Forms.TextBox QuestionExamOutput;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox TopicExamFilter;
        private System.Windows.Forms.DateTimePicker DateTimeOutput;
        private System.Windows.Forms.DateTimePicker ExamDateInput;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker ExamTimeInput;
    }
}