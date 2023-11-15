namespace TheNoteTakingApp__Windows_Forms_
{
    partial class ViewPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            availableLabel = new Label();
            availableListBox = new ListBox();
            titleLabel2 = new Label();
            authorLabel2 = new Label();
            title2 = new Label();
            author2 = new Label();
            categoryLabel2 = new Label();
            category2 = new Label();
            label6 = new Label();
            messageTextBox = new TextBox();
            refreshBtn = new Button();
            deleteBtn = new Button();
            editButton = new Button();
            SuspendLayout();
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            availableLabel.Location = new Point(25, 112);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new Size(127, 20);
            availableLabel.TabIndex = 0;
            availableLabel.Text = "Available Notes: ";
            // 
            // availableListBox
            // 
            availableListBox.FormattingEnabled = true;
            availableListBox.ItemHeight = 20;
            availableListBox.Location = new Point(25, 136);
            availableListBox.Margin = new Padding(3, 4, 3, 4);
            availableListBox.Name = "availableListBox";
            availableListBox.Size = new Size(166, 244);
            availableListBox.TabIndex = 1;
            availableListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // titleLabel2
            // 
            titleLabel2.AutoSize = true;
            titleLabel2.Location = new Point(25, 59);
            titleLabel2.Name = "titleLabel2";
            titleLabel2.Size = new Size(45, 20);
            titleLabel2.TabIndex = 2;
            titleLabel2.Text = "Title: ";
            // 
            // authorLabel2
            // 
            authorLabel2.AutoSize = true;
            authorLabel2.Location = new Point(25, 31);
            authorLabel2.Name = "authorLabel2";
            authorLabel2.Size = new Size(57, 20);
            authorLabel2.TabIndex = 3;
            authorLabel2.Text = "Author:";
            // 
            // title2
            // 
            title2.AutoSize = true;
            title2.Location = new Point(97, 59);
            title2.Name = "title2";
            title2.Size = new Size(0, 20);
            title2.TabIndex = 4;
            // 
            // author2
            // 
            author2.AutoSize = true;
            author2.Location = new Point(97, 31);
            author2.Name = "author2";
            author2.Size = new Size(0, 20);
            author2.TabIndex = 5;
            // 
            // categoryLabel2
            // 
            categoryLabel2.AutoSize = true;
            categoryLabel2.Location = new Point(25, 85);
            categoryLabel2.Name = "categoryLabel2";
            categoryLabel2.Size = new Size(76, 20);
            categoryLabel2.TabIndex = 6;
            categoryLabel2.Text = "Category: ";
            // 
            // category2
            // 
            category2.AutoSize = true;
            category2.Location = new Point(97, 85);
            category2.Name = "category2";
            category2.Size = new Size(0, 20);
            category2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 31);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 8;
            label6.Text = "Message:";
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(328, 31);
            messageTextBox.Margin = new Padding(3, 4, 3, 4);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(419, 353);
            messageTextBox.TabIndex = 9;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(197, 136);
            refreshBtn.Margin = new Padding(3, 4, 3, 4);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(56, 31);
            refreshBtn.TabIndex = 10;
            refreshBtn.Text = "Load";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(112, 400);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(80, 31);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(25, 400);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(80, 31);
            editButton.TabIndex = 12;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // ViewPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(editButton);
            Controls.Add(deleteBtn);
            Controls.Add(refreshBtn);
            Controls.Add(messageTextBox);
            Controls.Add(label6);
            Controls.Add(category2);
            Controls.Add(categoryLabel2);
            Controls.Add(author2);
            Controls.Add(title2);
            Controls.Add(authorLabel2);
            Controls.Add(titleLabel2);
            Controls.Add(availableListBox);
            Controls.Add(availableLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewPanel";
            Size = new Size(750, 459);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label availableLabel;
        private ListBox availableListBox;
        private Label titleLabel2;
        private Label authorLabel2;
        private Label title2;
        private Label author2;
        private Label categoryLabel2;
        private Label category2;
        private Label label6;
        private TextBox messageTextBox;
        private Button refreshBtn;
        private Button deleteBtn;
        private Button editButton;
    }
}
