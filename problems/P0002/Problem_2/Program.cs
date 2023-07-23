namespace Problem_2
{
    internal class Program
    {
        static void Plus(int Number_1, int Number_2)
        {
            Console.WriteLine(Number_1 + Number_2);
        }
         static void Minus(int Number_3, int Number_4)
        {
            Console.WriteLine(Number_3 - Number_4);
        }
        static void Multiplication(int Number_5, int Number_6)
        {
            Console.WriteLine(Number_5 * Number_6);
        }
        static void Division(int Number_7,int Number_8)
        {
            Console.WriteLine(Number_7 / Number_8);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Phrase: ");
            string Phrase = Console.ReadLine();
            string[] splited_Phrase = Phrase.Split();
            if (splited_Phrase[1] == "+")
            {
                Plus(Convert.ToInt32(splited_Phrase[0]),Convert.ToInt32(splited_Phrase[2]));
            }
            if (splited_Phrase[1] == "-")
            {
                Minus(Convert.ToInt32(splited_Phrase[0]), Convert.ToInt32(splited_Phrase[2]));
            }
            if (splited_Phrase[1] == "*")
            {
                Multiplication(Convert.ToInt32(splited_Phrase[0]), Convert.ToInt32(splited_Phrase[2]));
            }
            if (splited_Phrase[1] == "/")
            {
                Division(Convert.ToInt32(splited_Phrase[0]), Convert.ToInt32(splited_Phrase[2]));
            }
        }
    }
}