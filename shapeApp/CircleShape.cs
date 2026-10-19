
using System.Drawing;

namespace ShapeApp
{
    public class CircleShape : Shape
    {
        public CircleShape(Rectangle b, Color c)
            : base(b, c)
        {
        }

        public override string Name
        {
            get { return "Дугуй"; }
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = MakePen())
            using (Brush brush = MakeFill())
            {
                g.FillEllipse(brush, Bounds);
                g.DrawEllipse(pen, Bounds);
            }

            base.Draw(g);
        }
    }
}
