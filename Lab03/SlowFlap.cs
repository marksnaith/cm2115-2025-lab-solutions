using System;

namespace Lab03;

/**
An extra class to demonstrate different behaviours implementing a single interface 
**/

public class SlowFlap : IFlapBehaviour
{
    public void FlapLeftWing()
    {
        Console.WriteLine("The left wing is flapping slowly!");
    }

    public void FlapRightWing()
    {
        Console.WriteLine("The right wing is flapping slowly!");
    }
}
