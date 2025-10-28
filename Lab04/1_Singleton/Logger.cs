using System;

namespace Lab04;

public class Logger
{
    private static Logger instance = null;

    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }
        return instance;
    }

    private Logger() { }

    private List<string> messages = new List<string>();

    public void Log(string message)
    {
        this.messages.Add(message);
    }

    public void PrintLog()
    {
        foreach(var message in this.messages)
        {
            Console.WriteLine(message);
        }
    }
}
