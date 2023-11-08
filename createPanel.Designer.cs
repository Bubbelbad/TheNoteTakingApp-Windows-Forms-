namespace TheNoteTakingApp__Windows_Forms_
{
    partial class createPanel
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
            authorLabel = new Label();
            categoryLabel = new Label();
            messageLabel = new Label();
            authorTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            saveCreateButton = new Button();
            messageTextBox = new TextBox();
            secretCheckBox = new CheckBox();
            titleLabel = new Label();
            titleTextBox = new TextBox();
            SuspendLayout();
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(16, 25);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new Size(47, 15);
            authorLabel.TabIndex = 1;
            authorLabel.Text = "Author:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(16, 80);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(58, 15);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Category:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new Point(244, 25);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(56, 15);
            messageLabel.TabIndex = 3;
            messageLabel.Text = "Message:";
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(81, 22);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.Size = new Size(120, 23);
            authorTextBox.TabIndex = 4;
            authorTextBox.TextChanged += authorTextBox_TextChanged;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Items.AddRange(new object[] { "Poem", "Complaint", "Bold Statement", "Kväde", "Secret" });
            categoryComboBox.Location = new Point(79, 77);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(121, 23);
            categoryComboBox.TabIndex = 5;
            // 
            // saveCreateButton
            // 
            saveCreateButton.Location = new Point(317, 302);
            saveCreateButton.Name = "saveCreateButton";
            saveCreateButton.Size = new Size(53, 23);
            saveCreateButton.TabIndex = 6;
            saveCreateButton.Text = "Save";
            saveCreateButton.UseVisualStyleBackColor = true;
            saveCreateButton.Click += button1_Click;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(317, 25);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(312, 270);
            messageTextBox.TabIndex = 7;
            // 
            // secretCheckBox
            // 
            secretCheckBox.AutoSize = true;
            secretCheckBox.Location = new Point(80, 110);
            secretCheckBox.Name = "secretCheckBox";
            secretCheckBox.Size = new Size(63, 19);
            secretCheckBox.TabIndex = 8;
            secretCheckBox.Text = "Secret?";
            secretCheckBox.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Enabled = false;
            titleLabel.Location = new Point(16, 51);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(35, 15);
            titleLabel.TabIndex = 9;
            titleLabel.Text = "Title: ";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(80, 48);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(120, 23);
            titleTextBox.TabIndex = 10;
            // 
            // createPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(titleTextBox);
            Controls.Add(titleLabel);
            Controls.Add(secretCheckBox);
            Controls.Add(messageTextBox);
            Controls.Add(saveCreateButton);
            Controls.Add(categoryComboBox);
            Controls.Add(authorTextBox);
            Controls.Add(messageLabel);
            Controls.Add(categoryLabel);
            Controls.Add(authorLabel);
            Name = "createPanel";
            Size = new Size(656, 344);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label authorLabel;
        private Label categoryLabel;
        private Label messageLabel;
        private TextBox authorTextBox;
        private ComboBox categoryComboBox;
        private Button saveCreateButton;
        private TextBox messageTextBox;
        private CheckBox secretCheckBox;
        private Label titleLabel;
        private TextBox titleTextBox;
    }
}
