
namespace Module16;
class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Yalina", LastName = "Jamli", Department = "Engineering", Salary = 75000, Age = 28 },
            new Employee { Id = 2, FirstName = "Ajay", LastName = "Sanyal", Department = "Marketing", Salary = 55000, Age = 32 },
            new Employee { Id = 3, FirstName = "Jamil", LastName = "Jamali", Department = "Engineering", Salary = 82000, Age = 35 },
            new Employee { Id = 4, FirstName = "Aslam", LastName = "SP", Department = "HR", Salary = 60000, Age = 26 },
            new Employee { Id = 5, FirstName = "Aalam", LastName = "Pathan", Department = "Marketing", Salary = 58000, Age = 29 },
            new Employee { Id = 6, FirstName = "Javed", LastName = "Khanani", Department = "Engineering", Salary = 90000, Age = 40 },
            new Employee { Id = 7, FirstName = "Hamza", LastName = "Mazari", Department = "HR", Salary = 62000, Age = 31 },
            new Employee { Id = 8, FirstName = "Pinda", LastName = "Kholi", Department = "HR", Salary = 60000, Age = 26 },
            new Employee { Id = 9, FirstName = "Iqbal", LastName = "Major", Department = "Marketing", Salary = 58000, Age = 29 },
            new Employee { Id = 10, FirstName = "JaskiritSingh", LastName = "Rangi", Department = "Engineering", Salary = 90000, Age = 40 }
        };
        //### Exercise 1:
        //Using `let`, compute the full name (first + last) and filter employees whose full name is longer than 12 characters.
        // var result = (
        //                 from employee in employees 
        //                 let fullname = employee.FirstName + " " + employee.LastName
        //                 where fullname.Length > 12
        //                 select new { FullName = fullname }
        //         ).ToList();
        // foreach (var employee in result)
        // {
        //     Console.WriteLine(employee.FullName);
        // }
        
        // Exercise 2
        // Group employees by department (using group ... into) and show only departments with more than 1 employee
        // var result = (
        //     from employee in employees
        //     group employee by employee.Department
        //     into deptGrp
        //     where deptGrp.Count() > 1
        //     select new
        //     {
        //         Department = deptGrp.Key,
        //         Employee = deptGrp.Select(x => x.FirstName + " " + x.LastName).ToList()
        //     }
        // );
        // foreach (var item in result)
        // {
        //     Console.WriteLine(item.Department);
        //     foreach (var employee in item.Employee)
        //     {
        //         Console.WriteLine(employee);
        //     }
        // }
        
        //Exercise 3
        //Use a nested sub-query to find employees whose salary is above the overall average salary.
        // var empAboveAvg = (from e in employees 
        //                     where e.Salary > (from emp in employees where emp.Department == e.Department
        //                        select  emp.Salary
        //                     ).Average()
        //                     select new {e.FirstName, e.Department, e.Salary}
        //         ).ToList();
        //
        // foreach (var emp in empAboveAvg)
        // {
        //     Console.WriteLine($"{emp.FirstName} - {emp.Department} - {emp.Salary}");
        // }
        
        
        //### Exercise 4:
        //Using `let`, compute `SalaryPerMonth = Salary / 12` and `TaxPerMonth = SalaryPerMonth * 0.25`. Show employees where TaxPerMonth > 1500.
        
        // var salaryPerMonth = (from employee in employees 
        //                 let SalaryPerMonth = employee.Salary / 12
        //                 let  TaxPerMonth = SalaryPerMonth * 0.25
        //                 where TaxPerMonth > 1500
        //                     select new
        //                     {
        //                         Name = employee.FirstName + " " + employee.LastName,
        //                         SalaryPerMonth,
        //                         TaxPerMonth
        //                     }
        //     );
        // foreach (var emp in salaryPerMonth)
        // {
        //     Console.WriteLine($"{emp.Name} - Tax - {emp.TaxPerMonth}");
        // }
        
        // ### Exercise 5:
        // Use `select ... into` to first classify employees as "Senior" (age >= 35) or "Junior", then filter to show only "Senior" employees.
        
        // var result = (from employee in employees
        //             select new
        //             {
        //                 employee.FirstName,
        //                 employee.LastName,
        //                 EmployeeSeniority = employee.Age >= 35 ? "Senior" : "Junior"
        //             }
        //             into classfied
        //             where classfied.EmployeeSeniority == "Senior"
        //                 orderby classfied.EmployeeSeniority
        //                     select classfied
        //         ).ToList();
        //
        // foreach (var employee in result)
        // {
        //     Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.EmployeeSeniority}");
        // }
    }
}

