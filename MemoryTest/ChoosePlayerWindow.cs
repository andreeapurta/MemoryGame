using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class ChoosePlayerWindow : Form
    {
        public ChoosePlayerWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(player1NameTxtBox.Text)) && !(string.IsNullOrEmpty(player1NameTxtBox.Text)))
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void ChoosePlayerWindow_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void player1NameTxtBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}