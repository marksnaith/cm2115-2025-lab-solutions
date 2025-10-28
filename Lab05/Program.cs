using Lab05._1a_Command;
using Lab05._1b_Observer;
using Lab05._1c_Strategy;
using Lab05._1d_Visitor;

Console.WriteLine("==Part 1a - Command==");

var box = new Box();
var crate = new Crate();

var pickUpBoxCommand = new PickUpCommand(box);
var dropBoxCommand = new DropCommand(box);
var pickUpCrateCommand = new PickUpCommand(crate);
var dropCrateCommand = new DropCommand(crate);
Dictionary<string, RobotCommand> commands = new Dictionary<string, RobotCommand>();

commands.Add("Pick up box", pickUpBoxCommand);
commands.Add("Drop box", dropBoxCommand);
commands.Add("Pick up crate", pickUpCrateCommand);
commands.Add("Drop crate", dropCrateCommand);

// choose a command to execute
commands["Pick up box"].Execute();

Console.WriteLine();

var robot = new Robot();

robot.AddPickUpCommand("pick up box", box);
robot.AddDropCommand("drop box", box);

// normally some time later
robot.ExecuteCommand("pick up box");

Console.WriteLine("\n=====");
Console.WriteLine("==Part 1b - Observer==");

var input = new TextInput();
input.AddObserver(new PrintTextObserver());
input.AddObserver(new TextCountObserver());
input.GetTextInput();

Console.WriteLine("\n=====");
Console.WriteLine("==Part 1c - Strategy==");

var checkout = new Checkout(new NoDiscount());

decimal noDiscount = checkout.Total(10.0m);
Console.WriteLine("Total: " + noDiscount);

checkout.SetDiscount(new TenPercent());
decimal tenPercent = checkout.Total(10.0m);
Console.WriteLine("Total: " + tenPercent);

Console.WriteLine("\n=====");
Console.WriteLine("==Part 1d - Visitor==");

Car[] cars = { new PetrolCar(), new ElectricCar() };
var visitor = new CarServiceVisitor();

foreach (Car car in cars)
{
    car.Accept(visitor);
}