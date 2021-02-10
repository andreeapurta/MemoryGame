using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class FirstWindow : Form
    {
        public MainWindow f;
        public MemoryGame m;
        public RulesWindow q = new RulesWindow();
        public ChoosePlayerWindow p = new ChoosePlayerWindow();

        public int counter;

        public FirstWindow()
        {
            InitializeComponent();
        }

        private void SinglePlayerButton_Click(object sender, EventArgs e)
        {
            counter = 60;
            f = new MainWindow();
            m = new MemoryGameSinglePlayer(f);

            q.Close();
            m.AddPictures();
            f.Show();
            f.Refresh();
            m.TurnFaceCard();
            f.Refresh();
            showFaceCardsTimer.Interval = 3000;
            showFaceCardsTimer.Enabled = true;

            f.countdownLbl.Visible = true;

            CountdownTimer.Start();
            playMultiplayerBtn.Text = "Play Multiplayer";
            PlaySinglePlayerBtn.Text = "Replay";
        }

        private void MultiplayerButton_Click(object sender, EventArgs e)
        {
            f = new MainWindow();
            m = new MemoryGameMultiplayer(f);

            q.Close();
            m.AddPictures();
            f.Show();
            f.Refresh();
            if (p.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                f.player1TurnLbl.Text = p.player1NameTxtBox.Text + "'s Turn";
                f.scorePlayer1Label.Text = p.player1NameTxtBox.Text + "'s Score";
                f.player2TurnLbl.Text = p.player2NameTxtBox.Text + "'s Turn";
                f.scorePlayer2Label.Text = p.player2NameTxtBox.Text + "'s Score";
                p.player1NameTxtBox.Text = " ";
                p.player2NameTxtBox.Text = " ";
            }
            m.TurnFaceCard();
            f.Refresh();
            f.countdownLbl.Visible = false;
            showFaceCardsTimer.Interval = 3000;
            showFaceCardsTimer.Enabled = true;
            PlaySinglePlayerBtn.Text = "Play";
            playMultiplayerBtn.Text = "Replay";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void perioada_Tick(object sender, EventArgs e)
        {
            m.TurnBackCard();
            showFaceCardsTimer.Enabled = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {
            q = new RulesWindow();
            q.Show();
        }

        private void CardsTurnTimer_Tick(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            f.countdownLbl.Text = counter.ToString();
            if (counter == 0)
            {
                CountdownTimer.Stop();
                m.TurnFaceCard();
                m.ShowWhoWon();
                m.DisableCards();
            }
        }
    }
}