// DiscountApplier.cs
public class DiscountApplier
{
    private readonly Discount discount;

    public DiscountApplier(Discount discount)
    {
        this.discount = discount;
    }

    public decimal TotalAfterDiscount(decimal amount)
    {
        return discount.Apply(amount);
    }
}
