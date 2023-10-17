//double a = double.Parse(Console.ReadLine());
//double b = double.Parse(Console.ReadLine());
//double c = double.Parse(Console.ReadLine());
//double x = 0;

//if (b < a)
//{
//    x = a;
//    a = b;
//    b = x;
//}
//if (c < a)
//{
//    x = c;
//    c = a;
//    a = x;
//}
//if (c < b)
//{
//    x = c;
//    c = b;
//    b = x;
//}
//if (a == b)
//{
//    x = a;
//    a = b;
//    b = x;
//}
//if (a == c)
//{
//    x = a;
//    a = c;
//    c = x;
//}
//if (b == c)
//{
//    x = b;
//    b = c;
//    c = x;
//}
//Console.WriteLine(c);
//Console.WriteLine(b);
//Console.WriteLine(a);

double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine(a);
    if (b > c)
    {
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
    else
    {
        Console.WriteLine(c);
        Console.WriteLine(b);
    }
}
else if (b > a && b > c)
{
    Console.WriteLine(b);
    if (a > c)
    {
        Console.WriteLine(a);
        Console.WriteLine(c);
    }
    else
    {
        Console.WriteLine(c);
        Console.WriteLine(a);
    }
}
else if (c > a && c > b)
{
    Console.WriteLine(c);
    if (a > b)
    {
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine(b);
        Console.WriteLine(a);
    }
}