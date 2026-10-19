
using System;
using System.Drawing;

namespace ShapeApp
{
    public class PieShape : Shape
    {
        private readonly float startAngle;
        private readonly float sweepAngle;

        public PieShape(Rectangle b, Color c)
            : base(b, c)
        {
            startAngle = Rnd.Next(0, 360);
            sweepAngle = Rnd.Next(45, 316);
        }

        public override string Name
        {
            get { return "Pie"; }
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = MakePen())
            using (Brush brush = MakeFill())
            {
                g.FillPie(brush, Bounds, startAngle, sweepAngle);
                g.DrawPie(pen, Bounds, startAngle, sweepAngle);
            }

            base.Draw(g);
        }
    }
}
