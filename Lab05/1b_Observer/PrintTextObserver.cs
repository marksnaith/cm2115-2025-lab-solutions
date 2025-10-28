using System;

namespace Lab05._1b_Observer;

public class PrintTextObserver : TextInputObserver
{
    public void Update(string text)
    {
        Console.WriteLine("Notified: " + text);
    }
}
