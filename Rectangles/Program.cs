using System;

class Program
{
    public static void Main()
    {
       Test01_Ctors();
       Test02_Methods();
       Test03_Center();
       Test04_Adjust();
       Test05_Move();
       Test06_Intersection();
    }

    public static void Test01_Ctors()
    {
        Rectangle rect1 = new Rectangle();
        Console.WriteLine(rect1);
        Rectangle rect2 = new Rectangle(3, 3, 5, 5);
        Console.WriteLine(rect2);
        Rectangle rect3 = new Rectangle(3, 3, 5, 1);
        Console.WriteLine(rect3);
        Rectangle rect4 = new Rectangle(3, 3, 1, 1);
        Console.WriteLine(rect4);
        Rectangle rect5 = new Rectangle(3, 3, 1, 5);
        Console.WriteLine(rect5);
    }

    public static void Test02_Methods()
    {
        Rectangle rect = new Rectangle(3, 4, 9, 10);
        Console.WriteLine(rect);
        Console.WriteLine("Circumference: " + rect.Circumference());
        Console.WriteLine("Diagonal:      " + rect.Diagonal());
        Console.WriteLine("Area:          " + rect.Area());
        Console.WriteLine("IsSquare:      " + rect.IsSquare());
    }

    public static void Test03_Center()
    {
        Rectangle rect1 = new Rectangle(1, 3, 3, 1);
        Console.WriteLine(rect1);
        Point p1 = rect1.Center();
        Console.WriteLine("Center: " + p1.ToString());

        Rectangle rect2 = new Rectangle(1, 4, 4, 1);
        Console.WriteLine(rect2);
        Point p2 = rect2.Center();
        Console.WriteLine("Center: " + p2.ToString());
    }

    public static void Test04_Adjust()
    {
        Rectangle rect = new Rectangle(3, 3, 1, 1);
        Console.WriteLine(rect);
        rect.AdjustWidth(3);
        Console.WriteLine(rect);
        rect.AdjustWidth(-1);
        Console.WriteLine(rect);
        rect.AdjustHeight(3);
        Console.WriteLine(rect);
        rect.AdjustHeight(-1);
        Console.WriteLine(rect);
    }

    public static void Test05_Move()
    {
        Rectangle rect = new Rectangle(1, 1, 4, 5);
        Console.WriteLine(rect);
        rect.Move(5, -5);
        Console.WriteLine(rect);
    }

    public static void Test06_Intersection()
    {
        Rectangle rect1 = new Rectangle(4, 8, 9, 5);
        Rectangle rect2 = new Rectangle(2, 10, 8, 6);
        Rectangle rect = rect1.Intersection(rect2);
        Console.WriteLine(rect);

        Rectangle rect3 = new Rectangle(7, 9, 9, 4);
        rect = rect1.Intersection(rect3);
        Console.WriteLine(rect);

        rect = rect3.Intersection(rect3);
        Console.WriteLine(rect);

        Rectangle rect4 = new Rectangle(6, 7, 10, 5);
        rect = rect1.Intersection(rect4);
        Console.WriteLine(rect);
    }
}

