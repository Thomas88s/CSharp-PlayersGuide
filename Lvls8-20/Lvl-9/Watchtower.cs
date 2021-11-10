
using System;

Console.WriteLine("Help locate the enemy!");
Console.Write("What is the x value of the enemy location? ");
int xCoord = Convert.ToInt32(Console.ReadLine());

Console.Write("Now, what is the y value of the enemy location? ");
int yCoord = Convert.ToInt32(Console.ReadLine());

if (xCoord < 0 && yCoord > 0)
{
    Console.WriteLine("They're approaching from the North West"!);
}
else if (xCoord < 0 && yCoord == 0)
{
    Console.WriteLine("They're approaching from the West"!);
}
else if (xCoord < 0 && yCoord < 0)
{
    Console.WriteLine("They're approaching from the South West"!);
}
else if (xCoord == 0 && yCoord > 0)
{
    Console.WriteLine("They're approaching from the North"!);
}
else if (xCoord == 0 && yCoord == 0)
{
    Console.WriteLine("The enemy is here!"!);
}
else if (xCoord == 0 && yCoord < 0)
{
    Console.WriteLine("They're approaching from the South"!);
}
else if (xCoord > 0 && yCoord > 0)
{
    Console.WriteLine("They're approaching from the North East"!);
}
else if (xCoord > 0 && yCoord == 0)
{
    Console.WriteLine("They're approaching from the East"!);
}
else if (xCoord > 0 && yCoord < 0)
{
    Console.WriteLine("They're approaching from the South West"!);
}