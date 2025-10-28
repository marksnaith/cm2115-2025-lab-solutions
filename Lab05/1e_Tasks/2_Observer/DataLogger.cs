using System;

namespace Lab05._1e_Tasks._2_Observer;

using System;
using System.IO;

public class DataLogger : IWeatherObserver
{
    private readonly string filePath;

    public DataLogger(string filePath)
    {
        this.filePath = filePath;
    }

    public void OnWeatherChanged(WeatherReading reading)
    {
        string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss},{reading.TemperatureC:0.0},{reading.RainfallMm:0.0},{reading.PressureHpa:0}";
        try
        {
            File.AppendAllText(filePath, line + Environment.NewLine);
            Console.WriteLine($"[DataLogger] Wrote: {line}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("[DataLogger] ERROR: " + ex.Message);
        }
    }
}
