using System;

namespace Lab05._1c_Strategy;

public class TenPercent : Discount
{
    public decimal Apply(decimal subtotal)
    {
        return subtotal * 0.9m;
    }
}
