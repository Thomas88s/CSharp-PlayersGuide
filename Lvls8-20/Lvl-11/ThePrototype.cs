using System;

int number1 = AskForNumber("Please enter a number between 0 and 100, Pilot: ");
int number2 = AskForNumber("Please enter a number between 0 and 100, Hunter: ");

int pilotNumb = number1;
int hunterNumb = number2;


int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

Console.Write(number1);


Console.Clear();

Console.Write(number2);


while (hunterNumb != pilotNumb)
{

    if (hunterNumb < pilotNumb)
    {
        Console.WriteLine("Hunter number is too low. Please try again. ");    
        hunterNumb = Convert.ToInt32(Console.ReadLine());
        
    }
    else if (hunterNumb > pilotNumb)
    {
        Console.WriteLine("Hunter number is too high. Please try again. ");
        hunterNumb = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        break;
    }

}
Console.WriteLine("The hunter's number matches the pilot's number. Correct.");








