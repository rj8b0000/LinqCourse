using Module11;
using Module9;

namespace Module11
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
                new Employee { Id = 4, Name = "Aslam", Department = "HR", Salary = 60000, Age = 26 , JoiningYear = 2024},
                new Employee { Id = 5, Name = "Aalam", Department = "Marketing", Salary = 58000, Age = 29 , JoiningYear = 2024},
                new Employee { Id = 6, Name = "Javed Khanani", Department = "Engineering", Salary = 90000, Age = 40 , JoiningYear = 2022},
                new Employee { Id = 7, Name = "Hamza", Department = "HR", Salary = 62000, Age = 31 , JoiningYear = 2021},
                new Employee { Id = 8, Name = "Pinda", Department = "HR", Salary = 60000, Age = 26 , JoiningYear = 2024},
                new Employee { Id = 9, Name = "Iqbal", Department = "Marketing", Salary = 58000, Age = 29 , JoiningYear = 2024},
                new Employee { Id = 10, Name = "Jaskirit", Department = "Engineering", Salary = 90000, Age = 40 , JoiningYear = 2022},
            };
            List<ProjectData> projectA = new List<ProjectData>
            {
                new ProjectData { EmployeeID = 7 },
                new ProjectData { EmployeeID = 8 },
                new ProjectData { EmployeeID = 9 },
                new ProjectData { EmployeeID = 4 },
            };
            List<ProjectData> projectB = new List<ProjectData>
            {
                new ProjectData { EmployeeID = 7 },
                new ProjectData { EmployeeID = 1 },
                new ProjectData { EmployeeID = 2 },
                new ProjectData { EmployeeID = 4 },
            };
            //Exercise 1
            // var numbers = new List<int> {1, 2, 2, 3, 3, 4, 5, 5, 5};
            // var unique = numbers.Distinct().ToList();
            // foreach (var number in unique)
            // {
            //     Console.WriteLine(number);
            // }
            
            //Exercise 2
            var list1 = new List<string> { "C#", "LINQ", "SQL" };
            var list2 = new List<string> { "SQL", "Azure", "Docker" };
            //(a) all unique tags combined
            // var uniqueTags = list1.Union(list2).ToList();
            // foreach (var tags in uniqueTags)
            // {
            //     Console.WriteLine(tags);
            // }
            //(b)  common tags
            // var getAllCommonTags = list1.Intersect(list2).ToList();
            // foreach (var tag in getAllCommonTags)
            // {
            //     Console.WriteLine(tag);
            // }
            //(c) tags only in the first list.
            // var getTagsOnlyInFirstList = list1.Except(list2).ToList();
            // foreach (var item in getTagsOnlyInFirstList)
            // {
            //     Console.WriteLine(item);
            // }

            //Exercise 3
            // var getAllUniqueDepts = employees.Select(employee => employee.Department).Distinct().ToList();
            // foreach (var department in getAllUniqueDepts)
            // {
            //     Console.WriteLine(department);
            // }
            
            //Exercise 4
            // var tagsOnlyInFirstList = projectA.Select(emp => emp.EmployeeID).Except(projectB.Select(emp => emp.EmployeeID)).ToList();
            // foreach (var tag in tagsOnlyInFirstList)
            // {
            //     Console.WriteLine(tag);
            // }
            
            //Exercise 5
            //Using DistinctBy, get one employee per department (the first one found).
            // var getOneEmployeePerDept = employees.DistinctBy(e => e.Department).ToList();
            // foreach (var emp in getOneEmployeePerDept)
            // {
            //     Console.WriteLine($"{emp.Name} - {emp.Department}");
            // }
        }
    }
}