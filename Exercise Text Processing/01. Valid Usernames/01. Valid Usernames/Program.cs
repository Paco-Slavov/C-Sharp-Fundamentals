string[] usernames = Console.ReadLine()
    .Split(", ");
foreach (string currName in usernames)
{
    if (currName.Length > 3 && currName.Length <= 16)
    {
        bool isUserNameValid = true;

        foreach (char currChar in currName)
        {
            if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_'))
            {
                isUserNameValid = false;
                break;
            }
        }
        if (isUserNameValid)
        {
            Console.WriteLine(currName);
        }
    }
}