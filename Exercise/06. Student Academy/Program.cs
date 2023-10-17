using System.ComponentModel;

Dictionary<string, double> students =
    new Dictionary<string, double>();

Dictionary<string, double> studentsGrades 
    = new Dictionary<string, double>();

int input = int.Parse(Console.ReadLine());

for (int i = 0; i < input; i++)
{
    string student = Console.ReadLine();
    double grades = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(student))
    {
       studentsGrades.Add(student, 1);
       students.Add(student, grades);
    }
    else
    {
        double gradesCount = studentsGrades[student] + 1;
        students[student] = (students[student] + grades) / gradesCount;
    }
}

foreach (var student in students)
{
    if (student.Value >= 4.5)
    {
        Console.WriteLine($"{student.Key} -> {student.Value:f2}");
    }
}