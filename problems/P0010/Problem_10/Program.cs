using System;

namespace Problem_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Multiply_PrimeNumber = 2;
            for (int i = 3; i < Number; i++)
            {
                int Num = 0;
                for (int x = 2; x < Number; x++)
                {
                    if (i % x == 0)
                    {
                        Num += 1;
                    }
                }
                if (Num == 1)
                {
                    Multiply_PrimeNumber *= i;
                }
            }
            Console.WriteLine(Multiply_PrimeNumber);
        }
    }
}