namespace Problem_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> N_Planet = new List<string>() { "Venus", "Erath", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            List<Int64> Planet = new List<Int64>() { 108200000, 149600000, 227900000, 778600000, 1433500000, 2872500000, 4495100000 };
            Console.WriteLine("Sun - MerCury");
            for (int t = 0; t < N_Planet.Count; t++)
            {
                Console.Write("Sun ");
                for (int h = 0; h < (Planet[t] / 57900000)+1; h++)
                {
                    Console.Write("-");
                }
                Console.WriteLine(" " + N_Planet[t]);

            }
        }
    }
}