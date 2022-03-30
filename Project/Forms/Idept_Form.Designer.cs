namespace Project.Forms
{
    partial class Idept_Form
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
            this.btn_deleteDept = new System.Windows.Forms.Button();
            this.btn_updateDept = new System.Windows.Forms.Button();
            this.btn_addDept = new System.Windows.Forms.Button();
            this.txb_deptLocation = new System.Windows.Forms.TextBox();
            this.txb_deptName = new System.Windows.Forms.TextBox();
            this.txb_deptId = new System.Windows.Forms.TextBox();
            this.dgv_departments = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_departments)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deleteDept
            // 
            this.btn_deleteDept.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deleteDept.ForeColor = System.Drawing.Color.Maroon;
            this.btn_deleteDept.Location = new System.Drawing.Point(321, 265);
            this.btn_deleteDept.Name = "btn_deleteDept";
            this.btn_deleteDept.Size = new System.Drawing.Size(118, 35);
            this.btn_deleteDept.TabIndex = 49;
            this.btn_deleteDept.Text = "Delete";
            this.btn_deleteDept.UseVisualStyleBackColor = true;
            this.btn_deleteDept.Click += new System.EventHandler(this.btn_deleteDept_Click);
            // 
            // btn_updateDept
            // 
            this.btn_updateDept.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_updateDept.ForeColor = System.Drawing.Color.Maroon;
            this.btn_updateDept.Location = new System.Drawing.Point(170, 265);
            this.btn_updateDept.Name = "btn_updateDept";
            this.btn_updateDept.Size = new System.Drawing.Size(121, 35);
            this.btn_updateDept.TabIndex = 48;
            this.btn_updateDept.Text = "Update";
            this.btn_updateDept.UseVisualStyleBackColor = true;
            this.btn_updateDept.Click += new System.EventHandler(this.btn_updateDept_Click);
            // 
            // btn_addDept
            // 
            this.btn_addDept.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_addDept.ForeColor = System.Drawing.Color.Maroon;
            this.btn_addDept.Location = new System.Drawing.Point(23, 265);
            this.btn_addDept.Name = "btn_addDept";
            this.btn_addDept.Size = new System.Drawing.Size(113, 35);
            this.btn_addDept.TabIndex = 47;
            this.btn_addDept.Text = "Add";
            this.btn_addDept.UseVisualStyleBackColor = true;
            this.btn_addDept.Click += new System.EventHandler(this.btn_addDept_Click);
            // 
            // txb_deptLocation
            // 
            this.txb_deptLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_deptLocation.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_deptLocation.Location = new System.Drawing.Point(205, 149);
            this.txb_deptLocation.Multiline = true;
            this.txb_deptLocation.Name = "txb_deptLocation";
            this.txb_deptLocation.Size = new System.Drawing.Size(204, 40);
            this.txb_deptLocation.TabIndex = 46;
            // 
            // txb_deptName
            // 
            this.txb_deptName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_deptName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_deptName.Location = new System.Drawing.Point(205, 103);
            this.txb_deptName.Multiline = true;
            this.txb_deptName.Name = "txb_deptName";
            this.txb_deptName.Size = new System.Drawing.Size(204, 40);
            this.txb_deptName.TabIndex = 45;
            // 
            // txb_deptId
            // 
            this.txb_deptId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.txb_deptId.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txb_deptId.Location = new System.Drawing.Point(205, 57);
            this.txb_deptId.Multiline = true;
            this.txb_deptId.Name = "txb_deptId";
            this.txb_deptId.Size = new System.Drawing.Size(204, 40);
            this.txb_deptId.TabIndex = 44;
            // 
            // dgv_departments
            // 
            this.dgv_departments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_departments.Location = new System.Drawing.Point(455, 11);
            this.dgv_departments.Name = "dgv_departments";
            this.dgv_departments.RowTemplate.Height = 25;
            this.dgv_departments.Size = new System.Drawing.Size(310, 365);
            this.dgv_departments.TabIndex = 43;
            this.dgv_departments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_departments_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(12, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Department Name: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Location:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(12, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "ID :";
            // 
            // Idept_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_deleteDept);
            this.Controls.Add(this.btn_updateDept);
            this.Controls.Add(this.btn_addDept);
            this.Controls.Add(this.txb_deptLocation);
            this.Controls.Add(this.txb_deptName);
            this.Controls.Add(this.txb_deptId);
            this.Controls.Add(this.dgv_departments);
            this.Name = "Idept_Form";
            this.Text = "Idept_Form";
            this.Load += new System.EventHandler(this.Idept_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_departments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_deleteDept;
        private System.Windows.Forms.Button btn_updateDept;
        private System.Windows.Forms.Button btn_addDept;
        private System.Windows.Forms.TextBox txb_deptLocation;
        private System.Windows.Forms.TextBox txb_deptName;
        private System.Windows.Forms.TextBox txb_deptId;
        private System.Windows.Forms.DataGridView dgv_departments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}