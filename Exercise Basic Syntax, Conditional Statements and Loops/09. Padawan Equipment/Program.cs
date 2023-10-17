double money = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double lightsaberPrice = double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());

double lightsabers = Math.Ceiling((double)students * 1.10);
double sumLightsabers = lightsabers * lightsaberPrice;

double sumRobes = students * robePrice;

double belts = students;
double sumBelts = belts * beltPrice;

double sixthBelts = Math.Floor((double)students / 6);
sumBelts = (students * beltPrice) - (sixthBelts * beltPrice);

double totalSum = sumRobes + sumLightsabers + sumBelts;

if (totalSum <= money)
{
    Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {totalSum - money:f2}lv more.");
}