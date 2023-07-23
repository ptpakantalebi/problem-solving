namespace Problem_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Num_1 = 0;
            int Num_2 = 1;
            Console.WriteLine(1);
            var Select_Num = 1;
            while (Num_1+Num_2 < Number)
            {
                Console.WriteLine(Num_1 + Num_2);
                if (Select_Num == 1)
                {
                    Num_1 += Num_2;
                    Select_Num = 2;
                }
                else
                {
                    Num_2 += Num_1;
                    Select_Num = 1;
                }
            }
        }
    }
}