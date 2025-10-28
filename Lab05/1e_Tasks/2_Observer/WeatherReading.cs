using System;

namespace Lab05._1e_Tasks._2_Observer;

public class WeatherReading
{
    public double TemperatureC { get; }
    public double RainfallMm { get; }
    public double PressureHpa { get; }

    public WeatherReading(double temperatureC, double rainfallMm, double pressureHpa)
    {
        TemperatureC = temperatureC;
        RainfallMm = rainfallMm;
        PressureHpa = pressureHpa;
    }

    public override string ToString()
    {
        return $"Temp: {TemperatureC:0.0}°C, Rainfall: {RainfallMm:0.0}mm, Pressure: {PressureHpa:0} hPa";
    }
}
