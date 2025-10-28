using System;

namespace Lab05._1e_Tasks._3_Strategy;

public class Checkout
{
    private Discount discount;
    private PaymentMethod payment;

    public Checkout(Discount initial, PaymentMethod payment)
    {
        this.discount = initial;
        this.payment = payment;
    }

    public void SetDiscount(Discount discount)
    {
        this.discount = discount;
    }

    public void SetPaymentMethod(PaymentMethod payment)
    {
        this.payment = payment;
    }

    public decimal Total(decimal subtotal)
    {
        return this.discount.Apply(subtotal);
    }

    public void Pay(decimal total)
    {
        this.payment.ProcessPayment(total);
    }
}
