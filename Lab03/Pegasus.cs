using System;

namespace Lab03;

public class Pegasus : IFly, IWalk
{

    private IFlapBehaviour flap;
    private IFourLeggedWalkBehaviour walk;

    public Pegasus(IFlapBehaviour flap, IFourLeggedWalkBehaviour walk)
    {
        this.flap = flap;
        this.walk = walk;
    }

    public void Fly()
    {
        this.flap.FlapLeftWing();
        this.flap.FlapRightWing();
    }

    public void Walk()
    {
        this.walk.MoveFrontLeftLeg();
        this.walk.MoveRearRightLeg();
        this.walk.MoveFrontRightLeg();
        this.walk.MoveRearLeftLeg();
    }
}
