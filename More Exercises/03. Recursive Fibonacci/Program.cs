int input = int.Parse(Console.ReadLine());
Console.WriteLine(GetFibonacci(input));

static int GetFibonacci(int n)

{
    if (n == 2 || n == 1) return 1;
    {
        int number = GetFibonacci(n - 1) + GetFibonacci(n - 2);
        return number;
    }
}
//int num = int.Parse(Console.ReadLine());
//int[] array = new int[] { 1, 1 };
//int sum = 0;

//switch (num)
//{
//    case 1:
//        Console.WriteLine("1");
//        return;
//    case 2:
//        Console.WriteLine("1");
//        return;
//}

//for (int i = 2; i < num; i++)
//{
//    sum = array[0] + array[1];
//    int[] newArray = new int[] { array[1], sum };
//    array = newArray;
//}
//Console.WriteLine(sum);