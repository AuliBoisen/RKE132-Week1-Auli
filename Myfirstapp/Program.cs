// See https://aka.ms/new-console-template for more information. This is a comment to my code.

// rakendus küsib kasutajal sisestada kasutaja tema nime ja see järel rakendus tervitab kasutajat nime pidi

Console.WriteLine("Hello, Auli!");
Console.WriteLine("enter your name:"); //output

//string-sõne
string userName = Console.ReadLine(); //input

Console.WriteLine("Hello" + "," + userName + "!"); //output

//string interpolatsion
Console.WriteLine($"Hello, {userName}!");//output