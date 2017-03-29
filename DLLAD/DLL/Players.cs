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
            return 1;
            // Hier moet nog een functie in!
        }
    }
}
