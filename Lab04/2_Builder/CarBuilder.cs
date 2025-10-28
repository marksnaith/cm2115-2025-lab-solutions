using System;

namespace Lab04;

public class CarBuilder
{
    // Mandatory
    public string Colour { get; }
    public string Model { get; }

    // Optional
    public bool HasCarPlay { get; private set; }
    public bool HasSunroof { get; private set; }
    public bool HasHeatedSeats { get; private set; }
    public List<string> ExtraFeatures { get; private set; }

    // Constructor for mandatory parameters
    public CarBuilder(string model, string colour)
    {
        Model = model;
        Colour = colour;
        ExtraFeatures = new List<string>();
    }

    // Optional feature methods (fluent style)
    public CarBuilder AddCarPlay()
    {
        HasCarPlay = true;
        return this;
    }

    public CarBuilder AddSunroof()
    {
        HasSunroof = true;
        return this;
    }

    public CarBuilder AddHeatedSeats()
    {
        HasHeatedSeats = true;
        return this;
    }

    public CarBuilder AddExtra(string feature)
    {
        ExtraFeatures.Add(feature);
        return this;
    }

    // Final build step
    public Car Build()
    {
        return new Car(this);
    }
}
