using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLAD
{
    public class RandArray
    {
        static int[] RandomArray = new int[1000000];
        

        public static void inputArray()
        {
            
            int maxRand = RandomArray.Length * 2;
            int min = 0;
            Random randomNo = new Random();
            int count = 0;

            foreach (int value in RandomArray)
            {
                RandomArray[count] = randomNo.Next(min, maxRand);
                count++;
            }
        }

        public static int showArray(int number)
        {
            return (RandomArray[number]);
        }

    }
}
