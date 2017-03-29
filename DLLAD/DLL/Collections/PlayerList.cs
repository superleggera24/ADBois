using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public static class PlayerList
    {
        public static List<Players> _PlayerBase;

        public static List<Players> PlayerBase
        {
            get { return _PlayerBase; }
        }
        
        public static void CreateList()
        {
            _PlayerBase = new List<Players>();
            int ID = 0;
            int HScore = 0;
            int size = 1000;

            for (int i = 0; i < size; i++)
            {
                ID = i;
                HScore = RandomNo(size);
                
                
                PlayerBase.Add(new Players(ID, HScore));
            }
        }

        public static string Shuffle(this string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }

        public static int RandomNo(int size)
        {
            Random rnd = new Random();
            return rnd.Next(size * 2);
        }
        public static List<Players> GetList()
        {
            return PlayerBase;
        }

        public static string GetPlayerStats(List<Players> PlayerBase)
        {
            string stats = null;
            foreach (AD.Players player in PlayerBase)
            {
                stats += "ID";
                stats += player.GetId(player).ToString();
                stats += ", Highscore: ";
                stats += player.GetScore(player).ToString();
                stats += Environment.NewLine;
                
            }
            return stats;
        }
    }
}
