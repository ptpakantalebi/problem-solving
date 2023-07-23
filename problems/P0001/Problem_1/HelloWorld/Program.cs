using System;

namespace odd_or_even_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Numner: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Number} is {(Number % 2 == 0 ? "even" : "odd")}");
        }
    }
}