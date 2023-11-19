namespace TheNoteTakingApp__Windows_Forms_
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            homeBtn = new Button();
            viewBtn = new Button();
            createBtn = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newCollectionToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            exportToTextToolStripMenuItem = new ToolStripMenuItem();
            toJsonToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            createPanel1 = new CreatePanel();
            homePanel1 = new homePanel();
            viewPanel1 = new ViewPanel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // homeBtn
            // 
            homeBtn.Location = new Point(30, 140);
            homeBtn.Margin = new Padding(3, 4, 3, 4);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(86, 31);
            homeBtn.TabIndex = 1;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = true;
            homeBtn.Click += homeBtn_Click;
            // 
            // viewBtn
            // 
            viewBtn.Location = new Point(30, 259);
            viewBtn.Margin = new Padding(3, 4, 3, 4);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(86, 31);
            viewBtn.TabIndex = 2;
            viewBtn.Text = "View";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(30, 201);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(86, 31);
            createBtn.TabIndex = 3;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Left;
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripMargin = new Padding(2);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 63);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(110, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newCollectionToolStripMenuItem, openToolStripMenuItem, exportToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newCollectionToolStripMenuItem
            // 
            newCollectionToolStripMenuItem.Name = "newCollectionToolStripMenuItem";
            newCollectionToolStripMenuItem.Size = new Size(193, 26);
            newCollectionToolStripMenuItem.Text = "&New Collection";
            newCollectionToolStripMenuItem.Click += newCollectionToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(193, 26);
            openToolStripMenuItem.Text = "&Open...(csv)";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToTextToolStripMenuItem, toJsonToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(193, 26);
            exportToolStripMenuItem.Text = "&Export";
            // 
            // exportToTextToolStripMenuItem
            // 
            exportToTextToolStripMenuItem.Name = "exportToTextToolStripMenuItem";
            exportToTextToolStripMenuItem.Size = new Size(254, 26);
            exportToTextToolStripMenuItem.Text = "Export collection to Text";
            exportToTextToolStripMenuItem.Click += exportToTextToolStripMenuItem_Click;
            // 
            // toJsonToolStripMenuItem
            // 
            toJsonToolStripMenuItem.Name = "toJsonToolStripMenuItem";
            toJsonToolStripMenuItem.Size = new Size(254, 26);
            toJsonToolStripMenuItem.Text = "Export collection to Json";
            toJsonToolStripMenuItem.Click += toJsonToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(193, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            helpToolStripMenuItem.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 569);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1045, 26);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // createPanel1
            // 
            createPanel1.Location = new Point(104, 116);
            createPanel1.Margin = new Padding(3, 5, 3, 5);
            createPanel1.Name = "createPanel1";
            createPanel1.Size = new Size(859, 563);
            createPanel1.TabIndex = 8;
            // 
            // homePanel1
            // 
            homePanel1.Location = new Point(104, 98);
            homePanel1.Margin = new Padding(3, 5, 3, 5);
            homePanel1.Name = "homePanel1";
            homePanel1.Size = new Size(929, 605);
            homePanel1.TabIndex = 10;
            // 
            // viewPanel1
            // 
            viewPanel1.Location = new Point(104, 85);
            viewPanel1.Margin = new Padding(3, 5, 3, 5);
            viewPanel1.Name = "viewPanel1";
            viewPanel1.Size = new Size(837, 563);
            viewPanel1.TabIndex = 11;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 595);
            Controls.Add(statusStrip1);
            Controls.Add(createBtn);
            Controls.Add(viewBtn);
            Controls.Add(homeBtn);
            Controls.Add(menuStrip1);
            Controls.Add(viewPanel1);
            Controls.Add(homePanel1);
            Controls.Add(createPanel1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button homeBtn;
        private Button viewBtn;
        private Button createBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private CreatePanel createPanel1;
        private homePanel homePanel1;
        private ViewPanel viewPanel1;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exportToTextToolStripMenuItem;
        private ToolStripMenuItem toJsonToolStripMenuItem;
        private ToolStripMenuItem newCollectionToolStripMenuItem;
    }
}