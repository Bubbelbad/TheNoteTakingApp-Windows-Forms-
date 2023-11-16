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
            deleteBtn = new Button();
            editButton = new Button();
            SuspendLayout();
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            availableLabel.Location = new Point(22, 115);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new Size(99, 15);
            availableLabel.TabIndex = 0;
            availableLabel.Text = "Available Notes: ";
            // 
            // availableListBox
            // 
            availableListBox.FormattingEnabled = true;
            availableListBox.ItemHeight = 15;
            availableListBox.Location = new Point(22, 133);
            availableListBox.Name = "availableListBox";
            availableListBox.Size = new Size(146, 184);
            availableListBox.TabIndex = 1;
            availableListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // titleLabel2
            // 
            titleLabel2.AutoSize = true;
            titleLabel2.Location = new Point(22, 44);
            titleLabel2.Name = "titleLabel2";
            titleLabel2.Size = new Size(35, 15);
            titleLabel2.TabIndex = 2;
            titleLabel2.Text = "Title: ";
            // 
            // authorLabel2
            // 
            authorLabel2.AutoSize = true;
            authorLabel2.Location = new Point(22, 23);
            authorLabel2.Name = "authorLabel2";
            authorLabel2.Size = new Size(47, 15);
            authorLabel2.TabIndex = 3;
            authorLabel2.Text = "Author:";
            // 
            // title2
            // 
            title2.AutoSize = true;
            title2.Location = new Point(85, 44);
            title2.Name = "title2";
            title2.Size = new Size(0, 15);
            title2.TabIndex = 4;
            // 
            // author2
            // 
            author2.AutoSize = true;
            author2.Location = new Point(85, 23);
            author2.Name = "author2";
            author2.Size = new Size(0, 15);
            author2.TabIndex = 5;
            // 
            // categoryLabel2
            // 
            categoryLabel2.AutoSize = true;
            categoryLabel2.Location = new Point(22, 64);
            categoryLabel2.Name = "categoryLabel2";
            categoryLabel2.Size = new Size(61, 15);
            categoryLabel2.TabIndex = 6;
            categoryLabel2.Text = "Category: ";
            // 
            // category2
            // 
            category2.AutoSize = true;
            category2.Location = new Point(85, 64);
            category2.Name = "category2";
            category2.Size = new Size(0, 15);
            category2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 23);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 8;
            label6.Text = "Message:";
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(323, 23);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(367, 294);
            messageTextBox.TabIndex = 9;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(98, 331);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(70, 23);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(22, 331);
            editButton.Name = "editButton";
            editButton.Size = new Size(70, 23);
            editButton.TabIndex = 12;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // ViewPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(editButton);
            Controls.Add(deleteBtn);
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
            Name = "ViewPanel";
            Size = new Size(808, 451);
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
        private Button deleteBtn;
        private Button editButton;
    }
}
