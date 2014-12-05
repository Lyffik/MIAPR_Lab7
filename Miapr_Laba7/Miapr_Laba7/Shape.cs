using System.Collections.Generic;
using System.Drawing;

namespace Miapr_Laba7
{
    public abstract class Shape
    {
        protected List<Point> points;

        protected Shape()
        {
            points = new List<Point>();
        }


        public virtual void AddPoint(Point p)
        {
        }

        public virtual void EditLastPoint(Point p)
        {
        }

        public abstract void Draw(Graphics graphics, Pen pen);
    }
}