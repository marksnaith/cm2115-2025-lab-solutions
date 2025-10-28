using System;

namespace Lab05._1e_Tasks._2_Observer;

public interface IWeatherObserver
{
    // Called when the WeatherStation broadcasts an update
    void OnWeatherChanged(WeatherReading reading);
}
