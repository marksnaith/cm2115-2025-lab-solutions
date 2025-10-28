using System;

namespace Lab05._1e_Tasks._1_drone;

public class TakeOffCommand : DroneCommand
{
    private Drone drone;
    private bool didTakeOff;

    public TakeOffCommand(Drone drone)
    {
        this.drone = drone;
    }

    public void Execute()
    {
        bool wasAirborne = drone.IsAirborne;
        drone.TakeOff();
        didTakeOff = !wasAirborne && drone.IsAirborne;
    }
}