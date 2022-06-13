using System;
using System.Drawing;
using System.Windows.Forms;

/* -----------------------
 * Geometric_figures_3 ---
 * -----------------------
 * Bakirov Karim_220 group
 */

namespace Geometric_experience
{
    public class Figure

    {
        public Point A;
        public String Image;
        public Graphics Holst;
        public Pen Upen;

        public Figure(string image = "no image")
        {
            Image = image;
        }

        public virtual Graphics Draw(Pen taked_pen, Graphics taked_hoslt)
        {
            return Holst;
        }

        public string TakingColor()
        {
            Color taked_color = Upen.Color;
            byte g = taked_color.G;
            byte b = taked_color.B;
            byte r = taked_color.R;
            byte a = taked_color.A;
            string text = String.Format("A:{0},R:{1},G:{2},B:{3};", new object[] { a, r, g, b });
            float pen_width = Upen.Width; text += Convert.ToString(pen_width);
            return text;
        }
    }

    class Segment : Figure
    {
        private Point B;
        public Segment(Point T1, Point T2)
        {
            Image = "Segment";
            A = T1;
            B = T2;
        }

        public override Graphics Draw(Pen taked_pen, Graphics taked_holst)
        {
            Holst = taked_holst;
            Upen = taked_pen;
            Holst.DrawLine(Upen, A.X, A.Y, B.X, B.Y);
            return Holst;
        }
        public override string ToString()
        {
            string text = TakingColor();
            return $"{text};{Image};{A.X} {A.Y};{B.X} {B.Y}";
        }
    }



    class Triangle : Figure
    {
        private Point[] allpoints;

        public Triangle(Point T1, Point T2, Point T3)
        {
            Image = "Triangle";
            A = T1;
            allpoints = new Point[3];
            allpoints[0] = A; allpoints[1] = T2; allpoints[2] = T3;
        }



        public override Graphics Draw(Pen taked_pen, Graphics taked_holst)
        {
            Holst = taked_holst;
            Upen = taked_pen;
            Holst.DrawPolygon(Upen, allpoints);
            return Holst;
        }

        public override string ToString()
        {
            string text = TakingColor();
            return $"{text};{Image};{A.X} {A.Y};{allpoints[1].X} {allpoints[1].Y};{allpoints[2].X} {allpoints[2].Y}";
        }
    }



    class Rectangle : Figure
    {
        private int weight;
        private int height;

        public Rectangle(Point T1, int Weight, int Height)
        {
            Image = "Rectangle";
            A = T1;
            weight = Weight;
            height = Height;
        }

        public override Graphics Draw(Pen taked_pen, Graphics taked_holst)
        {
            Upen = taked_pen;
            Holst = taked_holst;
            Holst.DrawRectangle(Upen, A.X, A.Y, weight, height);
            return Holst;
        }

        public override string ToString()
        {
            string text = TakingColor();
            return $"{text};{Image};{A.X} {A.Y};{weight};{height}";
        }

    }



    class Circle : Figure
    {
        private int Radius;
        public Circle(Point T1, int R)
        {
            Image = "Circle";
            A = T1;
            Radius = R;
        }

        public override Graphics Draw(Pen taked_pen, Graphics taked_holst)
        {
            Upen = taked_pen;
            Holst = taked_holst;
            Holst.DrawEllipse(Upen, A.X, A.Y, Radius, Radius);
            return Holst;
        }

        public override string ToString()
        {
            string text = TakingColor();
            return $"{text};{Image};{A.X} {A.Y};{Radius}";
        }
    }
}
