using System.Windows.Forms;

namespace MemoryGame
{
    public class Card
    {
        public string back;
        public MemoryGame F;
        public string face;
        public PictureBox picture;
        public bool stayTurned = false;
        public int Value;

        public Card(int X, int Y, int value, MemoryGame F)
        {
            picture = new PictureBox();
            picture.Top = X; //distanta dintre marginea de sus a pozei si marginea de sus a containerului
            picture.Left = Y; //distanta dintre marginea din stanga a pozei si marginea din stanga a containerului
            picture.Width = 150; //lungime
            picture.Height = 150; //inaltime
            picture.SizeMode = PictureBoxSizeMode.Zoom; //ca a incapa in picture box
            back = @"resources\\Cover.png";
            face = @"resources\\" + value.ToString() + ".png";
            picture.Click += ClickOnPicture; //! click-event, se apeleaza cand dai click pe picturebox
            this.Value = value;
            this.F = F;
        }

        public void ClickOnPicture(object sender, System.EventArgs e)
        {
            picture.Load(face); //Apesi click pe carte si cartea se itoarce cu fata
            picture.Refresh(); //Se redeseneaza cartea ca sa fie ok
            stayTurned = true; //a fost marcata ca intoarsa
            picture.Enabled = false; //aici s-a "dezactivat cartea" adica nu mai poti fa click pe ea, nu mai raspunde la interactia jucatorului
            F.IsMatching(this); //??? inca mi frica de asta
        }

        public void ShowTheBackOfTheCard()
        {
            picture.Load(back);
            picture.Refresh(); //forteaza forma sa se redeseneze
        }

        public void ShowTheFaceOfTheCard()
        {
            picture.Load(face);
            picture.Refresh();
        }
    }
}