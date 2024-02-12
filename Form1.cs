namespace GallowsApp
{
    public partial class Form1 : Form
    {
        private string[] _words;

        public Form1()
        {
            InitializeComponent();
            _words = new string[] { "register", "baobab", "nikolay", "banderveloper" };
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //label1.Text = Convert.ToChar(e.KeyCode).ToString();
            MessageBox.Show(e.KeyData.ToString());
        }
    }
}