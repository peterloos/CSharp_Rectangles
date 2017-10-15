using System;

class Rectangle
{
    private double x1;
    private double y1;
    private double x2;
    private double y2;

    // c'tors
    public Rectangle()
    {
        this.x1 = 0;
        this.y1 = 0;
        this.x2 = 0;
        this.y2 = 0;
    }

    public Rectangle(double x1, double y1, double x2, double y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.Normalize();
    }

    // properties
    public double X1
    {
        get
        {
            return this.x1;
        }

        set
        {
            this.x1 = value;
            this.Normalize();
        }
    }

    public double X2
    {
        get
        {
            return this.x2;
        }

        set
        {
            this.x2 = value;
            this.Normalize();
        }
    }

    public double Y1
    {
        get
        {
            return this.y1;
        }

        set
        {
            this.y1 = value;
            this.Normalize();
        }
    }

    public double Y2
    {
        get
        {
            return this.y2;
        }

        set
        {
            this.y2 = value;
            this.Normalize();
        }
    }

    // public interface
    public double Circumference()
    {
        return 2 * ((this.x2 - this.x1) + (this.y1 - this.y2));
    }

    public double Diagonal()
    {
        return
            Math.Sqrt(
                ((this.x2 - this.x1) * (this.x2 - this.x1) + 
                (this.y1 - this.y2) * (this.y1 - this.y2)));
    }

    public double Area()
    {
        return (this.x2 - this.x1) * (this.y1 - this.y2);
    }


    public bool IsSquare()
    {
        return (this.x2 - this.x1) == (this.y1 - this.y2);
    }

    public Point Center()
    {
        double x = this.x1 + (this.x2 - this.x1) / 2.0;
        double y = this.y2 + (this.y1 - this.y2) / 2.0;

        return new Point(x, y);
    }


    public void AdjustWidth(double width)
    {
        this.x2 = this.x1 + width;
        this.Normalize();
    }

    public void AdjustHeight(double height)
    {
        this.y2 = this.y1 - height;
        this.Normalize();
    }

    public void Move(double x, double y)
    {
        this.x1 += x;
        this.y1 += y;
        this.x2 += x;
        this.y2 += y;
    }

    public Rectangle Intersection(Rectangle rect)
    {
        double x1, y1, x2, y2;

        if (this.x2 <= rect.x1 || this.x1 >= rect.x2 ||
            this.y1 <= rect.y2 || this.y2 >= rect.y1)
        {
            return new Rectangle();
        }

        if (this.x1 < rect.x1)
        {
            x1 = rect.x1;
        }
        else
        {
            x1 = this.x1;
        }

        if (this.x2 < rect.x2)
        {
            x2 = this.x2;
        }
        else
        {
            x2 = rect.x2;
        }

        if (this.y1 > rect.y1)
        {
            y1 = rect.y1;
        }
        else
        {
            y1 = this.y1;
        }

        if (this.y2 > rect.y2)
        {
            y2 = this.y2;
        }
        else
        {
            y2 = rect.y2;
        }

        return new Rectangle(x1, y1, x2, y2);
    }

    // private helper methods
    private void Normalize()
    {
        if (this.x1 > this.x2)
        {
            double tmp = this.x1;
            this.x1 = this.x2;
            this.x2 = tmp;
        }

        if (this.y1<this.y2)
        {
            double tmp = this.y1;
            this.y1 = this.y2;
            this.y2 = tmp;
        }
    }

    // overrides
    public override String ToString()
    {
        String s1 = String.Format(
            "Rectangle: ({0:0.00},{1:0.00}),({2:0.00},{3:0.00})",
            this.x1, this.y1, this.x2, this.y2);

        String s2 = String.Format("[Area={0:0.00}, Circumference={1:0.00}, ",
            this.Area(), this.Circumference());

        String s3 = String.Format("Diagonal={0:0.00}, IsSquare={1:0.00}]",
            this.Diagonal(), this.IsSquare());

        return s1 + Environment.NewLine + s2 + s3;
    }
}

