// PaymentProcessor.cs
public class PaymentProcessor
{
    private readonly PaymentMethod method;

    public PaymentProcessor(PaymentMethod method)
    {
        this.method = method;
    }

    public void Pay(decimal amount)
    {
        method.Process(amount);
    }
}
