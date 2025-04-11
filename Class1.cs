using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paint_0
{
    enum Tool
    {
        Brush,
        Square,
        Rectangle,
        Ellipse,
        Circle
    }
    public abstract class Shapes
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public abstract void Draw(Graphics g, Pen pen);
    }

    public class Square : Shapes
    {
        public override void Draw(Graphics g, Pen pen)
        {
            int side = Math.Min(Math.Abs(EndPoint.X - StartPoint.X), Math.Abs(EndPoint.Y - StartPoint.Y));
            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            g.DrawRectangle(pen, x, y, side, side);
        }
    }

    public class ShapeRectangle : Shapes
    {
        public override void Draw(Graphics g, Pen pen)
        {
            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            int width = Math.Abs(EndPoint.X - StartPoint.X);
            int height = Math.Abs(EndPoint.Y - StartPoint.Y);
            g.DrawRectangle(pen, x, y, width, height);
        }
    }

    public class Ellipse : Shapes
    {
        public override void Draw(Graphics g, Pen pen)
        {
            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            int width = Math.Abs(EndPoint.X - StartPoint.X);
            int height = Math.Abs(EndPoint.Y - StartPoint.Y);
            g.DrawEllipse(pen, x, y, width, height);
        }
    }

    public class Circle : Shapes
    {
        public override void Draw(Graphics g, Pen pen)
        {
            int diameter = Math.Min(Math.Abs(EndPoint.X - StartPoint.X), Math.Abs(EndPoint.Y - StartPoint.Y));
            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            g.DrawEllipse(pen, x, y, diameter, diameter);
        }
    }
}
