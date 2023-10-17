using System.Text;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numbers = int.Parse(Console.ReadLine());
            
            string result = StringRepeat(input, numbers);
            Console.Write(result);
        }

        static string StringRepeat(string input, int numbers)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numbers; i++)
            {
                result.Append(input);
            }
            return result.ToString();
        }
    }
}