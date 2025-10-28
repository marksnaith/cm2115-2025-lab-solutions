using System;

namespace Lab05._1e_Tasks._1_drone;

public class HoverCommand : DroneCommand
{
    private Drone drone;

    public HoverCommand(Drone drone)
    {
        this.drone = drone;
    }

    public void Execute()
    {
        drone.Hover();
    }
}
