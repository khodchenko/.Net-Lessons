using System;

namespace ProjectExample
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.Write("Enter kilometer value:");
            int kilometers = Convert.ToInt32(Console.ReadLine());

            int meters = kilometers * 1000;

            Console.Write("Meters amount:"+ meters);
                  
                   
                       
        }
    }
}
