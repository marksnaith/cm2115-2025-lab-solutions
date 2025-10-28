using Lab04;
using Lab04._3_AbstractFactory;
using Lab04._3_AbstractFactory._1_furniture;

Console.WriteLine("==Part 1a - Logger==");

Logger logger = Logger.GetInstance();

logger.Log("Hello world");
Logger logger2 = Logger.GetInstance();
logger2.Log("This is a singleton!");
logger.PrintLog();

Console.WriteLine("\n=======");
Console.WriteLine("==Part 1b - Builder==");

PizzaBuilder builder = new PizzaBuilder(12, "Tomato");
Pizza myPizza = builder.AddPepperoni()
                        .AddPeppers()
                        .Build();

Console.WriteLine(myPizza);

Console.WriteLine("\n=======");
Console.WriteLine("==Part 1b Task - Cars==");

Car sportsCar = new CarBuilder("Coupe", "Red")
                            .AddCarPlay()
                            .AddSunroof()
                            .AddExtra("Sports Exhaust")
                            .Build();

sportsCar.Display();

Console.WriteLine();

Car economyCar = new CarBuilder("Hatchback", "Blue")
                    .AddHeatedSeats()
                    .Build();

economyCar.Display();

Console.WriteLine("\n=======");
Console.WriteLine("==Part 1c - Abstract Factory==");

var factory = new ModernFurnitureFactory();
FurnishHouse(factory);

var factory2 = new AntiqueFurnitureFactory();
Console.WriteLine();
FurnishHouse(factory2);

var factory3 = new RetroFurnitureFactory();
Console.WriteLine();
FurnishHouse(factory3);

void FurnishHouse(FurnitureFactory factory)
{
    Console.WriteLine(factory.Createchair().ChairDescription());
    Console.WriteLine(factory.CreateTable().TableDescription());
    Console.WriteLine(factory.CreateLamp().LampDescription());
}