using System.Xml.Linq;
using System.Text.Json;
namespace  Module18
{
	class Program
	{
		public static void Main(string[] args)
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
			
			
			//Exercise 1 
			//Write an EF Core query to get all employees from "HR" department, sorted by salary descending. Show the SQL it would generate (conceptually).
			// var result = employees.OrderByDescending(emp => emp.Salary).Where(emp => emp.Department == "HR").ToList();
			// foreach (var data in result)
			// {
			// 	Console.WriteLine($"{data.FirstName} {data.LastName} - {data.Department} - {data.Salary}");
			// }
			//SQL
			//SELECT * FROM EMPLOYEES WHERE DEPARTMENT = "HR" ORDER BY SAlARY DESC;
			
			//Exercie 2
			//Given the XML above, find the employee with the highest salary.

			// var xml = XDocument.Load("employees.xml");
			//
			// var highestSalary = xml.Descendants("employee")
			// 	.OrderByDescending(e => (decimal)e.Element("salary")).First();
			//
			// var result = employees.OrderByDescending(employee => employee.Salary).First();
			// Console.WriteLine($"Highest Salary: {(decimal)highestSalary.Element("salary")}");
			
			
			//Exercise 3
			//Deserialize the JSON above and group employees by department. Show count and total salary per department.
			// var json = File.ReadAllText("employees.json");
			// var employees = JsonSerializer.Deserialize<List<Employee>>(json);
			//
			// var result = employees.GroupBy(e => e.Department).Select(e => new { Department = e.Key, Count = e.Count(), TotalSalary = e.Sum(s => s.Salary) });
			// foreach (var emp in result)
			// {
			// 	Console.WriteLine($"{emp.Department} - {emp.TotalSalary} - {emp.Count}");
			// }
			
			// Exercise 4
			// // Write an `IQueryable` query that filters by department AND salary, then converts to `IEnumerable` for a custom C# transformation.
			// static int CalculateBonus(int argSalary)
			// {
			// 	return argSalary + 20000;
			// }
			// var result = employees.Where(employee => employee.Department == "Engineering" && employee.Salary > 60000)
			// 	.AsEnumerable()
			// 	.Select(emp => new
			// 	{
			// 		emp.FirstName,
			// 		Bonus = CalculateBonus(emp.Salary)
			// 	}).ToList();
			//
			// foreach (var employee in result)
			// {
			// 	Console.WriteLine($"{employee.FirstName} - {employee.Bonus}");
			// }
			
			//Exercise 5:
			//Query the XML to get all employee IDs (from the `id` attribute) where salary is greater than 60000.
			// var xml = XDocument.Load("employees.xml");
			//
			// var highestSalary = xml.Descendants("employee").Where(e => (decimal)e.Element("salary") > 60000).ToList();
			//
			// foreach (var employee in highestSalary)
			// {
			// 	Console.WriteLine($"{employee.Value}");
			// }
			
			
		}

		
	}
}