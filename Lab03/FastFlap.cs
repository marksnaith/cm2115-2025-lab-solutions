using System;

namespace Lab03;

public class FastFlap : IFlapBehaviour
{
    public void FlapLeftWing()
    {
        Console.WriteLine("The left wing is flapping fast!");
    }

    public void FlapRightWing()
    {
        Console.WriteLine("The right wing is flapping fast!");
    }
}
