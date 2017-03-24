using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD
{
    public class Players : IComparable
    {
        public static int ID { get; set; }
        public static string Name { get; set; }
        public static int Highscore { get; set; }

        public Players(int id, string name, int highscore)
        {
            ID = id;
            Name = name;
            Highscore = highscore;
        }

        public static void CreatePlayer(int id, string name, int highscore)
        {
            ID = id;
            Name = name;
            Highscore = highscore;
        }

        public int CompareTo(object obj)
        {
            return 1;
            // Hier moet nog een functie in!
        }
    }
}
