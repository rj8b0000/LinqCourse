using System.Collections;

namespace Module3
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Department = "Engineering", Salary = 75000, Age = 28 },
                new Employee { Id = 2, Name = "Bob", Department = "Marketing", Salary = 55000, Age = 32 },
                new Employee { Id = 3, Name = "Charlie", Department = "Engineering", Salary = 82000, Age = 35 },
                new Employee { Id = 4, Name = "Diana", Department = "HR", Salary = 60000, Age = 26 },
                new Employee { Id = 5, Name = "Eve", Department = "Marketing", Salary = 58000, Age = 29 },
                new Employee { Id = 6, Name = "Frank", Department = "Engineering", Salary = 90000, Age = 40 },
                new Employee { Id = 7, Name = "Grace", Department = "HR", Salary = 62000, Age = 31 },
            };
            
            //Exercise 1 
            //Using Method Syntax
            // var result = employees.Where(employee => employee.Department == "HR").ToList();
            // //Using Query Syntax
            // var result = (from e in employees where e.Department == "HR" select e).ToList();
            // foreach(var selectedEmployees in result)
            // {
            //     Console.WriteLine(selectedEmployees.Name);
            // }
            
            // Exercise 2
            
            // Method Syntax
            // var result = employees.Where(employee => employee.Age > 30).OrderBy(employee => employee.Age).ToList();
            //Query Syntax
            // var result = (from employee in employees where employee.Age > 30 select employee).ToList();
            // foreach (var employee in result)
            // {
            //     Console.WriteLine($"{employee.Name} - {employee.Age}");
            // }
            
            // Exercise 3
            //Method Syntax
            //var result = employees.Where(employee => employee.Salary > 55000 && employee.Salary < 70000).ToList();
            //Query Syntax
            // var result = (from employee in employees where employee.Salary > 55000 && employee.Salary < 70000 select employee).ToList();
            // foreach(var employee in result)
            // {
            //     Console.WriteLine($"{employee.Name} - {employee.Salary}");
            // }
            
            //Exercise 4
            //Method Syntax
            // var result = employees.Select(employee => new { employee.Department, employee.Name}).OrderBy(employee => employee.Department).ToList();
            //Query Syntax
            // var result = (from employee in employees orderby employee.Department select new {employee.Department , employee.Name}).ToList();
            // foreach (var emp in result)
            // {
            //     Console.WriteLine($"{emp.Name} - {emp.Department}");
            // }
        }
    }
}