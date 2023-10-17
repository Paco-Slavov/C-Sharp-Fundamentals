string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int intAsDayOfWeek = int.Parse(Console.ReadLine());

if (intAsDayOfWeek >= 1 && intAsDayOfWeek <= 7)
{
    Console.WriteLine(days[intAsDayOfWeek - 1]);
}
else
{
    Console.Write("Invalid day!");
}
