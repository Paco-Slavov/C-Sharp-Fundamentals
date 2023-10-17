namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(VowelsCount(input));

            int VowelsCount(string input)
            {
                int count = 0;
                
                foreach(var character in input)
                {
                    if (isVowel(character))
                    {
                        count++;
                    }
                }
                return count;
            }
            bool isVowel(char character)
            {
                char[] vowels = new[] { 'a', 'o' };
                return ("aeiouAEIOUY".IndexOf(character) >= 0);
            }
        }
    }
}