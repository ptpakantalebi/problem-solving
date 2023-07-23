namespace Problem_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            bool T_F = true;
            int N_1 = 2;
            while (Num != 1)
            {
                while (Num % N_1 == 0)
                {
                    Num /= N_1;
                    Console.WriteLine(N_1);
                }
                if(T_F)
                {
                    N_1 += 1;
                }
                else
                {
                    N_1 += 2;
                }
            }

            //var T_F = true;
            //for (int i = 2;i < Num;i += 2)
            //{
            //    Console.WriteLine(i);
            //    while (Num % i == 0)
            //    {
            //        Num /= i;
            //        Console.WriteLine(i);
            //    }
            //    if (T_F)
            //    {
            //        i -= 1;
            //        T_F = false;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
            //Console.WriteLine(Num);
        }
    }
}