using System;

namespace Lab03;

public class Trot : IFourLeggedWalkBehaviour
{
    public void MoveFrontLeftLeg()
    {
        Console.WriteLine("The front left leg is trotting!");
    }

    public void MoveFrontRightLeg()
    {
        Console.WriteLine("The front right leg is trotting!");
    }

    public void MoveRearLeftLeg()
    {
        Console.WriteLine("The rear left leg is trotting!");
    }

    public void MoveRearRightLeg()
    {
        Console.WriteLine("The rear right leg is trotting!");
    }
}
