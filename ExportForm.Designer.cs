namespace TheNoteTakingApp__Windows_Forms_
{
    partial class ExportForm
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
            exportButton = new Button();
            nameFileLabel = new Label();
            fileTextBox = new TextBox();
            chooseFolderLabel = new Label();
            folderButton = new Button();
            folderPathLabel1 = new Label();
            folderPathLabel = new Label();
            fileErrorLabel = new Label();
            directoryErrorLabel = new Label();
            SuspendLayout();
            // 
            // exportButton
            // 
            exportButton.Location = new Point(52, 234);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(75, 23);
            exportButton.TabIndex = 0;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click;
            // 
            // nameFileLabel
            // 
            nameFileLabel.AutoSize = true;
            nameFileLabel.Location = new Point(52, 95);
            nameFileLabel.Name = "nameFileLabel";
            nameFileLabel.Size = new Size(81, 15);
            nameFileLabel.TabIndex = 1;
            nameFileLabel.Text = "Name the file:";
            // 
            // fileTextBox
            // 
            fileTextBox.Location = new Point(52, 113);
            fileTextBox.Name = "fileTextBox";
            fileTextBox.Size = new Size(148, 23);
            fileTextBox.TabIndex = 2;
            // 
            // chooseFolderLabel
            // 
            chooseFolderLabel.AutoSize = true;
            chooseFolderLabel.Location = new Point(245, 95);
            chooseFolderLabel.Name = "chooseFolderLabel";
            chooseFolderLabel.Size = new Size(87, 15);
            chooseFolderLabel.TabIndex = 3;
            chooseFolderLabel.Text = "Choose folder: ";
            // 
            // folderButton
            // 
            folderButton.Location = new Point(245, 113);
            folderButton.Name = "folderButton";
            folderButton.Size = new Size(75, 23);
            folderButton.TabIndex = 4;
            folderButton.Text = "Folder";
            folderButton.UseVisualStyleBackColor = false;
            folderButton.Click += folderButton_Click;
            // 
            // folderPathLabel1
            // 
            folderPathLabel1.AutoSize = true;
            folderPathLabel1.Location = new Point(52, 177);
            folderPathLabel1.Name = "folderPathLabel1";
            folderPathLabel1.Size = new Size(93, 15);
            folderPathLabel1.TabIndex = 5;
            folderPathLabel1.Text = "Selected Folder: ";
            // 
            // folderPathLabel
            // 
            folderPathLabel.AutoSize = true;
            folderPathLabel.Location = new Point(52, 202);
            folderPathLabel.Name = "folderPathLabel";
            folderPathLabel.Size = new Size(0, 15);
            folderPathLabel.TabIndex = 6;
            // 
            // fileErrorLabel
            // 
            fileErrorLabel.AutoSize = true;
            fileErrorLabel.ForeColor = Color.Firebrick;
            fileErrorLabel.Location = new Point(52, 139);
            fileErrorLabel.Name = "fileErrorLabel";
            fileErrorLabel.Size = new Size(0, 15);
            fileErrorLabel.TabIndex = 7;
            fileErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // directoryErrorLabel
            // 
            directoryErrorLabel.AutoSize = true;
            directoryErrorLabel.ForeColor = Color.Firebrick;
            directoryErrorLabel.Location = new Point(245, 139);
            directoryErrorLabel.Name = "directoryErrorLabel";
            directoryErrorLabel.Size = new Size(0, 15);
            directoryErrorLabel.TabIndex = 8;
            directoryErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 290);
            Controls.Add(directoryErrorLabel);
            Controls.Add(fileErrorLabel);
            Controls.Add(folderPathLabel);
            Controls.Add(folderPathLabel1);
            Controls.Add(folderButton);
            Controls.Add(chooseFolderLabel);
            Controls.Add(fileTextBox);
            Controls.Add(nameFileLabel);
            Controls.Add(exportButton);
            Name = "ExportForm";
            Text = "ExportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exportButton;
        private Label nameFileLabel;
        private TextBox fileTextBox;
        private Label chooseFolderLabel;
        private Button folderButton;
        private Label folderPathLabel1;
        private Label folderPathLabel;
        private Label fileErrorLabel;
        private Label directoryErrorLabel;
    }
}