using System;

namespace Lab05._1e_Tasks._1_drone;

public class LandCommand : DroneCommand
{
    private Drone drone;

    public LandCommand(Drone drone)
    {
        this.drone = drone;
    }

    public void Execute()
    {
        drone.Land();
    }
}