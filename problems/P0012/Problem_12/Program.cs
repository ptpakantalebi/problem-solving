using System.ComponentModel.Design;

namespace Problem_12
{
    internal class Program
    {
        static int Is_prime(int Num)
        {
            bool T_F = true;
            for (int i = 2; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    T_F = false;
                }
            }
            if (T_F)
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
            int S_Num = 2;
            for (int x = 0; x != Number; x++)
            {
                while (Is_prime(S_Num) != S_Num) 
                {
                    S_Num++;
                }
                S_Num += 1;
                if (x == Number - 1)
                {
                    Console.WriteLine(S_Num-1);
                }
            }
        }
    }
}