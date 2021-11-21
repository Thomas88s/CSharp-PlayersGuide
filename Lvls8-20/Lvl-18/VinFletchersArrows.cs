using System;


Console.WriteLine("Welcome to the Arrow Shop!");

Arrow GetType()
{
    Console.WriteLine("Arrow type (Elite, Beginner, Marksman, Custom)");
    string input = Console.ReadLine();
    return input switch
    {
        "Elite" => Arrow.CreateEliteArrow(),
        "Beginner" => Arrow.CreateBeginnerArrow(),
        "Marksman" => Arrow.CreateMarksmanArrow(),
        "Custom" => GetArrow(),
        _ => throw new NotImplementedException()
    };

}

Arrow arrow = GetType();

if (arrow != null)
{
    Console.WriteLine(@$"Your Arrow | head: {arrow.Arrowhead} | fletching: {arrow.Fletching} | length: {arrow.Length}
                     cost: {arrow.GetCost()}");
}
else
{

    GetArrow();

}


Arrow GetArrow()
{
    Arrowhead arrowheadType = GetArrowheadType();
    Fletching fletchingType = GetFletchingType();
    float length = GetLength();
    return new Arrow(arrowheadType, fletchingType, length);
}



Arrowhead GetArrowheadType()
{
    Console.Write("Arrowhead type (steel, wood, obsidian): ");
    string input = Console.ReadLine();
    return input switch
    {
        "steel" => Arrowhead.steel,
        "wood" => Arrowhead.wood,
        "obsidian" => Arrowhead.obsidian,
        _ => throw new NotImplementedException()
    };
}

Fletching GetFletchingType()
{
    Console.Write("Fletching type (plastic, turkey feathers, goose feathers): ");
    string input = Console.ReadLine();
    return input switch
    {
        "plastic" => Fletching.plastic,
        "turkey feathers" => Fletching.turkeyFeathers,
        "goose feathers" => Fletching.gooseFeathers,
        _ => throw new NotImplementedException()
    };
}

float GetLength()
{
    float length = 0;

    while (length < 60 || length > 100)
    {
        Console.WriteLine("Arrow length (Between 60 cm and 100 cm)");
        length = Convert.ToSingle(Console.ReadLine());
    }
    return length;
}



class Arrow
{

    public Arrowhead Arrowhead { get; private set; }
    public Fletching Fletching { get; private set; }
    public float Length { get; private set; }



    public static Arrow CreateEliteArrow()
    {

        return new Arrow(Arrowhead.steel, Fletching.plastic, 95) { };

    }

    public static Arrow CreateBeginnerArrow()
    {

        return new Arrow(Arrowhead.wood, Fletching.gooseFeathers, 75) { };
    }

    public static Arrow CreateMarksmanArrow()
    {
        return new Arrow(Arrowhead.steel, Fletching.gooseFeathers, 65) { };
    }
    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }

    public float GetCost()
    {
        float arrowheadCost = Arrowhead switch
        {
            Arrowhead.steel => 10,
            Arrowhead.wood => 3,
            Arrowhead.obsidian => 5,
            _ => throw new NotImplementedException()
        };

        float fletchingCost = Fletching switch
        {
            Fletching.plastic => 10,
            Fletching.turkeyFeathers => 5,
            Fletching.gooseFeathers => 3,
            _ => throw new NotImplementedException()
        };

        float shaftCost = 0.05f * Length;

        return arrowheadCost + fletchingCost + shaftCost;
    }

}


enum Arrowhead { steel, wood, obsidian }
enum Fletching { plastic, turkeyFeathers, gooseFeathers }