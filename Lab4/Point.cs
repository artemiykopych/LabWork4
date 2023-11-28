using System;
using System.ComponentModel;

namespace Lab4
{
    interface IUnit
    {
        double X { get; set; }
        double Y { get; set; }
    }
    public class Point : IUnit
    {
        double x;
        double y;

        public Point()
        {
            var rnd = new Random();
            x = rnd.Next(0, 5);
            y = rnd.Next(0, 5);
        }

        public Point(double x1, double y1)
        {
            x = x1;
            y = y1;
        }

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y;} set { y = value; } }

        public void movePoint(int xm, int ym)
        {
            x = x + xm;
            y = y + ym;
        }
    }

    public class Square : Point
    {
        Point a;
        Point b;
        Point c;
        Point d;

        public Square(double x, double y)
        {
            a = new Point(x, y);
            b = new Point(x, y + 5);
            c = new Point(x + 5, y + 5);
            d = new Point(x + 5, y);
        }

        public void moveSquare(int xm, int ym)
        {
            a.movePoint(xm, ym);
            b.movePoint(xm, ym);
            c.movePoint(xm, ym);
            d.movePoint(xm, ym);
        }

        public double AX { get { return a.X; } set { a.X = value; } }
        public double AY { get { return a.Y;} set { a.Y = value; } }
        public double BX { get { return b.X;} set { b.X = value; } }
        public double BY { get { return b.Y;} set { b.Y = value; } }
        public double CX { get { return c.X;} set { c.X = value; } }
        public double CY { get { return c.Y;} set { c.Y = value; } }
        public double DX { get { return d.X; } set { d.X = value; } }
        public double DY { get { return d.Y; } set { d.Y = value; } }
    }

    public class Rectangle : Point
    {
        Point a;
        Point b;
        Point c;
        Point d;

        public Rectangle(double x, double y)
        {
            a = new Point(x, y);
            b = new Point(x, y + 5);
            c = new Point(x + 10, y + 5);
            d = new Point(x + 10, y);
        }

        public void moveRectangle(int xm, int ym)
        {
            a.movePoint(xm, ym);
            b.movePoint(xm, ym);
            c.movePoint(xm, ym);
            d.movePoint(xm, ym);
        }

        public double AX { get { return a.X; } set { a.X = value; } }
        public double AY { get { return a.Y; } set { a.Y = value; } }
        public double BX { get { return b.X; } set { b.X = value; } }
        public double BY { get { return b.Y; } set { b.Y = value; } }
        public double CX { get { return c.X; } set { c.X = value; } }
        public double CY { get { return c.Y; } set { c.Y = value; } }
        public double DX { get { return d.X; } set { d.X = value; } }
        public double DY { get { return d.Y; } set { d.Y = value; } }
    }

    public class Romb : Point
    {
        Point a;
        Point b;
        Point c;
        Point d;

        public Romb(double x, double y)
        {
            a = new Point(x, y);
            b = new Point(x + 1.25, y + 5);
            c = new Point(x + 6.25, y + 5);
            d = new Point(x + 5, y);
        }

        public void moveRectangle(int xm, int ym)
        {
            a.movePoint(xm, ym);
            b.movePoint(xm, ym);
            c.movePoint(xm, ym);
            d.movePoint(xm, ym);
        }

        public double AX { get { return a.X; } set { a.X = value; } }
        public double AY { get { return a.Y; } set { a.Y = value; } }
        public double BX { get { return b.X; } set { b.X = value; } }
        public double BY { get { return b.Y; } set { b.Y = value; } }
        public double CX { get { return c.X; } set { c.X = value; } }
        public double CY { get { return c.Y; } set { c.Y = value; } }
        public double DX { get { return d.X; } set { d.X = value; } }
        public double DY { get { return d.Y; } set { d.Y = value; } }
    }
}
