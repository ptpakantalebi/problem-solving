namespace Problem_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Sum = 2;
            for (int i = 3; i <= Number; i++)
            {
                Sum *= i;
            }
            Console.WriteLine(Sum);
        }
    }
}