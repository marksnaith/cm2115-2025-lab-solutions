// Recipe.cs
using System.Collections.Generic;

public class Recipe
{
    public string Title { get; }
    private readonly List<Ingredient> ingredients = new List<Ingredient>();

    public Recipe(string title)
    {
        Title = title;
    }

    public void AddIngredient(Ingredient i)
    {
        ingredients.Add(i);
    }

    public List<Ingredient> GetIngredients()
    {
        // Return a copy to avoid accidental modification
        return new List<Ingredient>(ingredients);
    }
}
