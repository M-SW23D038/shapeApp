using System;
using System.Drawing;

namespace ShapeApp
{
    public class PolygonShape : Shape
    {
        private readonly Point[] _points;   // цэгүүдийг нэг удаа үүсгэж хадгална

        public PolygonShape(Rectangle b, Color c) : base(b, c)
        {
            int n = Rnd.Next(5, 9);              // 5-8 оройтой
            _points = new Point[n];

            double cx = X + Width / 2.0;
            double cy = Y + Height / 2.0;

            for (int i = 0; i < n; i++)
            {
                double angle = 2 * Math.PI * i / n;
                double k = 0.5 + Rnd.NextDouble() * 0.5;   // төвөөс хол/ойр
                _points[i] = new Point(
                    (int)(cx + Math.Cos(angle) * k * Width / 2.0),
                    (int)(cy + Math.Sin(angle) * k * Height / 2.0));
            }
        }

        public override string Name { get { return "Polygon"; } }

        public override void Draw(Graphics g)
        {
            using (var fill = MakeFill())
            using (var pen = MakePen())
            {
                g.FillPolygon(fill, _points);
                g.DrawPolygon(pen, _points);
            }
            base.Draw(g);
        }
    }
}