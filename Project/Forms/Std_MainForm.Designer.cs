
namespace Project.Forms
{
    partial class Std_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Std_MainForm));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.Topic_btn = new System.Windows.Forms.Button();
            this.Exam_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseAppbtn = new System.Windows.Forms.Button();
            this.desktop_panel = new System.Windows.Forms.Panel();
            this.panelmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.panelmenu.Controls.Add(this.Topic_btn);
            this.panelmenu.Controls.Add(this.Exam_btn);
            this.panelmenu.Location = new System.Drawing.Point(1, 0);
            this.panelmenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(279, 863);
            this.panelmenu.TabIndex = 3;
            // 
            // Topic_btn
            // 
            this.Topic_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Topic_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Topic_btn.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Topic_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Topic_btn.Location = new System.Drawing.Point(0, 372);
            this.Topic_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Topic_btn.Name = "Topic_btn";
            this.Topic_btn.Size = new System.Drawing.Size(279, 65);
            this.Topic_btn.TabIndex = 4;
            this.Topic_btn.Text = "Topic";
            this.Topic_btn.UseVisualStyleBackColor = false;
            // 
            // Exam_btn
            // 
            this.Exam_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.Exam_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exam_btn.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exam_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Exam_btn.Location = new System.Drawing.Point(0, 511);
            this.Exam_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Exam_btn.Name = "Exam_btn";
            this.Exam_btn.Size = new System.Drawing.Size(279, 65);
            this.Exam_btn.TabIndex = 1;
            this.Exam_btn.Text = "Exam";
            this.Exam_btn.UseVisualStyleBackColor = false;
            this.Exam_btn.Click += new System.EventHandler(this.Exam_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseAppbtn);
            this.panel1.Location = new System.Drawing.Point(287, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 157);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(315, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Examination System";
            // 
            // CloseAppbtn
            // 
            this.CloseAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppbtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseAppbtn.Image")));
            this.CloseAppbtn.Location = new System.Drawing.Point(968, 0);
            this.CloseAppbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseAppbtn.Name = "CloseAppbtn";
            this.CloseAppbtn.Size = new System.Drawing.Size(37, 31);
            this.CloseAppbtn.TabIndex = 0;
            this.CloseAppbtn.UseVisualStyleBackColor = true;
            // 
            // desktop_panel
            // 
            this.desktop_panel.Location = new System.Drawing.Point(287, 165);
            this.desktop_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.desktop_panel.Name = "desktop_panel";
            this.desktop_panel.Size = new System.Drawing.Size(1005, 697);
            this.desktop_panel.TabIndex = 5;
            // 
            // Std_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 875);
            this.Controls.Add(this.desktop_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Std_MainForm";
            this.Text = "Std_MainForm";
            this.panelmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button Exam_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseAppbtn;
        private System.Windows.Forms.Button Topic_btn;
        private System.Windows.Forms.Panel desktop_panel;
    }
}