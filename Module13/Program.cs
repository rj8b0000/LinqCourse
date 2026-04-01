namespace  Module13
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Yalina", Department = "Engineering", Salary = 75000, Age = 28, JoiningYear = 2024},
                new Employee { Id = 2, Name = "Ajay Sanyal", Department = "Marketing", Salary = 55000, Age = 32, JoiningYear = 2025 },
                new Employee { Id = 3, Name = "Jamali", Department = "Engineering", Salary = 82000, Age = 35 , JoiningYear = 2025},
                new Employee { Id = 4, Name = "Aslamfghfghfghfghfghfghfghfghfghfghfg", Department = "HR", Salary = 60000, Age = 26 , JoiningYear = 2024},
                new Employee { Id = 5, Name = "Aalam", Department = "Marketing", Salary = 58000, Age = 29 , JoiningYear = 2024},
                new Employee { Id = 6, Name = "Javed Khanani", Department = "Engineering", Salary = 90000, Age = 40 , JoiningYear = 2022},
                new Employee { Id = 7, Name = "Hamza", Department = "HR", Salary = 62000, Age = 31 , JoiningYear = 2021},
                new Employee { Id = 8, Name = "Pinda", Department = "HR", Salary = 60000, Age = 26 , JoiningYear = 2024},
                new Employee { Id = 9, Name = "Iqbal", Department = "Marketing", Salary = 58000, Age = 29 , JoiningYear = 2024},
                new Employee { Id = 10, Name = "Jaskirit", Department = "Engineering", Salary = 90000, Age = 40 , JoiningYear = 2022},
            };
            
            
            // ### Exercise 1:
            // Convert the employees list to a **dictionary** keyed by `Id`. Look up the employee with Id = 3.
            // var employeesDictionary = employees.ToDictionary(e => e.Id, e => e);
            // Console.WriteLine(employeesDictionary[3].Name);
            
            
            // ### Exercise 2:
            // Create a **lookup** of employees by department. Access all employees in "Marketing".
            // var lookup = employees.ToLookup(e => e.Department);
            // var marketingDepartment = lookup["Marketing"].ToList();
            // foreach (var employee in marketingDepartment)
            // {
            //     Console.WriteLine(employee.Name);
            // }
            
            //### Exercise 3:
            //Get a `HashSet<string>` of all unique department names. Check if "Finance" exists.
            // var uniqueDepartments = employees.Select(e => e.Department).ToHashSet();
            // bool hasFinance = uniqueDepartments.Contains("Finance");
            // Console.WriteLine("Check has finance: " + hasFinance);
            
            //### Exercise 4:
            //Convert the result of a `Where` + `Select` query (names of employees > 30) to both a `List` and an `Array`. Compare them.
            // var result = employees.Select(employee => employee).Where(employee => employee.Name.Length > 30).ToList();
            // var result = employees.Select(employee => employee).Where(employee => employee.Name.Length > 30).ToArray();
            // foreach (var employee in result)
            // {
            //     Console.WriteLine($"{employee.Id} {employee.Name}");
            // }
            
            //### Exercise 5:
            //Try creating a `ToDictionary` with department as key. Observe the error. Then fix it using `GroupBy` + `ToDictionary`.
            // var result = employees.ToDictionary(k => k.Department, v => v);
            // foreach (var checkResult in result)
            // {
            //     Console.WriteLine($"{checkResult.Key} - {checkResult.Value}");
            // }
            
            //Error Occurred - Unhandled exception. System.ArgumentException: An item with the same key has already been added. Key: Engineering
            // at System.Collections.Generic.Dictionary`2.TryInsert(TKey key, TValue value, InsertionBehavior behavior)

            //The Fix 
            // var result = employees.GroupBy(e => e.Department).Select(g => new
            // {
            //     Department = g.Key,
            //     EmployeeName = g.FirstOrDefault().Name,
            // }).ToDictionary(s => s.Department, v => v);
            // foreach (var item in result)
            // {
            //     Console.WriteLine($"{item.Key} - {item.Value}");
            // }
                
            // var line = string.Join("", Enumerable.Repeat("-", 50));
            var hello3 = Enumerable.Repeat("Hello", 3).ToList();
            foreach (var text in hello3)
            {
                Console.WriteLine(text);
            }
        }
    }
}