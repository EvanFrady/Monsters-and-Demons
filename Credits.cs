using System.Windows.Forms;

namespace Monsters_and_Demons
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void btnBackFromOptions_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }
    }
}