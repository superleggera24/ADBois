using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class PlayerList
    {
        public static List<Players> _PlayerBase;

        public static List<Players> PlayerBase
        {
            get { return _PlayerBase; }
        }

        

        public void CreateList()
        {
            _PlayerBase = new List<Players>();
            int ID = 0;
            string Name = null;
            int HScore = 0;
            int size = 10;

            for (int i = 0; i < size; i++)
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[8];
                var random = new Random();

                for (int j = 0; j < stringChars.Length; j++)
                {
                    stringChars[j] = chars[random.Next(chars.Length)];
                }

                Random rnd = new Random();

                ID = i;
                HScore = rnd.Next(size * 2);
                Name = new String(stringChars);

                
                PlayerBase.Add(new Players(ID, Name, HScore));
            }
        }
        public static List<Players> GetList()
        {
            return PlayerBase;
        }

        public static string GetPlayerStats(List<Players> PlayerBase)
        {
            StringBuilder builder = new StringBuilder();
            foreach (AD.Players player in PlayerBase)
            {
                builder.Append(player).Append(" ");
            }
            string stats = builder.ToString();
            return stats;
        }
    }
}
