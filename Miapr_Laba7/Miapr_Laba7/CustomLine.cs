using System;
using System.Drawing;

namespace Miapr_Laba7
{
    public class CustomLine : Line
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            points[1] = CalculateEstimatePoint(points[0], points[1]);
            base.Draw(graphics, pen);
        }

        private Point CalculateEstimatePoint(Point startPoint, Point endPoint)
        {
            double angle = ((endPoint.X - startPoint.X) == 0)
                ? 90
                : Math.Atan(Math.Abs(endPoint.Y - startPoint.Y)/(double) Math.Abs(endPoint.X - startPoint.X))*180/
                  Math.PI;
            double distance = CalculateDistance(startPoint, endPoint);
            int signX = 0;
            int signY = 0;
            if (angle <= 22.5)
            {
                signX = (startPoint.X <= endPoint.X) ? 1 : -1;
                signY = 0;
            }
            else if (angle <= 67.5)
            {
                signX = (startPoint.X <= endPoint.X) ? 1 : -1;
                signY = (startPoint.Y <= endPoint.Y) ? 1 : -1;
                distance /= Math.Sqrt(2);
            }
            else if (angle <= 90)
            {
                signX = 0;
                signY = (startPoint.Y <= endPoint.Y) ? 1 : -1;
            }
            var result = new Point
            {
                X = startPoint.X + (int) (signX*distance),
                Y = startPoint.Y + (int) (signY*distance)
            };
            return result;
        }

        private double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        }
    }
}