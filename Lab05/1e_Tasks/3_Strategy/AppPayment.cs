using System;

namespace Lab05._1e_Tasks._3_Strategy;

public class AppPayment : PaymentMethod
{
    public bool ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Paid {amount} by app");
        return true;
    }
}
