namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.rockBtn = new System.Windows.Forms.Button();
            this.paperBtn = new System.Windows.Forms.Button();
            this.scissorsBtn = new System.Windows.Forms.Button();
            this.playerScoreLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.computerIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userChoiceIcon = new System.Windows.Forms.PictureBox();
            this.computerChoiceIcon = new System.Windows.Forms.PictureBox();
            this.playerStateLabel = new System.Windows.Forms.Label();
            this.computerStateLabel = new System.Windows.Forms.Label();
            this.finalWinnerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userChoiceIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerChoiceIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(196, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(207, 148);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 3;
            this.logoBox.TabStop = false;
            // 
            // rockBtn
            // 
            this.rockBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rockBtn.Location = new System.Drawing.Point(57, 246);
            this.rockBtn.Name = "rockBtn";
            this.rockBtn.Size = new System.Drawing.Size(111, 36);
            this.rockBtn.TabIndex = 4;
            this.rockBtn.Text = "Rock";
            this.rockBtn.UseVisualStyleBackColor = true;
            this.rockBtn.Click += new System.EventHandler(this.rockBtn_Click);
            // 
            // paperBtn
            // 
            this.paperBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.paperBtn.Location = new System.Drawing.Point(248, 246);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(111, 36);
            this.paperBtn.TabIndex = 5;
            this.paperBtn.Text = "Paper";
            this.paperBtn.UseVisualStyleBackColor = true;
            this.paperBtn.Click += new System.EventHandler(this.paperBtn_Click);
            // 
            // scissorsBtn
            // 
            this.scissorsBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.scissorsBtn.Location = new System.Drawing.Point(441, 246);
            this.scissorsBtn.Name = "scissorsBtn";
            this.scissorsBtn.Size = new System.Drawing.Size(111, 36);
            this.scissorsBtn.TabIndex = 6;
            this.scissorsBtn.Text = "Scissors";
            this.scissorsBtn.UseVisualStyleBackColor = true;
            this.scissorsBtn.Click += new System.EventHandler(this.scissorsBtn_Click);
            // 
            // playerScoreLabel
            // 
            this.playerScoreLabel.AutoSize = true;
            this.playerScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.playerScoreLabel.Location = new System.Drawing.Point(15, 78);
            this.playerScoreLabel.Name = "playerScoreLabel";
            this.playerScoreLabel.Size = new System.Drawing.Size(20, 23);
            this.playerScoreLabel.TabIndex = 7;
            this.playerScoreLabel.Text = "0";
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.computerScoreLabel.Location = new System.Drawing.Point(557, 69);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(20, 23);
            this.computerScoreLabel.TabIndex = 8;
            this.computerScoreLabel.Text = "0";
            // 
            // newGameBtn
            // 
            this.newGameBtn.Font = new System.Drawing.Font("Comic Sans MS", 8F);
            this.newGameBtn.Location = new System.Drawing.Point(262, 340);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(75, 23);
            this.newGameBtn.TabIndex = 9;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            this.newGameBtn.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // userIcon
            // 
            this.userIcon.Image = ((System.Drawing.Image)(resources.GetObject("userIcon.Image")));
            this.userIcon.Location = new System.Drawing.Point(16, 25);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(35, 50);
            this.userIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userIcon.TabIndex = 10;
            this.userIcon.TabStop = false;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.playerLabel.Location = new System.Drawing.Point(57, 25);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(77, 27);
            this.playerLabel.TabIndex = 11;
            this.playerLabel.Text = "Player:";
            // 
            // computerIcon
            // 
            this.computerIcon.Image = ((System.Drawing.Image)(resources.GetObject("computerIcon.Image")));
            this.computerIcon.Location = new System.Drawing.Point(558, 16);
            this.computerIcon.Name = "computerIcon";
            this.computerIcon.Size = new System.Drawing.Size(32, 50);
            this.computerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerIcon.TabIndex = 12;
            this.computerIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(449, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Computer:";
            // 
            // userChoiceIcon
            // 
            this.userChoiceIcon.Location = new System.Drawing.Point(57, 55);
            this.userChoiceIcon.Name = "userChoiceIcon";
            this.userChoiceIcon.Size = new System.Drawing.Size(118, 131);
            this.userChoiceIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userChoiceIcon.TabIndex = 14;
            this.userChoiceIcon.TabStop = false;
            // 
            // computerChoiceIcon
            // 
            this.computerChoiceIcon.Location = new System.Drawing.Point(434, 55);
            this.computerChoiceIcon.Name = "computerChoiceIcon";
            this.computerChoiceIcon.Size = new System.Drawing.Size(118, 131);
            this.computerChoiceIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computerChoiceIcon.TabIndex = 15;
            this.computerChoiceIcon.TabStop = false;
            // 
            // playerStateLabel
            // 
            this.playerStateLabel.AutoSize = true;
            this.playerStateLabel.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.playerStateLabel.Location = new System.Drawing.Point(56, 189);
            this.playerStateLabel.Name = "playerStateLabel";
            this.playerStateLabel.Size = new System.Drawing.Size(0, 31);
            this.playerStateLabel.TabIndex = 16;
            // 
            // computerStateLabel
            // 
            this.computerStateLabel.AutoSize = true;
            this.computerStateLabel.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.computerStateLabel.Location = new System.Drawing.Point(428, 189);
            this.computerStateLabel.Name = "computerStateLabel";
            this.computerStateLabel.Size = new System.Drawing.Size(0, 31);
            this.computerStateLabel.TabIndex = 17;
            // 
            // finalWinnerLabel
            // 
            this.finalWinnerLabel.AutoSize = true;
            this.finalWinnerLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.finalWinnerLabel.Location = new System.Drawing.Point(243, 191);
            this.finalWinnerLabel.Name = "finalWinnerLabel";
            this.finalWinnerLabel.Size = new System.Drawing.Size(0, 27);
            this.finalWinnerLabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 372);
            this.Controls.Add(this.finalWinnerLabel);
            this.Controls.Add(this.computerStateLabel);
            this.Controls.Add(this.playerStateLabel);
            this.Controls.Add(this.computerChoiceIcon);
            this.Controls.Add(this.userChoiceIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.computerIcon);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.userIcon);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.computerScoreLabel);
            this.Controls.Add(this.playerScoreLabel);
            this.Controls.Add(this.scissorsBtn);
            this.Controls.Add(this.paperBtn);
            this.Controls.Add(this.rockBtn);
            this.Controls.Add(this.logoBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userChoiceIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerChoiceIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button rockBtn;
        private System.Windows.Forms.Button paperBtn;
        private System.Windows.Forms.Button scissorsBtn;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.PictureBox computerIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox userChoiceIcon;
        private System.Windows.Forms.PictureBox computerChoiceIcon;
        private System.Windows.Forms.Label playerStateLabel;
        private System.Windows.Forms.Label computerStateLabel;
        private System.Windows.Forms.Label finalWinnerLabel;
    }
}

