using System;

namespace Lab02;

public class MultiFunctionDevice : IPrint, IScan, ICopy, IFax
{
    public void Print(string text)
    {
        Console.WriteLine("Printing " + text + " on multi-function device");
    }

    public void Scan(string text)
    {
        Console.WriteLine("Scanning " + text + " on multi-function device");
    }

    public void Copy(string text)
    {
        Console.WriteLine("Copying " + text + " on multi-function device");
    }

    public void Fax(string text)
    {
        Console.WriteLine("Faxing " + text + " on multi-function device");
    }
}
