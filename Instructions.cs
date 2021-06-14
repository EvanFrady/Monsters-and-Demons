using System.Windows.Forms;

namespace Monsters_and_Demons
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void btnBackFromInstructions_Click(object sender, System.EventArgs e)
        {
            this.Close();
            new MainMenu().Show();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
        }
    }
}