using System.IO;
string writeText = "Hello World!";  // Create a text string
File.WriteAllText(@"D:\CSharp-Exapmlpe\filename.txt", writeText);  // Create a file and write the content of writeText to it

string readText = File.ReadAllText(@"D:\CSharp-Exapmlpe\filename.txt");  // Read the contents of the file
Console.WriteLine(readText);  // Output the content
