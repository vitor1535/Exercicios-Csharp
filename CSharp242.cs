using System.Collections.Generic;
using csharp;
using System.Linq;
using System.Globalization;


List<Employee> list = new List<Employee>();

Console.Write("Enter the full file path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = new StreamReader(path))
    {
        while (!(sr.EndOfStream))
        {
            string[] aux = sr.ReadLine().Split(',');
            string name = aux[0];
            string email = aux[1];
            double salary = double.Parse(aux[2], CultureInfo.InvariantCulture);

            Employee emp = new Employee(name, email , salary);
            list.Add(emp);
        }
    }

    Console.Write("Enter the salary: ");
    double avgSalary = double.Parse(Console.ReadLine());

    var v1 = list.Where(p => p.Salary > avgSalary).Select(p => p.Email );
    var v2 = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);

    Console.WriteLine("Email of people whose salary is more than " + avgSalary);
    foreach(string str in v1)
    {
        Console.WriteLine(str);
    }

    Console.Write("Sum of salary of people whose name starts with 'M': ");
    Console.WriteLine(v2);
}
catch (Exception e)
{
    Console.WriteLine("ERROR: " + e.Message);
}

