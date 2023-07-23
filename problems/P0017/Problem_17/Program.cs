namespace Problem_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            for (int i = Num; i != -1;i --)
            {
                for (int j = i;j != 0; j--)
                {
                    Console.Write("+");
                }
                for (int x = Num-i; x != 0; x--)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
        }
    }
}