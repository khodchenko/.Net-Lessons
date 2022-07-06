using System;

namespace ProjectExample
{
    class Program
    {
        static void Main(string[] args)

        {
            int Min = 0;
            int Max = 20;

            int[] array = new int[5];

            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(Min, Max);
                Console.Write($"[{array[i]}] ");
            }

            MinimalElement(array);
        }

        //1. Find the minimum element of an array
        static void MinimalElement(int[] array)
        {
            int arrayMin = 100;
            for (int i = 0; i < array.Length; i++)
            {
                int arrayCurrent = array[i];
                if (arrayCurrent < arrayMin) {
                    arrayMin = arrayCurrent;
                }
            }
            Console.WriteLine(arrayMin);
        }
    }
}