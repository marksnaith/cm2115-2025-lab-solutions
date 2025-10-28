using System;

namespace Lab04;

public class PizzaBuilder
{
    public int Size { get; private set; }
    public string Sauce { get; private set; }
    public bool Pepperoni { get; private set; }
    public bool Pineapple { get; private set; }
    public bool Peppers { get; private set; }
    public bool Sweetcorn { get; private set; }
    public PizzaBuilder(int size, string sauce)
    {
        this.Size = size;
        this.Sauce = sauce;
    }
    public PizzaBuilder AddPepperoni()
    {
        this.Pepperoni = true;
        return this;
    }
    public PizzaBuilder AddPineapple()
    {
        this.Pineapple = true;
        return this;
    }
    public PizzaBuilder AddPeppers()
    {
        this.Peppers = true;
        return this;
    }
    public PizzaBuilder AddSweetcorn()
    {
        this.Sweetcorn = true;
        return this;
    }
    public Pizza Build()
    {
        return new Pizza(this);
    }
}
