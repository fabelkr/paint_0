using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint_0
{
    public abstract class Brushes
    {
        public abstract void Draw(Graphics g, Point currentPoint, Point previousPoint, Pen pen);
    }

    public class Default : Brushes
    {
        public override void Draw(Graphics g, Point currentPoint, Point previousPoint, Pen pen)
        {
            g.DrawLine(pen, previousPoint, currentPoint);
        }
    }

    public class Eraser : Brushes
    {
        private Control canvas;

        public Eraser(Control canvas)
        {
            this.canvas = canvas;
        }

        public override void Draw(Graphics g, Point currentPoint, Point previousPoint, Pen pen)
        {
            using (Pen eraserPen = new Pen(canvas.BackColor, pen.Width))
            {
                eraserPen.StartCap = LineCap.Round;
                eraserPen.EndCap = LineCap.Round;
                g.DrawLine(eraserPen, previousPoint, currentPoint);
            }
        }
    }

    public class Spray : Brushes
    {
        private Random rand = new Random();
        private const int BaseOpacity = 180;

        public override void Draw(Graphics g, Point currentPoint, Point previousPoint, Pen pen)
        {
            int density = (int)(pen.Width * 3);
            Color baseColor = pen.Color;

            for (int i = 0; i < density; i++)
            {
                int radius = (int)(pen.Width * rand.NextDouble());
                double angle = rand.NextDouble() * Math.PI * 2;
                int x = currentPoint.X + (int)(radius * Math.Cos(angle));
                int y = currentPoint.Y + (int)(radius * Math.Sin(angle));

                int opacity = BaseOpacity + rand.Next(-60, 40);
                opacity = Atomic.Clamp(opacity, 30, 255);

                Color sprayColor = Color.FromArgb(opacity, baseColor);

                using (Brush particleBrush = new SolidBrush(sprayColor))
                {
                    g.FillEllipse(particleBrush, x, y, 1.5f, 1.5f);
                }
            }
        }
    }

    public class Crayon : Brushes
    {
        private Random rand = new Random();
        private Point? lastPoint = null;
        private const float TextureDensity = 0.15f;
        private const float MaxJitter = 0.3f;

        public override void Draw(Graphics g, Point currentPoint, Point previousPoint, Pen pen)
        {
            if (!lastPoint.HasValue) lastPoint = currentPoint;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddLine(previousPoint, currentPoint);

                using (Pen outlinePen = new Pen(pen.Color, pen.Width))
                {
                    outlinePen.LineJoin = LineJoin.Round;
                    outlinePen.StartCap = LineCap.Round;
                    outlinePen.EndCap = LineCap.Round;
                    g.DrawPath(outlinePen, path);
                }

                AddContainedTexture(g, path, pen);
            }

            lastPoint = currentPoint;
        }

        private void AddContainedTexture(Graphics g, GraphicsPath path, Pen pen)
        {
            RectangleF bounds = path.GetBounds();
            bounds.Inflate(2, 2);

            using (Region strokeRegion = new Region(path))
            {
                g.SetClip(strokeRegion, CombineMode.Intersect);

                int particleCount = (int)(bounds.Width * bounds.Height * TextureDensity);

                for (int i = 0; i < particleCount; i++)
                {
                    float x = bounds.Left + (float)rand.NextDouble() * bounds.Width;
                    float y = bounds.Top + (float)rand.NextDouble() * bounds.Height;

                    if (path.IsVisible(x, y))
                    {
                        int opacity = rand.Next(40, 190);
                        float size = 1f + rand.Next(0, (int)(pen.Width * 0.7f));

                        using (SolidBrush b = new SolidBrush(Color.FromArgb(opacity, pen.Color)))
                        {
                            float jitterX = (float)(rand.NextDouble() - 0.5) * 2 * MaxJitter;
                            float jitterY = (float)(rand.NextDouble() - 0.5) * 2 * MaxJitter;

                            g.FillEllipse(b,
                                x + jitterX - size / 2,
                                y + jitterY - size / 2,
                                size, size);
                        }
                    }
                }

                g.ResetClip();
            }
        }
    }

    public class CalligraphyPen : Brushes
    {
        private float lastAngle = 0;
        private const float AngleSmoothing = 0.2f;

        public override void Draw(Graphics g, Point currentPoint, Point previousPoint, Pen pen)
        {
            float newAngle = (float)Math.Atan2(currentPoint.Y - previousPoint.Y,
                                             currentPoint.X - previousPoint.X);
            lastAngle = lastAngle * (1 - AngleSmoothing) + newAngle * AngleSmoothing;

            float width = pen.Width;
            Color baseColor = pen.Color;

            float distance = (float)Math.Sqrt(
                Math.Pow(currentPoint.X - previousPoint.X, 2) +
                Math.Pow(currentPoint.Y - previousPoint.Y, 2));

            int opacity = (int)(220 - Math.Min(distance * 2, 100));
            opacity = Atomic.Clamp(opacity, 100, 255);

            using (GraphicsPath path = new GraphicsPath())
            using (Brush calligraphyBrush = new SolidBrush(Color.FromArgb(opacity, baseColor)))
            {
                PointF p1 = new PointF(
                    previousPoint.X + width * (float)Math.Sin(lastAngle),
                    previousPoint.Y - width * (float)Math.Cos(lastAngle));
                PointF p2 = new PointF(
                    previousPoint.X - width * (float)Math.Sin(lastAngle),
                    previousPoint.Y + width * (float)Math.Cos(lastAngle));
                PointF p3 = new PointF(
                    currentPoint.X - width * (float)Math.Sin(lastAngle),
                    currentPoint.Y + width * (float)Math.Cos(lastAngle));
                PointF p4 = new PointF(
                    currentPoint.X + width * (float)Math.Sin(lastAngle),
                    currentPoint.Y - width * (float)Math.Cos(lastAngle));

                path.AddPolygon(new PointF[] { p1, p2, p3, p4 });
                g.FillPath(calligraphyBrush, path);

                using (Pen edgePen = new Pen(Color.FromArgb(opacity + 30, baseColor), 0.5f))
                {
                    g.DrawPath(edgePen, path);
                }
            }
        }
    }

    public class Marker : Brushes
    {
        private Queue<Point> points = new Queue<Point>();
        private const int MaxPoints = 5;

        public override void Draw(Graphics g, Point currentPoint, Point previousPoint, Pen pen)
        {
            points.Enqueue(currentPoint);
            if (points.Count > MaxPoints)
                points.Dequeue();

            if (points.Count > 1)
            {
                Point[] pointArray = points.ToArray();
                using (Pen markerPen = new Pen(Color.FromArgb(150, pen.Color), pen.Width))
                {
                    g.DrawCurve(markerPen, pointArray);
                }
            }
        }
    }

    public class OilPaint : Brushes
    {
        private Random rand = new Random();

        public override void Draw(Graphics g, Point currentPoint, Point previousPoint, Pen pen)
        {
            int bristleCount = (int)(pen.Width * 0.7f);
            for (int i = 0; i < bristleCount; i++)
            {
                float bristleWidth = pen.Width / bristleCount;
                float offset = (i - bristleCount / 2f) * bristleWidth;

                Point p1 = new Point(
                    previousPoint.X + (int)offset + rand.Next(-1, 2),
                    previousPoint.Y + rand.Next(-1, 2));
                Point p2 = new Point(
                    currentPoint.X + (int)offset + rand.Next(-1, 2),
                    currentPoint.Y + rand.Next(-1, 2));

                using (Pen bristlePen = new Pen(pen.Color, bristleWidth))
                {
                    g.DrawLine(bristlePen, p1, p2);
                }
            }
        }
    }
}
