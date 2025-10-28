using System;

namespace Lab05._1c_Strategy;

public class Checkout
{
    private Discount discount;

    public Checkout(Discount initial)
    {
        this.discount = initial;
    }

    public void SetDiscount(Discount discount)
    {
        this.discount = discount;
    }

    public decimal Total(decimal subtotal)
    {
        return this.discount.Apply(subtotal);
    }
}
