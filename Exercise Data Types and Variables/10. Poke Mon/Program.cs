int powerN = int.Parse(Console.ReadLine());
double half = powerN * 0.5;
int distanceM = int.Parse(Console.ReadLine());
int exhaustionY = int.Parse(Console.ReadLine());
int target = 0;
while (powerN >= distanceM)
{
    if (powerN == half)
    {
        powerN /= exhaustionY;
    }
    if (powerN >= distanceM)
    {
        powerN -= distanceM;
        target++;
    }
    else
    {
        break;
    }
}
Console.WriteLine(powerN);
Console.WriteLine(target);