using System.Diagnostics;

Console.WriteLine("Global using directives\n");

var stopwatch = Stopwatch.StartNew();

for (int i = 0; i < 100; i++)
{
    Console.WriteLine($"Counter");
}

stopwatch.Stop();

Console.WriteLine($"Operation time: {stopwatch.ElapsedMilliseconds}ms");

Console.ReadKey();




