
using System;

Console.Write(@"Choose a type of soup: Soup, Stew, or gumbo. ");
string chosenType = Console.ReadLine();



Console.Write("Now, choose the main ingredient: mushrooms, chicken, carrots, or potatoes. ");
string chosenIngredient = Console.ReadLine();

Console.WriteLine("Finally, choose a seasoning: spicy, salty, or sweet. ");
string chosenSeasoning = Console.ReadLine();







Console.WriteLine($"{}");







class Soup

{
    enum Type { soup, stew, gumbo }
    enum Ingredient { mushrooms, chicken, carrots, potatoes }
    enum Seasoning { spicy, salty, sweet }

    public string[] soup = new string[3];
};
