﻿
namespace Project.Forms
{
    partial class Ins_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ins_MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseAppbtn = new System.Windows.Forms.Button();
            this.desktop_panel = new System.Windows.Forms.Panel();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.Department_btn = new System.Windows.Forms.Button();
            this.Course_btn = new System.Windows.Forms.Button();
            this.Topic_btn = new System.Windows.Forms.Button();
            this.Rep_btn = new System.Windows.Forms.Button();
            this.Std_btn = new System.Windows.Forms.Button();
            this.Exam_btn = new System.Windows.Forms.Button();
            this.Ins_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseAppbtn);
            this.panel1.Location = new System.Drawing.Point(242, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 118);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(276, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Examination System";
            // 
            // CloseAppbtn
            // 
            this.CloseAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppbtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseAppbtn.Image")));
            this.CloseAppbtn.Location = new System.Drawing.Point(856, 0);
            this.CloseAppbtn.Name = "CloseAppbtn";
            this.CloseAppbtn.Size = new System.Drawing.Size(32, 23);
            this.CloseAppbtn.TabIndex = 0;
            this.CloseAppbtn.UseVisualStyleBackColor = true;
            this.CloseAppbtn.Click += new System.EventHandler(this.CloseAppbtn_Click);
            // 
            // desktop_panel
            // 
            this.desktop_panel.Location = new System.Drawing.Point(251, 125);
            this.desktop_panel.Name = "desktop_panel";
            this.desktop_panel.Size = new System.Drawing.Size(879, 523);
            this.desktop_panel.TabIndex = 1;
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.panelmenu.Controls.Add(this.Department_btn);
            this.panelmenu.Controls.Add(this.Course_btn);
            this.panelmenu.Controls.Add(this.Topic_btn);
            this.panelmenu.Controls.Add(this.Rep_btn);
            this.panelmenu.Controls.Add(this.Std_btn);
            this.panelmenu.Controls.Add(this.Exam_btn);
            this.panelmenu.Controls.Add(this.Ins_btn);
            this.panelmenu.Location = new System.Drawing.Point(1, 1);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(244, 647);
            this.panelmenu.TabIndex = 2;
            // 
            // Department_btn
            // 
            this.Department_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Department_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Department_btn.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Department_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Department_btn.Location = new System.Drawing.Point(0, 299);
            this.Department_btn.Name = "Department_btn";
            this.Department_btn.Size = new System.Drawing.Size(244, 49);
            this.Department_btn.TabIndex = 6;
            this.Department_btn.Text = "Department";
            this.Department_btn.UseVisualStyleBackColor = false;
            this.Department_btn.Click += new System.EventHandler(this.Department_btn_Click);
            // 
            // Course_btn
            // 
            this.Course_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Course_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Course_btn.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Course_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Course_btn.Location = new System.Drawing.Point(0, 364);
            this.Course_btn.Name = "Course_btn";
            this.Course_btn.Size = new System.Drawing.Size(244, 49);
            this.Course_btn.TabIndex = 5;
            this.Course_btn.Text = "Course";
            this.Course_btn.UseVisualStyleBackColor = false;
            this.Course_btn.Click += new System.EventHandler(this.Course_btn_Click);
            // 
            // Topic_btn
            // 
            this.Topic_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Topic_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Topic_btn.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Topic_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Topic_btn.Location = new System.Drawing.Point(0, 429);
            this.Topic_btn.Name = "Topic_btn";
            this.Topic_btn.Size = new System.Drawing.Size(244, 49);
            this.Topic_btn.TabIndex = 4;
            this.Topic_btn.Text = "Topic";
            this.Topic_btn.UseVisualStyleBackColor = false;
            this.Topic_btn.Click += new System.EventHandler(this.Topic_btn_Click);
            // 
            // Rep_btn
            // 
            this.Rep_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Rep_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rep_btn.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rep_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Rep_btn.Location = new System.Drawing.Point(0, 566);
            this.Rep_btn.Name = "Rep_btn";
            this.Rep_btn.Size = new System.Drawing.Size(244, 49);
            this.Rep_btn.TabIndex = 3;
            this.Rep_btn.Text = "Reports";
            this.Rep_btn.UseVisualStyleBackColor = false;
            this.Rep_btn.Click += new System.EventHandler(this.Rep_btn_Click);
            // 
            // Std_btn
            // 
            this.Std_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Std_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Std_btn.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Std_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Std_btn.Location = new System.Drawing.Point(0, 229);
            this.Std_btn.Name = "Std_btn";
            this.Std_btn.Size = new System.Drawing.Size(244, 49);
            this.Std_btn.TabIndex = 2;
            this.Std_btn.Text = "Student";
            this.Std_btn.UseVisualStyleBackColor = false;
            this.Std_btn.Click += new System.EventHandler(this.Std_btn_Click);
            // 
            // Exam_btn
            // 
            this.Exam_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Exam_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exam_btn.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exam_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Exam_btn.Location = new System.Drawing.Point(0, 498);
            this.Exam_btn.Name = "Exam_btn";
            this.Exam_btn.Size = new System.Drawing.Size(244, 49);
            this.Exam_btn.TabIndex = 1;
            this.Exam_btn.Text = "Exam";
            this.Exam_btn.UseVisualStyleBackColor = false;
            this.Exam_btn.Click += new System.EventHandler(this.Exam_btn_Click);
            // 
            // Ins_btn
            // 
            this.Ins_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Ins_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ins_btn.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ins_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Ins_btn.Location = new System.Drawing.Point(0, 163);
            this.Ins_btn.Name = "Ins_btn";
            this.Ins_btn.Size = new System.Drawing.Size(244, 49);
            this.Ins_btn.TabIndex = 0;
            this.Ins_btn.Text = "Instructor";
            this.Ins_btn.UseVisualStyleBackColor = false;
            this.Ins_btn.Click += new System.EventHandler(this.Ins_btn_Click);
            // 
            // Ins_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 656);
            this.Controls.Add(this.desktop_panel);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ins_MainForm";
            this.Text = "Ins_MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel desktop_panel;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button Ins_btn;
        private System.Windows.Forms.Button CloseAppbtn;
        private System.Windows.Forms.Button Rep_btn;
        private System.Windows.Forms.Button Std_btn;
        private System.Windows.Forms.Button Exam_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Course_btn;
        private System.Windows.Forms.Button Topic_btn;
        private System.Windows.Forms.Button Department_btn;
    }
}