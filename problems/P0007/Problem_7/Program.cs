namespace Problem_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 5; i < Number; i = i + 5)
            {
                Console.WriteLine(i);
            }
        }
    }
}