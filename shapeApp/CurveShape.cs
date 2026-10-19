
using System;
using System.Drawing;

namespace ShapeApp
{
    public class CurveShape : Shape
    {
        private readonly Point[] points;

        public CurveShape(Rectangle b, Color c)
            : base(b, c)
        {
            points = new Point[5];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(
                    X + i * Width / (points.Length - 1),
                    Y + Rnd.Next(0, Math.Max(1, Height))
                );
            }
        }

        public override string Name
        {
            get { return "Curve"; }
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = MakePen())
            {
                g.DrawCurve(pen, points);
            }

            base.Draw(g);
        }
    }
}
