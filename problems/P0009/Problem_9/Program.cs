namespace Problem_9
{
    class Program
    {
        static void Prime_number(int Prime)
        {
            int Sum = 0;
            for (int i = 2; i < Prime; i++)
            {
                if (Prime % i != 0)
                {
                    Sum += 1;
                }
            }
            if (Sum == Prime - 2)
            {
                Console.WriteLine(Prime);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int x = 2;x < Number; x++)
            {
                Prime_number(x);
            }
        }
    }
}