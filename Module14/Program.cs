namespace  Module14
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
                new Employee { Id = 4, Name = "Aslamfghfghfghfghfghfghfghfghfghfghfg", Department = "HR", Salary = 60000, Age = 26 , JoiningYear = 2024},
                new Employee { Id = 5, Name = "Aalam", Department = "Marketing", Salary = 58000, Age = 29 , JoiningYear = 2024},
                new Employee { Id = 6, Name = "Javed Khanani", Department = "Engineering", Salary = 90000, Age = 40 , JoiningYear = 2022},
                new Employee { Id = 7, Name = "Hamza", Department = "HR", Salary = 62000, Age = 31 , JoiningYear = 2021},
                new Employee { Id = 8, Name = "Pinda", Department = "HR", Salary = 60000, Age = 26 , JoiningYear = 2024},
                new Employee { Id = 9, Name = "Iqbal", Department = "Marketing", Salary = 58000, Age = 29 , JoiningYear = 2024},
                new Employee { Id = 10, Name = "Jaskirit", Department = "Engineering", Salary = 90000, Age = 40 , JoiningYear = 2022},
            };
            //Exercise 1
            //Generate numbers 1 to 20 using Range. Filter to get only numbers divisible by 3.
            // var numbers = Enumerable.Range(1, 20).Where(n => n % 3 == 0).ToList();
            // foreach (var number in numbers)
            // {
            //     Console.WriteLine(number);
            // }
            
            //Exercise 2
            // Generate a multiplication table for 9 (9 x 1 through 9 x 12) using `Range` + `Select`.
            // var multiplicationTable = Enumerable.Range(1, 10).Select(n => $"9 X {n} = {9 * n}").ToList();
            // foreach(var i in multiplicationTable)
            // {
            //     Console.WriteLine(i);
            // }
            
            //Exercise 3
            //Create a list of 5 default placeholder strings using Repeat: "(empty)".
            // var placeHolderString = Enumerable.Repeat("(empty)", 5).ToList();
            // foreach(var placeHolder in placeHolderString)
            // {
            //     Console.WriteLine(placeHolder);
            // }
            
            //Exercise 4:
            //Generate 50 random test employees using `Range` + `Select` with different names and random salaries.
            // var random = new Random();
            //
            // var testEmployees = Enumerable.Range(1, 50)
            //     .Select(i => new Employee
            //     {
            //         Id = i,
            //         Name = $"Employee_{i}",
            //         Department = new[] { "Engineering", "HR", "Marketing", "Finance" }[random.Next(4)],
            //         Salary = random.Next(25000, 100000), 
            //         Age = random.Next(22, 50),
            //         JoiningYear = random.Next(2018, 2026)
            //     })
            //     .ToList();
            //
            // foreach (var emp in testEmployees.Take(5)) 
            // {
            //     Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Department} - {emp.Salary}");
            // }
            
            //Exercise 5: 
            //Write a method that takes a nullable list. If null, return Enumerable.Empty<int>(). Otherwise, return the list filtered for positive numbers.
            List<int> numList = new List<int> { 1, 2, 4, -4, -2, -32, -43, 234, -12 };
            // List<int>? numList = null;

            static IEnumerable<int> FilteredList(List<int>? numList)
            {
                if (numList == null)
                {
                    return Enumerable.Empty<int>();
                }

                return numList.Where(n => n > 0);
            }

            var result = FilteredList(numList);
            foreach (var data in result)
            {
                Console.WriteLine(data);
            }
        }
    }
}