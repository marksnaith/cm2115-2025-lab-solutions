using System;

namespace Lab06;

public class Product
{
    public string Name { get; private set; }
    public int Price { get; private set; }

    public Product(string name, int price)
    {
        this.Name = name;
        this.Price = price;
    }
}
