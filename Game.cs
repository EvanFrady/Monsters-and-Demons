using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EnemiesList;

/*Monsters and Demons Game
 *By Evan Frady
 *For MSSA PCAD1 2021 
 * 
 * 
 */



namespace Monsters_and_Demons
{

    public partial class Game : Form
    {
        //delay to attack again
        static int timerAttack = 0;
        //battle counter shows which battle you are on, and also changes the monster.
        static int battleCounter;
        //generate random damage for player and enemy.
        Random randomDamage = new Random();
        //total amount of coins the player has.
        static int CoinDrop;


        public Game()
        {
            InitializeComponent();
        }



        public async void btnAttack_Click(object sender, System.EventArgs e)
        {
            btnAttack.Enabled = false;
            HunterStanding.Hide();
            HunterAttacking.Show();
            TimerAttack.Start();

            RandomPlayerAttack();
            if (EnemyHealthBar.Width != 0)
            {
                // Animation for the monster to "flinch" when attacking
                await Task.Delay(1000);
                PctrMonster.Location = new Point(490, 210);
                RandomEnemyAttack();
                await Task.Delay(300);
                PctrMonster.Location = new Point(500, 200);
                await Task.Delay(100);
            }
            btnAttack.Enabled = true;

        }






        public void RandomPlayerAttack()
        {
            // Player attack is between 0-25
            int PlayerAttackDamage = randomDamage.Next(5, 30);
            // subtract the damage from enemy health
            EnemyHealthBar.Width -= PlayerAttackDamage;
            if (PlayerAttackDamage != 0)
            {
                // add to the battle log
                txtboxBattleLog.Text += ("\nYou did " + PlayerAttackDamage + " Damage" + Environment.NewLine);
                if (EnemyHealthBar.Width == 0)
                {
                    txtboxBattleLog.Text += "YOU DEFEATED THE MONSTER!"+Environment.NewLine;
                    txtboxBattleLog.Text += ("+5 Gold" + Environment.NewLine + "+10 XP" +Environment.NewLine);
                    
                    panelNextBattle.Show();
                    btnAttack.Enabled = false;
                    btnAttack.Hide();
                    battleCounter++;
                    CoinDrop += 5;

                }
            }
            else
            {
                //if you rolled a 0, you missed.
                txtboxBattleLog.Text += ("\nYou missed!!!" + Environment.NewLine);
            }
            txtboxBattleLog.SelectionStart = txtboxBattleLog.TextLength;
            txtboxBattleLog.ScrollToCaret();
        }

        public void RandomEnemyAttack()
        {
            // random enemy attack from 0 - 25
            int EnemyAttackDamage = randomDamage.Next(0, 25);
            if (PlayerHealthBar.Width != 0)
            {
                if (EnemyHealthBar.Width != 0)
                {
                    PlayerHealthBar.Width -= EnemyAttackDamage;
                    if (EnemyAttackDamage != 0)
                    {
                        txtboxBattleLog.Text += ("\nEnemy did  " + EnemyAttackDamage + " Damage" + Environment.NewLine);
                    }
                    else
                    {
                        txtboxBattleLog.Text += ("\nThey missed???" + Environment.NewLine);
                    }
                }
                else
                {
                    btnAttack.Enabled = false;
                }
            }
            else if (PlayerHealthBar.Width == 0)
            {
                panelDeath.Show();
                btnAttack.Enabled = false;
            }
            txtboxBattleLog.SelectionStart = txtboxBattleLog.TextLength;
            txtboxBattleLog.ScrollToCaret();
        }

        // This displays the hunter attacking animation for 3 timer ticks.
        private  void TimerAttack_Tick(object sender, System.EventArgs e)
        {
            timerAttack++;
            if (timerAttack >= 3)
            {
                HunterAttacking.Hide();
                HunterStanding.Show();
                TimerAttack.Stop();
            }
        }

        //If you win a battle, next battle will come up, and generate a new battle.
        private void pctrNextBattle_Click(object sender, EventArgs e)
        {
            Game newGame = new Game();
            newGame.Show();
            this.Close();
        }



        private void Game_Load(object sender, EventArgs e)
        {
            panelNextBattle.Hide();
            panelDeath.Hide();
            PctrMonster.BorderStyle = BorderStyle.None;
            pctrNextBattle.BorderStyle = BorderStyle.None;
            panelDeath.BorderStyle = BorderStyle.None;
            btnDeathBottom.FlatAppearance.BorderSize = 0;
            btnDeathTop.FlatAppearance.BorderSize = 0;
            btnAttack.FlatAppearance.BorderSize = 0;
            btnBottomWin.FlatAppearance.BorderSize = 0;
            btnBackpack.FlatAppearance.BorderSize = 0;
            btnRunAway.FlatAppearance.BorderSize = 0;
            btnSpells.FlatAppearance.BorderSize = 0;
            HunterAttacking.Hide();
            lblBattleCounter.Text = battleCounter.ToString();
            lblGoldCoins.Text = CoinDrop.ToString();
            
            // This determines which monster the player will be battling.
            if (battleCounter == 1)
            {
                PctrMonster.Image = MonsterImages.GreenSlime;
            }
            if (battleCounter == 1)
            {
                PctrMonster.Image = MonsterImages.SnakeEasy;
            }
            if (battleCounter == 2)
            {
                PctrMonster.Image = MonsterImages.GoblinEasy;

            }
            if (battleCounter == 3)
            {
                PctrMonster.Image = MonsterImages.CockatriceEasy;
            }
            if (battleCounter == 4)
            {
                PctrMonster.Image = MonsterImages.LizardEasy;
            }
            if (battleCounter == 5)
            {
                PctrMonster.Image = MonsterImages.RatEasy;
            }
            if (battleCounter == 6)
            {
                PctrMonster.Image = MonsterImages.ScorpionEasy;
            }
            if (battleCounter == 7)
            {
                PctrMonster.Image = MonsterImages.WolfEasy;
            }
            if (battleCounter == 8)
            {
                PctrMonster.Image = MonsterImages.GhostEasy;
            }
            if (battleCounter == 9)
            {
                PctrMonster.Image = MonsterImages.DragonEasy;

            }
        }

        private void btnRunAway_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Town().Show();
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnDeath_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Town().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save the battle log to a .txt file for later use.
            TextWriter battleLog = new StreamWriter("Monsters_And_Demons_Battle_Log.txt");
            battleLog.WriteLine(txtboxBattleLog.Text);
            battleLog.Close();
        }
    }
}
