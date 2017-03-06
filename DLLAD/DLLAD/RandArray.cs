using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLAD
{
    public class RandArray
    {
        // hieronder wordt de array gemaakt
        static int[] RandomArray = new int[1000];
        
        // met deze functie worden er gegevens in de array ingevoerd
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

        // Met deze functie kan er een plaats in de array worden opgevraagd
        public static int showArray(int number)
        {
            return (RandomArray[number]);
        }

        // Deze functie initieert het sorteren via een BubbleSort.
        public static void bubbleArray()
        {
            BubbleSort.BubbleSortArrayList<int>(RandomArray);
        }
        // Deze functie initieert het sorteren via een InsertionSort.
        public static void insertSort()
        {
            InsertSort.InsertionSort(RandomArray);
        }
    }
}