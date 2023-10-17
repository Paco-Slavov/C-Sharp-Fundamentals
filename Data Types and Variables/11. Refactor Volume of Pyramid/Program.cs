double length, width, volume = 0;

Console.Write("Length: ");

length = double.Parse(Console.ReadLine());

Console.Write("Width: ");

width = double.Parse(Console.ReadLine());

Console.Write("Height: ");

volume = double.Parse(Console.ReadLine());

volume = (length * width * volume) / 3;

Console.WriteLine($"Pyramid Volume: {volume:f2}");