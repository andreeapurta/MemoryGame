using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btnExitMainWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void player1Color_Click(object sender, EventArgs e)
        {
        }

        public void playerLabel1_Click(object sender, EventArgs e)
        {
        }

        public void playerLabel2_Click(object sender, MaskInputRejectedEventArgs e)
        {
        }

        public void player2Color_Click(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void playerLabel1_Click_1(object sender, EventArgs e)
        {
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            //f.countdownLbl.Text = counter.ToString();
        }

        private void countdownLbl_Click(object sender, EventArgs e)
        {
        }
    }
}