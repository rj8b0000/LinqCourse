namespace  Module12;
public class Program
{
    public static void Main(string[] args)
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
        // ### Exercise 1:
        // Find the **total salary**, **average salary**, **highest salary**, and **lowest salary** from all employees.
        // var totalSalary = employees.Sum(e => e.Salary);
        // Console.WriteLine($"Total Salary: {totalSalary}");
        // var avergeSalary = employees.Average(e => e.Salary);
        // Console.WriteLine($"Average Salary: {avergeSalary}");
        // var highestSalary = employees.Max(e => e.Salary);
        // Console.WriteLine($"Max Salary: {highestSalary}");
        // var lowestSalary = employees.Min(e => e.Salary);
        // Console.WriteLine($"Min Salary: {lowestSalary}");
        
        // ### Exercise 2:
        // Count the number of employees **per department**.
        // var totalEmployees = employees.GroupBy(emp => emp.Department).Select(empGroup => new
        // {
        //     Department = empGroup.Key,
        //     TotalEmployees = empGroup.Count()
        // }).ToList();
        // foreach (var employee in totalEmployees)
        // {
        //     Console.WriteLine($"{employee.Department} - {employee.TotalEmployees}");
        // }
        
        // ### Exercise 3:
        // Use `Aggregate` to join a list of strings with " | " separator: `["A", "B", "C"]` → `"A | B | C"`
        // var strings = new List<string> {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
        //
        // var concatedStrings = strings.Aggregate((current, next) => current + " | " + next);
        // Console.WriteLine($"Concated Strings: {concatedStrings}");
        
        
        // ### Exercise 4:
        // Find the **employee with the highest salary** using `MaxBy`. Then do the same without `MaxBy` (using `OrderByDescending` + `First`).
        // var totalSalary = employees.MaxBy(employee => employee.Salary);
        // Console.WriteLine($"Total Salary and Employee Name: {totalSalary.Name} - {totalSalary.Salary}");
        
        // var totalSalary = employees.OrderByDescending(e => e.Salary).First().Salary;
        // Console.WriteLine($"Total Salary and Employee Name: {totalSalary.Name} - {totalSalary.Salary}");
        // Ans - MaxBy returns full object. Max does not returns the full object 
        // Console.WriteLine($"Total Salary and Employee Name: {totalSalary}");
        
        // ### Exercise 5:
        // // Generate a department summary report with: department name, head count, average salary, and total salary. Sort by total salary descending.
        // var departmentSummaryReport = employees.GroupBy(emp => emp.Department).Select(deptData => new
        // {
        //     Department = deptData.Key,
        //     EmployeesCount = deptData.Count(),
        //     AverageSalary = deptData.Average(s => s.Salary),
        //     TotalSalary = deptData.Sum(s => s.Salary)
        // }).OrderByDescending(s => s.TotalSalary).ToList();
        // foreach (var deptData in departmentSummaryReport)
        // {
        //     Console.WriteLine($"{deptData.Department} - {deptData.EmployeesCount} - {deptData.AverageSalary} - {deptData.TotalSalary}");
        // }
        
        
    }
}