//For Loop
//Syntax
/*
 for(statement1;statement2;statement3)
{

}
 */
//for(int i = 0; i < 5; i++)
//{
//    Console.WriteLine(i);
//}

for (int i = 0; i <= 10; i = i + 2)
{
    Console.WriteLine(i);
}

//foreach Loop
//Syntax 
/*
 foreach (type variableName in arrayName) 
{
  // code block to be executed
}
 */

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (var item in cars)
{
    Console.WriteLine(item);
}
