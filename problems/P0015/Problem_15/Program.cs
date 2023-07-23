namespace Problem_15
{
    internal class Program
    {
        static void Sum_List(List<int> list_Num)
        {
            int Sum = 0;
            foreach (var item in list_Num)
            {
                Sum += item;
            }
            Console.WriteLine("Sum Of These Numbers Are "+Sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many Numbers do you want to enter: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            var Lists = new List<int>();
            for (int i = 0;i < Num; i++)
            {
                Console.WriteLine("Enter the Number: ");
                Lists.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Sum_List(Lists);
        }
    }
}