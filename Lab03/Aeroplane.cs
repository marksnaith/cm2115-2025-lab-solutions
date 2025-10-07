using System;

namespace Lab03;

public class Aeroplane : IFly
{
    private IEngineBehaviour engines;

    public Aeroplane(IEngineBehaviour engines)
    {
        this.engines = engines;
    }

    public void Fly()
    {
        this.engines.StartLeftEngine();
        this.engines.StartRightEngine();
    }
}
