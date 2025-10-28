using System;

namespace Lab05._1e_Tasks._3_Strategy;

public class TenPercent : Discount
{
    public decimal Apply(decimal subtotal)
    {
        return subtotal * 0.9m;
    }
}
