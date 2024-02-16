namespace GallowsApp;

public  class CharLabel :Label
{
    public CharLabel()
    {
        Text = "_";
        Font = new Font("Georgia", 26, FontStyle.Regular);
        ForeColor = Color.Black;
        BackColor = Color.White;
        Size = new Size(50, 50);


    }
    public CharLabel(char letter,Point coordinate) : this()
    {
        Tag = (string)letter.ToString().ToUpper();
        Location=coordinate;
           
    }
}

