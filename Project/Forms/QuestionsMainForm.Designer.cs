namespace Project.Forms
{
    partial class QuestionsMainForm
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
            this.ID = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.Topic = new System.Windows.Forms.TextBox();
            this.TopicLabel = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionsGrid
            // 
            this.QuestionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionsGrid.Location = new System.Drawing.Point(503, 50);
            this.QuestionsGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QuestionsGrid.Name = "QuestionsGrid";
            this.QuestionsGrid.RowHeadersWidth = 51;
            this.QuestionsGrid.RowTemplate.Height = 25;
            this.QuestionsGrid.Size = new System.Drawing.Size(450, 438);
            this.QuestionsGrid.TabIndex = 21;
            this.QuestionsGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.QuestionsGrid_RowHeaderMouseClick);
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.ID.Enabled = false;
            this.ID.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(177, 50);
            this.ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(300, 50);
            this.ID.TabIndex = 24;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IDLabel.ForeColor = System.Drawing.Color.Maroon;
            this.IDLabel.Location = new System.Drawing.Point(12, 50);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(51, 29);
            this.IDLabel.TabIndex = 23;
            this.IDLabel.Text = "ID :";
            // 
            // Type
            // 
            this.Type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.Type.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Type.Location = new System.Drawing.Point(177, 108);
            this.Type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Type.Multiline = true;
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(300, 50);
            this.Type.TabIndex = 26;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TypeLabel.Location = new System.Drawing.Point(12, 108);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(83, 29);
            this.TypeLabel.TabIndex = 25;
            this.TypeLabel.Text = "Type :";
            // 
            // Topic
            // 
            this.Topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.Topic.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Topic.Location = new System.Drawing.Point(177, 166);
            this.Topic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Topic.Multiline = true;
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(300, 50);
            this.Topic.TabIndex = 28;
            // 
            // TopicLabel
            // 
            this.TopicLabel.AutoSize = true;
            this.TopicLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TopicLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TopicLabel.Location = new System.Drawing.Point(12, 166);
            this.TopicLabel.Name = "TopicLabel";
            this.TopicLabel.Size = new System.Drawing.Size(81, 29);
            this.TopicLabel.TabIndex = 27;
            this.TopicLabel.Text = "Topic:";
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(175)))), ((int)(((byte)(157)))));
            this.Description.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Description.Location = new System.Drawing.Point(177, 224);
            this.Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Description.MaxLength = 64000;
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(300, 111);
            this.Description.TabIndex = 30;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.ForeColor = System.Drawing.Color.Maroon;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 224);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(140, 29);
            this.DescriptionLabel.TabIndex = 29;
            this.DescriptionLabel.Text = "Description";
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_btn.ForeColor = System.Drawing.Color.Maroon;
            this.update_btn.Location = new System.Drawing.Point(383, 538);
            this.update_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(182, 47);
            this.update_btn.TabIndex = 42;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_btn.ForeColor = System.Drawing.Color.Maroon;
            this.delete_btn.Location = new System.Drawing.Point(690, 538);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(182, 47);
            this.delete_btn.TabIndex = 43;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.Color.Maroon;
            this.add_btn.Location = new System.Drawing.Point(79, 538);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(182, 47);
            this.add_btn.TabIndex = 44;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // QuestionsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 645);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.TopicLabel);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.QuestionsGrid);
            this.Name = "QuestionsMainForm";
            this.Text = "QuestionsMainForm";
            this.Load += new System.EventHandler(this.QuestionsMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView QuestionsGrid;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox Topic;
        private System.Windows.Forms.Label TopicLabel;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
    }
}