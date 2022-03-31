namespace Project.Forms
{
    partial class Choices
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
            this.QuestionsGrid = new System.Windows.Forms.DataGridView();
            this.ChoicesGrid = new System.Windows.Forms.DataGridView();
            this.QIDLabel = new System.Windows.Forms.Label();
            this.ChoicesForQuestion = new System.Windows.Forms.Label();
            this.QuestionID = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.CID = new System.Windows.Forms.Label();
            this.ChoiceID = new System.Windows.Forms.TextBox();
            this.FlagLabel = new System.Windows.Forms.Label();
            this.Flag = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoicesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionsGrid
            // 
            this.QuestionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionsGrid.Location = new System.Drawing.Point(524, 13);
            this.QuestionsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuestionsGrid.Name = "QuestionsGrid";
            this.QuestionsGrid.RowHeadersWidth = 51;
            this.QuestionsGrid.RowTemplate.Height = 25;
            this.QuestionsGrid.Size = new System.Drawing.Size(450, 212);
            this.QuestionsGrid.TabIndex = 22;
            this.QuestionsGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.QuestionsGrid_RowHeaderMouseClick);
            // 
            // ChoicesGrid
            // 
            this.ChoicesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChoicesGrid.Location = new System.Drawing.Point(524, 283);
            this.ChoicesGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChoicesGrid.Name = "ChoicesGrid";
            this.ChoicesGrid.RowHeadersWidth = 51;
            this.ChoicesGrid.RowTemplate.Height = 25;
            this.ChoicesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ChoicesGrid.Size = new System.Drawing.Size(450, 349);
            this.ChoicesGrid.TabIndex = 23;
            this.ChoicesGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ChoicesGrid_RowHeaderMouseClick);
            // 
            // QIDLabel
            // 
            this.QIDLabel.AutoSize = true;
            this.QIDLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QIDLabel.ForeColor = System.Drawing.Color.Maroon;
            this.QIDLabel.Location = new System.Drawing.Point(13, 81);
            this.QIDLabel.Name = "QIDLabel";
            this.QIDLabel.Size = new System.Drawing.Size(158, 29);
            this.QIDLabel.TabIndex = 24;
            this.QIDLabel.Text = "Question ID :";
            // 
            // ChoicesForQuestion
            // 
            this.ChoicesForQuestion.AutoSize = true;
            this.ChoicesForQuestion.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChoicesForQuestion.ForeColor = System.Drawing.Color.Maroon;
            this.ChoicesForQuestion.Location = new System.Drawing.Point(43, 29);
            this.ChoicesForQuestion.Name = "ChoicesForQuestion";
            this.ChoicesForQuestion.Size = new System.Drawing.Size(269, 29);
            this.ChoicesForQuestion.TabIndex = 25;
            this.ChoicesForQuestion.Text = "Choices for Question : ";
            // 
            // QuestionID
            // 
            this.QuestionID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.QuestionID.Enabled = false;
            this.QuestionID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionID.Location = new System.Drawing.Point(204, 71);
            this.QuestionID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuestionID.Multiline = true;
            this.QuestionID.Name = "QuestionID";
            this.QuestionID.Size = new System.Drawing.Size(273, 50);
            this.QuestionID.TabIndex = 26;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.Color.Maroon;
            this.add_btn.Location = new System.Drawing.Point(12, 585);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(104, 47);
            this.add_btn.TabIndex = 45;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_btn.ForeColor = System.Drawing.Color.Maroon;
            this.update_btn.Location = new System.Drawing.Point(152, 585);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(105, 47);
            this.update_btn.TabIndex = 46;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_btn.ForeColor = System.Drawing.Color.Maroon;
            this.delete_btn.Location = new System.Drawing.Point(291, 585);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(120, 47);
            this.delete_btn.TabIndex = 47;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // CID
            // 
            this.CID.AutoSize = true;
            this.CID.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CID.ForeColor = System.Drawing.Color.Maroon;
            this.CID.Location = new System.Drawing.Point(27, 292);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(134, 29);
            this.CID.TabIndex = 48;
            this.CID.Text = "Choice ID :";
            // 
            // ChoiceID
            // 
            this.ChoiceID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.ChoiceID.Enabled = false;
            this.ChoiceID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChoiceID.Location = new System.Drawing.Point(204, 283);
            this.ChoiceID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChoiceID.Multiline = true;
            this.ChoiceID.Name = "ChoiceID";
            this.ChoiceID.Size = new System.Drawing.Size(273, 50);
            this.ChoiceID.TabIndex = 49;
            // 
            // FlagLabel
            // 
            this.FlagLabel.AutoSize = true;
            this.FlagLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FlagLabel.ForeColor = System.Drawing.Color.Maroon;
            this.FlagLabel.Location = new System.Drawing.Point(27, 367);
            this.FlagLabel.Name = "FlagLabel";
            this.FlagLabel.Size = new System.Drawing.Size(75, 29);
            this.FlagLabel.TabIndex = 50;
            this.FlagLabel.Text = "Flag :";
            // 
            // Flag
            // 
            this.Flag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.Flag.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Flag.Location = new System.Drawing.Point(204, 358);
            this.Flag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Flag.Multiline = true;
            this.Flag.Name = "Flag";
            this.Flag.Size = new System.Drawing.Size(273, 50);
            this.Flag.TabIndex = 51;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Maroon;
            this.DescriptionLabel.Location = new System.Drawing.Point(27, 436);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(156, 29);
            this.DescriptionLabel.TabIndex = 52;
            this.DescriptionLabel.Text = "Description :";
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.Description.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Description.Location = new System.Drawing.Point(204, 436);
            this.Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Description.MaxLength = 64000;
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(273, 129);
            this.Description.TabIndex = 53;
            // 
            // Choices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 645);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.Flag);
            this.Controls.Add(this.FlagLabel);
            this.Controls.Add(this.ChoiceID);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.QuestionID);
            this.Controls.Add(this.ChoicesForQuestion);
            this.Controls.Add(this.QIDLabel);
            this.Controls.Add(this.ChoicesGrid);
            this.Controls.Add(this.QuestionsGrid);
            this.Name = "Choices";
            this.Text = "Choices";
            this.Load += new System.EventHandler(this.Choices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChoicesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView QuestionsGrid;
        private System.Windows.Forms.DataGridView ChoicesGrid;
        private System.Windows.Forms.Label QIDLabel;
        private System.Windows.Forms.Label ChoicesForQuestion;
        private System.Windows.Forms.TextBox QuestionID;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label CID;
        private System.Windows.Forms.TextBox ChoiceID;
        private System.Windows.Forms.Label FlagLabel;
        private System.Windows.Forms.TextBox Flag;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox Description;
    }
}