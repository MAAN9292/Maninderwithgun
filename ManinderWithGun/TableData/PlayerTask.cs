using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ManinderWithGun.TableData
{
    public class PlayerTask
    {
        //Insert Player's Data into table
        public int InsertData(PlayerData data)
        {
            MySqlCommand cmd = DataBaseConnection.GetConnection().CreateCommand();
            cmd.CommandText = "insert into players(PlayerName,age,win,Loss) values(@PlayerName,@age,@win,@loss);select last_insert_id();";
            cmd.Parameters.AddWithValue("@PlayerName", data.PlayerName);
            cmd.Parameters.AddWithValue("@age", data.Age);
            cmd.Parameters.AddWithValue("@win", data.Win);
            cmd.Parameters.AddWithValue("@loss", data.Loss);
            int Id = int.Parse(cmd.ExecuteScalar().ToString());
            cmd.Dispose();
            return Id;
        }



        //Load BULLET in any one of the 6-chamers
        public int LoadOneBullet()
        {
            int[] Chambers = { 1, 2, 3, 4, 5, 6,7,8,9 };
            Random r = new Random();
            int index = r.Next(1, 9);

            int bulletChamber = Chambers[index];
            return bulletChamber;
        }


        //Spin the Chamber and put bullet in any random chamber
        public int SpinChamber(int bullet)
        {
            int[] Chambers = { 1, 2, 3, 4, 5, 6,7,8,9 };
            Random r = new Random();
            bullet = r.Next(1, 9);

            int NewBulletChamber = Chambers[bullet];
            return NewBulletChamber;
        }


        //Fire the BULLET from the random chamber
        public bool BulletFire(int NewBulletChamber) //2
        {
            int[] Chambers = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Random r = new Random();
            int bullet = r.Next(1, 9);

            if (NewBulletChamber == bullet)
            {
                // Bullet fire sound
                SoundPlayer sp = new SoundPlayer(ManinderWithGun.Properties.Resources.gun_gunshot_01);
                sp.Play();
                return true;
            }
            else
            {
                // Empty Gun sound
                SoundPlayer sp = new SoundPlayer(ManinderWithGun.Properties.Resources.gun_cocking_01);
                sp.Play();
                return false;
            }
        }


        //Get the current Player data
        public PlayerData GetPlayerRecord(int Id)
        {
            MySqlCommand cmd = DataBaseConnection.GetConnection().CreateCommand();

            cmd.CommandText = "select * from players where PlayerId=@PlayerId";
            PlayerData data = null;
            cmd.Parameters.Add(new MySqlParameter("@PlayerId", Id));
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                data = new PlayerData();

                data.Win = int.Parse(reader[3].ToString());
                data.Loss = int.Parse(reader[4].ToString());

            }
            reader.Dispose();
            cmd.Dispose();
            return data;
        }


        //Update the SCORE of the Player
        public bool UpdatePlayerData(PlayerData data)
        {
            MySqlCommand cmd = DataBaseConnection.GetConnection().CreateCommand();
            cmd.CommandText = "update Players set win=@win , Loss=@Loss where PlayerID=@PlayerID;";
            cmd.Parameters.Add(new MySqlParameter("@PlayerID", data.PlayerID));
            cmd.Parameters.Add(new MySqlParameter("@win", data.Win));
            cmd.Parameters.Add(new MySqlParameter("@Loss", data.Loss));
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }


    }
}
