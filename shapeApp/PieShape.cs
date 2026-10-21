using System.Drawing;

namespace ShapeApp
{
    public class PieShape : Shape
    {
        private readonly float _startAngle;   // эхлэх өнцөг
        private readonly float _sweepAngle;   // хамрах өнцөг

        public PieShape(Rectangle b, Color c) : base(b, c)
        {
            _startAngle = Rnd.Next(0, 360);
            _sweepAngle = Rnd.Next(60, 301);
        }

        public override string Name { get { return "Pie"; } }

        public override void Draw(Graphics g)
        {
            using (var fill = MakeFill())
            using (var pen = MakePen())
            {
                g.FillPie(fill, Bounds, _startAngle, _sweepAngle);
                g.DrawPie(pen, Bounds, _startAngle, _sweepAngle);
            }
            base.Draw(g);
        }
    }
}