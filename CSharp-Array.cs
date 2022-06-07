using System.Linq;
//Create an Array
string[] cars = { "Volvo","BMW","Ford","Mazda"};
int[] myNum = { 5,2,3,6};

//Access the Elements of an Array
Console.WriteLine(cars[0]);

//Change an Array Element
cars[0] = "Opel";
Console.WriteLine(cars[0]);

//Array Length
Console.WriteLine(cars.Length);

//Loop Through an Array
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}

//The foreach Loop
foreach (string car in cars)
{
    Console.WriteLine(car);
}
Console.WriteLine("+++++++++++++++++++++++++");
//Sort Arrays
Array.Sort(cars);
foreach (string car in cars)
{
    Console.WriteLine(car);
}

Array.Sort(myNum);
foreach (int num in myNum)
{
    Console.WriteLine(num);
}

//System.Linq Namespace
Console.WriteLine(myNum.Max());
Console.WriteLine(myNum.Min());
Console.WriteLine(myNum.Sum());

//Other Ways to Create an Array

// Create an array of four elements, and add values later
string[] array = new string[4];

// Create an array of four elements and add values right away 
string[] array2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

// Create an array of four elements without specifying the size 
string[] array3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] array4 = { "Volvo", "BMW", "Ford", "Mazda" };
