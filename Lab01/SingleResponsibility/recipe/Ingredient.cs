// Ingredient.cs
public class Ingredient
{
    public string Name { get; }
    public int Grams { get; }
    public int CaloriesPer100g { get; }

    public Ingredient(string name, int grams, int caloriesPer100g)
    {
        Name = name;
        Grams = grams;
        CaloriesPer100g = caloriesPer100g;
    }
}
