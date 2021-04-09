using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa._2D
{
    class Elip:Shape
    {
        private Point o;

        public Elip(Point o, int a, int b)
        {
            this.O = o;
            this.A = a;
            this.b = b;
            this.MidPoint();
            this.Move();
            List.Add(O);
        }
        private void MidPoint()
        {
            double P = Math.Pow(B, 2) - Math.Pow(A, 2) * B + Math.Pow(A, 2) / 4;
            int y = B;
            int x = 0;
            int Dx = 0;
            int Dy = 2 * A*A * y;
            Point p1 = new Point(x, y);
            List.Add(p1);
            Clone(p1);
            while (Dx<Dy)
            {
                x++;
                Dx += 2 * B*B;
                if (P<0)
                {
                    P += (Math.Pow(B, 2) +Dx);
                }    
                else
                {
                    y--;
                    Dy -= 2 * A*A;
                    P += (Math.Pow(B, 2) + Dx - Dy);
                   
                }
                Point p = new Point(x, y);
                List.Add(p);
                Clone(p);
            }
            double Q = Math.Pow(B, 2) * Math.Pow(( x + 0.5f), 2) + Math.Pow(A, 2) * Math.Pow(( y - 1), 2) - Math.Pow(B, 2) * Math.Pow(A, 2);
            while (y > 0)
            {
                y --;
                Dy -= A*A * 2;
                if (Q < 0)
                {
                    x++;
                    Dx += B *B* 2;
                    Q += (Math.Pow(A, 2) - Dy + Dx);
                   
                }
                else
                {
                    Q += (Math.Pow(A, 2) - Dy);
                    
                }
                Point p = new Point(x, y);
                List.Add(p);
                Clone(p);
            }    
        }
        public void Move()
        {
            foreach (Point p in List)
            {
                p.X += O.X;
                p.Y = O.Y - p.Y;
            }
        }
        public void Show(Graphics g, Coor Ox)
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
        public void Show1(Graphics g, Coor Ox)
        {
            try
            {
                O.Show(g, Ox);
                foreach (var item in base.List)
                {
                    if(item.X > O.X)
                        item.Show(g,Descart.Point, Ox,Form1.PX/2);
                    else
                    item.Show(g, Ox);
                }
            }
            catch (Exception) { }
        }
        public void Show2(Graphics g, Coor Ox)
        {
            try
            {
                O.Show(g, Ox);
                foreach (var item in base.List)
                {
                    if (item.Y > O.Y)
                        item.Show(g, Descart.Point, Ox, Form1.PX / 2);
                    else
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
        private void Clone(Point p)
        {
            List.Add(new Point(-1 * p.X, p.Y));
            List.Add(new Point(p.X, -1 * p.Y));
            List.Add(new Point(-1 * p.X, -1 * p.Y));
        }
        /*public void PhepQuay(double alpha)
        {
            List.Clear();
            O.PhepQuay(alpha);
            MidPoint();
            //Image();
            Move();
            List.Add(O);
        }*/
        public new void PhepTyLe(double x)
        {
            List.Clear();
            O.PhepTyLe(x, x);
            A =Convert.ToInt32(A* x);
            B = Convert.ToInt32(B * x);
            MidPoint();
            //Image();
            Move();
            List.Add(O);
        }
        /*public void PhepQuay(int alpha)
        {


            PhepQuay((1.0 * alpha / 180) * Math.PI);
        }*/
        private int a;
        private int b;

        internal Point O { get => o; set => o = value; }
        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
    }
}
