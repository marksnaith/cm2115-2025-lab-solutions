// AreaCalculator.cs
using System.Collections.Generic;

public class AreaCalculator
{
    public double TotalArea(List<Shape> shapes)
    {
        double sum = 0.0;
        for (int i = 0; i < shapes.Count; i++)
        {
            sum += shapes[i].Area();
        }
        return sum;
    }
}
