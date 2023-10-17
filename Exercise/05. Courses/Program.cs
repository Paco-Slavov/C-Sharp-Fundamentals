string input = Console.ReadLine();

Dictionary<string, List<string>> courses =
    new Dictionary<string, List<string>>();

while (input != "end")
{
    string[] cmdArgs = input
        .Split(" : ");

    string courseName = cmdArgs[0];
    string studentName = cmdArgs[1];

    if (!courses.ContainsKey(courseName))
    {
        courses.Add(courseName, new List<string>() { });
        courses[courseName].Add($"-- {studentName}");
    }
    else
    {
        courses[courseName].Add($" -- {studentName}");
    }
    input = Console.ReadLine();
}

foreach (var course in courses)
{
    Console.WriteLine($"{course.Key}: {course.Value.Count()}");

    Console.WriteLine(string.Join(Environment.NewLine, course.Value));

}