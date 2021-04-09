using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa._2D
{
    class Square:Shape
    {
        private Point goc1;
        private int canhDai;
        private int canhNgan;
        private Point goc2, goc3, goc4;
        private List<Segment> listCanh = new List<Segment>();
        public Square( Point goc, int canhDai, int canhNgan)
        {
            a = canhDai;
            b = canhNgan;
            A = goc;
            B = new Point(A.X, A.Y + a);
            C = new Point(A.X+b, A.Y + a);
            D = new Point(A.X+b, A.Y);
            ListCanh.Add(new Segment(A, B));
            ListCanh.Add(new Segment(B, C));
            ListCanh.Add(new Segment(C, D));
            ListCanh.Add(new Segment(D, A));
            foreach(Segment s in ListCanh)
            {
                List.AddRange(s.List);
            }
            Remove();
        }
        private void Remove()
        {
            List.Remove(A);
            List.Remove(B);
            List.Remove(C);
            List.Remove(D);
        }
        public Square( Point goc, int canhNgan)/*Hình vuông*/
        {
            a = canhNgan;
            b = canhNgan;
            A = goc;
            B = new Point(A.X, A.Y + a);
            C = new Point(A.X + a, A.Y + a);
            D = new Point(A.X + a, A.Y);
            ListCanh.Add(new Segment(A, B));
            ListCanh.Add(new Segment(B, C));
            ListCanh.Add(new Segment(C, D));
            ListCanh.Add(new Segment(D, A));
            foreach (Segment s in ListCanh)
            {
                List.AddRange(s.List);
            }
            Remove();
        }
        public Square(Point goc, Point p2,bool hv=false)
        {
            
            A = goc;
            a = Math.Abs(p2.X - goc.X);
            b = Math.Abs(p2.Y - goc.Y);
            if (hv)
            {
                if (a > b)
                {
                    b = a;
                    if(p2.Y - goc.Y < 0)
                        C = new Point(p2.X, A.Y - a);
                    else
                        C = new Point(p2.X, A.Y + a);
                }
                else if (a == b)
                {
                   
                    C = new Point(p2.X, p2.Y);
                }
                else
                {
                    a = b;
                    if (p2.X - goc.X < 0)
                        C = new Point(A.X-a,p2.Y);
                    else
                        C = new Point(A.X + a, p2.Y);
                }
                B = new Point(A.X, C.Y);
                //C = new Point(A.X + b, A.Y + a);
                D = new Point(C.X, A.Y);
            }
            else
            {
                C = new Point(p2.X, p2.Y);
                B = new Point(A.X, C.Y);
                
                D = new Point(C.X, A.Y);
            }
            ListCanh.Add(new Segment(A, B));
            ListCanh.Add(new Segment(B, C));
            ListCanh.Add(new Segment(C, D));
            ListCanh.Add(new Segment(D, A));
            foreach (Segment s in ListCanh)
            {
                List.AddRange(s.List);
            }
            Remove();
        }
        public void Show(Graphics g, Coor Ox)
        {
            try
            {
                
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
            ListCanh.Clear();
            A.PhepQuay(alpha);
            B.PhepQuay(alpha);
            C.PhepQuay(alpha);
            D.PhepQuay(alpha);
            ListCanh.Add(new Segment(A, B));
            ListCanh.Add(new Segment(B, C));
            ListCanh.Add(new Segment(C, D));
            ListCanh.Add(new Segment(D, A));
            foreach (Segment s in ListCanh)
            {
                List.AddRange(s.List);
            }
            Remove();
        }
       /* public void PhepTinhTien(int x, int y, int z = 0)
        {
            List.Clear();
            ListCanh.Clear();
            A.PhepTinhTien(x, y, z);
            B.PhepTinhTien(x, y, z);
            C.PhepTinhTien(x, y, z);
            D.PhepTinhTien(x, y, z);
            ListCanh.Add(new Segment(A, B));
            ListCanh.Add(new Segment(B, C));
            ListCanh.Add(new Segment(C, D));
            ListCanh.Add(new Segment(D, A));
            foreach (Segment s in ListCanh)
            {
                List.AddRange(s.List);
            }
        }*/
        public new void PhepTyLe(double x)
        {
            List.Clear(); 
            ListCanh.Clear();
            A.PhepTyLe(x, x);
            B.PhepTyLe(x, x);
            C.PhepTyLe(x, x);
            D.PhepTyLe(x, x);
            ListCanh.Add(new Segment(A, B));
            ListCanh.Add(new Segment(B, C));
            ListCanh.Add(new Segment(C, D));
            ListCanh.Add(new Segment(D, A));
            foreach (Segment s in ListCanh)
            {
                List.AddRange(s.List);
            }
            Remove();
        }
        public new void PhepQuay(int alpha)
        {


            PhepQuay((1.0 * alpha / 180) * Math.PI);
        }
        public int a { get => canhDai; set => canhDai = value; }
        public int b { get => canhNgan; set => canhNgan = value; }
        internal Point A { get => goc1; set => goc1 = value; }
        internal Point B { get => goc2; set => goc2 = value; }
        internal Point C { get => goc3; set => goc3 = value; }
        internal Point D { get => goc4; set => goc4 = value; }
        internal List<Segment> ListCanh { get => listCanh; set => listCanh = value; }
    }
}
