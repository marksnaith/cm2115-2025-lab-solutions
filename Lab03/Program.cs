using Lab03;

Console.WriteLine("Percy:");
FastFlap flap = new FastFlap();
Pigeon percy = new Pigeon(flap);
percy.Fly();

/* Something else to demonstrate a different flap behaviour */
Console.WriteLine("\nPortia:");
SlowFlap flap2 = new SlowFlap();
Pigeon portia = new Pigeon(flap2);
portia.Fly();

Console.WriteLine(); // blank line

/* Pegasus - we'll reuse slow flapping */
Console.WriteLine("Pegasus: ");
Trot trot = new Trot();
Pegasus p = new Pegasus(flap2, trot);
p.Walk();
Console.WriteLine();
p.Fly();

Console.WriteLine();

/* Aeroplanes */
JetEngine jet = new JetEngine();
TurbopropEngine prop = new TurbopropEngine();

Aeroplane boeing737 = new Aeroplane(jet);
Aeroplane atr72 = new Aeroplane(prop);

Console.WriteLine("Boeing 737:");
boeing737.Fly();

Console.WriteLine("\nATR72:");
atr72.Fly();