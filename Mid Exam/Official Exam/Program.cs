int prodPerDay = int.Parse(Console.ReadLine());
int count = int.Parse(Console.ReadLine());
int allBisc = int.Parse(Console.ReadLine());

double myProdPerDay = 0;
double totalProd = 0;
double diff = 0;
double percent = 0;

for (int i = 0; i < 30; i++)
{
    myProdPerDay = prodPerDay * count;

    if (i % 3 == 0)
    {
        myProdPerDay = Math.Floor(myProdPerDay * 0.75);
    }
    totalProd += myProdPerDay;
}

Console.WriteLine($"You have produced {totalProd} biscuits for the past month.");

if (totalProd > allBisc)
{
    diff = totalProd - allBisc;
    percent = diff / allBisc * 100;
    Console.WriteLine($"You produce {percent:f2} percent more biscuits.");
}
else
{
    diff = allBisc - totalProd;
    percent = diff / allBisc * 100;
    Console.WriteLine($"You produce {percent:f2} percent less biscuits.");
}