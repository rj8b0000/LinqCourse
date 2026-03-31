namespace  Module8
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
                new Employee { Id = 7, Name = "Hamza", Department = "HR", Salary = 62000, Age = 31 , JoiningYear = 2021},
                new Employee { Id = 8, Name = "Pinda", Department = "HR", Salary = 60000, Age = 26 , JoiningYear = 2024},
                new Employee { Id = 9, Name = "Iqbal", Department = "Marketing", Salary = 58000, Age = 29 , JoiningYear = 2024},
                new Employee { Id = 10, Name = "Jaskirit", Department = "Engineering", Salary = 90000, Age = 40 , JoiningYear = 2022},
            };
            
            //Exercise 1
            //Get First Five Employees sorted by Name 
            // var result = employees.OrderBy(emp => emp.Name).Take(5).ToList();
            // foreach (var item in result)
            // {
            //     Console.WriteLine(item.Name);
            // }
            
            //Exercise 2
            //Implement pagination: write a method that takes a page number and page size, and returns the correct page of employees.
            //Resuable Paging Method
            // static List<T> GetPage<T>(List<T> source, int pageNumber, int pageSize)
            // {
            //     return source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            // }
            //
            // var result = GetPage(employees, 3, 4);
            // foreach (var employee in result)
            // {
            //     Console.WriteLine($"{employee.Id} {employee.Name}");
            // }
            
            // Exercise 3
            // Given `[1, 3, 5, 8, 2, 4, 6]`, use `TakeWhile` to take elements while they are **odd**. What is the result?
            // var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            // var result = numbers.TakeWhile(num => num % 2 != 0).ToList();
            // foreach (var number in result)
            // {
            //     Console.WriteLine(number);
            // }
            
            // Exercise 4
            //Split a list of 25 numbers into chunks of 7. How many chunks do you get? What is in the last chunk?
            // var numbers = Enumerable.Range(1, 25).ToList();
            //
            // var chunks = numbers.Chunk(7).ToList();
            // foreach (var chunk in chunks)
            // {
            //     Console.WriteLine(chunk[4]);
            // }
            
            //Exercise 5
            //Get the bottom 3 lowest-paid employees using sorting + Take.
            // var result = employees.OrderBy(emp => emp.Salary).Take(3).ToList();
            // foreach (var employee in result)
            // {
            //     Console.WriteLine(employee.Name);
            // }
            
        }
    }
}