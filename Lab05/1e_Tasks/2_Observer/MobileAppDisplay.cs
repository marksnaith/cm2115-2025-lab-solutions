using System;

namespace Lab05._1e_Tasks._2_Observer;

using System;

public class MobileAppDisplay : IWeatherObserver
{
    private readonly string username;

    public MobileAppDisplay(string username)
    {
        this.username = username;
    }

    public void OnWeatherChanged(WeatherReading reading)
    {
        Console.WriteLine($"[MobileApp:{username}] {reading}");
    }
}