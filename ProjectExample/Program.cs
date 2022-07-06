using System;

namespace ProjectExample
{
    class Program
    {
        static void Main(string[] args)

        {
            int Min = 0;
            int Max = 20;

            int[] array = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(Min, Max);
                Console.Write($"[{array[i]}] ");
            }

            getMaximalElementIndex(array);
        }

        //1. Find the minimum element of an array
        static void getMinimalElement(int[] array)
        {
            int arrayMin = 99; 
            for (int i = 0; i < array.Length; i++)
            {
                int arrayCurrent = array[i];
                if (arrayCurrent < arrayMin) {
                    arrayMin = arrayCurrent;
                }
            }
            Console.WriteLine(arrayMin);
        }

        //2. Find the maximum element of an array
        static void getMaximumElement(int[] array)
        {
            int arrayMax = -99; 
            for (int i = 0; i < array.Length; i++)
            {
                int arrayCurrent = array[i];
                if (arrayCurrent > arrayMax)
                {
                    arrayMax = arrayCurrent;
                }
            }
            Console.WriteLine(arrayMax);
        }

        //3. Find the index of the minimum element of the array
        static void getMinimalElementIndex(int[] array)
        {
            int arrayMin = 99;
            int arrayMinInex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int arrayCurrent = array[i];
                if (arrayCurrent < arrayMin)
                {
                    arrayMin = arrayCurrent;
                    arrayMinInex = i;
                }
            }
            Console.WriteLine(arrayMinInex);
        }

        //4. Find the index of the maximum element of the array
        static void getMaximalElementIndex(int[] array)
        {
            int arrayMin = -99;
            int arrayMaxInex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int arrayCurrent = array[i];
                if (arrayCurrent > arrayMin)
                {
                    arrayMin = arrayCurrent;
                    arrayMaxInex = i;
                }
            }
            Console.WriteLine(arrayMaxInex);
        }

        //5. Calculate the sum of array elements with odd indices
        //6. Make an array reverse(an array in the opposite direction)
        //7. Count the number of odd array elements
        //8. Swap the first and second half of the array, for example, for an array of 1 2 3 4, the result is 3 4 1 2, or for 1 2 3 4 5 -> 4 5 3 1 2.
        //9. Sort the array in ascending order in one of the ways: bubble(Bubble), selection(Select) or inserts(Insert))
        //10. Sort the array in descending order in one of the ways(different from the method in the 9th task): bubble(Bubble), selection(Select) or inserts(Insert))
    }
}