namespace Problem_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int Input_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((Input_Number*(Input_Number+1))/2);
        }
    }
}