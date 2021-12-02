using System;

Point a = new Point(2, 3);
Point b = new Point(-4, 0);

Console.Write($"({a.X}, {a.Y})");
Console.Write($"({b.X}, {b.Y})");


public class Point
{
    public float X { get; }
    public float Y { get; }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }

    public Point() : this(0, 0) { }

}

