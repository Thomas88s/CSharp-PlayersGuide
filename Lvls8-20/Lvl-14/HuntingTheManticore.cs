using System;
int manticore = 10;
int cityOfConsolas = 15;
int round = 1;
int cannonRange = 100;



void player2Choice()
{
    Console.Write("Player Two choose a desired cannon range. ");
}


void Status()
{
    Console.WriteLine($"STATUS| Round: {round} | City of Consolas: {cityOfConsolas}/15 | Manticore: {manticore}/10");

}
    

void damageDelt()
{

    if (round % 3 == 0 && round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("The Cannon obliterates the Manticore with a Mighty fire-electric blast dealing 10 damage!");
        manticore -= 10;
        cityOfConsolas--;
        round++;
        
    }
    else if (round % 5 == 0) 
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The Manticore is struck by a brilliant electric blast for 3 damage!");
        manticore -= 3;
        cityOfConsolas--;
        round++;
        
    }
    else if (round % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire erupts from the cannon engulfing the Manticore for 3 damage!");
        manticore -= 3;
        cityOfConsolas--;
        round++;
        
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("The Cannon blast the Manticore for 1 damage.");
        manticore -= 1;
        cityOfConsolas--;
        round++;
        
    }
    Console.ForegroundColor = ConsoleColor.White;
    
}
Console.ForegroundColor = ConsoleColor.White;
Console.Write("Player One choose the Manticore's distance from the city (1 to 100). ");
int distanceFromCity = Convert.ToInt32(Console.ReadLine());
Console.Clear();





while (manticore != 0 || cityOfConsolas != 0)
   {
            Console.WriteLine("--------------------------------");
            Status();
            player2Choice();
            cannonRange = Convert.ToInt32(Console.ReadLine());

    if (cannonRange < distanceFromCity)
    {
        Console.WriteLine("The cannon FELL SHORT of hitting the Manticore.");
        cityOfConsolas--;
        round++;
        Console.ReadKey();


    }
    else if (cannonRange > distanceFromCity)
    {
        Console.WriteLine("The cannon OVERSHOT the Manticore.");
        cityOfConsolas--;
        round++;
        Console.ReadKey();


    }
    else if (cannonRange == distanceFromCity)
    {
        damageDelt();
        Console.ReadKey();

    }
    
   if (manticore <= 0)
   {
   Console.WriteLine("The Manticore has been destoryed! The city of Consolas is saved!");
        Console.ReadKey();
        break;
    }
   if (cityOfConsolas <= 0)
   {
    Console.WriteLine("Alas, the city was destoryed...");
        Console.ReadKey();
        break;
   }

   }
        
   
        