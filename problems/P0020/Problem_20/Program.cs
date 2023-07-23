namespace Problem_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            IDictionary<int, string> numberNames = new Dictionary<int, string>()
            {
                {1, "One"},
                {2, "two"},
                {3, "Three"},
                {4, "Four"},
                {5, "Five"},
                {6, "Six"},
                {7, "Seven"},
                {8, "Eight"},
                {9, "Nine"},
                {10, "Ten"}
            };
            Console.WriteLine(numberNames.ElementAt(Number - 1).Value);

        }
    }
}