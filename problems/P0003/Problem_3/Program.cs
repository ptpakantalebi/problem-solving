using System;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first year: ");
            int Year_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second year: ");
            int Year_2 = Convert.ToInt32(Console.ReadLine());
            if (Year_1 > Year_2)
            {
                Console.WriteLine((Year_1 - Year_2) * 365);
            }
            else
            {
                Console.WriteLine((Year_2 - Year_1) * 365);
            }
        }
    }
}