using System;

namespace Lab03;

public class TurbopropEngine : IEngineBehaviour
{
    public void StartLeftEngine()
    {
        Console.WriteLine("The left propeller is spinning!");
    }

    public void StartRightEngine()
    {
        Console.WriteLine("The right propeller is spinning!");
    }
}
