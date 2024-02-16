using System.Text.Json;

namespace GallowsApp
{
    public partial class Form1 : Form
    {
        private string[] _words;
        private string _wordsFilePath;
        private string _currentChoiceWord;
        private Random _random;
        private string _imagesFolderPath;
        private const int _COORDINATE_LABEL_Y_STEP = 65;
        private List<CharLabel> _charLabels;
        private List<Image> _gallowsImageList;
        private int _currentImageIndex;


        public Form1()
        {
            InitializeComponent();
            _random = new Random();
            _currentImageIndex = 0;
            _charLabels = new List<CharLabel>();
            _imagesFolderPath = "../../../img";
            _wordsFilePath = "../../../words.json";
            _words = LoadWords();
            var imagesPathList = Directory.GetFiles(_imagesFolderPath).ToList();
            _gallowsImageList = new List<Image>();
            foreach (var oneImagePath in imagesPathList)
            {
                _gallowsImageList.Add(Image.FromFile(oneImagePath));
            }

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (_charLabels.Any(oneLabel => oneLabel.Text == e.KeyData.ToString())) return;


            if (_charLabels.Any(oneLabel => oneLabel.Tag?.ToString() == e.KeyData.ToString()) && e.KeyData.ToString() != "_")
            {
                var selectLabelsContainer = _charLabels.Where(oneLabel => oneLabel.Tag?.ToString() == e.KeyData.ToString());
                foreach (var oneSelectLabel in selectLabelsContainer)
                {
                    oneSelectLabel.Text = e.KeyData.ToString();
                    oneSelectLabel.Tag = "_";
                }
                if (_charLabels.All(oneLabel => oneLabel.Tag.ToString() == "_"))
                {
                    var newPlayerScore = int.Parse(playerScoreLabel.Text);
                    playerScoreLabel.Text = (++newPlayerScore).ToString();
                    new GameOverForm(this, true).ShowDialog();
                }

            }

            else
            {
                mainPictureBox.Image = _gallowsImageList[++_currentImageIndex];
                if (_currentImageIndex == _gallowsImageList.Count - 1)
                {

                    foreach (var charLabel in _charLabels)
                    {
                        if (charLabel.Tag.ToString() != "_")
                            charLabel.Text = charLabel?.Tag.ToString();
                    }
                    var newComputerScore = int.Parse(computerScoreLabel.Text);
                    computerScoreLabel.Text = (++newComputerScore).ToString();
                    new GameOverForm(this, false).ShowDialog();
                }


            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ChoiceRandomWorb();
            //MessageBox.Show(_currentChoiceWord);
            DrawLabels();

        }
        public void UpdateGame()
        {
            ChoiceRandomWorb();
            _currentImageIndex = 0;
            currentWordPanel.Controls.Clear();
            _charLabels.Clear();
            DrawLabels();

        }
        private void ChoiceRandomWorb() => _currentChoiceWord = _words[_random.Next(0, _words.Length)];
        private void DrawLabels()
        {
            for (int i = 0; i < _currentChoiceWord.Length; i++)
            {
                var label = new CharLabel(_currentChoiceWord[i], new Point(20 + (_COORDINATE_LABEL_Y_STEP * i), 25));
                _charLabels.Add(label);
                currentWordPanel.Controls.Add(label);
            }
            mainPictureBox.Image = _gallowsImageList[_currentImageIndex];
        }
        private string[] LoadWords()
        {
            using var reader = new StreamReader(_wordsFilePath);
            var json = reader.ReadToEnd();
            return JsonSerializer.Deserialize<IEnumerable<string>>(json).ToArray();
        }


    }
}