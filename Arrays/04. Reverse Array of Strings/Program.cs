string[] names = Console.ReadLine().Split();

//1. for (int i = 0; i < names.Length / 2; i++)
//{
//    string firstElement = names[i];
//    string lastElement = names[names.Length - 1 - i];
//    names[i] = lastElement;
//    names[names.Length - 1 - i] = firstElement;
//}

names = names.Reverse().ToArray();

//3. Array.Sort(names);
Console.WriteLine(string.Join(" ", names));