namespace Problem_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            List<int> list_Num = new List<int>()
            {
                1, 1,
            };
            for (int y = 0; y != Num; y++)
            {
                if (y == 0)
                {
                    for(int w = 0; w < Num-1; w++){ Console.Write(" "); }
                    Console.WriteLine("1");
                }
                if (y == 1)
                {
                    for (int q = 0; q < Num-2; q++) { Console.Write(" "); }
                    Console.WriteLine("1 1");
                }
                if (y > 2 || y == 2)
                {
                    int Sum = 0;
                    for (int t = 0;t < list_Num.Count-1; t++)
                    {
                        Sum = list_Num[t] + list_Num[t + 1];
                        list_Num.RemoveAt(t);
                        list_Num.Insert(t, Sum);
                    }
                    list_Num.Insert(0, 1);
                    for (int z = 0; z < Num-(y+1); z++) { Console.Write(" "); }
                    foreach (var count in list_Num){Console.Write(count + " ");}
                    Console.WriteLine();
                }
            }

        }
    }
}