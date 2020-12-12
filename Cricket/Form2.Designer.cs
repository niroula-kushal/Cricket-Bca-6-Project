namespace Cricket
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.team1TextBox = new System.Windows.Forms.TextBox();
            this.SaveLoadContextMenuForTeam1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveTeamInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTeamInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.team2TextBox = new System.Windows.Forms.TextBox();
            this.SaveLoadContextMenuForTeam2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Team1 = new System.Windows.Forms.TextBox();
            this.Team2 = new System.Windows.Forms.TextBox();
            this.OversTotal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.team1Bat = new System.Windows.Forms.RadioButton();
            this.team2Bat = new System.Windows.Forms.RadioButton();
            this.bowlingLimit = new System.Windows.Forms.NumericUpDown();
            this.OverLimit = new System.Windows.Forms.Label();
            this.numOfPlayers = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveBox = new System.Windows.Forms.SaveFileDialog();
            this.OpenBox = new System.Windows.Forms.OpenFileDialog();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMatchStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchStatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.team1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.team2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchConfigurationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.teamInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.team1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.team2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveLoadContextMenuForTeam1.SuspendLayout();
            this.SaveLoadContextMenuForTeam2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OversTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlingLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfPlayers)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // team1TextBox
            // 
            this.team1TextBox.ContextMenuStrip = this.SaveLoadContextMenuForTeam1;
            this.team1TextBox.Location = new System.Drawing.Point(29, 109);
            this.team1TextBox.Multiline = true;
            this.team1TextBox.Name = "team1TextBox";
            this.team1TextBox.Size = new System.Drawing.Size(130, 239);
            this.team1TextBox.TabIndex = 3;
            // 
            // SaveLoadContextMenuForTeam1
            // 
            this.SaveLoadContextMenuForTeam1.BackColor = System.Drawing.SystemColors.Info;
            this.SaveLoadContextMenuForTeam1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLoadContextMenuForTeam1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTeamInfoToolStripMenuItem,
            this.loadTeamInfoToolStripMenuItem});
            this.SaveLoadContextMenuForTeam1.Name = "SaveLoadContextMenu";
            this.SaveLoadContextMenuForTeam1.Size = new System.Drawing.Size(174, 48);
            this.SaveLoadContextMenuForTeam1.Opening += new System.ComponentModel.CancelEventHandler(this.SaveLoadContextMenuForTeam1_Opening);
            // 
            // saveTeamInfoToolStripMenuItem
            // 
            this.saveTeamInfoToolStripMenuItem.AutoToolTip = true;
            this.saveTeamInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveTeamInfoToolStripMenuItem.Image")));
            this.saveTeamInfoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Yellow;
            this.saveTeamInfoToolStripMenuItem.Name = "saveTeamInfoToolStripMenuItem";
            this.saveTeamInfoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveTeamInfoToolStripMenuItem.Text = "Save Team Info";
            this.saveTeamInfoToolStripMenuItem.Click += new System.EventHandler(this.saveTeamInfoToolStripMenuItem_Click);
            // 
            // loadTeamInfoToolStripMenuItem
            // 
            this.loadTeamInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadTeamInfoToolStripMenuItem.Image")));
            this.loadTeamInfoToolStripMenuItem.Name = "loadTeamInfoToolStripMenuItem";
            this.loadTeamInfoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.loadTeamInfoToolStripMenuItem.Text = "Load Team Info";
            this.loadTeamInfoToolStripMenuItem.Click += new System.EventHandler(this.loadTeamInfoToolStripMenuItem_Click);
            // 
            // team2TextBox
            // 
            this.team2TextBox.ContextMenuStrip = this.SaveLoadContextMenuForTeam2;
            this.team2TextBox.Location = new System.Drawing.Point(278, 109);
            this.team2TextBox.Multiline = true;
            this.team2TextBox.Name = "team2TextBox";
            this.team2TextBox.Size = new System.Drawing.Size(130, 239);
            this.team2TextBox.TabIndex = 4;
            // 
            // SaveLoadContextMenuForTeam2
            // 
            this.SaveLoadContextMenuForTeam2.AutoSize = false;
            this.SaveLoadContextMenuForTeam2.BackColor = System.Drawing.SystemColors.Info;
            this.SaveLoadContextMenuForTeam2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLoadContextMenuForTeam2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.SaveLoadContextMenuForTeam2.Name = "SaveLoadContextMenu";
            this.SaveLoadContextMenuForTeam2.Size = new System.Drawing.Size(157, 70);
            this.SaveLoadContextMenuForTeam2.Opening += new System.ComponentModel.CancelEventHandler(this.SaveLoadContextMenuForTeam2_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem1.Text = "Save Team Info";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem2.Text = "Load Team Info";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Team1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Team2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(165, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 44);
            this.button1.TabIndex = 10;
            this.button1.Text = "Go!!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Team1
            // 
            this.Team1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Team1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Team1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Team1.Location = new System.Drawing.Point(29, 69);
            this.Team1.Name = "Team1";
            this.Team1.Size = new System.Drawing.Size(130, 20);
            this.Team1.TabIndex = 1;
            // 
            // Team2
            // 
            this.Team2.Location = new System.Drawing.Point(278, 68);
            this.Team2.Name = "Team2";
            this.Team2.Size = new System.Drawing.Size(130, 20);
            this.Team2.TabIndex = 2;
            // 
            // OversTotal
            // 
            this.OversTotal.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OversTotal.ForeColor = System.Drawing.Color.Black;
            this.OversTotal.Location = new System.Drawing.Point(165, 133);
            this.OversTotal.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.OversTotal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OversTotal.Name = "OversTotal";
            this.OversTotal.Size = new System.Drawing.Size(107, 23);
            this.OversTotal.TabIndex = 5;
            this.OversTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OversTotal.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(183, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Overs";
            // 
            // team1Bat
            // 
            this.team1Bat.AutoSize = true;
            this.team1Bat.BackColor = System.Drawing.Color.Transparent;
            this.team1Bat.Checked = true;
            this.team1Bat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Bat.Location = new System.Drawing.Point(29, 354);
            this.team1Bat.Name = "team1Bat";
            this.team1Bat.Size = new System.Drawing.Size(96, 23);
            this.team1Bat.TabIndex = 8;
            this.team1Bat.TabStop = true;
            this.team1Bat.Text = "BattingFirst";
            this.team1Bat.UseVisualStyleBackColor = false;
            // 
            // team2Bat
            // 
            this.team2Bat.AutoSize = true;
            this.team2Bat.BackColor = System.Drawing.Color.Transparent;
            this.team2Bat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Bat.Location = new System.Drawing.Point(284, 354);
            this.team2Bat.Name = "team2Bat";
            this.team2Bat.Size = new System.Drawing.Size(96, 23);
            this.team2Bat.TabIndex = 9;
            this.team2Bat.Text = "BattingFirst";
            this.team2Bat.UseVisualStyleBackColor = false;
            // 
            // bowlingLimit
            // 
            this.bowlingLimit.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bowlingLimit.ForeColor = System.Drawing.Color.Black;
            this.bowlingLimit.Location = new System.Drawing.Point(165, 194);
            this.bowlingLimit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.bowlingLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bowlingLimit.Name = "bowlingLimit";
            this.bowlingLimit.Size = new System.Drawing.Size(107, 23);
            this.bowlingLimit.TabIndex = 6;
            this.bowlingLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bowlingLimit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // OverLimit
            // 
            this.OverLimit.AutoSize = true;
            this.OverLimit.BackColor = System.Drawing.Color.Transparent;
            this.OverLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OverLimit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OverLimit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverLimit.ForeColor = System.Drawing.Color.DarkBlue;
            this.OverLimit.Location = new System.Drawing.Point(165, 168);
            this.OverLimit.Name = "OverLimit";
            this.OverLimit.Size = new System.Drawing.Size(101, 18);
            this.OverLimit.TabIndex = 12;
            this.OverLimit.Text = "BowlingLimit";
            // 
            // numOfPlayers
            // 
            this.numOfPlayers.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfPlayers.ForeColor = System.Drawing.Color.Black;
            this.numOfPlayers.Location = new System.Drawing.Point(165, 245);
            this.numOfPlayers.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numOfPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numOfPlayers.Name = "numOfPlayers";
            this.numOfPlayers.Size = new System.Drawing.Size(107, 23);
            this.numOfPlayers.TabIndex = 7;
            this.numOfPlayers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numOfPlayers.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(170, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "PlayerCount";
            // 
            // SaveBox
            // 
            this.SaveBox.DefaultExt = "Team File|*.team";
            this.SaveBox.Filter = "Team File (*.team)|*.team|All Files(*.*)|*.*";
            // 
            // OpenBox
            // 
            this.OpenBox.DefaultExt = "Team File (*.team)|*.team";
            this.OpenBox.Filter = "Team File (*.team)|*.team|All Files (*.*)|*.*";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(439, 24);
            this.MainMenu.TabIndex = 15;
            this.MainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMatchStatsToolStripMenuItem,
            this.loadConfigurationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "Match";
            // 
            // loadMatchStatsToolStripMenuItem
            // 
            this.loadMatchStatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchToolStripMenuItem,
            this.matchStatToolStripMenuItem,
            this.matchConfigurationToolStripMenuItem,
            this.teamToolStripMenuItem});
            this.loadMatchStatsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadMatchStatsToolStripMenuItem.Image")));
            this.loadMatchStatsToolStripMenuItem.Name = "loadMatchStatsToolStripMenuItem";
            this.loadMatchStatsToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadMatchStatsToolStripMenuItem.Text = "Load";
            // 
            // matchToolStripMenuItem
            // 
            this.matchToolStripMenuItem.Name = "matchToolStripMenuItem";
            this.matchToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.matchToolStripMenuItem.Text = "Match";
            this.matchToolStripMenuItem.Click += new System.EventHandler(this.matchToolStripMenuItem_Click);
            // 
            // matchStatToolStripMenuItem
            // 
            this.matchStatToolStripMenuItem.Name = "matchStatToolStripMenuItem";
            this.matchStatToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.matchStatToolStripMenuItem.Text = "Match Stat";
            this.matchStatToolStripMenuItem.Click += new System.EventHandler(this.matchStatToolStripMenuItem_Click);
            // 
            // matchConfigurationToolStripMenuItem
            // 
            this.matchConfigurationToolStripMenuItem.Name = "matchConfigurationToolStripMenuItem";
            this.matchConfigurationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.matchConfigurationToolStripMenuItem.Text = "Match Configuration";
            this.matchConfigurationToolStripMenuItem.Click += new System.EventHandler(this.matchConfigurationToolStripMenuItem_Click);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.team1ToolStripMenuItem,
            this.team2ToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.teamToolStripMenuItem.Text = "Team Info";
            this.teamToolStripMenuItem.Click += new System.EventHandler(this.teamToolStripMenuItem_Click);
            // 
            // team1ToolStripMenuItem
            // 
            this.team1ToolStripMenuItem.Name = "team1ToolStripMenuItem";
            this.team1ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.team1ToolStripMenuItem.Text = "Team 1";
            this.team1ToolStripMenuItem.Click += new System.EventHandler(this.team1ToolStripMenuItem_Click);
            // 
            // team2ToolStripMenuItem
            // 
            this.team2ToolStripMenuItem.Name = "team2ToolStripMenuItem";
            this.team2ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.team2ToolStripMenuItem.Text = "Team 2";
            this.team2ToolStripMenuItem.Click += new System.EventHandler(this.team2ToolStripMenuItem_Click);
            // 
            // loadConfigurationToolStripMenuItem
            // 
            this.loadConfigurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchConfigurationToolStripMenuItem1,
            this.teamInfoToolStripMenuItem});
            this.loadConfigurationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadConfigurationToolStripMenuItem.Image")));
            this.loadConfigurationToolStripMenuItem.Name = "loadConfigurationToolStripMenuItem";
            this.loadConfigurationToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadConfigurationToolStripMenuItem.Text = "Save";
            // 
            // matchConfigurationToolStripMenuItem1
            // 
            this.matchConfigurationToolStripMenuItem1.Name = "matchConfigurationToolStripMenuItem1";
            this.matchConfigurationToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.matchConfigurationToolStripMenuItem1.Text = "Match Configuration";
            this.matchConfigurationToolStripMenuItem1.Click += new System.EventHandler(this.matchConfigurationToolStripMenuItem1_Click);
            // 
            // teamInfoToolStripMenuItem
            // 
            this.teamInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.team1ToolStripMenuItem1,
            this.team2ToolStripMenuItem1});
            this.teamInfoToolStripMenuItem.Name = "teamInfoToolStripMenuItem";
            this.teamInfoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.teamInfoToolStripMenuItem.Text = "Team Info";
            // 
            // team1ToolStripMenuItem1
            // 
            this.team1ToolStripMenuItem1.Name = "team1ToolStripMenuItem1";
            this.team1ToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.team1ToolStripMenuItem1.Text = "Team 1";
            this.team1ToolStripMenuItem1.Click += new System.EventHandler(this.team1ToolStripMenuItem1_Click);
            // 
            // team2ToolStripMenuItem1
            // 
            this.team2ToolStripMenuItem1.Name = "team2ToolStripMenuItem1";
            this.team2ToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.team2ToolStripMenuItem1.Text = "Team 2";
            this.team2ToolStripMenuItem1.Click += new System.EventHandler(this.team2ToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(439, 416);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numOfPlayers);
            this.Controls.Add(this.OverLimit);
            this.Controls.Add(this.bowlingLimit);
            this.Controls.Add(this.team2Bat);
            this.Controls.Add(this.team1Bat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OversTotal);
            this.Controls.Add(this.Team2);
            this.Controls.Add(this.Team1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.team2TextBox);
            this.Controls.Add(this.team1TextBox);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 455);
            this.MinimumSize = new System.Drawing.Size(455, 455);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cricket Score Board";
            this.SaveLoadContextMenuForTeam1.ResumeLayout(false);
            this.SaveLoadContextMenuForTeam2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OversTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlingLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfPlayers)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox team1TextBox;
        private System.Windows.Forms.TextBox team2TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Team1;
        private System.Windows.Forms.TextBox Team2;
        private System.Windows.Forms.NumericUpDown OversTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton team1Bat;
        private System.Windows.Forms.RadioButton team2Bat;
        private System.Windows.Forms.NumericUpDown bowlingLimit;
        private System.Windows.Forms.Label OverLimit;
        private System.Windows.Forms.NumericUpDown numOfPlayers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog SaveBox;
        private System.Windows.Forms.OpenFileDialog OpenBox;
        private System.Windows.Forms.ContextMenuStrip SaveLoadContextMenuForTeam1;
        private System.Windows.Forms.ToolStripMenuItem saveTeamInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTeamInfoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMatchStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchStatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchConfigurationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem teamInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem team1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem team2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem team1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem team2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem matchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip SaveLoadContextMenuForTeam2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;


    }
}