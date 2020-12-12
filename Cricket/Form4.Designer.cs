namespace Cricket
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.hypotheticalRRLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hypotheticalRR = new System.Windows.Forms.TextBox();
            this.hypotheticalScore = new System.Windows.Forms.TextBox();
            this.hypotheticalVerdict = new System.Windows.Forms.TextBox();
            this.hypotheticalQuestion = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.whatIfRunRateWasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowMe = new System.Windows.Forms.Button();
            this.optionalLabel = new System.Windows.Forms.Label();
            this.optionalValue = new System.Windows.Forms.TextBox();
            this.errorText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hypotheticalRRLabel
            // 
            this.hypotheticalRRLabel.AutoSize = true;
            this.hypotheticalRRLabel.BackColor = System.Drawing.Color.Transparent;
            this.hypotheticalRRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hypotheticalRRLabel.ForeColor = System.Drawing.Color.White;
            this.hypotheticalRRLabel.Location = new System.Drawing.Point(0, 56);
            this.hypotheticalRRLabel.Name = "hypotheticalRRLabel";
            this.hypotheticalRRLabel.Size = new System.Drawing.Size(144, 13);
            this.hypotheticalRRLabel.TabIndex = 0;
            this.hypotheticalRRLabel.Text = "What if the run rate was";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score would be";
            // 
            // hypotheticalRR
            // 
            this.hypotheticalRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hypotheticalRR.Location = new System.Drawing.Point(147, 50);
            this.hypotheticalRR.Name = "hypotheticalRR";
            this.hypotheticalRR.Size = new System.Drawing.Size(114, 26);
            this.hypotheticalRR.TabIndex = 2;
            this.hypotheticalRR.TextChanged += new System.EventHandler(this.hypotheticalRR_TextChanged);
            // 
            // hypotheticalScore
            // 
            this.hypotheticalScore.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hypotheticalScore.Enabled = false;
            this.hypotheticalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hypotheticalScore.ForeColor = System.Drawing.Color.Red;
            this.hypotheticalScore.Location = new System.Drawing.Point(147, 92);
            this.hypotheticalScore.Name = "hypotheticalScore";
            this.hypotheticalScore.Size = new System.Drawing.Size(114, 26);
            this.hypotheticalScore.TabIndex = 3;
            // 
            // hypotheticalVerdict
            // 
            this.hypotheticalVerdict.Enabled = false;
            this.hypotheticalVerdict.Location = new System.Drawing.Point(15, 207);
            this.hypotheticalVerdict.Multiline = true;
            this.hypotheticalVerdict.Name = "hypotheticalVerdict";
            this.hypotheticalVerdict.Size = new System.Drawing.Size(503, 20);
            this.hypotheticalVerdict.TabIndex = 4;
            // 
            // hypotheticalQuestion
            // 
            this.hypotheticalQuestion.ContextMenuStrip = this.contextMenuStrip1;
            this.hypotheticalQuestion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.hypotheticalQuestion.FormattingEnabled = true;
            this.hypotheticalQuestion.Items.AddRange(new object[] {
            "What should be the Run Rate to Win?",
            "What should be the Run Rate to reach score X?",
            "What should be the Run Rate to Win with X overs remaining?",
            "What should be the Run Rate to reach score X with X overs remaining?"});
            this.hypotheticalQuestion.Location = new System.Drawing.Point(8, 12);
            this.hypotheticalQuestion.Name = "hypotheticalQuestion";
            this.hypotheticalQuestion.Size = new System.Drawing.Size(510, 21);
            this.hypotheticalQuestion.TabIndex = 5;
            this.hypotheticalQuestion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whatIfRunRateWasToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 26);
            // 
            // whatIfRunRateWasToolStripMenuItem
            // 
            this.whatIfRunRateWasToolStripMenuItem.Name = "whatIfRunRateWasToolStripMenuItem";
            this.whatIfRunRateWasToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.whatIfRunRateWasToolStripMenuItem.Text = "WhatIfRunRateWas";
            this.whatIfRunRateWasToolStripMenuItem.Click += new System.EventHandler(this.whatIfRunRateWasToolStripMenuItem_Click);
            // 
            // ShowMe
            // 
            this.ShowMe.Location = new System.Drawing.Point(363, 106);
            this.ShowMe.Name = "ShowMe";
            this.ShowMe.Size = new System.Drawing.Size(66, 23);
            this.ShowMe.TabIndex = 6;
            this.ShowMe.Text = "Find Answers";
            this.ShowMe.UseVisualStyleBackColor = true;
            this.ShowMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // optionalLabel
            // 
            this.optionalLabel.AutoSize = true;
            this.optionalLabel.Location = new System.Drawing.Point(265, 56);
            this.optionalLabel.Name = "optionalLabel";
            this.optionalLabel.Size = new System.Drawing.Size(0, 13);
            this.optionalLabel.TabIndex = 10;
            // 
            // optionalValue
            // 
            this.optionalValue.BackColor = System.Drawing.Color.White;
            this.optionalValue.Enabled = false;
            this.optionalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionalValue.Location = new System.Drawing.Point(363, 50);
            this.optionalValue.Name = "optionalValue";
            this.optionalValue.Size = new System.Drawing.Size(155, 26);
            this.optionalValue.TabIndex = 11;
            this.optionalValue.TextChanged += new System.EventHandler(this.optionalValue_TextChanged);
            // 
            // errorText
            // 
            this.errorText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.errorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorText.Enabled = false;
            this.errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Location = new System.Drawing.Point(363, 78);
            this.errorText.Multiline = true;
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(155, 61);
            this.errorText.TabIndex = 12;
            this.errorText.TextChanged += new System.EventHandler(this.errorText_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(528, 237);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.optionalValue);
            this.Controls.Add(this.optionalLabel);
            this.Controls.Add(this.ShowMe);
            this.Controls.Add(this.hypotheticalQuestion);
            this.Controls.Add(this.hypotheticalVerdict);
            this.Controls.Add(this.hypotheticalScore);
            this.Controls.Add(this.hypotheticalRR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hypotheticalRRLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.ShowInTaskbar = false;
            this.Text = "What If Analysis";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hypotheticalRRLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hypotheticalRR;
        private System.Windows.Forms.TextBox hypotheticalScore;
        private System.Windows.Forms.TextBox hypotheticalVerdict;
        private System.Windows.Forms.ComboBox hypotheticalQuestion;
        private System.Windows.Forms.Button ShowMe;
        private System.Windows.Forms.Label optionalLabel;
        private System.Windows.Forms.TextBox optionalValue;
        private System.Windows.Forms.TextBox errorText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem whatIfRunRateWasToolStripMenuItem;
    }
}