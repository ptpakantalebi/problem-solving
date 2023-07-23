namespace Problem_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number: ");
            int Number_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator: ");
            string Operator = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            int Number_2 = Convert.ToInt32(Console.ReadLine());
            if (Operator == "+")
            {
                Console.WriteLine(Number_1 + Number_2);
            }
            if (Operator == "-")
            {
                Console.WriteLine(Number_1 - Number_2);
            }
            if (Operator == "*")
            {
                Console.WriteLine(Number_1 * Number_2);
            }
            if (Operator == "/")
            {
                Console.WriteLine(Number_1 / Number_2);
            }
        }
    }
}