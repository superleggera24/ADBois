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

        

        public int GetId(Players Player)
        {
            return ID;
        }

        public string GetName(Players Player)
        {
            return this.Name;
        }

        public int GetScore(Players Player)
        {
            return this.Highscore;
        }

        public string GetStats(Players Player)
        {
            string ThisName = GetName(Player);
            int ThisScore = GetScore(Player);
            string CreateString = $"Name {ThisName}, Score {ThisScore}.";
            return CreateString;
        }

        public int CompareTo(object obj)
        {
            return 1;
            // Hier moet nog een functie in!
        }
    }
}
