using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static int yt(int c, int q)
        {
            if (q == 0)
            {
                return 1;
            }
            int gh = 10;
            for (int w = 0; w < q-1; w++)
            {
                gh *= 10;
            }
            return gh;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            var Num_1 = Console.ReadLine().ToCharArray();
            Array.Reverse(Num_1);
            Console.WriteLine("Enter the Number again: ");
            var Num_2 = Console.ReadLine().ToCharArray();
            Array.Reverse(Num_2);
            Console.WriteLine((Num_1.Length,Num_2.Length));
            var Sum = 0;
            for (int i = 0; i < Num_1.Length; i++)
            {
                for (int j = 0; j < Num_2.Length; j++)
                {
                    Sum += (int.Parse(Num_1[i].ToString()) * yt(10, i)) * (int.Parse(Num_2[j].ToString()) * yt(10, j));
                }
            }
            Console.WriteLine(Sum);
        }
    }
}