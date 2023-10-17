int numberOfEmployees = int.Parse(Console.ReadLine());

var listOfEmployees = new List<Employee>();

for (int i = 0; i < numberOfEmployees; i++)
{
    string[] input = Console.ReadLine()
        .Split();

    string name = input[0];
    double salary = double.Parse(input[1]);
    string department = input[2];

    var newEmployee = new Employee(name, salary, department);

    listOfEmployees.Add(newEmployee);
}

listOfEmployees = listOfEmployees.OrderBy(x => x.Department).ToList();

var departments = new Dictionary<string, List<double>>();

for (int i = 0; i < listOfEmployees.Count; i++)
{
    string newDepartment = listOfEmployees[i].Department;
    double newSalary = listOfEmployees[i].Salary;
    
    if (!departments.ContainsKey(newDepartment))
    {
        departments[newDepartment] = new List<double>();
    }
    departments[newDepartment].Add(newSalary);
}
string departmentMaxAverage = departments.OrderByDescending
    (x => x.Value.Average()).First().Key;

listOfEmployees = listOfEmployees
    .Where(x => x.Department == departmentMaxAverage)
    .OrderByDescending(x => x.Salary)
     .ToList();

Console.WriteLine($"Highest Average Salary: {departmentMaxAverage}");

foreach (var men in listOfEmployees)
{
    Console.WriteLine($"{men.Name} {men.Salary:f2}");
}

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public Employee (string name, double salary, string department)
    {
        this.Name = name;
        this.Salary = salary;
        this.Department = department;
    }
}