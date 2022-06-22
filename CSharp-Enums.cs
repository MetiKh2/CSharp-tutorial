Months myVar = Months.June;
Console.WriteLine((int)myVar);
Level level= Level.Medium;
switch (level)
{
    case Level.Low:
        Console.WriteLine("Low level");
        break;
    case Level.Medium:
        Console.WriteLine("Medium level");
        break;
    case Level.High:
        Console.WriteLine("High level");
        break;
}
enum Level
{
    Low,
    Medium,
    High
}
enum Months
{
    January,    // 0
    February,   // 1
    March=6,      // 6
    April,      // 7
    May,        // 8
    June,       // 9
    July        // 10
}
