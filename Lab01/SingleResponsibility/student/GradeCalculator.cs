// GradeCalculator.cs
public class GradeCalculator
{
    public double Average(Student s)
    {
        var list = s.GetGrades();
        if (list.Count == 0) return 0.0;

        int sum = 0;
        for (int i = 0; i < list.Count; i++)
        {
            sum += list[i];
        }
        return (double)sum / list.Count;
    }
}
