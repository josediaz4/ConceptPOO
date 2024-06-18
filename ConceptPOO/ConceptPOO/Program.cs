
using ConceptPOO;
using System.Linq.Expressions;

Console.WriteLine("Concepts POO");
Console.WriteLine("============");

//try
//{
//    Console.WriteLine(new Date(1994, 4, 4));
//    Console.WriteLine(new Date(1990, 3, 1));
//    Console.WriteLine(new Date(1994, 8, 45));

//}
//catch (Exception error)
//{
//    Console.WriteLine(error.Message);
//}

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.40M
};
//Console.WriteLine("Salary Employee");
//Console.WriteLine(employee1);
//Console.WriteLine("---------------------------");

Employee employee2 = new CommisionEmployee()
{
    Id = 2020,
    FirstName = "Maria",
    LastName = "Rodriguez",
    BirthDate = new Date(1998, 10, 10),
    HiringDate = new Date(2022, 8, 1),
    IsActive = true,
    CommisionPercentaje = 0.03f,
    Sales = 320000000m
};
//Console.WriteLine("Commission Employee");
//Console.WriteLine(employee2);
//Console.WriteLine("---------------------------");

Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Jose",
    LastName = "Diaz",
    BirthDate = new Date(1994, 4, 14),
    HiringDate = new Date(2024, 7, 1),
    IsActive = true,
    HourValue = 12356.46M,
    Hours = 123.5F
};
//Console.WriteLine("Hourly Employee");
//Console.WriteLine(employee3);
//Console.WriteLine("---------------------------");

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 4040,
    FirstName = "Pepe",
    LastName = "Grillo",
    BirthDate = new Date(1991, 3, 1),
    HiringDate = new Date(2020, 10, 10),
    IsActive = true,
    Base = 860678.45M,
    Sales = 58000000M,
    CommisionPercentaje = 0.015F
};
//Console.WriteLine("Base Commission Employee");
//Console.WriteLine(employee4);
//Console.WriteLine("---------------------------");

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}

Console.WriteLine("                               ==================");
Console.WriteLine($"TOTAL                         {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Id = 0001,
    Description = "iPhone 13",
    Quantity = 6,
    Price = 5300000m
};
Invoice invoice2 = new Invoice()
{
    Id = 0002,
    Description = "Posta Prem",
    Quantity = 17.5f,
    Price = 32000m
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);