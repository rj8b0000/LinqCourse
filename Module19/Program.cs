using System;
using System.Collections.Generic;
using System.Linq;
using Module19;
using static Module19.EnumerableExtensions;

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
        //Write a WhereNot<T> extension method that returns elements that do NOT match the predicate.
        // var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //
        // var result = numbers.WhereNot(x => x > 3);
        //
        // foreach (var n in result)
        // {
        //     Console.WriteLine(n);
        // }
        
        //Exercise 2
        //Write an IsEmpty<T> extension method on IEnumerable<T> that returns true if the sequence has no elements. (Hint: use !source.Any())
        // if (employees.IsEmpty())
        // {
        //     Console.WriteLine("No employees found");
        // }
        
        //Exercise 3
        //Write a TakeEveryNth<T> method that returns every Nth element from a sequence.
        // var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        // var result = numbers.TakeEveryNthElement(2);
        // foreach (var item in result)
        // {
        //     Console.WriteLine(item);
        // }
        
        // Exercise 4:
        // Write a `Shuffle<T>` extension method that returns elements in random order.
        // var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        // var shuffled = numbers.Shuffle();
        // foreach (var data in shuffled)
        // {
        //     Console.WriteLine(data);
        // }
        
        // Exercise 5:
        // Write a ToDictionarySafe<T, TKey, TValue> that handles duplicate keys by keeping the first value instead of throwing.
        // var dict = IEnumerable<Employee>.ToDictionarySafe(
        //     employees,
        //     e => e.Department,
        //     e => e.FirstName
        //     
        // );
        // foreach (var data in dict)
        // {
        //     Console.WriteLine($"{data.Key} -  {data.Value}");
        // }
    }
}