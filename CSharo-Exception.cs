//try
//{
//    int[] myNumbers = { 1, 2, 3 };
//    Console.WriteLine(myNumbers[10]);
//}
//catch(Exception e)
//{
//    Console.WriteLine("Something went wrong");
//}
//finally
//{
//    Console.WriteLine("The try catch is finished");
//}

try
{
    CheckAge(20);
    CheckAge(15);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

void CheckAge(int age)
{
    if (age < 18)
    {
        throw new ArithmeticException("Access denied - you must be at least 18 years old");
    }
    else
    {
        Console.WriteLine("Access generated - you are old enough!");
    }
}
