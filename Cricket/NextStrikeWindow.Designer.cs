namespace Cricket
{
    partial class NextStrikeWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NextStrikeWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.Bats1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Bats2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(233, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Done!!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bats1
            // 
            this.Bats1.AutoSize = true;
            this.Bats1.BackColor = System.Drawing.Color.Transparent;
            this.Bats1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bats1.ForeColor = System.Drawing.Color.Linen;
            this.Bats1.Location = new System.Drawing.Point(61, 66);
            this.Bats1.Name = "Bats1";
            this.Bats1.Size = new System.Drawing.Size(106, 29);
            this.Bats1.TabIndex = 7;
            this.Bats1.TabStop = true;
            this.Bats1.Text = "nameB1";
            this.Bats1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Which batsman should be on strike?";
            // 
            // Bats2
            // 
            this.Bats2.AutoSize = true;
            this.Bats2.BackColor = System.Drawing.Color.Transparent;
            this.Bats2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.Bats2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bats2.ForeColor = System.Drawing.Color.Linen;
            this.Bats2.Location = new System.Drawing.Point(389, 66);
            this.Bats2.Name = "Bats2";
            this.Bats2.Size = new System.Drawing.Size(106, 29);
            this.Bats2.TabIndex = 5;
            this.Bats2.TabStop = true;
            this.Bats2.Text = "nameB2";
            this.Bats2.UseVisualStyleBackColor = false;
            // 
            // NextStrikeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(562, 174);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bats1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bats2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NextStrikeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NextStrikeWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Bats1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Bats2;
    }
}