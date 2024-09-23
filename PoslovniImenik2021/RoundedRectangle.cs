using System.Drawing;
using System.Drawing.Drawing2D;

namespace PoslovniImenik
{
    public abstract class RoundedRectangle
    {
        // Methods
        protected RoundedRectangle()
        {
        }

        public static GraphicsPath Create(Rectangle rect)
        {
            return Create(rect.X, rect.Y, rect.Width, rect.Height);
        }

        public static GraphicsPath Create(Rectangle rect, int radius)
        {
            return Create(rect.X, rect.Y, rect.Width, rect.Height, radius);
        }

        public static GraphicsPath Create(Rectangle rect, int radius, RectangleCorners c)
        {
            return Create(rect.X, rect.Y, rect.Width, rect.Height, radius, c);
        }

        public static GraphicsPath Create(int x, int y, int width, int height)
        {
            return Create(x, y, width, height, 5);
        }

        public static GraphicsPath Create(int x, int y, int width, int height, int radius)
        {
            return Create(x, y, width, height, radius, RectangleCorners.All);
        }

        public static GraphicsPath Create(int x, int y, int width, int height, int radius, RectangleCorners corners)
        {
            int num = x + width;
            int num2 = y + height;
            int num3 = num - radius;
            int num4 = num2 - radius;
            int num5 = x + radius;
            int num6 = y + radius;
            int num7 = radius * 2;
            int num8 = num - num7;
            int num9 = num2 - num7;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            if ((RectangleCorners.TopLeft & corners) == RectangleCorners.TopLeft)
            {
                path.AddArc(x, y, num7, num7, 180f, 90f);
            }
            else
            {
                path.AddLine(x, num6, x, y);
                path.AddLine(x, y, num5, y);
            }
            path.AddLine(num5, y, num3, y);
            if ((RectangleCorners.TopRight & corners) == RectangleCorners.TopRight)
            {
                path.AddArc(num8, y, num7, num7, 270f, 90f);
            }
            else
            {
                path.AddLine(num3, y, num, y);
                path.AddLine(num, y, num, num6);
            }
            path.AddLine(num, num6, num, num4);
            if ((RectangleCorners.BottomRight & corners) == RectangleCorners.BottomRight)
            {
                path.AddArc(num8, num9, num7, num7, 0f, 90f);
            }
            else
            {
                path.AddLine(num, num4, num, num2);
                path.AddLine(num, num2, num3, num2);
            }
            path.AddLine(num3, num2, num5, num2);
            if ((RectangleCorners.BottomLeft & corners) == RectangleCorners.BottomLeft)
            {
                path.AddArc(x, num9, num7, num7, 90f, 90f);
            }
            else
            {
                path.AddLine(num5, num2, x, num2);
                path.AddLine(x, num2, x, num4);
            }
            path.AddLine(x, num4, x, num6);
            path.CloseFigure();
            return path;
        }

        // Nested Types
        public enum RectangleCorners
        {
            None = 0,
            TopLeft = 1,
            TopRight = 2,
            BottomLeft = 4,
            BottomRight = 8,
            All = 15
        }
    }
}
