using System;

namespace Lab04;

public class Pizza
{
    private int size;
    private string sauce;
    private bool pepperoni = false;
    private bool pineapple = false;
    private bool peppers = false;
    private bool sweetcorn = false;
    public Pizza(PizzaBuilder builder)
    {
        this.size = builder.Size;
        this.sauce = builder.Sauce;
        this.pepperoni = builder.Pepperoni;
        this.pineapple = builder.Pineapple;
        this.peppers = builder.Peppers;
        this.sweetcorn = builder.Sweetcorn;
    }
    public override string ToString()
    {
        return "A " + this.size + " inch pizza, with "
        + this.sauce + " sauce:"
        + "\nPepperoni: " + this.pepperoni
        + "\nPineapple: " + this.pineapple
        + "\nPeppers: " + this.peppers
        + "\nSweetcorn: " + this.sweetcorn;
    }
}
