using System;

namespace Solution_02
{
    class Rectangle
    {
        private Point left_top;
        private Point right_bottom;

        // c'tors
        public Rectangle()
        {
            this.left_top = new Point();
            this.right_bottom = new Point();
        }

        public Rectangle(double x1, double y1, double x2, double y2)
        {
            this.left_top = new Point(x1, y1);
            this.right_bottom = new Point(x2, y2);
            this.Normalize();
        }

        // properties
        public double X1
        {
            get
            {
                return this.left_top.X;
            }

            set
            {
                this.left_top.X = value;
                this.Normalize();
            }
        }

        public double Y1
        {
            get
            {
                return this.left_top.Y;
            }

            set
            {
                this.left_top.Y = value;
                this.Normalize();
            }
        }

        public double X2
        {
            get
            {
                return this.right_bottom.X;
            }

            set
            {
                this.right_bottom.X = value;
                this.Normalize();
            }
        }



        public double Y2
        {
            get
            {
                return this.right_bottom.Y;
            }

            set
            {
                this.right_bottom.Y = value;
                this.Normalize();
            }
        }

        public double Circumference
        {
            get
            {
                return 2 * ((this.right_bottom.X - this.left_top.X) + (this.left_top.Y - this.right_bottom.Y));
            }
        }

        public double Diagonal
        {
            get
            {
                return
                    Math.Sqrt(
                        ((this.right_bottom.X - this.left_top.X) * (this.right_bottom.X - this.left_top.X) +
                        (this.left_top.Y - this.right_bottom.Y) * (this.left_top.Y - this.right_bottom.Y)));
            }
        }

        public double Area
        {
            get
            {
                return (this.right_bottom.X - this.left_top.X) * (this.left_top.Y - this.right_bottom.Y);
            }
        }

        public bool IsSquare
        {
            get
            {
                return (this.right_bottom.X - this.left_top.X) == (this.left_top.Y - this.right_bottom.Y);
            }
        }

        public Point Center
        {
            get
            {
                return
                    new Point(
                        this.left_top.X + (this.right_bottom.X - this.left_top.X) / 2.0,
                        this.right_bottom.Y + (this.left_top.Y - this.right_bottom.Y) / 2.0);
            }
        }

        // public interface
        public void AdjustWidth(double width)
        {
            this.right_bottom.X = this.left_top.X + width;
            this.Normalize();
        }

        public void AdjustHeight(double height)
        {
            this.right_bottom.Y = this.left_top.Y - height;
            this.Normalize();
        }

        public void Move(double x, double y)
        {
            this.left_top.X += x;
            this.left_top.Y += y;
            this.right_bottom.X += x;
            this.right_bottom.Y += y;
        }

        public Rectangle Intersection(Rectangle rect)
        {
            double x1, y1, x2, y2;

            if (this.right_bottom.X <= rect.left_top.X || this.left_top.X >= rect.right_bottom.X ||
                this.left_top.Y <= rect.right_bottom.Y || this.right_bottom.Y >= rect.left_top.Y)
            {
                return new Rectangle();
            }

            if (this.left_top.X < rect.left_top.X)
            {
                x1 = rect.left_top.X;
            }
            else
            {
                x1 = this.left_top.X;
            }

            if (this.right_bottom.X < rect.right_bottom.X)
            {
                x2 = this.right_bottom.X;
            }
            else
            {
                x2 = rect.right_bottom.X;
            }

            if (this.left_top.Y > rect.left_top.Y)
            {
                y1 = rect.left_top.Y;
            }
            else
            {
                y1 = this.left_top.Y;
            }

            if (this.right_bottom.Y > rect.right_bottom.Y)
            {
                y2 = this.right_bottom.Y;
            }
            else
            {
                y2 = rect.right_bottom.Y;
            }

            return new Rectangle(x1, y1, x2, y2);
        }

        // private helper methods
        private void Normalize()
        {
            if (this.left_top.X > this.right_bottom.X)
            {
                double tmp = this.left_top.X;
                this.left_top.X = this.right_bottom.X;
                this.right_bottom.X = tmp;
            }

            if (this.left_top.Y < this.right_bottom.Y)
            {
                double tmp = this.left_top.Y;
                this.left_top.Y = this.right_bottom.Y;
                this.right_bottom.Y = tmp;
            }
        }

        // overrides
        public override String ToString()
        {
            String s1 = String.Format(
                "Rectangle: ({0:0.00},{1:0.00}),({2:0.00},{3:0.00})",
                this.left_top.X, this.left_top.Y, this.right_bottom.X, this.right_bottom.Y);

            String s2 = String.Format("[Area={0:0.00}, Circumference={1:0.00}, ",
                this.Area, this.Circumference);

            String s3 = String.Format("Diagonal={0:0.00}, IsSquare={1:0.00}]",
                this.Diagonal, this.IsSquare);

            return s1 + Environment.NewLine + s2 + s3;
        }
    }
}
