// ShippingCalculator.cs
using System;
using System.Collections.Generic;

public class ShippingCalculator
{
    private readonly List<Surcharge> surcharges;

    public ShippingCalculator(List<Surcharge> surcharges)
    {
        this.surcharges = surcharges;
    }

    public decimal Calculate(ShippingContext ctx)
    {
        decimal cost = 2m + (ctx.DistanceKm * 0.25m) + (ctx.WeightKg * 0.4m);

        for (int i = 0; i < surcharges.Count; i++)
        {
            cost = surcharges[i].Apply(cost, ctx);
        }

        return Math.Round(cost, 2);
    }
}
