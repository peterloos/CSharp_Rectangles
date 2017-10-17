﻿using System;

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
    }

    public double Y
    {
        get { return this.y; }
    }

    // overrides
    public override String ToString()
    {
        String s = String.Format("({0:.##},{1:.##})", this.x, this.y);
        return s;
    }
}

