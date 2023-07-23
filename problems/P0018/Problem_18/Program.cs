using System.Transactions;

namespace Problem_18
{
    internal class Program
    {
        static int Is_prime(int Num)
        {
            int Counter = 0;
            for (int t = 2;t < Num; t++)
            {
                if (Num % t == 0)
                {
                    Counter += 1;
                    break;
                }
            }
            if (Counter == 0)
            {
                return Num;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Number = Number - 1;
            }
            else
            {
                Number = Number - 2;
            }
            for (int y = 3;y < Number;y += 2)
            {
                if (Is_prime(y) == y & Is_prime(y+2) == y+2)
                {
                    Console.WriteLine(y + " " + (Convert.ToInt32(y) + 2));
                }
            }
        }
    }
}