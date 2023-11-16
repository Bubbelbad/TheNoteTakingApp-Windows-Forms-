namespace TheNoteTakingApp__Windows_Forms_
{
    partial class ExportJsonForm
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
            folderPathLabel = new Label();
            folderPathLabel1 = new Label();
            folderButton = new Button();
            chooseFolderLabel = new Label();
            fileTextBox = new TextBox();
            nameFileLabel = new Label();
            exportButton = new Button();
            directoryErrorLabel = new Label();
            SuspendLayout();
            // 
            // folderPathLabel
            // 
            folderPathLabel.AutoSize = true;
            folderPathLabel.Location = new Point(25, 126);
            folderPathLabel.Name = "folderPathLabel";
            folderPathLabel.Size = new Size(0, 15);
            folderPathLabel.TabIndex = 13;
            // 
            // folderPathLabel1
            // 
            folderPathLabel1.AutoSize = true;
            folderPathLabel1.Location = new Point(25, 101);
            folderPathLabel1.Name = "folderPathLabel1";
            folderPathLabel1.Size = new Size(93, 15);
            folderPathLabel1.TabIndex = 12;
            folderPathLabel1.Text = "Selected Folder: ";
            // 
            // folderButton
            // 
            folderButton.Location = new Point(218, 37);
            folderButton.Name = "folderButton";
            folderButton.Size = new Size(75, 23);
            folderButton.TabIndex = 11;
            folderButton.Text = "Folder";
            folderButton.UseVisualStyleBackColor = false;
            // 
            // chooseFolderLabel
            // 
            chooseFolderLabel.AutoSize = true;
            chooseFolderLabel.Location = new Point(218, 19);
            chooseFolderLabel.Name = "chooseFolderLabel";
            chooseFolderLabel.Size = new Size(87, 15);
            chooseFolderLabel.TabIndex = 10;
            chooseFolderLabel.Text = "Choose folder: ";
            // 
            // fileTextBox
            // 
            fileTextBox.Location = new Point(25, 37);
            fileTextBox.Name = "fileTextBox";
            fileTextBox.Size = new Size(148, 23);
            fileTextBox.TabIndex = 9;
            // 
            // nameFileLabel
            // 
            nameFileLabel.AutoSize = true;
            nameFileLabel.Location = new Point(25, 19);
            nameFileLabel.Name = "nameFileLabel";
            nameFileLabel.Size = new Size(81, 15);
            nameFileLabel.TabIndex = 8;
            nameFileLabel.Text = "Name the file:";
            // 
            // exportButton
            // 
            exportButton.Location = new Point(25, 158);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(75, 23);
            exportButton.TabIndex = 7;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = false;
            // 
            // directoryErrorLabel
            // 
            directoryErrorLabel.AutoSize = true;
            directoryErrorLabel.Location = new Point(220, 62);
            directoryErrorLabel.Name = "directoryErrorLabel";
            directoryErrorLabel.Size = new Size(0, 15);
            directoryErrorLabel.TabIndex = 14;
            // 
            // ExportJsonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 222);
            Controls.Add(directoryErrorLabel);
            Controls.Add(folderPathLabel);
            Controls.Add(folderPathLabel1);
            Controls.Add(folderButton);
            Controls.Add(chooseFolderLabel);
            Controls.Add(fileTextBox);
            Controls.Add(nameFileLabel);
            Controls.Add(exportButton);
            Name = "ExportJsonForm";
            Text = "ExportJsonForm";
            Load += ExportJsonForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label folderPathLabel;
        private Label folderPathLabel1;
        private Button folderButton;
        private Label chooseFolderLabel;
        private TextBox fileTextBox;
        private Label nameFileLabel;
        private Button exportButton;
        private Label directoryErrorLabel;
    }
}