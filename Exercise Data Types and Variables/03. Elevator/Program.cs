double numberOfPeople = double.Parse(Console.ReadLine());
int elevatorCapacity = int.Parse(Console.ReadLine());

int numberofCourses = (int)Math.Ceiling(numberOfPeople / elevatorCapacity);

Console.WriteLine(numberofCourses);