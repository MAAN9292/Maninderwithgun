using ManinderWithGun.TableData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManinderWithGun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Fill the form and Play
        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                string Age, PlayerName;
                Age = tbAge.Text.Trim();
                PlayerName = tbName.Text.Trim();
                if (PlayerName.Equals(""))
                {
                    MessageBox.Show("Please enter player name");
                }
                else if (Age.Equals(""))
                {
                    MessageBox.Show("Please enter your age");
                }
                
                else
                {
                    PlayerData obj = new PlayerData();
                    obj.PlayerName = PlayerName;
                    obj.Age = int.Parse(Age);
                    obj.Win = 0;
                    obj.Loss = 0;
                    if (obj.Age >= 18)
                    {
                        int PlayerID = new PlayerTask().InsertData(obj);
                        if (PlayerID != 0)
                        {
                            this.Hide();
                            Game g = new Game(PlayerName, PlayerID);
                            g.Show();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Be mature enough to play this game");
                    }
                    
                }


            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show("Please enter numeric values only");

                }
                else if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Player name already exists, please user another name");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Exit from game
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.ExitThread();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
