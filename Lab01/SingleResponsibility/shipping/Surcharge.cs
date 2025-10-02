// Surcharge.cs
public abstract class Surcharge
{
    public abstract decimal Apply(decimal currentCost, ShippingContext ctx);
}
