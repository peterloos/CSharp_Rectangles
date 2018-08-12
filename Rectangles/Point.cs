using System;

class Point
{
    private double x;
    private double y;

    // c'tors
    public Point ()
    {
        this.x = 0;
        this.y = 0;
    }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // properties
    public double X
    {
        get { return this.x; }
        set { this.x = value; }
    }

    public double Y
    {
        get { return this.y; }
        set { this.y = value; }
    }

    // overrides
    public override String ToString()
    {
        return String.Format("({0:.##},{1:.##})", this.x, this.y);
    }

    public override bool Equals(Object obj)
    {
        if (!(obj is Point))
            return false;

        Point p = (Point) obj;

        return this.X == p.X && this.Y == p.Y;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

