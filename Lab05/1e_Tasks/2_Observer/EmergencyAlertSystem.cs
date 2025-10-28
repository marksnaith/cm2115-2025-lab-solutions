using System;

namespace Lab05._1e_Tasks._2_Observer;

using System;

public class EmergencyAlertSystem : IWeatherObserver
{
    private readonly double heatWarningC;
    private readonly double floodRainMm;
    private readonly double lowPressureHpa;

    public EmergencyAlertSystem(double heatWarningC = 30.0, double floodRainMm = 50.0, double lowPressureHpa = 980.0)
    {
        this.heatWarningC = heatWarningC;
        this.floodRainMm = floodRainMm;
        this.lowPressureHpa = lowPressureHpa;
    }

    public void OnWeatherChanged(WeatherReading reading)
    {
        if (reading.TemperatureC >= heatWarningC)
            Console.WriteLine("[ALERT] Heat warning triggered!");

        if (reading.RainfallMm >= floodRainMm)
            Console.WriteLine("[ALERT] Flood risk due to heavy rainfall.");

        if (reading.PressureHpa <= lowPressureHpa)
            Console.WriteLine("[ALERT] Low pressure system detected. Severe weather possible.");
    }
}