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
            currentWordPanel.BackColor = SystemColors.ButtonShadow;
            currentWordPanel.Location = new Point(29, 467);
            currentWordPanel.Name = "currentWordPanel";
            currentWordPanel.Size = new Size(1047, 99);
            currentWordPanel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 587);
            Controls.Add(currentWordPanel);
            Controls.Add(mainPictureBox);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox mainPictureBox;
        private Panel currentWordPanel;
    }
}