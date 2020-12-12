namespace Cricket
{
    partial class RunOutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunOutWindow));
            this.nameB2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nameB1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameB2
            // 
            this.nameB2.AutoSize = true;
            this.nameB2.BackColor = System.Drawing.Color.Transparent;
            this.nameB2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.nameB2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameB2.ForeColor = System.Drawing.Color.Linen;
            this.nameB2.Location = new System.Drawing.Point(373, 69);
            this.nameB2.Name = "nameB2";
            this.nameB2.Size = new System.Drawing.Size(106, 29);
            this.nameB2.TabIndex = 1;
            this.nameB2.TabStop = true;
            this.nameB2.Text = "nameB2";
            this.nameB2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(121, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Which batsman was out?";
            // 
            // nameB1
            // 
            this.nameB1.AutoSize = true;
            this.nameB1.BackColor = System.Drawing.Color.Transparent;
            this.nameB1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameB1.ForeColor = System.Drawing.Color.Linen;
            this.nameB1.Location = new System.Drawing.Point(45, 69);
            this.nameB1.Name = "nameB1";
            this.nameB1.Size = new System.Drawing.Size(106, 29);
            this.nameB1.TabIndex = 3;
            this.nameB1.TabStop = true;
            this.nameB1.Text = "nameB1";
            this.nameB1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(217, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Done!!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RunOutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(562, 174);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameB1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameB2);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "RunOutWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunOutWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton nameB2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton nameB1;
        private System.Windows.Forms.Button button1;


    }
}