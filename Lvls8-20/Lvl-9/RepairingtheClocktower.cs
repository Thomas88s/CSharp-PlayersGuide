using System;





Console.Write("Enter a number into the clock. ");
int clockInput = Convert.ToInt32(Console.ReadLine());

if (clockInput%2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}