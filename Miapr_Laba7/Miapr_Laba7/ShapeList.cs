using System.Collections.Generic;
using System.Drawing;

namespace Miapr_Laba7
{
    public class ShapesList
    {
        private readonly List<Shape> shapes = new List<Shape>();

        public int Count()
        {
            return shapes.Count;
        }

        public void AddShape(Shape sh)
        {
            shapes.Add(sh);
        }

        public void DrawListOfShapes(Graphics graphics, Pen pen)
        {
            foreach (Shape sh in shapes)
            {
                sh.Draw(graphics, pen);
            }
        }
    }
}