using System.Drawing;

namespace ShapeApp
{
    public class CurveShape : Shape
    {
        private readonly Point[] _points;

        public CurveShape(Rectangle b, Color c) : base(b, c)
        {
            int n = 5;
            _points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                int px = X + i * Width / (n - 1);        // x тэнцүү зайтай
                int py = Y + Rnd.Next(0, Height + 1);    // y санамсаргүй
                _points[i] = new Point(px, py);
            }
        }

        public override string Name { get { return "Curve"; } }

        public override void Draw(Graphics g)
        {
            using (var pen = MakePen())
            {
                g.DrawCurve(pen, _points);
            }
            base.Draw(g);
        }
    }
}