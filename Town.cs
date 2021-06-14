using System;
using System.Windows.Forms;

namespace Monsters_and_Demons
{
    public partial class Town : Form
    {
        public Town()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game().Show();
        }
    }
}