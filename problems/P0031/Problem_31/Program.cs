namespace Problem_31
{
    internal class Program
    {
        static int Is_prime(int x)
        {
            int check = 0;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    check+=1;
                }
            }
            if (check == 0)
            {
                return x;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int Num = int.Parse(Console.ReadLine());
            int S_N = 2;
            while (S_N < Num)
            {
                if (Is_prime(S_N) == S_N & Is_prime(Num-S_N) == Num - S_N)
                {
                    Console.WriteLine(S_N + "," + (Num - S_N));
                    break;
                }
                S_N++;
            }
        }
    }
}