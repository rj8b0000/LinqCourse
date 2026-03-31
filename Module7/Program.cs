using Module7;
namespace  Module7
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
            var deptList = new List<string> { "Engineering", "Marketing", "HR" };
            
            // Exercise 1
            // var result = employees.FirstOrDefault(e => e.Salary > 70000);
            // if (result != null)
            // {
            //     Console.WriteLine(result.Name);
            // }
            // else
            // {
            //     Console.WriteLine("No employees");
            // }
            
            
            // Exercise 2
            // var result = employees.Single(employee => employee.Id == 5);
            // Console.WriteLine(result.Name);
            
            // Exercise 3
            // bool hasAgeLessThen25 = employees.Any(e => e.Age < 25);
            // Console.WriteLine(hasAgeLessThen25);
            //
            // bool allHaveAgeLessThen50 = employees.All(e => e.Age < 50);
            // Console.WriteLine(allHaveAgeLessThen50);
            
            // Exercise 4
            // var orders = new List<int>{150, 200, 150, 300, 25};
            //
            // bool doesItContainsValue200 = orders.Contains(200);
            // Console.WriteLine(doesItContainsValue200);
            //
            // bool checkAllOrderLessthen100 = orders.All(x => x > 100);
            // Console.WriteLine(checkAllOrderLessthen100);
            
            // Exercise 5
            // var result = deptList.Where(dept => employees.Any(emp => emp.Department == dept && emp.Salary > 80000)).ToList();
            // Console.WriteLine(result[0]);
        }
    }
}