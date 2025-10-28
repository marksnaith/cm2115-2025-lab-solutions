using System;

namespace Lab05._1a_Command;

public class Robot
{
    private Dictionary<string, RobotCommand> commands;

    public Robot()
    {
        this.commands = new Dictionary<string, RobotCommand>();
    }

    public void AddPickUpCommand(string command, Pickable item)
    {
        var cmd = new PickUpCommand(item);
        this.commands.Add(command, cmd);
    }

    public void AddDropCommand(string command, Pickable item)
    {
        var cmd = new DropCommand(item);
        this.commands.Add(command, cmd);
    }

    public void ExecuteCommand(string command)
    {
        if (this.commands.ContainsKey(command))
        {
            this.commands[command].Execute();
        }
        else
        {
            Console.WriteLine("Command doesn't exist");
        }
    }
}
