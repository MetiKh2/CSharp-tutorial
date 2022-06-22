
 Pig myPig = new Pig();  // Create a Pig object
    myPig.AnimalSound();
myPig.Run();
interface IAnimal
{
    void AnimalSound(); //interface method
}
interface IMyInterface
{
    void Run();
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal,IMyInterface
{
    public void AnimalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }

    public void Run()
    {
        Console.WriteLine("Running");
    }
}
