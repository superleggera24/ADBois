using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD
{
    public class Players : IComparable
    {
        public int ID { get; set; } // wordt uniek gegenereerd
        public string Name { get; set; } // Niet perse uniek, maar wordt voor deze casus even random aangemaakt.
        public int Highscore { get; set; } // De highscores. Een van de mogelijkheden om mee te vergelijken.

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

        // Hieronder de belangrijkste methode om te zorgen dat deze objecten generiek zijn. Een eigen compareto methode.
        public int CompareTo(object obj) 
        {
            int value = 0;
            Players player2 = obj as AD.Players;

            // Eerst kijken of het ingevoerde object (obj) een int is en dat vervolgens converteren.
            if (player2 == null)
            {
                int i = Convert.ToInt32(obj);
                value = 2;
                if(Highscore < i)
                {
                    value = -1;
                }
                else if (Highscore == i)
                {
                    value = 0;
                }
                else if (Highscore > i)
                {
                    value = 1;
                }

            }
            else
            {
                if (Highscore < player2.Highscore) // Als de eigen highscore lager is dan die van de opgevraagde speler, geef dan -1.
                {
                    value = -1;
                }
                else if (Highscore == player2.Highscore) // Als de highscores gelijk is, geef dan een 0.
                {
                    value = 0;
                }
                else if (Highscore > player2.Highscore) // Als de eigen highscore hoger is dan die van de opgevraagde speler, geef dan 1.
                {
                    value = 1;
                }
            }
            return value;
        }

        public override bool Equals(object player2) // Een generieke Equals methode.
        {
            int score = Convert.ToInt32(player2);
            bool value = false;
            if (Highscore == score)
            {
                value = true;
            }
            return value;
        }
    }
}

