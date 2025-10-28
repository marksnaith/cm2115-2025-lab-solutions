using System;
using System.Collections.Generic;
namespace Lab04;

public class Car
{
    // Mandatory
    public string Colour { get; }
    public string Model { get; }

    // Optional
    public bool HasCarPlay { get; }
    public bool HasSunroof { get; }
    public bool HasHeatedSeats { get; }
    public List<string> ExtraFeatures { get; }

    // Car constructed from builder
    public Car(CarBuilder builder)
    {
        Colour = builder.Colour;
        Model = builder.Model;
        HasCarPlay = builder.HasCarPlay;
        HasSunroof = builder.HasSunroof;
        HasHeatedSeats = builder.HasHeatedSeats;
        ExtraFeatures = new List<string>(builder.ExtraFeatures);
    }

    public void Display()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Colour: {Colour}");
        Console.WriteLine($"CarPlay: {HasCarPlay}");
        Console.WriteLine($"Sunroof: {HasSunroof}");
        Console.WriteLine($"Heated Seats: {HasHeatedSeats}");
        Console.WriteLine($"Extras: {(ExtraFeatures.Count == 0 ? "None" : string.Join(", ", ExtraFeatures))}");
    }
}
