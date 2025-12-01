using System;

// Спільний інтерфейс
interface IShape
{
    int GetArea();
}

class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

class Square : IShape
{
    public int Side { get; set; }

    public int GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape rect = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine($"Rectangle Area: {rect.GetArea()}"); // 50

        IShape square = new Square { Side = 5 };
        Console.WriteLine($"Square Area: {square.GetArea()}"); // 25

        Console.ReadKey();
    }
}