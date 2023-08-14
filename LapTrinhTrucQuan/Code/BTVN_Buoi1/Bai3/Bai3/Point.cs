using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Point
    {
        private double x;
        private double y;  

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void Nhap()
        {
            Console.WriteLine("Nhap x: "); 
            this.x = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap y: ");
            this.y = double.Parse(Console.ReadLine());
        }

        public void In()
        {
            Console.WriteLine("(" + this.x + ", " + this.y + ")");
        }

        public double KhoangCach(Point p)
        {
            return Math.Sqrt(Math.Pow((this.x - p.x), 2) + Math.Pow((this.y - p.y), 2));
        } 
    }
}
