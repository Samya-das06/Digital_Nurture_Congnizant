//Square 

using System;

public class Square
{
    private static Square instance;
    private int side;

    private Square(int side)
    {
        this.side = side;
    }

    public static Square GetInstance(int side)
    {
        if (instance == null)
        {
            instance = new Square(side);
        }
        return instance;
    }

    public int GetArea()
    {
        return side * side;
    }

    public int GetSide()
    {
        return side;
    }

    public void SetSide(int side)
    {
        this.side = side;
    }

    public static void Main(string[] args)
    {
        Square square1 = Square.GetInstance(5);
        Console.WriteLine("Square1 side: " + square1.GetSide());
        Console.WriteLine("Square1 area: " + square1.GetArea());

        Square square2 = Square.GetInstance(10); 
        Console.WriteLine("Square2 side: " + square2.GetSide()); 
        Console.WriteLine("Square2 area: " + square2.GetArea());

        Console.WriteLine("square1 == square2? " + (square1 == square2));
    }
}
