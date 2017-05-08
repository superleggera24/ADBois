using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    // Klasse gemaakt en geschreven door: Frans Orsel

    // Deze klasse wordt gebruikt voor ons formulier.
    public class PlayerList<T>
    {
        public static List<T> PlayerBase = new List<T>();

        // hiermee wordt een lijst gecreëerd.
        public PlayerList()
        {
            PlayerBase = new List<T>();
            ReturnBase();
        }

        // Hier wordt de spelerslijst weergegeven
        public List<T> ReturnBase()
        {
            return PlayerBase;
        }
    }
}
