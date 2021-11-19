using System;

Arrow arrow = GetArrow();
Console.WriteLine(@$"Your Arrow | head: {arrow._arrowhead} | fletching: {arrow._fletching} | length: {arrow._length}
                     cost: {arrow.GetCost()}");

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
    private Arrowhead _arrowhead;
    private Fletching _fletching;
    private float _length;

    public Arrowhead GetArrowhead() => _arrowhead;
    public Fletching GetFletching() => _fletching;
    public float GetLength() => _length;
    private Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    public float GetCost()
    {
        float arrowheadCost = _arrowhead switch
        {
            Arrowhead.steel => 10,
            Arrowhead.wood => 3,
            Arrowhead.obsidian => 5,
            _ => throw new NotImplementedException()
        };

        float fletchingCost = _fletching switch
        {
            Fletching.plastic => 10,
            Fletching.turkeyFeathers => 5,
            Fletching.gooseFeathers => 3,
            _ => throw new NotImplementedException()
        };

        float shaftCost = 0.05f * _length;

        return arrowheadCost + fletchingCost + shaftCost;
    }

}


enum Arrowhead { steel, wood, obsidian }
enum Fletching { plastic, turkeyFeathers, gooseFeathers }