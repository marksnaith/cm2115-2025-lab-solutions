using System;

namespace Lab05._1e_Tasks._3_Strategy;

public interface PaymentMethod
{
    bool ProcessPayment(decimal amount);
}
