using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AD.Collections
{
    public class StartList<T>
    {
        List<T> PlayerBase = new List<T>();

        

        public void CreateList()
        {
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

                Players.CreatePlayer(ID, Name, HScore);
            }
        }
    }
}
