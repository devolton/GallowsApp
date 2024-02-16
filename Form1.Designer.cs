namespace GallowsApp
{
    partial class Form1
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
            mainPictureBox = new PictureBox();
            currentWordPanel = new Panel();
            scoreMainLabel = new Label();
            playerMainLabel = new Label();
            computerMainLabel = new Label();
            playerScoreLabel = new Label();
            computerScoreLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // mainPictureBox
            // 
            mainPictureBox.Location = new Point(29, 21);
            mainPictureBox.Name = "mainPictureBox";
            mainPictureBox.Size = new Size(430, 421);
            mainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            mainPictureBox.TabIndex = 0;
            mainPictureBox.TabStop = false;
            // 
            // currentWordPanel
            // 
            currentWordPanel.BackColor = Color.White;
            currentWordPanel.BorderStyle = BorderStyle.Fixed3D;
            currentWordPanel.Location = new Point(29, 467);
            currentWordPanel.Name = "currentWordPanel";
            currentWordPanel.Size = new Size(1047, 99);
            currentWordPanel.TabIndex = 1;
            // 
            // scoreMainLabel
            // 
            scoreMainLabel.AutoSize = true;
            scoreMainLabel.Font = new Font("Georgia", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            scoreMainLabel.ForeColor = Color.FromArgb(0, 0, 192);
            scoreMainLabel.Location = new Point(748, 21);
            scoreMainLabel.Name = "scoreMainLabel";
            scoreMainLabel.Size = new Size(150, 51);
            scoreMainLabel.TabIndex = 2;
            scoreMainLabel.Text = "Score";
            // 
            // playerMainLabel
            // 
            playerMainLabel.AutoSize = true;
            playerMainLabel.Font = new Font("Georgia", 24F, FontStyle.Italic, GraphicsUnit.Point);
            playerMainLabel.ForeColor = Color.FromArgb(192, 0, 192);
            playerMainLabel.Location = new Point(575, 110);
            playerMainLabel.Name = "playerMainLabel";
            playerMainLabel.Size = new Size(152, 46);
            playerMainLabel.TabIndex = 3;
            playerMainLabel.Text = "Player:";
            // 
            // computerMainLabel
            // 
            computerMainLabel.AutoSize = true;
            computerMainLabel.Font = new Font("Georgia", 24F, FontStyle.Italic, GraphicsUnit.Point);
            computerMainLabel.ForeColor = Color.FromArgb(192, 0, 192);
            computerMainLabel.Location = new Point(846, 110);
            computerMainLabel.Name = "computerMainLabel";
            computerMainLabel.Size = new Size(214, 46);
            computerMainLabel.TabIndex = 4;
            computerMainLabel.Text = "Computer:";
            // 
            // playerScoreLabel
            // 
            playerScoreLabel.AutoSize = true;
            playerScoreLabel.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            playerScoreLabel.ForeColor = Color.Navy;
            playerScoreLabel.Location = new Point(619, 192);
            playerScoreLabel.Name = "playerScoreLabel";
            playerScoreLabel.Size = new Size(40, 45);
            playerScoreLabel.TabIndex = 5;
            playerScoreLabel.Text = "0";
            // 
            // computerScoreLabel
            // 
            computerScoreLabel.AutoSize = true;
            computerScoreLabel.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            computerScoreLabel.ForeColor = Color.Navy;
            computerScoreLabel.Location = new Point(928, 192);
            computerScoreLabel.Name = "computerScoreLabel";
            computerScoreLabel.Size = new Size(40, 45);
            computerScoreLabel.TabIndex = 6;
            computerScoreLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1105, 587);
            Controls.Add(computerScoreLabel);
            Controls.Add(playerScoreLabel);
            Controls.Add(computerMainLabel);
            Controls.Add(playerMainLabel);
            Controls.Add(scoreMainLabel);
            Controls.Add(currentWordPanel);
            Controls.Add(mainPictureBox);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gallows";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox mainPictureBox;
        private Panel currentWordPanel;
        private Label scoreMainLabel;
        private Label playerMainLabel;
        private Label computerMainLabel;
        private Label playerScoreLabel;
        private Label computerScoreLabel;
    }
}