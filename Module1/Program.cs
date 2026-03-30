using System;
using System.Linq;
using LinqCourse.Model;

namespace LinqCourse
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> student = new List<Student>
            {
                new Student
                {
                    Id = 1, Name = "Alice", Department = "CS", Marks = 92, JoiningDate = new DateTime(2024, 1, 15)
                },
                new Student
                {
                    Id = 2, Name = "Bob", Department = "IT", Marks = 78, JoiningDate = new DateTime(2024, 2, 10)
                },
                new Student
                {
                    Id = 3, Name = "Charlie", Department = "CS", Marks = 85, JoiningDate = new DateTime(2024, 3, 5)
                },
                new Student
                {
                    Id = 4, Name = "Diana", Department = "IT", Marks = 60, JoiningDate = new DateTime(2024, 1, 20)
                },
                new Student
                {
                    Id = 5, Name = "Eve", Department = "CS", Marks = 95, JoiningDate = new DateTime(2024, 4, 1)
                },
                
                new Student
                {
                    Id = 6, Name = "John", Department = "CS", Marks = 95, JoiningDate = new DateTime(2024, 4, 1)
                },
            };

            //Using Deffered Execution
            var query = student.Where(student => student.Marks > 80);
            foreach (var item in query)
            {
                Console.WriteLine(item.Name + " - " + item.Marks);
            }
            //Using Immidiate execution
            var query2 = student.Where(student => student.Marks > 80).ToList();
            foreach (var item in query2)
            {
                Console.WriteLine(item.Name + " - " + item.Marks);
            }
        }
    }
}