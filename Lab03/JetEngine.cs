using System;

namespace Lab03;

public class JetEngine : IEngineBehaviour
{
    public void StartLeftEngine()
    {
        Console.WriteLine("The left jet engine is roaring!");
    }

    public void StartRightEngine()
    {
        Console.WriteLine("The right jet engine is roaring!");
    }
}
