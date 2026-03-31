namespace  Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            var departments = new List<Department>
            {
                new Department { Id = 1, Name = "Engineering" },
                new Department { Id = 2, Name = "Marketing" },
                new Department { Id = 3, Name = "HR" },
                new Department { Id = 4, Name = "Legal" },  // No employees
            };
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", DepartmentId = 1 },
                new Employee { Id = 2, Name = "Bob", DepartmentId = 2 },
                new Employee { Id = 3, Name = "Charlie", DepartmentId = 1 },
                new Employee { Id = 4, Name = "Diana", DepartmentId = 4 },
                new Employee { Id = 5, Name = "Eve", DepartmentId = 2 },
                new Employee { Id = 6, Name = "Frank", DepartmentId = 4 },
            };
            
            //Exercise 1 - Inner join employees with departments. Show employee name and department name. Both syntaxes.
            // var result = employees.Join(
            //     departments, employee => employee.DepartmentId, department => department.Id,
            //     (employee, department) => new { employee.Name, Department = department.Name }).ToList();
            //
            // foreach (var employee in result)
            // {
            //     Console.WriteLine($"{employee.Name} - {employee.Department}");
            // }
            
            //Exercise 2 - Group join: For each department, show the department name and a list of employee names. Include departments with no employees.
            // var result = departments.GroupJoin(employees, dept => dept.Id, emp => emp.DepartmentId,
            //     (dept, empGrp) => new { Department = dept.Name, Employee = empGrp.Select(e => e.Name) }).ToList();
            // foreach (var department in result)
            // {
            //     Console.WriteLine($"{department.Department} -");
            //     foreach (var employee in department.Employee)
            //     {
            //         Console.WriteLine($"{employee}");
            //     }
            // }
            
            //Exercise 3 
            //Left outer join: Show all departments and their employees. If a department has no employees, show "(none)". Both syntaxes.
            // var result = departments
            //     .GroupJoin(employees, dept => dept.Id, emp => emp.DepartmentId,
            //         (department, empGroup) => new { department, empGroup }).SelectMany(x => x.empGroup.DefaultIfEmpty(),
            //         (x, emp) => new { Department = x.department.Name, Employee = emp?.Name ?? "(none)" }).ToList();
            // foreach (var data in result)
            // {
            //     Console.WriteLine($"{data.Department} - {data.Employee}");
            // }
            
            //Exercise 4
            //Cross join: Given a list of ["Tea", "Coffee"] and ["Small", "Medium", "Large"], generate all drink + size combinations.
            // var drink = new List<string> { "Tea", "Coffee" };
            // var sizes = new List<string> { "Small", "Medium", "Large" };
            //
            // var combinations = drink
            //     .SelectMany(
            //         c => sizes,
            //         (color, size) => new { Color = color, Size = size }
            //     )
            //     .ToList();
            //
            // foreach (var data in combinations)
            // {
            //     Console.WriteLine($"{data.Color} - {data.Size}");
            // }
            
        }
    }
}