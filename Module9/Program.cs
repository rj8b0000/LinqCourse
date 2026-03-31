namespace  Module9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Yalina", Department = "Engineering", Salary = 75000, Age = 28, JoiningYear = 2024},
                new Employee { Id = 2, Name = "Ajay Sanyal", Department = "Marketing", Salary = 55000, Age = 32, JoiningYear = 2025 },
                new Employee { Id = 3, Name = "Jamali", Department = "Engineering", Salary = 82000, Age = 35 , JoiningYear = 2025},
                new Employee { Id = 4, Name = "Aslam", Department = "HR", Salary = 60000, Age = 26 , JoiningYear = 2024},
                new Employee { Id = 5, Name = "Aalam", Department = "Marketing", Salary = 58000, Age = 29 , JoiningYear = 2024},
                new Employee { Id = 6, Name = "Javed Khanani", Department = "Engineering", Salary = 90000, Age = 40 , JoiningYear = 2022},
                new Employee { Id = 7, Name = "Hamza", Department = "HR", Salary = 62000, Age = 31 , JoiningYear = 2021},
                new Employee { Id = 8, Name = "Pinda", Department = "HR", Salary = 60000, Age = 26 , JoiningYear = 2024},
                new Employee { Id = 9, Name = "Iqbal", Department = "Marketing", Salary = 58000, Age = 29 , JoiningYear = 2024},
                new Employee { Id = 10, Name = "Jaskirit", Department = "Engineering", Salary = 90000, Age = 40 , JoiningYear = 2022},
            };
            var orders = new List<Order>
            {
                new Order
                {
                    CustomerName = "Hamza",
                    Items = new List<OrderItem>
                    {
                        new OrderItem { Id = 1, ProductName = "Laptop", Price = 65000 },
                        new OrderItem { Id = 2, ProductName = "Mouse", Price = 700 },
                    
                    },
                },
                new Order
                {
                    CustomerName = "Jamali",
                    Items = new List<OrderItem>
                    {
                        new OrderItem { Id = 1, ProductName = "Keyboard", Price = 5500 },
                        new OrderItem { Id = 2, ProductName = "Monitor", Price = 7800 }
                    },
                }
            };
            var groups = employees.GroupBy(e => e.Department).ToList();

            // Exercise 1
            // Group employees by department and show the **count and average salary** per department. Both syntaxes.
            // var departmentStatus = employees.GroupBy(emp => emp.Department).Select(dept => new
            // {
            //     Department = dept.Key,
            //     EmployeeCount = dept.Count(),
            //     AverageSalary = Math.Ceiling(dept.Average(emp => emp.Salary)),
            // }).ToList();
            
            // var departmentStatus = (from employee in employees group employee by employee.Department into department select new { Department = department.Key, EmployeeCount = department.Count(), AverageSalary = Math.Ceiling(department.Average(emp => emp.Salary)) }).ToList();
            //
            // foreach (var group in departmentStatus)
            // {
            //     Console.WriteLine($"{group.Department} - {group.EmployeeCount} employees - {group.AverageSalary}");
            // }
            
            //Exercise 2
            //Group a list of numbers into "Even" and "Odd" groups. Show the count and sum for each.
            // var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // var result = numbers.GroupBy(num => num % 2 == 0 ? "Even": "Odd").Select(g => new {Count = g.Count(), Sum =  g.Sum()}).ToList();
            // foreach (var item in result)
            // {
            //     Console.WriteLine(item.Count + " " + item.Sum);
            // }

            // Exercise 3
            //Group employees by department. Show only departments with average salary > 65000.
            // var result = employees.GroupBy(e => e.Department).Select(dept => new
            // {
            //     Department = dept.Key,
            //     AverageSalary = dept.Average(e => e.Salary),
            // }).Where(g => g.AverageSalary > 65000).ToList();
            // foreach (var group in result)
            // {
            //     Console.WriteLine(group.Department);
            // }
            
            // Exercise 4
            // Group employees by the **first letter of their name**. For each group, show the letter and the names.
            // var result = employees.GroupBy(e => e.Name[0]).Select(g => new { Letter = g.Key, Names = g.Select(e => e.Name).ToList() }).ToList();
            // foreach (var group in result)
            // {
            //     Console.WriteLine(group.Letter);
            //     foreach (var name in group.Names)
            //     {
            //         Console.WriteLine($"{name}");
            //     }
            // }
            
            // Exercise 5
            // // Group orders by customer, and for each customer show: total number of orders, total amount, and average amount.
            // var result = orders.GroupBy(order => order.CustomerName).Select(g => new
            // {
            //     CustomerName = g.Key,
            //     TotalOrders = g.Count(),
            //     Total = g.Sum(order => order.Items.Sum(i => i.Price)),
            //     Average = g.Average(order => order.Items.Sum(i => i.Price)),
            // }).ToList();
            // foreach (var item in result)
            // {
            //     Console.WriteLine($"{item.CustomerName}, {item.TotalOrders} {item.Total} {item.Average}");
            // }
        }
    }
}