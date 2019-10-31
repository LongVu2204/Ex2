using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyPoint
    {
        private int X, Y;

        public MyPoint()
        {
            this.X = this.Y = 0;
        }

        public MyPoint(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
        public void SetX(int newX)
        {
            this.X = newX;
        }

        public void SetY(int newY)
        {
            this.Y = newY;
        }

        public int[] GetXY()
        {
            return new int[] { this.X, this.Y };                         
        }

        public void SetXY(int newX, int newY)
        {
            this.X = newX;
            this.Y = newY;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1})", this.X, this.Y);
        }

        public double Distance(int X, int Y)
        {
            return Math.Sqrt(Math.Pow(this.X - X, 2) + Math.Pow(this.Y - Y, 2));
        }

        public double Distance(MyPoint point)
        {
            return Distance(point.GetX(), point.GetY());
        }

        public double Distance()
        {
            return Distance(0, 0);
        }
    }
}