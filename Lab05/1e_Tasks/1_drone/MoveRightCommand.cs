using System;

namespace Lab05._1e_Tasks._1_drone;

public class MoveRightCommand : DroneCommand
{
    private Drone drone;

    public MoveRightCommand(Drone drone)
    {
        this.drone = drone;
    }

    public void Execute()
    {
        drone.MoveRight();
    }
}