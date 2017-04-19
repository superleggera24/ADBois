using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class PlayerList<T>
    {
        public static List<T> PlayerBase = new List<T>();

        public PlayerList()
        {
            PlayerBase = new List<T>();
            ReturnBase();
        }

        public List<T> ReturnBase()
        {
            return PlayerBase;
        }
        
        public static int RandomNo(int size)
        {
            Random rnd = new Random();
            return rnd.Next(size * 2);
        }
    }
}
