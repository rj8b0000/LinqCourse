using StudentGradeAnalyzer.Models;

namespace  StudentGradeAnalyzer
{
	class Program
	{
		static void Main(string[] args)
		{
			var students = new List<Student>
            {
                new Student
                    {
                        Id = 1,
                        Name = "Amit",
                        Class = "10A",
                        Scores = new List<SubjectScore>
                        {
                            new SubjectScore { Subject = "Math", Marks = 85 },
                            new SubjectScore { Subject = "Science", Marks = 78 },
                            new SubjectScore { Subject = "English", Marks = 90 }
                        }
                    },

                new Student
                    {
                        Id = 2,
                        Name = "Neha",
                        Class = "10A",
                        Scores = new List<SubjectScore>
                        {
                            new SubjectScore { Subject = "Math", Marks = 92 },
                            new SubjectScore { Subject = "Science", Marks = 88 },
                            new SubjectScore { Subject = "English", Marks = 95 }
                        }
                    },

                new Student
                    {
                        Id = 3,
                        Name = "Rahul",
                        Class = "10B",
                        Scores = new List<SubjectScore>
                        {
                            new SubjectScore { Subject = "Math", Marks = 70 },
                            new SubjectScore { Subject = "Science", Marks = 65 },
                            new SubjectScore { Subject = "English", Marks = 72 }
                        }
                    },

                new Student
                    {
                    Id = 4,
                    Name = "Priya",
                    Class = "10A",
                    Scores = new List<SubjectScore>
                    {
                        new SubjectScore { Subject = "Math", Marks = 88 },
                        new SubjectScore { Subject = "Science", Marks = 91 },
                        new SubjectScore { Subject = "English", Marks = 84 }
                    }
                },

                new Student
                    {
                    Id = 5,
                    Name = "Karan",
                    Class = "10B",
                    Scores = new List<SubjectScore>
                    {
                        new SubjectScore { Subject = "Math", Marks = 76 },
                        new SubjectScore { Subject = "Science", Marks = 80 },
                        new SubjectScore { Subject = "English", Marks = 79 }
                    }
                },

                new Student
                    {
                    Id = 6,
                    Name = "Sneha",
                    Class = "10A",
                    Scores = new List<SubjectScore>
                    {
                        new SubjectScore { Subject = "Math", Marks = 36 },
                        new SubjectScore { Subject = "Science", Marks = 20 },
                        new SubjectScore { Subject = "English", Marks = 45 }
                    }
                }
            };
            //1. Top Performers 
            // var result = students.Select(student => new
            //     {
            //         student.Name,
            //         student.Class,
            //         AverageMarks = student.Scores.Average(score => score.Marks)
            //     })
            //     .OrderByDescending(student => student.AverageMarks)
            //     .Take(5)
            //     .ToList();
            //
            // Console.WriteLine("** TOP 5 Performing Students **");
            //
            // foreach (var student in result)
            // {
            //     Console.WriteLine($"{student.Name}, {student.Class}, {student.AverageMarks:F2}");
            // }
            
            //2. Subject Analyisis
            // var result = students.SelectMany(s => s.Scores).GroupBy(s => new
            // {
            //     SubjectName = s.Subject,
            // }).Select(
            //         s => new
            //         {
            //             SubjectName = s.Key,
            //             AverageScore = s.Average(s => s.Marks),
            //             HighestScore = s.Max(s => s.Marks),
            //             LowestScore = s.Min(s => s.Marks),
            //         }
            //     );
            // foreach (var student in result)
            // {
            //     Console.WriteLine($"{student.SubjectName.SubjectName} - {student.AverageScore} - {student.HighestScore} - {student.LowestScore}");
            // }
            
            // 3.Class Analyisis
            // var classReport = students
            //     .GroupBy(student => student.Class)
            //     .Select(group => new
            //     {
            //         Class = group.Key,
            //
            //         StudentCount = group.Count(),
            //
            //         ClassAverage = group.Average(student =>
            //             student.Scores.Average(score => score.Marks)
            //         ),
            //
            //         Topper = group
            //             .Select(student => new
            //             {
            //                 student.Name,
            //                 AverageMarks = student.Scores.Average(score => score.Marks)
            //             })
            //             .OrderByDescending(student => student.AverageMarks)
            //             .First()
            //     })
            //     .ToList();
            //
            //
            // Console.WriteLine("** CLASS REPORT **");
            //
            // foreach (var cls in classReport)
            // {
            //     Console.WriteLine(
            //         $"-- {cls.Class} | Students: {cls.StudentCount} | " +
            //         $"-- Class Avg: {cls.ClassAverage:F2} | " +
            //         $"-- Topper: {cls.Topper.Name} ({cls.Topper.AverageMarks:F2})"
            //     );
            // }
            
            //4. Failing Students 
            // var result = students
            //     .SelectMany(s => s.Scores.Select(score => new
            //     {
            //         s.Name,
            //         s.Class,
            //         score.Subject,
            //         score.Marks
            //     }))
            //     .Where(s => s.Marks < 40);
            //
            // foreach (var student in result)
            // {
            //     Console.WriteLine($"{student.Marks} {student.Subject}  {student.Class} {student.Name}");
            // }
  
            //5. Honor Role
            // var result = students.Select(s => new
            // {
            //     s.Name,
            //     s.Class,
            //     s.Scores
            // }).Where(s => s.Scores.All(ss => ss.Marks > 85));
            //
            // foreach (var student in result)
            // {
            //     Console.WriteLine(student.Name);
            // }
            
            //6. **Subject Comparison**: Zip the average marks of "Math" and "Science" for all students and find who scored higher in Math vs Science.

            var result = students.Select(s =>
            {
                var math = s.Scores.First(score => score.Subject == "Math").Marks;
                var science = s.Scores.First(score => score.Subject == "Science").Marks;

                return new
                {
                    s.Name,
                    MathMarks = math,
                    ScienceMarks = science,
                    HigherIn = math > science
                        ? "Math"
                        : math < science
                            ? "Science"
                            : "Equal"
                };
            });
            
            foreach (var student in result)
            {
                Console.WriteLine($"{student.Name}: Higher in {student.HigherIn}");
            }

        }
	}
}