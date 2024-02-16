using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GallowsApp
{
    public partial class GameOverForm : Form
    {
        private Form1 _mainForm;
        private bool _isWin;
        private bool _isPlayAgainButtonClick;
        public GameOverForm(Form1 mainForm, bool isWin)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _isWin = isWin;
            _isPlayAgainButtonClick = false;
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            _mainForm.UpdateGame();
            _isPlayAgainButtonClick = true;
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.Close();
        }

        private void GameOverForm_Load(object sender, EventArgs e)
        {
            if (_isWin)
            {
                statusLabel.ForeColor = Color.LightGreen;
                statusLabel.Text = "You win!";
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "You lose!";
            }
        }

        private void GameOverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isPlayAgainButtonClick)
                _mainForm.Close();
        }
    }
}
