Pig myPig = new Pig(); // Create a Pig object
myPig.animalSound();  // Call the abstract method
myPig.sleep();  // Call the regular method
abstract class Animal
{
    public abstract void animalSound();
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}
class Pig : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}
