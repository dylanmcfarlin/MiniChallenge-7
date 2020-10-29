using System;

// Dylan McFarlin
// Date Revised: 9-4-20
// MiniChallenge#7
// Program that takes a sequence of numbers and reverse them.
// Code Reviewed by: Ann
    // Comments: Ace-Good Job!

namespace MiniChallenge_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers to reverse:");
            string numList = Console.ReadLine();

            Console.WriteLine("Original numbers: " + numList);
            
            for(int i = numList.Length -1; i >= 0; i--)
            {
                Console.Write(numList[i]);
            }

           /* int numList[] = new int[5];
            Console.Clear();
            Console.WriteLine("Enter a number:");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int num3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int num4 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int num5 = Convert.ToInt16(Console.ReadLine());
            */
        }
    }
}
