using System;

namespace Lab02;

public class Photocopier : ICopy
{
    public void Copy(string text)
    {
        Console.WriteLine("Copying " + text + " on photocopier");
    }
}
