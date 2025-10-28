using System;

namespace Lab05._1a_Command;

public class DropCommand : RobotCommand
{

    private Pickable item;

    public DropCommand(Pickable item)
    {
        this.item = item;
    }

    public void Execute()
    {
        this.item.Drop();
    }
}
