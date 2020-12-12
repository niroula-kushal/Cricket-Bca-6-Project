namespace Cricket
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Batsman2Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OversLeftValue = new System.Windows.Forms.Label();
            this.OversLeftLabel = new System.Windows.Forms.Label();
            this.BowlingPanel = new System.Windows.Forms.Panel();
            this.BowlsDetails = new System.Windows.Forms.Label();
            this.LegalDelivery = new System.Windows.Forms.RadioButton();
            this.Out = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Extras = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.bowlerLabel = new System.Windows.Forms.Label();
            this.RunsOffBat = new System.Windows.Forms.NumericUpDown();
            this.wide = new System.Windows.Forms.RadioButton();
            this.noBall = new System.Windows.Forms.RadioButton();
            this.outMechanics = new System.Windows.Forms.Panel();
            this.Caught = new System.Windows.Forms.RadioButton();
            this.RunOut = new System.Windows.Forms.RadioButton();
            this.Batsman1Label = new System.Windows.Forms.Label();
            this.BatsmanList = new System.Windows.Forms.ListBox();
            this.BowlerList = new System.Windows.Forms.ListBox();
            this.Score = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TargetValue = new System.Windows.Forms.Label();
            this.Batsman1Score = new System.Windows.Forms.Label();
            this.Batsman2Score = new System.Windows.Forms.Label();
            this.RunRatesAndStuffs = new System.Windows.Forms.GroupBox();
            this.rrOrProjValue = new System.Windows.Forms.Label();
            this.crrValue = new System.Windows.Forms.Label();
            this.neededForBowling = new System.Windows.Forms.TextBox();
            this.neededForBatting = new System.Windows.Forms.TextBox();
            this.ReqRRorProjected = new System.Windows.Forms.Label();
            this.CRR = new System.Windows.Forms.Label();
            this.MainContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SaveMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBox = new System.Windows.Forms.SaveFileDialog();
            this.batteam = new System.Windows.Forms.TextBox();
            this.Target = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.BowlingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Extras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunsOffBat)).BeginInit();
            this.outMechanics.SuspendLayout();
            this.RunRatesAndStuffs.SuspendLayout();
            this.MainContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asynchronous Scoreboard Utility";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RunOffBat";
            // 
            // Batsman2Label
            // 
            this.Batsman2Label.AutoEllipsis = true;
            this.Batsman2Label.AutoSize = true;
            this.Batsman2Label.BackColor = System.Drawing.Color.Transparent;
            this.Batsman2Label.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batsman2Label.ForeColor = System.Drawing.SystemColors.Info;
            this.Batsman2Label.Location = new System.Drawing.Point(2, 111);
            this.Batsman2Label.Name = "Batsman2Label";
            this.Batsman2Label.Size = new System.Drawing.Size(69, 16);
            this.Batsman2Label.TabIndex = 2;
            this.Batsman2Label.Text = "Batsman2";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.OversLeftValue);
            this.groupBox1.Controls.Add(this.OversLeftLabel);
            this.groupBox1.Controls.Add(this.BowlingPanel);
            this.groupBox1.Controls.Add(this.LegalDelivery);
            this.groupBox1.Controls.Add(this.Out);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Extras);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bowlerLabel);
            this.groupBox1.Controls.Add(this.RunsOffBat);
            this.groupBox1.Controls.Add(this.wide);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.noBall);
            this.groupBox1.Controls.Add(this.outMechanics);
            this.groupBox1.Location = new System.Drawing.Point(170, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 256);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BallByBall";
            // 
            // OversLeftValue
            // 
            this.OversLeftValue.AutoSize = true;
            this.OversLeftValue.Location = new System.Drawing.Point(338, 35);
            this.OversLeftValue.Name = "OversLeftValue";
            this.OversLeftValue.Size = new System.Drawing.Size(15, 13);
            this.OversLeftValue.TabIndex = 29;
            this.OversLeftValue.Text = "{}";
            // 
            // OversLeftLabel
            // 
            this.OversLeftLabel.AutoSize = true;
            this.OversLeftLabel.Location = new System.Drawing.Point(276, 35);
            this.OversLeftLabel.Name = "OversLeftLabel";
            this.OversLeftLabel.Size = new System.Drawing.Size(62, 13);
            this.OversLeftLabel.TabIndex = 28;
            this.OversLeftLabel.Text = "Overs Left: ";
            // 
            // BowlingPanel
            // 
            this.BowlingPanel.AutoScroll = true;
            this.BowlingPanel.Controls.Add(this.BowlsDetails);
            this.BowlingPanel.Location = new System.Drawing.Point(108, 182);
            this.BowlingPanel.Name = "BowlingPanel";
            this.BowlingPanel.Size = new System.Drawing.Size(188, 55);
            this.BowlingPanel.TabIndex = 26;
            // 
            // BowlsDetails
            // 
            this.BowlsDetails.AutoSize = true;
            this.BowlsDetails.Location = new System.Drawing.Point(8, 11);
            this.BowlsDetails.Name = "BowlsDetails";
            this.BowlsDetails.Size = new System.Drawing.Size(0, 13);
            this.BowlsDetails.TabIndex = 17;
            // 
            // LegalDelivery
            // 
            this.LegalDelivery.AutoSize = true;
            this.LegalDelivery.Checked = true;
            this.LegalDelivery.Location = new System.Drawing.Point(13, 33);
            this.LegalDelivery.Name = "LegalDelivery";
            this.LegalDelivery.Size = new System.Drawing.Size(89, 17);
            this.LegalDelivery.TabIndex = 15;
            this.LegalDelivery.TabStop = true;
            this.LegalDelivery.Text = "LegalDelivery";
            this.LegalDelivery.UseVisualStyleBackColor = true;
            this.LegalDelivery.CheckedChanged += new System.EventHandler(this.LegalDelivery_CheckedChanged);
            // 
            // Out
            // 
            this.Out.AutoSize = true;
            this.Out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Out.Location = new System.Drawing.Point(25, 147);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(41, 17);
            this.Out.TabIndex = 10;
            this.Out.Text = "Out";
            this.Out.UseVisualStyleBackColor = true;
            this.Out.CheckedChanged += new System.EventHandler(this.Out_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(302, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "NextBall";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.EnabledChanged += new System.EventHandler(this.NextBallEnabledChanged);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Extras
            // 
            this.Extras.Location = new System.Drawing.Point(119, 109);
            this.Extras.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Extras.Name = "Extras";
            this.Extras.Size = new System.Drawing.Size(120, 20);
            this.Extras.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Extras";
            // 
            // bowlerLabel
            // 
            this.bowlerLabel.AutoSize = true;
            this.bowlerLabel.Location = new System.Drawing.Point(23, 193);
            this.bowlerLabel.Name = "bowlerLabel";
            this.bowlerLabel.Size = new System.Drawing.Size(39, 13);
            this.bowlerLabel.TabIndex = 6;
            this.bowlerLabel.Text = "Bowler";
            // 
            // RunsOffBat
            // 
            this.RunsOffBat.Location = new System.Drawing.Point(119, 74);
            this.RunsOffBat.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.RunsOffBat.Name = "RunsOffBat";
            this.RunsOffBat.Size = new System.Drawing.Size(120, 20);
            this.RunsOffBat.TabIndex = 4;
            // 
            // wide
            // 
            this.wide.AutoSize = true;
            this.wide.Location = new System.Drawing.Point(119, 33);
            this.wide.Name = "wide";
            this.wide.Size = new System.Drawing.Size(50, 17);
            this.wide.TabIndex = 3;
            this.wide.Text = "Wide";
            this.wide.UseVisualStyleBackColor = true;
            this.wide.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // noBall
            // 
            this.noBall.AutoSize = true;
            this.noBall.Location = new System.Drawing.Point(199, 33);
            this.noBall.Name = "noBall";
            this.noBall.Size = new System.Drawing.Size(56, 17);
            this.noBall.TabIndex = 0;
            this.noBall.Text = "NoBall";
            this.noBall.UseVisualStyleBackColor = true;
            this.noBall.CheckedChanged += new System.EventHandler(this.noBall_CheckedChanged);
            // 
            // outMechanics
            // 
            this.outMechanics.BackColor = System.Drawing.Color.Transparent;
            this.outMechanics.Controls.Add(this.Caught);
            this.outMechanics.Controls.Add(this.RunOut);
            this.outMechanics.Location = new System.Drawing.Point(108, 135);
            this.outMechanics.Name = "outMechanics";
            this.outMechanics.Size = new System.Drawing.Size(291, 41);
            this.outMechanics.TabIndex = 16;
            // 
            // Caught
            // 
            this.Caught.AutoSize = true;
            this.Caught.Location = new System.Drawing.Point(21, 14);
            this.Caught.Name = "Caught";
            this.Caught.Size = new System.Drawing.Size(59, 17);
            this.Caught.TabIndex = 19;
            this.Caught.TabStop = true;
            this.Caught.Text = "Caught";
            this.Caught.UseVisualStyleBackColor = true;
            this.Caught.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // RunOut
            // 
            this.RunOut.AutoSize = true;
            this.RunOut.Location = new System.Drawing.Point(146, 14);
            this.RunOut.Name = "RunOut";
            this.RunOut.Size = new System.Drawing.Size(62, 17);
            this.RunOut.TabIndex = 18;
            this.RunOut.TabStop = true;
            this.RunOut.Text = "RunOut";
            this.RunOut.UseVisualStyleBackColor = true;
            // 
            // Batsman1Label
            // 
            this.Batsman1Label.AutoEllipsis = true;
            this.Batsman1Label.AutoSize = true;
            this.Batsman1Label.BackColor = System.Drawing.Color.Transparent;
            this.Batsman1Label.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batsman1Label.ForeColor = System.Drawing.Color.Red;
            this.Batsman1Label.Location = new System.Drawing.Point(2, 56);
            this.Batsman1Label.Name = "Batsman1Label";
            this.Batsman1Label.Size = new System.Drawing.Size(68, 16);
            this.Batsman1Label.TabIndex = 5;
            this.Batsman1Label.Text = "Batsman1";
            // 
            // BatsmanList
            // 
            this.BatsmanList.BackColor = System.Drawing.Color.BurlyWood;
            this.BatsmanList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BatsmanList.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BatsmanList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BatsmanList.FormattingEnabled = true;
            this.BatsmanList.ItemHeight = 19;
            this.BatsmanList.Location = new System.Drawing.Point(961, 34);
            this.BatsmanList.Name = "BatsmanList";
            this.BatsmanList.Size = new System.Drawing.Size(120, 228);
            this.BatsmanList.TabIndex = 7;
            this.BatsmanList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BowlerList
            // 
            this.BowlerList.BackColor = System.Drawing.Color.BurlyWood;
            this.BowlerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BowlerList.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BowlerList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BowlerList.FormattingEnabled = true;
            this.BowlerList.ItemHeight = 19;
            this.BowlerList.Location = new System.Drawing.Point(1144, 34);
            this.BowlerList.Name = "BowlerList";
            this.BowlerList.Size = new System.Drawing.Size(116, 228);
            this.BowlerList.TabIndex = 8;
            this.BowlerList.SelectedIndexChanged += new System.EventHandler(this.BowlerList_SelectedIndexChanged);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.ForeColor = System.Drawing.Color.Blue;
            this.Score.Location = new System.Drawing.Point(103, 163);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(24, 13);
            this.Score.TabIndex = 9;
            this.Score.Text = "0/0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(958, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Batsmen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(1141, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bowlers";
            // 
            // TargetValue
            // 
            this.TargetValue.AutoSize = true;
            this.TargetValue.BackColor = System.Drawing.Color.Transparent;
            this.TargetValue.ForeColor = System.Drawing.Color.Blue;
            this.TargetValue.Location = new System.Drawing.Point(103, 194);
            this.TargetValue.Name = "TargetValue";
            this.TargetValue.Size = new System.Drawing.Size(24, 13);
            this.TargetValue.TabIndex = 24;
            this.TargetValue.Text = "0/0";
            // 
            // Batsman1Score
            // 
            this.Batsman1Score.AutoSize = true;
            this.Batsman1Score.BackColor = System.Drawing.Color.Transparent;
            this.Batsman1Score.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batsman1Score.ForeColor = System.Drawing.Color.Red;
            this.Batsman1Score.Location = new System.Drawing.Point(73, 56);
            this.Batsman1Score.Name = "Batsman1Score";
            this.Batsman1Score.Size = new System.Drawing.Size(78, 16);
            this.Batsman1Score.TabIndex = 26;
            this.Batsman1Score.Text = "Runs(Balls)";
            // 
            // Batsman2Score
            // 
            this.Batsman2Score.AutoSize = true;
            this.Batsman2Score.BackColor = System.Drawing.Color.Transparent;
            this.Batsman2Score.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Batsman2Score.ForeColor = System.Drawing.SystemColors.Info;
            this.Batsman2Score.Location = new System.Drawing.Point(73, 111);
            this.Batsman2Score.Name = "Batsman2Score";
            this.Batsman2Score.Size = new System.Drawing.Size(81, 16);
            this.Batsman2Score.TabIndex = 27;
            this.Batsman2Score.Text = "Runs (Balls)";
            // 
            // RunRatesAndStuffs
            // 
            this.RunRatesAndStuffs.BackColor = System.Drawing.Color.Transparent;
            this.RunRatesAndStuffs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RunRatesAndStuffs.Controls.Add(this.rrOrProjValue);
            this.RunRatesAndStuffs.Controls.Add(this.crrValue);
            this.RunRatesAndStuffs.Controls.Add(this.neededForBowling);
            this.RunRatesAndStuffs.Controls.Add(this.neededForBatting);
            this.RunRatesAndStuffs.Controls.Add(this.ReqRRorProjected);
            this.RunRatesAndStuffs.Controls.Add(this.CRR);
            this.RunRatesAndStuffs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RunRatesAndStuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunRatesAndStuffs.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RunRatesAndStuffs.Location = new System.Drawing.Point(961, 297);
            this.RunRatesAndStuffs.Name = "RunRatesAndStuffs";
            this.RunRatesAndStuffs.Size = new System.Drawing.Size(299, 221);
            this.RunRatesAndStuffs.TabIndex = 28;
            this.RunRatesAndStuffs.TabStop = false;
            this.RunRatesAndStuffs.Text = "CurrentSituation";
            // 
            // rrOrProjValue
            // 
            this.rrOrProjValue.AutoSize = true;
            this.rrOrProjValue.Location = new System.Drawing.Point(192, 63);
            this.rrOrProjValue.Name = "rrOrProjValue";
            this.rrOrProjValue.Size = new System.Drawing.Size(0, 13);
            this.rrOrProjValue.TabIndex = 6;
            // 
            // crrValue
            // 
            this.crrValue.AutoSize = true;
            this.crrValue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.crrValue.Location = new System.Drawing.Point(192, 31);
            this.crrValue.Name = "crrValue";
            this.crrValue.Size = new System.Drawing.Size(21, 13);
            this.crrValue.TabIndex = 5;
            this.crrValue.Text = "{ }";
            // 
            // neededForBowling
            // 
            this.neededForBowling.BackColor = System.Drawing.Color.Tan;
            this.neededForBowling.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.neededForBowling.Enabled = false;
            this.neededForBowling.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neededForBowling.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.neededForBowling.Location = new System.Drawing.Point(15, 148);
            this.neededForBowling.Multiline = true;
            this.neededForBowling.Name = "neededForBowling";
            this.neededForBowling.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.neededForBowling.Size = new System.Drawing.Size(240, 51);
            this.neededForBowling.TabIndex = 4;
            // 
            // neededForBatting
            // 
            this.neededForBatting.BackColor = System.Drawing.Color.Tan;
            this.neededForBatting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.neededForBatting.Cursor = System.Windows.Forms.Cursors.Default;
            this.neededForBatting.Enabled = false;
            this.neededForBatting.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neededForBatting.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.neededForBatting.Location = new System.Drawing.Point(15, 91);
            this.neededForBatting.Multiline = true;
            this.neededForBatting.Name = "neededForBatting";
            this.neededForBatting.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.neededForBatting.Size = new System.Drawing.Size(240, 51);
            this.neededForBatting.TabIndex = 3;
            // 
            // ReqRRorProjected
            // 
            this.ReqRRorProjected.AutoSize = true;
            this.ReqRRorProjected.Location = new System.Drawing.Point(13, 63);
            this.ReqRRorProjected.Name = "ReqRRorProjected";
            this.ReqRRorProjected.Size = new System.Drawing.Size(0, 13);
            this.ReqRRorProjected.TabIndex = 2;
            // 
            // CRR
            // 
            this.CRR.AutoSize = true;
            this.CRR.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CRR.Location = new System.Drawing.Point(12, 31);
            this.CRR.Name = "CRR";
            this.CRR.Size = new System.Drawing.Size(106, 13);
            this.CRR.TabIndex = 0;
            this.CRR.Text = "Current Run Rate";
            // 
            // MainContextMenu
            // 
            this.MainContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveMatch,
            this.Undo});
            this.MainContextMenu.Name = "MainContextMenu";
            this.MainContextMenu.Size = new System.Drawing.Size(136, 48);
            // 
            // SaveMatch
            // 
            this.SaveMatch.Name = "SaveMatch";
            this.SaveMatch.Size = new System.Drawing.Size(135, 22);
            this.SaveMatch.Text = "Save Match";
            this.SaveMatch.Click += new System.EventHandler(this.SaveMatch_Click);
            // 
            // Undo
            // 
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(135, 22);
            this.Undo.Text = "Undo";
            this.Undo.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // SaveBox
            // 
            this.SaveBox.DefaultExt = "Match File(*.curl)|*.curl";
            this.SaveBox.FileName = "Match1";
            this.SaveBox.Filter = "Match File(*.curl)|*.curl";
            // 
            // batteam
            // 
            this.batteam.BackColor = System.Drawing.Color.BurlyWood;
            this.batteam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.batteam.Enabled = false;
            this.batteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteam.Location = new System.Drawing.Point(5, 163);
            this.batteam.Name = "batteam";
            this.batteam.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.batteam.Size = new System.Drawing.Size(92, 16);
            this.batteam.TabIndex = 29;
            this.batteam.Text = "BatTeam";
            // 
            // Target
            // 
            this.Target.BackColor = System.Drawing.Color.BurlyWood;
            this.Target.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Target.Enabled = false;
            this.Target.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Target.Location = new System.Drawing.Point(5, 190);
            this.Target.Name = "Target";
            this.Target.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Target.Size = new System.Drawing.Size(92, 16);
            this.Target.TabIndex = 30;
            this.Target.Text = "BatTeam";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1272, 537);
            this.ContextMenuStrip = this.MainContextMenu;
            this.Controls.Add(this.Target);
            this.Controls.Add(this.batteam);
            this.Controls.Add(this.RunRatesAndStuffs);
            this.Controls.Add(this.Batsman2Score);
            this.Controls.Add(this.Batsman1Score);
            this.Controls.Add(this.TargetValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.BowlerList);
            this.Controls.Add(this.BatsmanList);
            this.Controls.Add(this.Batsman1Label);
            this.Controls.Add(this.Batsman2Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1022, 576);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cricket Score Board-";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BowlingPanel.ResumeLayout(false);
            this.BowlingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Extras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunsOffBat)).EndInit();
            this.outMechanics.ResumeLayout(false);
            this.outMechanics.PerformLayout();
            this.RunRatesAndStuffs.ResumeLayout(false);
            this.RunRatesAndStuffs.PerformLayout();
            this.MainContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Batsman2Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown RunsOffBat;
        private System.Windows.Forms.RadioButton wide;
        private System.Windows.Forms.RadioButton noBall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Extras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bowlerLabel;
        private System.Windows.Forms.Label Batsman1Label;
        private System.Windows.Forms.ListBox BatsmanList;
        private System.Windows.Forms.ListBox BowlerList;
        private System.Windows.Forms.CheckBox Out;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton LegalDelivery;
        private System.Windows.Forms.Panel outMechanics;
        private System.Windows.Forms.Label TargetValue;
        private System.Windows.Forms.Label BowlsDetails;
        private System.Windows.Forms.RadioButton RunOut;
        private System.Windows.Forms.RadioButton Caught;
        private System.Windows.Forms.Panel BowlingPanel;
        private System.Windows.Forms.Label Batsman1Score;
        private System.Windows.Forms.Label Batsman2Score;
        private System.Windows.Forms.Label OversLeftValue;
        private System.Windows.Forms.Label OversLeftLabel;
        private System.Windows.Forms.GroupBox RunRatesAndStuffs;
        private System.Windows.Forms.TextBox neededForBowling;
        private System.Windows.Forms.TextBox neededForBatting;
        private System.Windows.Forms.Label ReqRRorProjected;
        private System.Windows.Forms.Label CRR;
        private System.Windows.Forms.Label rrOrProjValue;
        private System.Windows.Forms.Label crrValue;
        private System.Windows.Forms.ContextMenuStrip MainContextMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveMatch;
        private System.Windows.Forms.SaveFileDialog SaveBox;
        private System.Windows.Forms.TextBox batteam;
        private System.Windows.Forms.TextBox Target;
        private System.Windows.Forms.ToolStripMenuItem Undo;
    }
}