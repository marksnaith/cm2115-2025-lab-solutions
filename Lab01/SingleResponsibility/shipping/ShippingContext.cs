// ShippingContext.cs
using System;

public class ShippingContext
{
    public decimal DistanceKm { get; }
    public decimal WeightKg { get; }
    public DateTime When { get; }
    public bool IsBulky { get; }

    public ShippingContext(decimal distanceKm, decimal weightKg, DateTime when, bool isBulky)
    {
        DistanceKm = distanceKm;
        WeightKg = weightKg;
        When = when;
        IsBulky = isBulky;
    }
}
