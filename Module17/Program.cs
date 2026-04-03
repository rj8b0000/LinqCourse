namespace  Module17
{
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
			//Exercise 1:
			// Define a `Where` query on a list. Add items to the list. Execute the query. Verify that new items appear in results.
			// var numbers = new List<int> {1,2,3};
			// var query = numbers.Where(x => x > 1);
			// numbers.Add(5);
			// foreach(var n in query)
			// {
			// 	Console.WriteLine(n);
			// }
			
			//Exercise 2:
			//Create a query with a `Console.WriteLine` inside the lambda. Verify it does not print until you call `.ToList()`.
			// var query = employees.Where(e =>
			// {
			// 	Console.WriteLine($"Checking {e.FirstName}"); // Side effect to show execution
			// 	return e.Salary > 60000;
			// });
			//
			// var list = query.ToList();
			
			// Exercise 3:
			// Create a query and enumerate it 3 times. Add a counter inside the lambda. What is the counter value after all 3 enumerations?
			// int counter = 0;
			// var numbers = new List<int> { 1, 2, 3, 4 };
			// var query = numbers.Where(x =>
			// {
			// 	counter++;
			// 	return x > 2;
			// });
			// foreach(var item in query) { }
			// foreach(var item in query) { }
			// foreach(var item in query) { }
			//
			// Console.WriteLine(counter);
			
			//Exercise - 4 Break the Chain Technique
			//employees.Where(e => e.Salary > 50000).Select(e => e.Name.ToUpper()).OrderBy(n => n).Take(3)
			
			// var filteredEmployees = employees.Where(e => e.Salary > 50000);
			// var selectNameAndConvertToUppr = filteredEmployees.Select(e => e.FirstName.ToUpper());
			// var orderData = selectNameAndConvertToUppr.OrderBy(n => n);
			// var take3 = orderData.Take(3);
			//
			// foreach (var employee in take3)
			// {
			// 	Console.WriteLine(employee);
			// }
			
			//### Exercise 5:
			//Refactor a nested sub-query (find employees above department average) into a `GroupBy` + `ToDictionary` approach. Compare the performance mentally.
			
			// var result = employees.Where(emp => emp.Salary > 
			// 										employees.Where(e => e.Department == e.Department)
			// 	                                    .Average(e => e.Salary)
			// 										).ToList();
			// foreach (var emp in result)
			// {
			// 	Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.Salary);
			// }
			//
			
			// var departmentAverages = employees.GroupBy(e => e.Department).ToDictionary(
			// 			g => g.Key,
			// 			g => g.Average(e => e.Salary)
			// 	);
			// foreach (var emp in departmentAverages)
			// {
			// 	Console.WriteLine($"{emp.Key} -  {emp.Value}");
			// }
			
				
		}
	}
}