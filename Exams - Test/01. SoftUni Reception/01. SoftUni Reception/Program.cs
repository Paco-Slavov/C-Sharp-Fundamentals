int numOfStudentPer1Hour1 = int.Parse(Console.ReadLine());
int numOfStudentPer1Hour2 = int.Parse(Console.ReadLine());
int numOfStudentPer1Hour3 = int.Parse(Console.ReadLine());
int studentCount = int.Parse(Console.ReadLine());

int hourCount = 0;
int maxStudentPerHour = numOfStudentPer1Hour1 + numOfStudentPer1Hour2 + numOfStudentPer1Hour3;

if (studentCount % maxStudentPerHour == 0)
{
    hourCount = studentCount / maxStudentPerHour + 1;
}
if (hourCount > 3 && maxStudentPerHour % 3 == 0)
{
    hourCount += hourCount / 3 - 1;
}
else if (hourCount > 3)
{
    hourCount += hourCount / 3;
}

Console.WriteLine($"Time needed: {hourCount}h");