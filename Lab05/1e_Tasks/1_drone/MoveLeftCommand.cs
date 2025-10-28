using System;

namespace Lab05._1e_Tasks._1_drone;

public class MoveLeftCommand : DroneCommand
{
    private Drone drone;

    public MoveLeftCommand(Drone drone)
    {
        this.drone = drone;
    }

    public void Execute()
    {
        drone.MoveLeft();
    }
}
