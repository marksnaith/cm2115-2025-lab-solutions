using System;

namespace Lab05._1c_Strategy;

public class NoDiscount : Discount
{
    public decimal Apply(decimal subtotal)
    {
        return subtotal;
    }
}
