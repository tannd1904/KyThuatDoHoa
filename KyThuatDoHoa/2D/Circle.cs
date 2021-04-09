using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa._2D
{
    class Circle:Shape
    {
        Point o;
        double r;
        //List<Point> list = new List<Point>();
        public Circle(Point cent, double r)
        {
            this.O = cent;
            R = r;
            //List.Add(O);
            //Bresenham();
            MidPoint();
            //Image();
            Move();
            List.Add(O);
        }
        private void MidPoint()
        {
            int x = 0;
            int y = Convert.ToInt32(R) ;
            int maxX = Convert.ToInt32(Math.Sqrt(2) / 2 * R);
            // int maxX = Math.Sqrt(2) / 2 * R;
            double P = 1 - R;
            
            while (x <= maxX)
            {
                if (P < 0) 
                    P += 2 * x + 3;
                else 
                { 
                    P += 2 * (x - y) + 5; 
                    y --; 
                }
                Point p = new Point(x, y);
                List.Add(p);
                Clone(p);
                x ++;
                
            }
        }
        private void Bresenham()
        {
            double P = 3 - 2 * R;
            //int x = 0;
            int y = Convert.ToInt32(Math.Floor(R));
            int max = Convert.ToInt32(Math.Floor(R) *Math.Pow(2,0.5)/2);
            try
            {
                for (int x = 0; x <= max; x++)
                {
                    if (P < 0)
                    {
                        P += (4 * x + 6);
                    }
                    else
                    {
                        y--;
                        P += (4 * (x - y) + 10);
                        
                    }
                    Point p = new Point(x, y);
                    List.Add(p);
                    Clone(p);
                }
            }
            catch(Exception)
            {

            }
        }
        private void Clone(Point p)
        {
            
                List.Add(new Point(-1*p.X, p.Y));
                List.Add(new Point(p.X, -1 * p.Y));
                List.Add(new Point(-1 * p.X, -1 * p.Y));
                List.Add(new Point(p.Y, p.X));
                List.Add(new Point(-1 * p.Y, p.X));
                List.Add(new Point(p.Y, -1 * p.X));
                List.Add(new Point(-1 * p.Y,-1 * p.X));
            
        }
        public void Move()
        {
            foreach (Point p in List)
            {
                p.X += O.X;
                p.Y = O.Y -p.Y;
            }
        }
        public void Show(Graphics g,Coor Ox)
        {
            try
            {
                O.Show(g, Ox);
                foreach (var item in base.List)
                {
                    item.Show(g, Ox);
                }
            }
            catch (Exception) { }
        }
        public void Hide(Graphics g, Coor Ox)
        {
            try
            {
                O.Hide(g, Ox);
                foreach (var item in base.List)
                {
                    item.Hide(g, Ox);
                }
            }
            catch (Exception) { }
        }
        public new void PhepQuay(double alpha)
        {
            List.Clear();
            O.PhepQuay(alpha);
            MidPoint();
            //Image();
            Move();
            List.Add(O);
        }
        public new void PhepTyLe(double x)
        {
            List.Clear();
            O.PhepTyLe(x,x);
            R *= x;
            MidPoint();
            //Image();
            Move();
            List.Add(O);
        }
        public new void PhepQuay(int alpha)
        {


            PhepQuay((1.0 * alpha / 180) * Math.PI);
        }
        internal Point O { get => o; set => o = value; }
        public double R { get => r; set => r = value; }
        //internal List<Point> List { get => base.List; set => base.List = value; }
    }
}
