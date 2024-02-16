namespace GallowsApp
{
    public partial class Form1 : Form
    {
        private string[] _words;
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
            _words = new string[] { "register", "baobab", "nikolay", "banderveloper" };
            _random = new Random();
            _currentImageIndex = 0;
            _charLabels = new List<CharLabel>();
            _imagesFolderPath = "../../../img";
            var imagesPathList = Directory.GetFiles(_imagesFolderPath).ToList();
            _gallowsImageList = new List<Image>();
            foreach (var oneImagePath in imagesPathList)
            {
                _gallowsImageList.Add(Image.FromFile(oneImagePath));
            }

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //добавить логику на проверку уже нажатых кнопок

            if (_charLabels.Any(oneLabel => oneLabel.Tag?.ToString() == e.KeyData.ToString()))
            {
                var selectLabelsContainer = _charLabels.Where(oneLabel => oneLabel.Tag?.ToString() == e.KeyData.ToString());
                foreach (var oneSelectLabel in selectLabelsContainer)
                {
                    oneSelectLabel.Text = e.KeyData.ToString();
                    oneSelectLabel.Tag = "_";
                }
                if (_charLabels.All(oneLabel => oneLabel.Tag.ToString() == "_"))
                {
                    new GameOverForm(this,true).ShowDialog();
                }

            }
            else
            {

                if (_currentImageIndex == _gallowsImageList.Count - 1)
                {

                    foreach (var charLabel in _charLabels)
                    {
                        if (charLabel.Tag.ToString() != "_")
                            charLabel.Text = charLabel?.Tag.ToString();
                    }
                    new GameOverForm(this,false).ShowDialog();
                }
                else
                    mainPictureBox.Image = _gallowsImageList[++_currentImageIndex];
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ChoiceRandomWorb();
            MessageBox.Show(_currentChoiceWord);
            for (int i = 0; i < _currentChoiceWord.Length; i++)
            {
                var label = new CharLabel(_currentChoiceWord[i], new Point(20 + (_COORDINATE_LABEL_Y_STEP * i), 25));
                _charLabels.Add(label);
                currentWordPanel.Controls.Add(label);
            }
            mainPictureBox.Image = _gallowsImageList[_currentImageIndex];

        }
        public void UpdateGame()
        {
            ChoiceRandomWorb();
            _currentImageIndex = 0;
            currentWordPanel.Controls.Clear();
            for (int i = 0; i < _currentChoiceWord.Length; i++)
            {
                var label = new CharLabel(_currentChoiceWord[i], new Point(20 + (_COORDINATE_LABEL_Y_STEP * i), 25));
                _charLabels.Add(label);
                currentWordPanel.Controls.Add(label);
            }
            mainPictureBox.Image = _gallowsImageList[_currentImageIndex];
        }
        private void ChoiceRandomWorb() => _currentChoiceWord = _words[_random.Next(0, _words.Length)];


    }
}