using System.Drawing;

namespace ShapeApp
{
    public class CircleShape : Shape
    {
        public CircleShape(Rectangle b, Color c) : base(b, c) { }

        public override string Name { get { return "Дугуй"; } }

        public override void Draw(Graphics g)
        {
            using (var fill = MakeFill())
            using (var pen = MakePen())
            {
                g.FillEllipse(fill, Bounds);
                g.DrawEllipse(pen, Bounds);
            }
            base.Draw(g);
        }
    }
}