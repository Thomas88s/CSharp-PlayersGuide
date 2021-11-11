using System;


string initialQuestion = "Please enter a number between 0 and 100, Pilot: ";
string secondQuestion = "Please enter a number between 0 and 100, Hunter: ";

Console.Write(initialQuestion);

int pilotNumb = Convert.ToInt32(Console.ReadLine());

    Console.Clear();

    Console.Write(secondQuestion);
    int hunterNumb = Convert.ToInt32(Console.ReadLine());

while (hunterNumb != pilotNumb)
{
    if (hunterNumb < pilotNumb)
    {
    Console.WriteLine("Hunter number is too low");
    Console.Write(secondQuestion);
    hunterNumb = Convert.ToInt32(Console.ReadLine());
    }
    else if (hunterNumb > pilotNumb)
    {
    Console.WriteLine("Hunter number is too high");
    Console.Write(secondQuestion);
    hunterNumb = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
    break;
    }

}
 Console.WriteLine("The hunter's number matches the pilot's number. Correct.");



   




