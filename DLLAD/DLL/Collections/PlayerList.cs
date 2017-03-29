using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class PlayerList
    {
        public static List<Players> PlayerBase = new List<Players>();

        public PlayerList()
        {
            PlayerBase = new List<Players>();
            ReturnBase();
        }

        public List<Players> ReturnBase()
        {
            return PlayerBase;
        }

        public void NewPlayer(int Id, string Name, int Score)
        {
            PlayerBase.Add(new Players(Id, Name, Score));
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
    }
}
