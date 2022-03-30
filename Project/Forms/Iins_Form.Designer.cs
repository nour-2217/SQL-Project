
namespace Project.Forms
{
    partial class Iins_Form
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
            this.dgv_instructors = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_insID = new System.Windows.Forms.TextBox();
            this.txb_insFname = new System.Windows.Forms.TextBox();
            this.txb_insLname = new System.Windows.Forms.TextBox();
            this.txb_insDOB = new System.Windows.Forms.TextBox();
            this.txb_insGender = new System.Windows.Forms.TextBox();
            this.txb_insPhone = new System.Windows.Forms.TextBox();
            this.txb_insPass = new System.Windows.Forms.TextBox();
            this.txb_insAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_pass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_insDept = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_insUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instructors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_instructors
            // 
            this.dgv_instructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_instructors.Location = new System.Drawing.Point(373, 12);
            this.dgv_instructors.Name = "dgv_instructors";
            this.dgv_instructors.RowTemplate.Height = 25;
            this.dgv_instructors.Size = new System.Drawing.Size(478, 362);
            this.dgv_instructors.TabIndex = 20;
            this.dgv_instructors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_instructors_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(23, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID :";
            // 
            // txb_insID
            // 
            this.txb_insID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_insID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_insID.Location = new System.Drawing.Point(163, 12);
            this.txb_insID.Multiline = true;
            this.txb_insID.Name = "txb_insID";
            this.txb_insID.Size = new System.Drawing.Size(204, 40);
            this.txb_insID.TabIndex = 22;
            // 
            // txb_insFname
            // 
            this.txb_insFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_insFname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_insFname.Location = new System.Drawing.Point(163, 58);
            this.txb_insFname.Multiline = true;
            this.txb_insFname.Name = "txb_insFname";
            this.txb_insFname.Size = new System.Drawing.Size(204, 40);
            this.txb_insFname.TabIndex = 23;
            // 
            // txb_insLname
            // 
            this.txb_insLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_insLname.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_insLname.Location = new System.Drawing.Point(163, 104);
            this.txb_insLname.Multiline = true;
            this.txb_insLname.Name = "txb_insLname";
            this.txb_insLname.Size = new System.Drawing.Size(204, 40);
            this.txb_insLname.TabIndex = 24;
            // 
            // txb_insDOB
            // 
            this.txb_insDOB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_insDOB.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_insDOB.Location = new System.Drawing.Point(163, 150);
            this.txb_insDOB.Multiline = true;
            this.txb_insDOB.Name = "txb_insDOB";
            this.txb_insDOB.Size = new System.Drawing.Size(204, 40);
            this.txb_insDOB.TabIndex = 25;
            // 
            // txb_insGender
            // 
            this.txb_insGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_insGender.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_insGender.Location = new System.Drawing.Point(163, 196);
            this.txb_insGender.Multiline = true;
            this.txb_insGender.Name = "txb_insGender";
            this.txb_insGender.Size = new System.Drawing.Size(204, 40);
            this.txb_insGender.TabIndex = 26;
            // 
            // txb_insPhone
            // 
            this.txb_insPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_insPhone.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_insPhone.Location = new System.Drawing.Point(163, 242);
            this.txb_insPhone.Multiline = true;
            this.txb_insPhone.Name = "txb_insPhone";
            this.txb_insPhone.Size = new System.Drawing.Size(204, 40);
            this.txb_insPhone.TabIndex = 27;
            // 
            // txb_insPass
            // 
            this.txb_insPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_insPass.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_insPass.Location = new System.Drawing.Point(163, 332);
            this.txb_insPass.Multiline = true;
            this.txb_insPass.Name = "txb_insPass";
            this.txb_insPass.Size = new System.Drawing.Size(204, 40);
            this.txb_insPass.TabIndex = 28;
            // 
            // txb_insAge
            // 
            this.txb_insAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_insAge.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_insAge.Location = new System.Drawing.Point(163, 380);
            this.txb_insAge.Multiline = true;
            this.txb_insAge.Name = "txb_insAge";
            this.txb_insAge.Size = new System.Drawing.Size(204, 40);
            this.txb_insAge.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(27, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 30;
            this.label2.Text = "Age :";
            // 
            // txb_pass
            // 
            this.txb_pass.AutoSize = true;
            this.txb_pass.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txb_pass.ForeColor = System.Drawing.Color.Maroon;
            this.txb_pass.Location = new System.Drawing.Point(23, 342);
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.Size = new System.Drawing.Size(92, 24);
            this.txb_pass.TabIndex = 31;
            this.txb_pass.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(23, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Phone :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(23, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Gender :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(23, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "Date of Birth :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(23, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Last Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(23, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "First Name :";
            // 
            // txb_insDept
            // 
            this.txb_insDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_insDept.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_insDept.Location = new System.Drawing.Point(507, 385);
            this.txb_insDept.Multiline = true;
            this.txb_insDept.Name = "txb_insDept";
            this.txb_insDept.Size = new System.Drawing.Size(204, 40);
            this.txb_insDept.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(372, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 24);
            this.label10.TabIndex = 39;
            this.label10.Text = "Department :";
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.Color.Maroon;
            this.add_btn.Location = new System.Drawing.Point(75, 437);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(159, 35);
            this.add_btn.TabIndex = 40;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_btn.ForeColor = System.Drawing.Color.Maroon;
            this.update_btn.Location = new System.Drawing.Point(353, 437);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(159, 35);
            this.update_btn.TabIndex = 41;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_btn.ForeColor = System.Drawing.Color.Maroon;
            this.delete_btn.Location = new System.Drawing.Point(645, 437);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(159, 35);
            this.delete_btn.TabIndex = 42;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(23, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Username";
            // 
            // txb_insUsername
            // 
            this.txb_insUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_insUsername.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_insUsername.Location = new System.Drawing.Point(163, 286);
            this.txb_insUsername.Multiline = true;
            this.txb_insUsername.Name = "txb_insUsername";
            this.txb_insUsername.Size = new System.Drawing.Size(204, 40);
            this.txb_insUsername.TabIndex = 43;
            // 
            // Iins_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_insUsername);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txb_insDept);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_insAge);
            this.Controls.Add(this.txb_insPass);
            this.Controls.Add(this.txb_insPhone);
            this.Controls.Add(this.txb_insGender);
            this.Controls.Add(this.txb_insDOB);
            this.Controls.Add(this.txb_insLname);
            this.Controls.Add(this.txb_insFname);
            this.Controls.Add(this.txb_insID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgv_instructors);
            this.Name = "Iins_Form";
            this.Text = "Iins_Form";
            this.Load += new System.EventHandler(this.Iins_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instructors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_instructors;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_insID;
        private System.Windows.Forms.TextBox txb_insFname;
        private System.Windows.Forms.TextBox txb_insLname;
        private System.Windows.Forms.TextBox txb_insDOB;
        private System.Windows.Forms.TextBox txb_insGender;
        private System.Windows.Forms.TextBox txb_insPhone;
        private System.Windows.Forms.TextBox txb_insPass;
        private System.Windows.Forms.TextBox txb_insAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txb_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_insDept;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_insUsername;
    }
}