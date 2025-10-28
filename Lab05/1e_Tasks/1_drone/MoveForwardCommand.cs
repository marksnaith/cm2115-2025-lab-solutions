using System;

namespace Lab05._1e_Tasks._1_drone;

public class MoveForwardCommand : DroneCommand
{
    private Drone drone;

    public MoveForwardCommand(Drone drone)
    {
        this.drone = drone;
    }

    public void Execute()
    {
        drone.MoveForward();
    }
}
