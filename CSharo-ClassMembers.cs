Car Ford = new Car();
Ford.model = "Mustang";
Ford.color = "red";
Ford.year = 1969;

Car Opel = new Car();
Opel.model = "Astra";
Opel.color = "white";
Opel.year = 2005;

Console.WriteLine(Ford.model);
Console.WriteLine(Opel.model);
Opel.fullThrottle();
Ford.fullThrottle();
class Car
{
    // Class members
    public string model;
    public int year;
    public string color;      // field
   public int maxSpeed ;          // field
    public void fullThrottle()   // method
    {
        Console.WriteLine($"The {model} is going as fast as it can!");
    }
}
