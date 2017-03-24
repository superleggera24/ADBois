using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD
{
    class Player IComparable<Player>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Highscore { get; set; }

        public Player(int id, string name, int highscore)
        {
            ID = id;
            Name = name;
            Highscore = highscore;
        }
    }
}
