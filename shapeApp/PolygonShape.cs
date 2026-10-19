
using System;
using System.Drawing;

namespace ShapeApp
{
    public class PolygonShape : Shape
    {
        private readonly Point[] points;

        public PolygonShape(Rectangle b, Color c)
            : base(b, c)
        {
            int count = Rnd.Next(3, 8);
            points = new Point[count];

            for (int i = 0; i < count; i++)
            {
                points[i] = new Point(
                    X + Rnd.Next(0, Math.Max(1, Width)),
                    Y + Rnd.Next(0, Math.Max(1, Height))
                );
            }
        }

        public override string Name
        {
            get { return "Polygon"; }
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = MakePen())
            using (Brush brush = MakeFill())
            {
                g.FillPolygon(brush, points);
                g.DrawPolygon(pen, points);
            }

            base.Draw(g);
        }
    }
}
