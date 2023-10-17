namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            bool isValid = true;

            if (!IsLengthValid(password))
            {
                isValid = false;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!OnlyContainsDigitsAndLetter(password))
            {
                isValid = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!ContainsAtLeast2Digits(password))
            {
                isValid = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
            bool IsLengthValid(string password)
            {
                //return password.Length >= 6 && password.Length <= 10;
                return password.Length is >= 6 and <= 10;
            }
            bool OnlyContainsDigitsAndLetter(string password)
            {
                return password.All(char.IsLetterOrDigit);
            }
            bool ContainsAtLeast2Digits(string password)
            {
                return password.Count(char.IsDigit) >= 2;
            }
        }
    }
}