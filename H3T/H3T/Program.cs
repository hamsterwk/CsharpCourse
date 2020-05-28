using System;

namespace H3T
{
    public class Point
    {
        public double x, y;
        public Point(double _x, double _y)
        {
            x = _x; y = _y;
        }
        public static Point operator -(Point a, Point b)
        {
            return new Point( a.x - b.x, a.y - b.y);
        }
        public static double operator *(Point a,Point b)
        {
            return a.x * b.y - a.y * b.x;
        }
    }


    interface ShapeInterface
    {
        double getArea();
        bool isValid();
    }
    public abstract class Shape
    {
        public int pointCnt=1;
        public Point[] pointArray = new Point[4];
    }
    class Rectangle:Shape,ShapeInterface
    {
        new public int pointCnt = 4;
        public Rectangle() { }
        public Rectangle(Point[] P)
        {
            for (int i = 0; i < 4; i++) pointArray[i] = P[i];
        }
        double ShapeInterface.getArea()
        {
            double rtn = 0;
            Point height = pointArray[0] - pointArray[1];
            Point width = pointArray[2] - pointArray[1];
            rtn = height * width;
            if (rtn < 0) rtn = -rtn;
            return rtn;
        }
        bool ShapeInterface.isValid()
        {
            if(pointCnt != 4) { return false; }
            Point a = pointArray[0] - pointArray[1];
            Point b = pointArray[3] - pointArray[2];
            if (a.x != b.x || a.y!= b.y) return false;
            b = pointArray[2] - pointArray[1];
            if (a.x * b.x + a.y * b.y == 0) return true;
            else return false;
        }

    }

    class Square : Rectangle,ShapeInterface
    {

        public Square(Point[] P)
        {
            for (int i = 0; i < 4; i++) pointArray[i] = P[i];
        }
        double ShapeInterface.getArea()
        {
            Point height = pointArray[0] - pointArray[1];
            return (height.x*height.x)+(height.y*height.y);
        }
        bool ShapeInterface.isValid()
        {
            if (pointCnt != 4) { return false; }
            Point a = pointArray[0] - pointArray[1];
            Point b = pointArray[3] - pointArray[2];
            if (a.x != b.x || a.y != b.y) return false;
            b = pointArray[2] - pointArray[1];
            if (a.x * b.x + a.y * b.y != 0) return false;
            double lenA = a.x * a.x + a.y * a.y;
            double lenB = b.x * b.x + b.y * b.y;
            return lenA == lenB;
        }
    }
    class Triangle : Shape, ShapeInterface
    {
        new public int pointCnt = 3;
        public Triangle(Point[] P)
        {
            for (int i = 0; i < 3; i++) pointArray[i] = P[i];
        }
        double ShapeInterface.getArea()
        {
            Point A = pointArray[2] - pointArray[1];
            Point B = pointArray[1] - pointArray[0];
            double rtn = A * B;
            if (rtn < 0) rtn = -rtn;
            return rtn;
        }
        bool ShapeInterface.isValid()
        {
            if (pointCnt != 4) { return false; }
            Point a = pointArray[0] - pointArray[1];
            Point b = pointArray[0] - pointArray[2];
            return a * b != 0;
        }
    }
    public class ShapeF
    {
        public static Shape CreateShape(string type)
        {
            Shape rtn = null;
            Random rd = new Random();
            if (type == "Rectangle")
            {
                double x1 = rd.Next(), x2 = rd.Next();
                double y1 = rd.Next(), y2 = rd.Next();
                if (x1 > x2) { double tmp = x1;x1 = x2;x2 = tmp; }
                if (y1 > y2) { double tmp = y1;y1 = y2;y2 = tmp; }
                Point[] pSet = { new Point(x1, y1), new Point(x2, y1), new Point(x2, y2), new Point(x1, y2) };
                rtn = new Rectangle(pSet);
            }else if (type == "Square")
            {
                double x1 = rd.Next(),y1=rd.Next(),width=rd.Next();
                Point[] pSet = { new Point(x1, y1), new Point(x1 + width, y1), new Point(x1 + width, y1 + width), new Point(x1, y1 + width) };
                rtn = new Square(pSet);
            }else if (type == "Triangle")
            {
                Point[] pSet = new Point[3];
                for(int i = 0; i < 3; i++)
                {
                    pSet[i] = new Point(rd.Next(), rd.Next());
                }
                rtn = new Triangle(pSet);
            }
            return rtn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle A = ShapeF.CreateShape("Rectangle");
            for (int i = 0; i < 4; i++){
                Console.WriteLine("(" + A.pointArray[i].x + ", " + A.pointArray[i].y + ")");
            }
            A.getArea();
        }
    }
}
