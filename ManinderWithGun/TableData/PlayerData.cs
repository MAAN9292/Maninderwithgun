using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManinderWithGun.TableData
{
    public class PlayerData
    {
        int age, playerID, win, loss, totalScore;
        string playerName;

        public int Age { get => age; set => age = value; }
        public int PlayerID { get => playerID; set => playerID = value; }
        public int Win { get => win; set => win = value; }
        public int Loss { get => loss; set => loss = value; }
        public int TotalScore { get => totalScore; set => totalScore = value; }
        public string PlayerName { get => playerName; set => playerName = value; }
    }
}
