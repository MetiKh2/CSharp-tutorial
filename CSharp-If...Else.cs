// The if statement
//Syntax
//if (condition)
//{

//}
int x = 20;
int y = 18;
if (x>y)
{
    Console.WriteLine("20 is greater than 18");
}

//The else Statement
//Syntax
//if (condition)
//{
//    // block of code to be executed if the condition is True
//}
//else
//{
//    // block of code to be executed if the condition is False
//}

int time = 20;
if (time<18)
{
    Console.WriteLine("Good Day");
}
else
{
    Console.WriteLine("Good Evening");
}

//The else if Statement
//Syntax
//if (condition1)
//{
//    // block of code to be executed if condition1 is True
//}
//else if (condition2)
//{
//    // block of code to be executed if the condition1 is false and condition2 is True
//}
//else
//{
//    // block of code to be executed if the condition1 is false and condition2 is False
//}
int time2 = 22;
if (time2 < 10)
{
    Console.WriteLine("Good morning.");
}
else if (time < 20)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}
//Short Hand If...Else (Ternary Operator)
//Syntax
//variable = (condition) ? expressionTrue : expressionFalse;
int time3 = 20;
string result = (time < 18) ? "Good Day" : "Good Evening";
Console.WriteLine(result);
