

namespace  Module4
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Employee> employees = new List<Employee>
      {
        new Employee { Id = 1, Name = "Alice", Department = "Engineering", Salary = 75000, Age = 28, JoiningYear = 2024},
        new Employee { Id = 2, Name = "Bob", Department = "Marketing", Salary = 55000, Age = 32, JoiningYear = 2025 },
        new Employee { Id = 3, Name = "Charlie", Department = "Engineering", Salary = 82000, Age = 35 , JoiningYear = 2025},
        new Employee { Id = 4, Name = "Diana", Department = "HR", Salary = 60000, Age = 26 , JoiningYear = 2024},
        new Employee { Id = 5, Name = "Eve", Department = "Marketing", Salary = 58000, Age = 29 , JoiningYear = 2024},
        new Employee { Id = 6, Name = "Frank", Department = "Engineering", Salary = 90000, Age = 40 , JoiningYear = 2022},
        new Employee { Id = 7, Name = "Grace", Department = "HR", Salary = 62000, Age = 31 , JoiningYear = 2021},
      };
      
      //Exercise 1
      //Method Syntax
      // var result = employees.Where(e => e.Name.StartsWith("A") || e.Name.StartsWith("E") || e.Name.StartsWith("I") || e.Name.StartsWith("O") || e.Name.StartsWith("U")).ToList();
      //Query Syntax
      // var result = (from employee in employees where employee.Name.StartsWith("A") || employee.Name.StartsWith("E") || employee.Name.StartsWith("I") || employee.Name.StartsWith("O") || employee.Name.StartsWith("U") select employee).ToList();
      // foreach (var employee in result)
      // {
      //   Console.WriteLine(employee.Name);
      // }
      
      // //Exercise 2
      // var mixedList = new List<object> { 1, "hello", 2, "world", 3.14, true, 4, 6.45, 1.223 };
      // var onlyDouble = mixedList.OfType<double>().ToList();
      // foreach (var num in onlyDouble)
      // {
      //   Console.WriteLine(num);
      // }
      
      //Exercise 3
      //method syntax
      // var result = employees.Where(employee => employee.JoiningYear == 2024 && employee.Salary > 60000).ToList();
      // //query syntax
      // var result = (from employee in employees where employee.JoiningYear == 2024 && employee.Salary > 60000 select employee).ToList();
      // foreach (var employee in result)
      // {
      //   Console.WriteLine($"{employee.Name} - {employee.JoiningYear}");
      // }
      
      //Exercise 4
      // const string name = "Gr";
      // const string department = "HR";
      // var result = employees
      //   .Where(e => e.Name.Contains(name, StringComparison.OrdinalIgnoreCase) || e.Department.Contains(department, StringComparison.OrdinalIgnoreCase))
      //   .ToList();
      // foreach(var str in result)
      // {
      //   Console.WriteLine($"{str.Name} - {str.Department}");
      // }
      
      // //Exercise 5
      // List<string> departmentList = ["Engineering", "Marketing"];
      // var result = employees.Where(e => departmentList.Contains(e.Department));
      // foreach (var employee in result)
      // {
      //   Console.WriteLine($"{employee.Name} - {employee.Department}");
      // }
    }
  }
}