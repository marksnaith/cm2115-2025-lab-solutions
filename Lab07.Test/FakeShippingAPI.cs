using System;

namespace Lab07.Test;

public class FakeShippingAPI : IShippingAPI
{
    public int CostToReturn { get; set; }

    public int GetShipping(string postcode)
    {
        return this.CostToReturn;
    }
}
