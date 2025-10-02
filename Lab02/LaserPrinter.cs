using System;

namespace Lab02;

public class LaserPrinter : IPrint
{
    public void Print(string text)
    {
        Console.WriteLine("Printing " + text + " on laser printer");
    }
}
