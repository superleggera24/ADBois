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
        public int Highscore { get; set; }

        public Players(int id, int highscore)
        {
            ID = id;
            
            Highscore = highscore;
        }

        

        public int GetId(Players Player)
        {
            return ID;
        }

        

        public int GetScore(Players Player)
        {
            return this.Highscore;
        }

       

        public int CompareTo(object obj)
        {
            return 1;
            // Hier moet nog een functie in!
        }
    }
}
