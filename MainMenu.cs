using System;
using System.Windows.Forms;

namespace Monsters_and_Demons
{
    public partial class MainMenu : Form
    {
        static int timerAAH;
        static int timerHelp;





        public MainMenu()
        {
            InitializeComponent();
            ChatTimerAHH.Start();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInstruction_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Instructions().Show();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Credits().Show();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game().Show();
        }

        private void ChatTimerHelp_Tick(object sender, EventArgs e)
        {
            timerHelp++;
            if (timerHelp == 15)
            {
                pctrHelp.Hide();
                ChatTimerHelp.Stop();
            }
        }

        private void ChatTimerAHH_Tick(object sender, EventArgs e)
        {
            timerAAH++;
            if (timerAAH == 10)
            {
                pctrAHH.Hide();
                ChatTimerAHH.Stop();
            }
        }
    }
}
