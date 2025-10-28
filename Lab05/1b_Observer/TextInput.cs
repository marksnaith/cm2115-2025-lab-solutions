using System;

namespace Lab05._1b_Observer;

public class TextInput
{
    private List<TextInputObserver> observers;

    public TextInput()
    {
        this.observers = new List<TextInputObserver>();
    }

    public void AddObserver(TextInputObserver observer)
    {
        this.observers.Add(observer);
    }

    private void NotifyObservers(string text)
    {
        foreach (TextInputObserver observer in this.observers)
        {
            observer.Update(text);
        }
    }

    public void GetTextInput()
    {
        Console.Write("Enter some text: ");
        string input = Console.ReadLine();
        this.NotifyObservers(input);
    }
}
