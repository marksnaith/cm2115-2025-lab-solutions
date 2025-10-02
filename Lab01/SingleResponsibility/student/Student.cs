// Student.cs
using System.Collections.Generic;

public class Student
{
    public string Name { get; }
    private readonly List<int> grades = new List<int>();

    public Student(string name)
    {
        Name = name;
    }

    public void AddGrade(int grade)
    {
        grades.Add(grade);
    }

    public List<int> GetGrades()
    {
        // Return a copy to protect internal list
        return new List<int>(grades);
    }
}
