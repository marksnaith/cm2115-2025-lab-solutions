// TranscriptPrinter.cs
using System;
using System.Text;
using System.Collections.Generic;

public class TranscriptPrinter
{
    private readonly GradeCalculator calc = new GradeCalculator();

    public string Render(Student s)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Transcript for ");
        sb.AppendLine(s.Name);

        sb.Append("Grades: ");
        List<int> grades = s.GetGrades();
        for (int i = 0; i < grades.Count; i++)
        {
            sb.Append(grades[i]);
            if (i < grades.Count - 1) sb.Append(", ");
        }
        sb.AppendLine();

        double avg = calc.Average(s);
        sb.Append("Average: ");
        sb.Append(avg.ToString("F2"));

        return sb.ToString();
    }
}