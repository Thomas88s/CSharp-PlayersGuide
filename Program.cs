using System;


Console.WriteLine("How many eggs will the sisters get?");
int numbOfEggs = int.Parse(Console.ReadLine());



 int sistersShare = numbOfEggs / 4;
int duckbearsShare = numbOfEggs % 4;

Console.WriteLine($"The sisters get {sistersShare} and duckbear gets {duckbearsShare}.");