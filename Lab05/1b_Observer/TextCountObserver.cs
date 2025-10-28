using System;

namespace Lab05._1b_Observer;

public class TextCountObserver : TextInputObserver
{
    public void Update(string text)
    {
        int length = text.Length;
        Console.WriteLine("The text has " + length + " characters");
    }
}
