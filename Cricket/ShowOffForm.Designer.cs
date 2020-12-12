namespace Cricket
{
    partial class ShowOffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowOffForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsOfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Summary = new System.Windows.Forms.GroupBox();
            this.Team2Score = new System.Windows.Forms.Label();
            this.Team1Score = new System.Windows.Forms.Label();
            this.Team2Name = new System.Windows.Forms.Label();
            this.Verdict = new System.Windows.Forms.Label();
            this.Team1Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BowlingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BattingPanel = new System.Windows.Forms.TableLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.teamName = new System.Windows.Forms.TextBox();
            this.SaveBox = new System.Windows.Forms.SaveFileDialog();
            this.OpenBox = new System.Windows.Forms.OpenFileDialog();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.Summary.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.statsOfToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGameStatToolStripMenuItem,
            this.loadGameStatToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveGameStatToolStripMenuItem
            // 
            this.saveGameStatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveGameStatToolStripMenuItem.Image")));
            this.saveGameStatToolStripMenuItem.Name = "saveGameStatToolStripMenuItem";
            this.saveGameStatToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveGameStatToolStripMenuItem.Text = "Save Game Stat";
            this.saveGameStatToolStripMenuItem.Click += new System.EventHandler(this.saveGameStatToolStripMenuItem_Click);
            // 
            // loadGameStatToolStripMenuItem
            // 
            this.loadGameStatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadGameStatToolStripMenuItem.Image")));
            this.loadGameStatToolStripMenuItem.Name = "loadGameStatToolStripMenuItem";
            this.loadGameStatToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.loadGameStatToolStripMenuItem.Text = "Load Game Stat";
            this.loadGameStatToolStripMenuItem.Click += new System.EventHandler(this.loadGameStatToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripMenuItem.Image")));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.reportToolStripMenuItem.Text = "Exit";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // statsOfToolStripMenuItem
            // 
            this.statsOfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstTeamToolStripMenuItem,
            this.secondTeamToolStripMenuItem});
            this.statsOfToolStripMenuItem.Name = "statsOfToolStripMenuItem";
            this.statsOfToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.statsOfToolStripMenuItem.Text = "StatsOf";
            // 
            // firstTeamToolStripMenuItem
            // 
            this.firstTeamToolStripMenuItem.BackColor = System.Drawing.Color.Coral;
            this.firstTeamToolStripMenuItem.Font = new System.Drawing.Font("Cambria Math", 9F, System.Drawing.FontStyle.Bold);
            this.firstTeamToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.firstTeamToolStripMenuItem.Name = "firstTeamToolStripMenuItem";
            this.firstTeamToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.firstTeamToolStripMenuItem.Size = new System.Drawing.Size(156, 70);
            this.firstTeamToolStripMenuItem.Text = "FirstTeam";
            this.firstTeamToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.firstTeamToolStripMenuItem.ToolTipText = "Displays the battingand bowling stats ";
            this.firstTeamToolStripMenuItem.Click += new System.EventHandler(this.firstTeamToolStripMenuItem_Click);
            // 
            // secondTeamToolStripMenuItem
            // 
            this.secondTeamToolStripMenuItem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.secondTeamToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            this.secondTeamToolStripMenuItem.ForeColor = System.Drawing.Color.DarkMagenta;
            this.secondTeamToolStripMenuItem.Name = "secondTeamToolStripMenuItem";
            this.secondTeamToolStripMenuItem.Size = new System.Drawing.Size(156, 72);
            this.secondTeamToolStripMenuItem.Text = "SecondTeam";
            this.secondTeamToolStripMenuItem.ToolTipText = "Displays the battingand bowling stats ";
            this.secondTeamToolStripMenuItem.Click += new System.EventHandler(this.secondTeamToolStripMenuItem_Click);
            // 
            // Summary
            // 
            this.Summary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Summary.BackgroundImage")));
            this.Summary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Summary.Controls.Add(this.Team2Score);
            this.Summary.Controls.Add(this.Team1Score);
            this.Summary.Controls.Add(this.Team2Name);
            this.Summary.Controls.Add(this.Verdict);
            this.Summary.Controls.Add(this.Team1Name);
            this.Summary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Summary.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Summary.ForeColor = System.Drawing.Color.Black;
            this.Summary.Location = new System.Drawing.Point(15, 37);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(1262, 122);
            this.Summary.TabIndex = 1;
            this.Summary.TabStop = false;
            this.Summary.Text = "Summary";
            // 
            // Team2Score
            // 
            this.Team2Score.AutoSize = true;
            this.Team2Score.BackColor = System.Drawing.Color.Transparent;
            this.Team2Score.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Score.ForeColor = System.Drawing.Color.Black;
            this.Team2Score.Location = new System.Drawing.Point(126, 58);
            this.Team2Score.Name = "Team2Score";
            this.Team2Score.Size = new System.Drawing.Size(156, 16);
            this.Team2Score.TabIndex = 4;
            this.Team2Score.Text = "Team2 Score/wicket";
            this.Team2Score.Click += new System.EventHandler(this.Team2Score_Click);
            // 
            // Team1Score
            // 
            this.Team1Score.AutoSize = true;
            this.Team1Score.BackColor = System.Drawing.Color.Transparent;
            this.Team1Score.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1Score.ForeColor = System.Drawing.Color.Black;
            this.Team1Score.Location = new System.Drawing.Point(126, 32);
            this.Team1Score.Name = "Team1Score";
            this.Team1Score.Size = new System.Drawing.Size(153, 16);
            this.Team1Score.TabIndex = 3;
            this.Team1Score.Text = "Team1 Score/wicket";
            this.Team1Score.Click += new System.EventHandler(this.Team1Score_Click);
            // 
            // Team2Name
            // 
            this.Team2Name.AutoSize = true;
            this.Team2Name.BackColor = System.Drawing.Color.Transparent;
            this.Team2Name.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Name.ForeColor = System.Drawing.Color.Black;
            this.Team2Name.Location = new System.Drawing.Point(0, 58);
            this.Team2Name.Name = "Team2Name";
            this.Team2Name.Size = new System.Drawing.Size(59, 16);
            this.Team2Name.TabIndex = 2;
            this.Team2Name.Text = "Team2";
            // 
            // Verdict
            // 
            this.Verdict.AutoSize = true;
            this.Verdict.BackColor = System.Drawing.Color.Transparent;
            this.Verdict.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verdict.ForeColor = System.Drawing.Color.Black;
            this.Verdict.Location = new System.Drawing.Point(0, 92);
            this.Verdict.Name = "Verdict";
            this.Verdict.Size = new System.Drawing.Size(62, 16);
            this.Verdict.TabIndex = 1;
            this.Verdict.Text = "Verdict";
            // 
            // Team1Name
            // 
            this.Team1Name.AutoSize = true;
            this.Team1Name.BackColor = System.Drawing.Color.Transparent;
            this.Team1Name.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1Name.ForeColor = System.Drawing.Color.Black;
            this.Team1Name.Location = new System.Drawing.Point(0, 32);
            this.Team1Name.Name = "Team1Name";
            this.Team1Name.Size = new System.Drawing.Size(56, 16);
            this.Team1Name.TabIndex = 0;
            this.Team1Name.Text = "Team1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.BowlingPanel);
            this.panel1.Controls.Add(this.BattingPanel);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(14, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 420);
            this.panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox2.Location = new System.Drawing.Point(601, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 19);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "BowlingStats";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.Location = new System.Drawing.Point(7, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 19);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "BattingStats";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BowlingPanel
            // 
            this.BowlingPanel.AutoScroll = true;
            this.BowlingPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.BowlingPanel.ColumnCount = 6;
            this.BowlingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BowlingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BowlingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BowlingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BowlingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BowlingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BowlingPanel.Location = new System.Drawing.Point(601, 31);
            this.BowlingPanel.Name = "BowlingPanel";
            this.BowlingPanel.RowCount = 1;
            this.BowlingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BowlingPanel.Size = new System.Drawing.Size(659, 369);
            this.BowlingPanel.TabIndex = 2;
            // 
            // BattingPanel
            // 
            this.BattingPanel.AutoScroll = true;
            this.BattingPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.BattingPanel.ColumnCount = 6;
            this.BattingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BattingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BattingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BattingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BattingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BattingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BattingPanel.Location = new System.Drawing.Point(3, 31);
            this.BattingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BattingPanel.Name = "BattingPanel";
            this.BattingPanel.RowCount = 1;
            this.BattingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BattingPanel.Size = new System.Drawing.Size(581, 369);
            this.BattingPanel.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(584, 420);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // teamName
            // 
            this.teamName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.teamName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teamName.Enabled = false;
            this.teamName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamName.ForeColor = System.Drawing.Color.LimeGreen;
            this.teamName.Location = new System.Drawing.Point(15, 165);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(290, 19);
            this.teamName.TabIndex = 3;
            this.teamName.TextChanged += new System.EventHandler(this.teamName_TextChanged);
            // 
            // SaveBox
            // 
            this.SaveBox.DefaultExt = "Match File (*.3yrs)|*.3yrs";
            this.SaveBox.FileName = "Match1";
            this.SaveBox.Filter = "Match File (*.3yrs)|*.3yrs";
            this.SaveBox.ShowHelp = true;
            this.SaveBox.Title = "Save Match Stat";
            // 
            // OpenBox
            // 
            this.OpenBox.DefaultExt = "Match File (*.3yrs)|*.3yrs";
            this.OpenBox.FileName = "Match1";
            this.OpenBox.Filter = "Match File (*.3yrs)|*.3yrs";
            this.OpenBox.Title = "Load Match Stat";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // ShowOffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1289, 658);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Summary);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1305, 697);
            this.MinimumSize = new System.Drawing.Size(1305, 697);
            this.Name = "ShowOffForm";
            this.Text = "ShowOffForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Summary.ResumeLayout(false);
            this.Summary.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsOfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondTeamToolStripMenuItem;
        private System.Windows.Forms.GroupBox Summary;
        private System.Windows.Forms.Label Team2Score;
        private System.Windows.Forms.Label Team1Score;
        private System.Windows.Forms.Label Team2Name;
        private System.Windows.Forms.Label Verdict;
        private System.Windows.Forms.Label Team1Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel BattingPanel;
        private System.Windows.Forms.TableLayoutPanel BowlingPanel;
        private System.Windows.Forms.TextBox teamName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameStatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameStatToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveBox;
        private System.Windows.Forms.OpenFileDialog OpenBox;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
    }
}