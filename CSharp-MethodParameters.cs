//Parameters and Arguments
//MyMethod("Liam");
//MyMethod("Jenny");
//MyMethod("Anja");


//void MyMethod(string firstName)
//{
//    Console.WriteLine(firstName+" Refsnes");
//}


//Default Parameter Value

//MyMethod("Sweden");
//MyMethod("India");
//MyMethod();
//MyMethod("USA");


//void MyMethod(string country="Norway")
//{
//    Console.WriteLine(country);
//}


//Multiple Parameters


//MyMethod("Liam",5);
//MyMethod("Jenny",10);
//MyMethod("Anja",12);

//void MyMethod(string firstName ,int age)
//{
//    Console.WriteLine(firstName+" is "+age);
//}


//Return Values

//Console.WriteLine(MyMethod(3));
//Console.WriteLine(Sum(3,4));
//int z=Sum(1,2);
//Console.WriteLine(z);
//int MyMethod(int x)
//{
//    return x + 5;
//}
//int Sum(int x,int y)
//{
//    return x + y;
//}

//Named Arguments

void MyMethod(string child1, string child2, string child3)
{
    Console.WriteLine("The youngest child is: " + child3);
}

MyMethod(child3: "John", child1: "Liam", child2: "Liam");
