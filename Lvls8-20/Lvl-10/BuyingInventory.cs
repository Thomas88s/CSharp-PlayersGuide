
using System;
using System.Collections.Generic;

Console.WriteLine("The following items are available:");
    Console.WriteLine("1 - Rope");
    Console.WriteLine("2 - Torches");
    Console.WriteLine("3 - Climbing Equipment");
    Console.WriteLine("4 - Clean Water");
    Console.WriteLine("5 - Machete");
    Console.WriteLine("6 Canoe");
    Console.WriteLine("7 - Food Supplies");
    Console.Write("What number do you want to see the price of? ");

    var choice = Convert.ToInt32(Console.ReadLine());

    Console.Write("What is your name? ");

    string name = Console.ReadLine();


double price1 = 10;
double price2 = 15;
double price3 = 25;
double price4 = 1;
double price5 = 20;
double price6 = 200;
double price7 = 1;


if (name == "Thomas")
{
     price1 /= 2;
     price2 /= 2;
     price3 /= 2;
     price4 /= 2;
     price5 /= 2;
     price6 /= 2;
     price7 /= 2;   
}



String response =  choice switch
{
    1 => $"Rope cost {price1} gold.",
    2 => $"Torches cost {price2} gold.",
    3 => $"Climbing Equipment cost {price3} gold.",
    4 => $"Clean Water cost {price4} gold.",
    5 => $"Machete cost {price5} gold.",
    6 => $"Canoe cost {price6} gold.",
    7 => $"Food Supplies cost {price7} gold",
    _ => "Sorry, we don't have that.",
};


Console.WriteLine(response);