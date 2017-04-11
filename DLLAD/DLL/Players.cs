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

        public int CompareTo(Players player2)
        {
            if (player2 == null) return 2;
            return Highscore.CompareTo(player2.Highscore);
            if (Highscore > player2.Highscore)
            {
                return 1;
            }
            else if (Highscore < player2.Highscore)
            {
                return -1;
            }
            else if (Highscore == player2.Highscore)
            {
                return 0;
            }
         }

        public static bool operator > (Players operand1, Players operand2 )
        {
            return operand1.CompareTo(operand2) == 1;
        }

        public static bool operator <(Players operand1, Players operand2)
        {
            return operand1.CompareTo(operand2) == -1;
        }

        public static bool operator >= (Players operand1, Players operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        public static bool operator <= (Players operand1, Players operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }
    }
}

