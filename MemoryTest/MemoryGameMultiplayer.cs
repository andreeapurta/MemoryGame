using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    internal class MemoryGameMultiplayer : MemoryGame
    {
        public MemoryGameMultiplayer(MainWindow f) : base(f)
        {
        }

        public override void IncrementScoreIfCardsAreMatching()
        {
            if (player1.move == true)
            {
                player1.IncrementScore();
                f.scorePlayer1TextBox.Text = player1.score.ToString();
            }
            else if (player2.move == true)
            {
                player2.IncrementScore();
                f.scorePlayer2TextBox.Text = player2.score.ToString();
            }
        }

        public void ChangePlayersTurns()
        {
            if (player1.move == true)
            {
                player1.move = false;
                f.player1TurnLbl.Visible = false;
                f.player1Color.Visible = false;

                f.player2TurnLbl.Visible = true;
                f.player2Color.Visible = true;
                player2.move = true;
            }
            else if (player2.move == true)
            {
                player2.move = false;
                f.player2TurnLbl.Visible = false;
                f.player2Color.Visible = false;

                player1.move = true;
                f.player1TurnLbl.Visible = true;
                f.player1Color.Visible = true;
            }
        }

        public override void DisableThePlayersTurnsLabels()
        {
            f.player1TurnLbl.Visible = false;
            f.player1Color.Visible = false;

            f.player2TurnLbl.Visible = false;
            f.player2Color.Visible = false;
        }

        public override void IsMatching(Card cardToMatch)
        {
            if (last == null)
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
                ChangePlayersTurns();
            }
        }

        public override void ShowWhoWon()
        {
            Label wonLabel = new Label { Width = 140 };
            wonLabel.Font = new Font("Microsoft YaHei UI", 13, FontStyle.Regular);
            wonLabel.ForeColor = System.Drawing.Color.Red;
            wonLabel.Location = new Point(1108, 100);

            if (player1.score > player2.score)
            {
                wonLabel.Text = "Player 1 Won!!";
            }
            else if (player1.score < player2.score)
            {
                wonLabel.Text = "Player 2 Won!!";
            }
            else if (player1.score < player2.score)
            { wonLabel.Text = "It's a tie"; }

            DisableThePlayersTurnsLabels();
            f.Controls.Add(wonLabel);
        }
    }
}