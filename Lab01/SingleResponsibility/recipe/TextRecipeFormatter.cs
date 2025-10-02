// TextRecipeFormatter.cs
using System;
using System.Text;
using System.Collections.Generic;

public class TextRecipeFormatter
{
    public string Format(Recipe recipe, int totalCalories)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Recipe: ");
        sb.AppendLine(recipe.Title);

        List<Ingredient> items = recipe.GetIngredients();
        for (int i = 0; i < items.Count; i++)
        {
            Ingredient ing = items[i];
            sb.Append("- ");
            sb.Append(ing.Name);
            sb.Append(' ');
            sb.Append(ing.Grams);
            sb.AppendLine("g");
        }

        sb.Append("Total: ");
        sb.Append(totalCalories);
        sb.AppendLine(" kcal");

        return sb.ToString();
    }
}
