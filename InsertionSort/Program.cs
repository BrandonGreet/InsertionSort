//This program sorts a given array using insertion sort.
using System;
using System.IO;

namespace InsertionSort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Initializing reader, writer, and bigArray
            StreamReader reader = new StreamReader("/Users/BrandonGreet/Desktop/bigArray.txt");
            int[] bigArray = new int[10000];
            string entry;
            int line = 0;
            while((entry = reader.ReadLine()) != null)
            {
                bigArray[line] = int.Parse(entry);
                line++;
            }
            reader.Close();


            //Sorts by moves entries left until nothing before them is greater.
            int curIndex;
            int tempVal;
            for (int i = 1; i < 10000; i++)
            {
                curIndex = i;
                while (curIndex != 0 && bigArray[curIndex] < bigArray[curIndex - 1])
                {
                    tempVal = bigArray[curIndex];
                    bigArray[curIndex] = bigArray[curIndex - 1];
                    bigArray[curIndex - 1] = tempVal;
                    curIndex--;
                }
            }

            foreach (int item in bigArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
