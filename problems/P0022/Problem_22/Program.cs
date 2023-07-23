namespace Problem_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Enter the Number that has {Num} digits:");
            var First_N = Console.ReadLine();
            var splited_First_N = First_N.Split(" ");
            Console.WriteLine($"Enter the Number that has {Num} digits again:");
            var second_N = Console.ReadLine();
            var splited_secod_N = second_N.Split(" ");
            for (int i = 0; i < Num; i++)
            {
                Console.Write(Convert.ToInt32(splited_First_N[i]) + Convert.ToInt32(splited_secod_N[i])+" ");
            }
        }
    }
}