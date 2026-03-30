using System;
using Module5.ViewModel;

namespace Module5
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
            // var departments = new List<Department>
            // {
            //     new Department
            //     {
            //         Name = "IT",
            //         Members = new List<Employee>
            //         {
            //             new Employee { Name = "Ravi" },
            //             new Employee { Name = "Kiran" }
            //         }
            //     },
            //     new Department
            //     {
            //         Name = "HR",
            //         Members = new List<Employee>
            //         {
            //             new Employee { Name = "Amit" },
            //             new Employee { Name = "Neha" }
            //         }
            //     }
            // };
            
            var orders = new List<Order>
            {
                new Order
                {
                    CustomerName = "Bob",
                    Items = new List<string> { "Laptop", "Mouse" }
                },
                new Order
                {
                    CustomerName = "Alice",
                    Items = new List<string> { "Keyboard" }
                },
                new Order
                {
                    CustomerName = "Bob",
                    Items = new List<string> { "Monitor", "USB Cable" }
                }
            };
            //Exercise 1
            //Method Syntax
            // var summaries = employees
            //     .Select(e => new
            //     {
            //         FullInfo = $"{e.Name} ({e.Department})"
            //     })
            //     .ToList();
            //
            // foreach (var employee in summaries)
            // {
            //     Console.WriteLine(employee);
            // }
            
            
            // //Exercise 2
            // var result = departments.SelectMany(department => department.Members).ToList();
            // foreach (var department in result)
            // {
            //     Console.WriteLine(department.Name);
            // }

            //Exercise 3
            // var result = orders.Where(o => o.CustomerName == "Bob").SelectMany(o => o.Items).ToList();
            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            //
            // }
            
            //Exercise 4
            // var result = employees.Select((e, index) => new { Index = index + 1, e.Name }).ToList();
            // foreach (var emp in result)
            // {
            //     Console.WriteLine($"{emp.Index} - {emp.Name}");
            // }
            
            var sentences = new List<string> { "Hello World", "LINQ is great", "C# is fun" };
            var result = sentences.SelectMany(sentence =>  sentence.Split(' ')).ToList();
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}