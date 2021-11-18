//using System;



//Chest current = Chest.Locked;


//Choices();

//void Choices()
//{
//    Console.WriteLine("-------------------------------------------");
//    Console.Write($"The Chest is {current}. What Would you like to do? ");
//    string action = Console.ReadLine();


//    if (current == Chest.Locked && action == "unlock")
//    {
//        current = Chest.Unlocked;
//        Choices();
//    }

//    else if (current == Chest.Unlocked && action == "open")
//    {
//        current = Chest.Open;
//        Choices();
//    }
//    else if (current == Chest.Unlocked && action == "lock")
//    {
//        current = Chest.Locked;
//        Choices();
//    }
//    else if (current == Chest.Open && action == "close")
//    {
//        current = Chest.Unlocked;
//        Choices();
//    }
//    else
//    {
//        Console.WriteLine("That action cannot be performed right now.");
//        Choices();
//    }
//    Choices();
//}

//enum Chest { Locked, Unlocked, Open }
