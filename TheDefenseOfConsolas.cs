using System;


Console.Title = "Defense of Consolas";
Console.WriteLine("We need to protect the city!");
Console.Write("Whats the Target's Row? ");
int row = int.Parse(Console.ReadLine());

Console.Write("What is Target's Column? ");
int column = int.Parse(Console.ReadLine());



string coordinats1 = ($"({row + 1}, {column})");
string coordinats2 = ($"({row}, {column + 1})");
string coordinats3 = ($"({row - 1}, {column})");
string coordinats4 = ($"({row}, {column - 1})");


Console.Beep(440, duration: 1000);
Console.BackgroundColor = ConsoleColor.Green;
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Deploy to:");
Console.WriteLine(coordinats1);
Console.WriteLine(coordinats2);
Console.WriteLine(coordinats3);
Console.WriteLine(coordinats4);

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Press any key to quit");
Console.ReadKey(true);

