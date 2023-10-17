char inputSymbol = char.Parse(Console.ReadLine());

if (inputSymbol >= 64 && inputSymbol <= 90)
    //char.IsUpper(inputSymbol)
    //inputSymbol >= 'A' && inputSymbol <= 'Z'
{
    Console.WriteLine("upper-case");
}
else
{
    Console.WriteLine("lower-case");
}