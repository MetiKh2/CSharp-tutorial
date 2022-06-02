string txt = "Hello Guys";
//String length
Console.WriteLine("The length of the txt string is : "+txt.Length);
//ToUpper & ToLower
Console.WriteLine(txt.ToUpper());
Console.WriteLine(txt.ToLower());
//String Concatenation
string firstName = "John";
string lastName = "Doe";
//string fullName=firstName+" "+lastName;
string fullName=string .Concat(firstName," ", lastName);
Console.WriteLine(fullName);
//String Interpolation
string fullNameWithInterPolation = $"My full name is : {firstName} {lastName}";
Console.WriteLine(fullNameWithInterPolation);
//Access Strings
string myString = "Hello friends";
Console.WriteLine(myString[5]);
Console.WriteLine(myString.IndexOf("f"));
string name = "John Doe";

int charPosition = name.IndexOf("D");

string myLastName=name.Substring(charPosition);
string myFirstName=name.Substring(0,charPosition);    
Console.WriteLine(myLastName);
Console.WriteLine(myFirstName);
//Special Characters
// \' == '
// \" == "
// \\ \
// /n == new line
// /t tab
// /b backspace
string message = "We are the so-called \"Vikings\" from the north.";
string text = "The character \\ is called backslash";

//Adding Numbers and Strings
int x = 10;
int y = 10;
Console.WriteLine(x+y);
