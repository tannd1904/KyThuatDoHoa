using KyThuatDoHoa._2D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa._3D
{
    class Sphere
    {
        private Point o;
        private double r;
        private Circle c1;
        private Elip e1;
        private Elip e2;

        public Sphere(Point o, double r)
        {
            this.O = o;
            this.R = r;
            int x1 =  O.X - Convert.ToInt32(Math.Ceiling(O.Z * 0.5));
            int y1 = O.Y - Convert.ToInt32(Math.Ceiling(O.Z * 0.5));
            Point O1 = new Point(x1, y1);
            c1 = new Circle(O1, R);
            E1 = new Elip(O1, Convert.ToInt32(R / 3), Convert.ToInt32(R));
            E2 = new Elip(O1, Convert.ToInt32(R ), Convert.ToInt32(R/3));
        }
        public void Show(Graphics g,Coor O)
        {
            this.O.Show(g, O);
            this.C1.Show(g, O);
            this.E1.Show1(g, O);
            this.E2.Show2(g, O);
        }

        public double R { get => r; set => r = value; }
        internal Point O { get => o; set => o = value; }
        internal Circle C1 { get => c1; set => c1 = value; }
        internal Elip E1 { get => e1; set => e1 = value; }
        internal Elip E2 { get => e2; set => e2 = value; }
    }
}
