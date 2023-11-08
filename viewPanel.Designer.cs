namespace TheNoteTakingApp__Windows_Forms_
{
    partial class viewPanel
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
            messsageLabel = new Label();
            SuspendLayout();
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Location = new Point(22, 15);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new Size(95, 15);
            availableLabel.TabIndex = 0;
            availableLabel.Text = "Available Notes: ";
            // 
            // availableListBox
            // 
            availableListBox.FormattingEnabled = true;
            availableListBox.ItemHeight = 15;
            availableListBox.Location = new Point(22, 42);
            availableListBox.Name = "availableListBox";
            availableListBox.Size = new Size(146, 229);
            availableListBox.TabIndex = 1;
            availableListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // messsageLabel
            // 
            messsageLabel.AutoSize = true;
            messsageLabel.Location = new Point(271, 42);
            messsageLabel.Name = "messsageLabel";
            messsageLabel.Size = new Size(38, 15);
            messsageLabel.TabIndex = 2;
            messsageLabel.Text = "label1";
            // 
            // viewPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(messsageLabel);
            Controls.Add(availableListBox);
            Controls.Add(availableLabel);
            Name = "viewPanel";
            Size = new Size(656, 344);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label availableLabel;
        private ListBox availableListBox;
        private Label messsageLabel;
    }
}
