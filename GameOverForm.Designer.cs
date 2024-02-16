namespace GallowsApp
{
    partial class GameOverForm
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
            statusLabel = new Label();
            playAgainButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Snap ITC", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            statusLabel.ForeColor = Color.FromArgb(0, 192, 0);
            statusLabel.Location = new Point(46, 19);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(252, 61);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "You win";
            // 
            // playAgainButton
            // 
            playAgainButton.BackColor = Color.FromArgb(0, 192, 0);
            playAgainButton.FlatAppearance.BorderSize = 0;
            playAgainButton.FlatStyle = FlatStyle.Flat;
            playAgainButton.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            playAgainButton.ForeColor = Color.White;
            playAgainButton.Location = new Point(46, 112);
            playAgainButton.Name = "playAgainButton";
            playAgainButton.Size = new Size(261, 70);
            playAgainButton.TabIndex = 1;
            playAgainButton.Text = "Play Again";
            playAgainButton.UseVisualStyleBackColor = false;
            playAgainButton.Click += playAgainButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Red;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Georgia", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(79, 214);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(195, 61);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // GameOverForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(365, 320);
            Controls.Add(exitButton);
            Controls.Add(playAgainButton);
            Controls.Add(statusLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameOverForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gallows";
            FormClosing += GameOverForm_FormClosing;
            Load += GameOverForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label statusLabel;
        private Button playAgainButton;
        private Button exitButton;
    }
}