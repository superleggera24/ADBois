using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD
{
    public class Players : IComparable
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public int Highscore { get; set; }

        public Players(int id, string name, int highscore)
        {
            ID = id;
            Name = name;
            Highscore = highscore;
        }

        public int GetId()
        {
            return ID;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetScore()
        {
            return this.Highscore;
        }

        public int CompareTo(object obj)
        {
            int value = 0;
            Players player2 = obj as AD.Players;

            if (player2 == null)
            {
                value = 2;
            }
            else if (Highscore < player2.Highscore)
            {
                value = -1;
            }
            else if (Highscore == player2.Highscore)
            {
                value = 0;
            }
            else if (Highscore > player2.Highscore)
            {
                value = 1;
            }
            return value;
        }

        public override bool Equals(object player2)
        {
            int score = Convert.ToInt32(player2);
            bool value = false;
            if (Highscore == score)
            {
                value = true;
            }
            return value;
        }
    }
}

