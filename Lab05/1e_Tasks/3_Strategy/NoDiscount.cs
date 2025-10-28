using System;

namespace Lab05._1e_Tasks._3_Strategy;

public class NoDiscount : Discount
{
    public decimal Apply(decimal subtotal)
    {
        return subtotal;
    }
}
