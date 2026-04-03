namespace StudentGradeAnalyzer.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Class { get; set; }  // "10A", "10B", "11A", etc.
    public List<SubjectScore> Scores { get; set; }
}