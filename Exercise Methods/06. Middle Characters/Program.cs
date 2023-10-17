namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(Mid(input));
        }
        static string Mid(string input)
        {
            int length = input.Length;
            string result = string.Empty;

            if (length % 2 == 1)
            {
                result = input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString(); ;
            }

            return result;

        }
    }
}