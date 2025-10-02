// LoyaltyPolicy.cs
using System;

public abstract class LoyaltyPolicy
{
    public abstract int PointsFor(decimal amount);
}
