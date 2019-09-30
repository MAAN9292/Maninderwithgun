using ManinderWithGun.TableData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManinderWithGun
{
    public partial class Game : Form
    {
        int BulletChamber;
        int NewChamber;
        int tryFire = 0;
        string PlayerName;
        int PlayerID;
        int KilledCount;
        public Game(string Name, int id)
        {
            this.PlayerName = Name;
            PlayerID = id;
            
            InitializeComponent();
        }

        // Implementing Load Bullet method
        private void btLoad_Click(object sender, EventArgs e)
        {
            try
            {
                BulletChamber = new PlayerTask().LoadOneBullet();
                lbWasted.Text = "";
                lbTotalScore.Text = "";
                lbScore.Text = "";
                lbBullectCOunt.Text = ": 1";
                if (lbBullectCOunt.Text != null)
                {
                    tryFire = 0;
                    SoundPlayer sp = new SoundPlayer(ManinderWithGun.Properties.Resources.LoadBUllet);
                    sp.Play();

                    btSpin.Enabled = true;
                    btLoad.Enabled = false;
                }
                else
                {
                    btLoad.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            lbName.Text = "Name: " + PlayerName;

            btSpin.Enabled = false;
            btFire.Enabled = false;
           
            lbScore.Text = "";
            lbTotalScore.Text = "";
        }

        // Implementing Load Chamer spin
        private void btSpin_Click(object sender, EventArgs e)
        {
            try
            {
                NewChamber = new PlayerTask().SpinChamber(BulletChamber);
                SoundPlayer sp = new SoundPlayer(ManinderWithGun.Properties.Resources.spin);
                sp.Play();
                btFire.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Lets Fire the GUN
        private void btFire_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {

                    if (tryFire == 2) // Only 2 chances
                    {
                        btFire.Enabled = false;
                        btLoad.Enabled = false;
                        btSpin.Enabled = false;
                    }
                    else
                    {
                        bool status = new PlayerTask().BulletFire(NewChamber);
                        PlayerData data;

                        // when Bullet Fired
                        if (status == true)  
                        {
                            // get Player's win count
                            data = new PlayerTask().GetPlayerRecord(PlayerID); 
                            data.PlayerID = PlayerID;
                            data.Win = data.Win + 1;
                            data.Loss = 0;

                            // update player's score
                            if (new PlayerTask().UpdatePlayerData(data)) 
                            {
                                
                                lbBullectCOunt.Text = "";
                                KilledCount = data.Win; ;
                                lbScore.Text = "Killed: "+KilledCount.ToString();
                                btFire.Enabled = false;
                                btLoad.Enabled = true;
                                lbWasted.Text = "Good Job! Load 1 Bullet Again";
                            }
                        }
                        else
                        {
                            // when Bullet NOT Fired
                            tryFire = tryFire + 1;
                            NewChamber = NewChamber + 1;

                            if (tryFire == 2)
                            {
                                // get Player's record
                                data = new PlayerTask().GetPlayerRecord(PlayerID); 
                                data.Win = KilledCount;
                                data.Loss = 1;
                                data.PlayerID = PlayerID;

                                if (new PlayerTask().UpdatePlayerData(data))
                                {
                                  
                                    btFire.Enabled = true;
                                    lbScore.Text = "Killed: " + data.Win;
                                    lbTotalScore.Text = "Total Score: "+ KilledCount.ToString();
                                    
                                    btSpin.Enabled = false;
                                    btFire.Enabled = false;
                                    DataBaseConnection.CloseConnection();

                                    if (KilledCount > 0)
                                    {
                                        lbWasted.Text = "You Dead! Your Total Score: " + KilledCount;
                                        lbTotalScore.Text = "";

                                    }
                                    else
                                    {
                                        lbWasted.Text = "Wasted Youth!";
                                        
                                        DataBaseConnection.CloseConnection();
                                    }
                                }

                                
                            }

                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Exit from Game
        private void btExit_Click(object sender, EventArgs e)
        {
            DataBaseConnection.CloseConnection();
            Application.ExitThread();
        }

        private void btPlayAgain_Click(object sender, EventArgs e)
        {
            try
            {
                tryFire = 0;
                PlayerData data;
                data = new PlayerTask().GetPlayerRecord(PlayerID);
                data.Win = 0;
                data.Loss = 0;
                data.PlayerID = PlayerID;

                if (new PlayerTask().UpdatePlayerData(data))
                {
                    lbWasted.Text = "";
                    lbTotalScore.Text = "Killed: 0";
                    lbScore.Text = "Total Score: 0";
                    btLoad.Enabled = true;
                    KilledCount = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
