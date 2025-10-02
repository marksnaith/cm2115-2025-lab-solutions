// FileStudentRepository.cs
using System.Collections.Generic;
using System.IO;

public class FileStudentRepository
{
    public void Save(Student s, string path)
    {
        using (StreamWriter writer = new StreamWriter(path, false))
        {
            writer.WriteLine("Student: " + s.Name);

            List<int> grades = s.GetGrades();
            for (int i = 0; i < grades.Count; i++)
            {
                writer.WriteLine(grades[i]);
            }
        }
    }
}
