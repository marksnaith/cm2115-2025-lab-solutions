using System;

namespace Lab05._1e_Tasks._1_drone;

public class MoveBackwardCommand : DroneCommand
{
    private Drone drone;

    public MoveBackwardCommand(Drone drone)
    {
        this.drone = drone;
    }

    public void Execute()
    {
        drone.MoveBackward();
    }
}
