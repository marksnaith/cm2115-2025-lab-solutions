using System;

namespace Lab05._1e_Tasks._3_Strategy;

public interface Discount
{
    decimal Apply(decimal subtotal);
}
