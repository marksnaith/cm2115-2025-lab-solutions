// NutritionCalculator.cs
public class NutritionCalculator
{
    public int TotalCalories(Recipe recipe)
    {
        int total = 0;
        var items = recipe.GetIngredients();
        for (int i = 0; i < items.Count; i++)
        {
            var ing = items[i];
            total += (ing.Grams * ing.CaloriesPer100g) / 100;
        }
        return total;
    }
}
