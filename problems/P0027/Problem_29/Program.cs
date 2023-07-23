namespace Problem_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Numbers: ");
            var Num = Console.ReadLine().Split(" ");
            if (Num[0] == "P:")
            {
                for (int g = 1; g < Num.Length; g++)
                {
                    Console.Write(g + " ");
                }
                Console.WriteLine();
                for (int i = 1; i != Num.Length; i++)
                {
                    Console.WriteLine(i + " " + Num[i]);
                }
            }
            else
            {
                List<string> list = new List<string>();
                for (int h = 1; h != Num.Length; h++)
                {
                    string[] N = Console.ReadLine().Split(" ");
                    list.Add(N[1]);
                }
                for (int y = 0; y < list.Count; y++)
                {
                    Console.Write(list[y]+" ");
                }

            }
        }
    }
}