//Constructors

Car Ford = new Car("Mustang","Red",1969);  // Create an object of the Car Class (this will call the constructor)
Car Opel = new Car("Astra", "Green",1970);  // Create an object of the Car Class (this will call the constructor)
 

//Car Ford = new Car();
//Ford.model = "Mustang";
//Ford.color = "red";
//Ford.year = 1969;

//Car Opel = new Car();
//Opel.model = "Astra";
//Opel.color = "white";
//Opel.year = 2005;

//Console.WriteLine(Ford.model);
//Console.WriteLine(Opel.model);

class Car
{
    public string model;  // Create a field
    public string color;  // Create a field
    public int year;  // Create a field

    // Create a class constructor for the Car class
    public Car(string modelName, string colorName, int yearName)
    {
        model = modelName; // Set the initial value for model
        color = colorName;
        year = yearName;
    }

}
