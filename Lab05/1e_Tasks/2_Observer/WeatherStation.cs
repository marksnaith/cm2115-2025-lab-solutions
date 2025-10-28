using System;

namespace Lab05._1e_Tasks._2_Observer;

using System;
using System.Collections.Generic;

public class WeatherStation
{
    private readonly List<IWeatherObserver> observers = new List<IWeatherObserver>();

    private double temperatureC;
    private double rainfallMm;
    private double pressureHpa;

    public void Attach(IWeatherObserver observer)
    {
        if (observer != null && !observers.Contains(observer))
            observers.Add(observer);
    }

    public void Detach(IWeatherObserver observer)
    {
        observers.Remove(observer);
    }

    public void UpdateTemperature(double temperatureC)
    {
        this.temperatureC = temperatureC;
        Notify();
    }

    public void UpdateRainfall(double rainfallMm)
    {
        this.rainfallMm = rainfallMm;
        Notify();
    }

    public void UpdatePressure(double pressureHpa)
    {
        this.pressureHpa = pressureHpa;
        Notify();
    }

    public void SetReading(double temperatureC, double rainfallMm, double pressureHpa)
    {
        this.temperatureC = temperatureC;
        this.rainfallMm = rainfallMm;
        this.pressureHpa = pressureHpa;
        Notify();
    }

    private void Notify()
    {
        WeatherReading reading = new WeatherReading(temperatureC, rainfallMm, pressureHpa);
        foreach (var observer in observers)
        {
            observer.OnWeatherChanged(reading);
        }
    }
}