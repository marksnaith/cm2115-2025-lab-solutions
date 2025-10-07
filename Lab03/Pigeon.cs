using System;

namespace Lab03;

public class Pigeon : IFly
{
    private IFlapBehaviour flap;

    public Pigeon(IFlapBehaviour flap)
    {
        this.flap = flap;
    }

    public void Fly()
    {
        this.flap.FlapLeftWing();
        this.flap.FlapRightWing();
    }
}
