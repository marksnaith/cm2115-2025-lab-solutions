using System;

namespace Lab05._1a_Command;

public class PickUpCommand : RobotCommand
{
    private Pickable item;

    public PickUpCommand(Pickable item)
    {
        this.item = item;
    }

    public void Execute()
    {
        this.item.PickUp();
    }
}
