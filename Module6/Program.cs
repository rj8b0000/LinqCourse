using System;
using Module6;

namespace Module6
{
    class Program
    {
        public static void Main(string[] args)
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
            //Exercise 1 - In Ascending
            //Method Syntax
            // var result = employees.OrderBy(e => e.Salary).ToList();
            // foreach (var employee in result)
            // {
            //     Console.WriteLine($"{employee.Name} - {employee.Salary}");
            // }
            // Query Syntax
            // var result = (from employee in employees orderby employee.Salary select employee).ToList();
            // foreach (var employee in result)
            // {
            //     Console.WriteLine($"{employee.Name} - {employee.Salary}");
            // }
            
            // Exercise 1 - In Descending
            // var result = employees.OrderByDescending(e => e.Salary).ToList();
            // Query Index
            // var result = (from employee in employees orderby employee.Salary descending select employee).ToList();
            // foreach (var employee in result)
            // {
            //     Console.WriteLine($"{employee.Name} - {employee.Salary}");
            // }
            
            // Exercise 2 
            // var result = employees.OrderBy(employee => employee.Department).ToList();
            // var result = (from employee in employees orderby employee.Department select employee).ToList();
            // var result = employees.OrderByDescending(employee => employee.Department).ThenByDescending(employee => employee.Age).ToList();
            // var result = (from employee in employees orderby employee.Department descending , employee.Age descending select employee).ToList();
            // foreach (var employee in result)
            // {
            //     Console.WriteLine($"{employee.Name} - {employee.Department} - {employee.Age}");
            // }
            
            //Exercise 3
            // var names = new List<string> { "Rudraksh", null, "Hamza", null, "Aslam", null, "Aalam", "Jamali", null, "Yalina" };
            // var sortedNames = names.OrderBy(x => x == null).ThenBy(x => x).ToList();
            // foreach (var name in sortedNames)
            // {
            //     Console.WriteLine(name);
            // }
            
            // Exercise 4
            // var names = new List<string> { "Rudraksh", "Hamza", "aslam", "alam", "Jamali", "yalina" };
            // var sortedNames = names.OrderBy(name => name, StringComparer.OrdinalIgnoreCase).ToList();
            // foreach (var name in sortedNames)
            // {
            //     Console.WriteLine(name);
            // }
            
            //Exercise 5
            // var result = employees.OrderBy(employee => employee.Age).Take(3).ToList();
            // foreach (var employee in result)
            // {
            //     Console.WriteLine($"{employee.Name} - {employee.Age}");
            // }
        }
    }
}