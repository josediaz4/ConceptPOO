
using ConceptPOO;

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
Console.WriteLine("Salary Employee");
Console.WriteLine(employee1);
Console.WriteLine("---------------------------");

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
Console.WriteLine("Commission Employee");
Console.WriteLine(employee2);
