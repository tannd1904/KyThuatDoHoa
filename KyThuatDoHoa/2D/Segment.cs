using KyThuatDoHoa._2D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa
{
    class Segment:Shape
    {
        Point first;
        Point last;
        //List< Point> list;
        //float k;

        public Segment(Point first, Point last)
        {
            if (first.D3)
            {
                First = new Point(0, 0, 0);
                Last = new Point(0, 0, 0);
                First.X = first.X - Convert.ToInt32(Math.Ceiling(first.Z * 0.5));
                First.Y = first.Y - Convert.ToInt32(Math.Ceiling(first.Z * 0.5));
                Last.X = last.X - Convert.ToInt32(Math.Ceiling(last.Z * 0.5));
                Last.Y = last.Y - Convert.ToInt32(Math.Ceiling(last.Z * 0.5));
            }
            else
            {
                First = first;
                Last = last;
            }
            //List = new List< Point>();
            try
            {
                if (First.X != Last.X)
                {
                    List.Add( First);
                    List.Add( Last);
                }
                else
                {
                    List.Add( First);
                    List.Add( Last);
                }    
            }
            catch(Exception)
            { 
            
            }
            this.Draw(First, Last);
        }
        public static double Distant(Point p1, Point p2)
        {
            return Math.Pow(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2), 0.5);
        }
        private void Bresenham(int x1,int x2,int y1, int y2,double k,bool type = false)
        {
            int Dx = x2 - x1;
            int Dy = y2 - y1;
            int P = 2 * Dy - Dx;
            int y = y1;
            double yr = Convert.ToDouble(y);
            try
            {
                for (int i = x1 + 1; i < x2; i++)
                {
                    yr += k;
                    y = Convert.ToInt32(yr);
                    if (P < 0)
                    {
                        P += 2 * Dy;
                    }
                    else
                    {
                        P += (2 * Dy - 2 * Dx);
                    }
                    if(type)
                        List.Add(new Point(y, i));
                    else
                        List.Add(new Point(i, y));
                }
            }
            catch(Exception)
            { }
            
        }
        private double TinhK(Point first1, Point last1)
        {
            return Convert.ToDouble(1.0 * (first1.Y - last1.Y) / (first1.X - last1.X));
        }
        public void Draw(Point first1, Point last1)
        {

            
            if(first1.X == last1.X)
            {
                int i = first1.Y;
                while(i!=last1.Y)
                {
                    if (first1.Y > last1.Y)
                        i--;
                    else
                        i++;
                    try
                    {
                        List.Add( new Point(first1.X, i));
                    }
                    catch (Exception)
                    { }
                }
                return;
            }
            else
            {
                double k = TinhK(first1, last1);
                int x1, x2, y1, y2;
                bool type = false;
                if (k > 1)
                {
                    type = true;
                    k = 1.0 / k;
                    if (first1.X > last1.X)
                    {
                       
                        x1 = last1.Y;
                        x2 = first1.Y;
                        y1 = last1.X;
                        y2 = first1.X;
                    }   
                    else
                    {
                        x2 = last1.Y;
                        x1 = first1.Y;
                        y2 = last1.X;
                        y1 = first1.X;
                    }    
                }
                else if (k >= 0 && k <= 1)
                {
                    //k = 1-k;
                    if (first1.X > last1.X)
                    {

                        y1 = last1.Y;
                        y2 = first1.Y;
                        x1 = last1.X;
                        x2 = first1.X;
                    }
                    else
                    {
                        y2 = last1.Y;
                        y1 = first1.Y;
                        x2 = last1.X;
                        x1 = first1.X;
                    }
                }
                else if (k >= -1 && k <0 )
                {
                    //k = -1* k;
                    if (first1.X > last1.X)
                    {

                        y1 = last1.Y;
                        y2 = first1.Y;
                        x1 = last1.X;
                        x2 = first1.X;
                    }
                    else
                    {
                        y2 = last1.Y;
                        y1 = first1.Y;
                        x2 = last1.X;
                        x1 = first1.X;
                    }
                }
                else
                {
                    type = true;
                    k = 1.0 / k;
                    if (first1.X > last1.X)
                    {

                        x2 = last1.Y;
                        x1 = first1.Y;
                        y2 = last1.X;
                        y1 = first1.X;
                    }
                    else
                    {
                        x1 = last1.Y;
                        x2 = first1.Y;
                        y1 = last1.X;
                        y2 = first1.X;
                    }
                }
                Bresenham(x1, x2, y1, y2, k,type);
            }
            
        }
        public void Show(Graphics g,Coor O,bool dut = false)
        {
            try
            {
                first.Show(g,O);
                last.Show(g, O);
                foreach (Point p in List)
                    if (dut)
                        p.Show(g, Descart.Point, O, Form1.PX / 2);
                    else
                        p.Show(g, O);    
            }
            catch (Exception) { }
        }
        public void Hide(Graphics g, Coor O)
        {
            try
            {
                first.Hide(g, O);
                last.Hide(g,O);
                foreach (Point p in List)
                    p.Hide(g, O);
            }
            catch (Exception) { }
        }
        public new  void PhepQuay(double alpha)
        {
            List.Clear();
            First.PhepQuay(alpha);
            Last.PhepQuay(alpha);
            List.Add(First);
            List.Add(Last);
            this.Draw();
        }
        public new  void PhepTyLe(double x)
        {
            List.Clear();
            First.PhepTyLe(x,x);
            Last.PhepTyLe(x,x);
            List.Add(First);
            List.Add(Last);
            this.Draw();
        }
        public new void PhepQuay(int alpha)
        {


            PhepQuay((1.0 * alpha / 180) * Math.PI);
        }
        public void Draw()
        {
            Draw(First, Last);
        }
        internal Point First { get => first; set => first = value; }
        internal Point Last { get => last; set => last = value; }
        //internal List< Point> List { get => base.List; set => base.List = value; }
    }
}
