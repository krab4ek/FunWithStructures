#region Structures on C#
Console.WriteLine("***** Fun With Structures*****");
//Point myPoint;
Point myPoint = new Point();
myPoint.Display();
myPoint.X = 349;
myPoint.Y = 76;
myPoint.Display();
myPoint.Increment();
myPoint.Display();
myPoint.Decrement();
myPoint.Decrement();
myPoint.Display();
Point myPoint2 = new Point(40,60);
myPoint2.Display();



#endregion

struct Point
{
    //Поля структуры
    public int X;
    public int Y;

    public Point(int XPos, int YPos)
    {
        X = XPos;
        Y = YPos;
    }

    public void Increment()
    {
        X++; Y++;
    }

    public void Decrement()
    {
        X--; Y--;
    }

    public void Display()
    {
        Console.WriteLine($"X={X}, Y={Y}");
    }
}