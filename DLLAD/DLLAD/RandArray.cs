using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLAD
{
    public class RandArray
    {
        int[] RandomArray = new 
        public static void createArray(int max)
        {
            int[] RandomArray = new int[max];
            inputArray(max);
        }

        public static void inputArray(int max)
        {
            
            int maxRand = max * 2;
            int min = 0;
            Random randomNo = new Random();
            int count = 0;

            foreach (int value in RandomArray)
            {
                RandomArray[count] = randomNo.Next(min, maxRand);
                count++;
            }
        }

        public void showArray()
        {
            int count = 0;
            foreach (int value in RandomArray)
            {
                Console.WriteLine(RandomArray[count]);
                count++;
            }
        }

    }
}
