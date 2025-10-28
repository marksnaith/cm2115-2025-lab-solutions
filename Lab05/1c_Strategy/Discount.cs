using System;

namespace Lab05._1c_Strategy;

public interface Discount
{
    decimal Apply(decimal subtotal);
}
