using System;

namespace Lab05._1e_Tasks._1_drone;

public class Drone
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Altitude { get; private set; }
    public bool IsAirborne => Altitude > 0;

    public void TakeOff()
    {
        if (IsAirborne) { Console.WriteLine("Drone already airborne."); return; }
        Altitude = 10; 
        Console.WriteLine("Take off → Altitude: " + Altitude);
    }

    public void Land()
    {
        if (!IsAirborne) { Console.WriteLine("Drone already on the ground."); return; }
        Altitude = 0;
        Console.WriteLine("Land → Altitude: " + Altitude);
    }

    public void Hover()
    {
        if (!IsAirborne) { Console.WriteLine("Cannot hover while on ground."); return; }
        Console.WriteLine("Hovering at Altitude: " + Altitude + " at (" + X + "," + Y + ")");
    }

    public void MoveForward()
    {
        if (!IsAirborne) { Console.WriteLine("Cannot move while on ground."); return; }
        Y += 1;
        Console.WriteLine("Move forward → (" + X + "," + Y + ")");
    }

    public void MoveBackward()
    {
        if (!IsAirborne) { Console.WriteLine("Cannot move while on ground."); return; }
        Y -= 1;
        Console.WriteLine("Move backward → (" + X + "," + Y + ")");
    }

    public void MoveLeft()
    {
        if (!IsAirborne) { Console.WriteLine("Cannot move while on ground."); return; }
        X -= 1;
        Console.WriteLine("Move left → (" + X + "," + Y + ")");
    }

    public void MoveRight()
    {
        if (!IsAirborne) { Console.WriteLine("Cannot move while on ground."); return; }
        X += 1;
        Console.WriteLine("Move right → (" + X + "," + Y + ")");
    }
}