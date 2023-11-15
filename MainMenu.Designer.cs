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
            headerLabel = new Label();
            homeBtn = new Button();
            viewBtn = new Button();
            createBtn = new Button();
            deleteBtn = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            exportToTextToolStripMenuItem = new ToolStripMenuItem();
            toJsonToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            customToolStripMenuItem = new ToolStripMenuItem();
            switchThemeToolStripMenuItem = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            unicornToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            createPanel1 = new CreatePanel();
            deletePanel1 = new DeletePanel();
            homePanel1 = new homePanel();
            viewPanel1 = new ViewPanel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Papyrus", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(257, 44);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(409, 58);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "The Note Taking App";
            // 
            // homeBtn
            // 
            homeBtn.Location = new Point(14, 107);
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
            viewBtn.Location = new Point(14, 145);
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
            createBtn.Location = new Point(14, 184);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(86, 31);
            createBtn.TabIndex = 3;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(14, 223);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(86, 31);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Download";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, customToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(870, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, exportToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(224, 26);
            openToolStripMenuItem.Text = "&Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToTextToolStripMenuItem, toJsonToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(224, 26);
            exportToolStripMenuItem.Text = "&Export";
            // 
            // exportToTextToolStripMenuItem
            // 
            exportToTextToolStripMenuItem.Name = "exportToTextToolStripMenuItem";
            exportToTextToolStripMenuItem.Size = new Size(224, 26);
            exportToTextToolStripMenuItem.Text = "Export to Text";
            exportToTextToolStripMenuItem.Click += exportToTextToolStripMenuItem_Click;
            // 
            // toJsonToolStripMenuItem
            // 
            toJsonToolStripMenuItem.Name = "toJsonToolStripMenuItem";
            toJsonToolStripMenuItem.Size = new Size(224, 26);
            toJsonToolStripMenuItem.Text = "Export to Json";
            toJsonToolStripMenuItem.Click += toJsonToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(224, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // customToolStripMenuItem
            // 
            customToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { switchThemeToolStripMenuItem });
            customToolStripMenuItem.Name = "customToolStripMenuItem";
            customToolStripMenuItem.Size = new Size(58, 24);
            customToolStripMenuItem.Text = "&Tools";
            // 
            // switchThemeToolStripMenuItem
            // 
            switchThemeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { defaultToolStripMenuItem, darkToolStripMenuItem, unicornToolStripMenuItem });
            switchThemeToolStripMenuItem.Name = "switchThemeToolStripMenuItem";
            switchThemeToolStripMenuItem.Size = new Size(137, 26);
            switchThemeToolStripMenuItem.Text = "T&heme";
            switchThemeToolStripMenuItem.Click += switchThemeToolStripMenuItem_Click;
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(143, 26);
            defaultToolStripMenuItem.Text = "Default";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(143, 26);
            darkToolStripMenuItem.Text = "Dark";
            // 
            // unicornToolStripMenuItem
            // 
            unicornToolStripMenuItem.Name = "unicornToolStripMenuItem";
            unicornToolStripMenuItem.Size = new Size(143, 26);
            unicornToolStripMenuItem.Text = "Unicorn";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
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
            statusStrip1.Location = new Point(0, 583);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(870, 26);
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
            createPanel1.Location = new Point(106, 107);
            createPanel1.Margin = new Padding(3, 5, 3, 5);
            createPanel1.Name = "createPanel1";
            createPanel1.Size = new Size(750, 459);
            createPanel1.TabIndex = 8;
            // 
            // deletePanel1
            // 
            deletePanel1.Location = new Point(106, 107);
            deletePanel1.Margin = new Padding(3, 5, 3, 5);
            deletePanel1.Name = "deletePanel1";
            deletePanel1.Size = new Size(750, 459);
            deletePanel1.TabIndex = 9;
            // 
            // homePanel1
            // 
            homePanel1.Location = new Point(106, 107);
            homePanel1.Margin = new Padding(3, 5, 3, 5);
            homePanel1.Name = "homePanel1";
            homePanel1.Size = new Size(750, 459);
            homePanel1.TabIndex = 10;
            // 
            // viewPanel1
            // 
            viewPanel1.Location = new Point(106, 107);
            viewPanel1.Margin = new Padding(3, 5, 3, 5);
            viewPanel1.Name = "viewPanel1";
            viewPanel1.Size = new Size(750, 459);
            viewPanel1.TabIndex = 11;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 609);
            Controls.Add(viewPanel1);
            Controls.Add(homePanel1);
            Controls.Add(deletePanel1);
            Controls.Add(createPanel1);
            Controls.Add(statusStrip1);
            Controls.Add(deleteBtn);
            Controls.Add(createBtn);
            Controls.Add(viewBtn);
            Controls.Add(homeBtn);
            Controls.Add(headerLabel);
            Controls.Add(menuStrip1);
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

        private Label headerLabel;
        private Button homeBtn;
        private Button viewBtn;
        private Button createBtn;
        private Button deleteBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private CreatePanel createPanel1;
        private DeletePanel deletePanel1;
        private homePanel homePanel1;
        private ViewPanel viewPanel1;
        private ToolStripMenuItem customToolStripMenuItem;
        private ToolStripMenuItem switchThemeToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem unicornToolStripMenuItem;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exportToTextToolStripMenuItem;
        private ToolStripMenuItem toJsonToolStripMenuItem;
    }
}