using System.Drawing;

namespace Miapr_Laba7
{
    public class Line : Shape
    {
        public Line() : base()
        {
        }

        public override void AddPoint(Point p)
        {
            if (points.Count < 2)
                points.Add(p);
            else
                EditLastPoint(p);
        }

        public override void EditLastPoint(Point p)
        {
            points[1] = p;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, points[0], points[1]);
        }
    }
}