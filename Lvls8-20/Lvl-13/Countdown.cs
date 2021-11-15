using System;

//for (int x = 10; x > 0; x--)
//    Console.WriteLine(x);
int number = 10;

int loopDLoop(int number)
{
    if (number == 1) return number;
    Console.WriteLine(number);
    return  loopDLoop(number - 1);

}

Console.WriteLine(loopDLoop(number));