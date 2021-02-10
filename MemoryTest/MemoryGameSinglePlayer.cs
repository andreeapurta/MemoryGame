using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    internal class MemoryGameSinglePlayer : MemoryGame
    {
        public MemoryGameSinglePlayer(MainWindow f) : base(f)
        {
            //astea nu stiu unde sa le pun mai exact asa ca il constructor sa le vad

            f.player1TurnLbl.Visible = false;

            f.scorePlayer1Label.Text = "Score: ";
            f.scorePlayer2TextBox.Visible = false;
            f.player1Color.Visible = false;
            f.scorePlayer2Label.Visible = false;
        }

        public override void IsMatching(Card cardToMatch)
        {
            if (last == null)  //
            {
                last = cardToMatch;
            }
            else if (cardToMatch.Value == allTheCardsList.Find(x => x == last).Value)
            {
                cardToMatch.picture.Enabled = false;
                allTheCardsList.Find(x => x == last).picture.Enabled = false;
                last = null;

                IncrementScoreIfCardsAreMatching();

                if (EndTheGame() == true)
                {
                    return;
                }
            }
            else
            {
                TurnCardsDelay();
                IsNotMatching(cardToMatch);
            }
        }

        public override void IncrementScoreIfCardsAreMatching()
        {
            player1.IncrementScore();
            f.scorePlayer1TextBox.Text = player1.score.ToString();
        }

        public override void ShowWhoWon()
        {
            Label wonLabel = new Label { Width = 140 };
            wonLabel.Font = new Font("Microsoft YaHei UI", 13, FontStyle.Regular);
            wonLabel.ForeColor = System.Drawing.Color.Red;
            wonLabel.Location = new Point(1108, 100);

            DisableThePlayersTurnsLabels();
            if (player1.score == 1600)
            {
                wonLabel.Text = "You Won!!";
            }
            else
            {
                wonLabel.Text = "You Lost!!";
            }
            f.Controls.Add(wonLabel);
        }

        public override void DisableThePlayersTurnsLabels()
        {
            f.player1TurnLbl.Visible = false;
            f.player1Color.Visible = false;
        }
    }
}