using KyThuatDoHoa._2D;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa._3D
{
    class Cube
    {
        private Point a, b, c, d, a1, b1, c1, d1;
        private int canh;
        private List<Segment> nega = new List<Segment>();
        private List<Segment> pose = new List<Segment>();
        public Cube(Point a, int canh)
        {
            this.A = a;
            A.Name = "A";
            this.Canh = canh;
            B = new Point(A.X, A.Y+Canh, A.Z,"B");
            C = new Point(A.X+Canh, A.Y + Canh, A.Z,"C");
            D = new Point(A.X+Canh, A.Y, A.Z,"D");
            E = new Point(A.X, A.Y , A.Z + Canh, "E");
            F = new Point(A.X, A.Y + Canh, A.Z + Canh, "F");
            G = new Point(A.X + Canh, A.Y + Canh, A.Z + Canh, "G");
            H = new Point(A.X + Canh, A.Y, A.Z + Canh, "H");
            nega.Add(new Segment(A, E));

            nega.Add(new Segment(A, B));
            nega.Add(new Segment(A, D));

            pose.Add(new Segment(B, C));
            pose.Add(new Segment(D, C));

            pose.Add(new Segment(B, F));
            pose.Add(new Segment(G, C));
            pose.Add(new Segment(D, H));

            pose.Add(new Segment(E, F));
            pose.Add(new Segment(F, G));
            pose.Add(new Segment(G, H));
            pose.Add(new Segment(H, E));

        }
        public void Show(Graphics g,Coor O)
        {
            foreach(Segment n in nega)
            {
                n.Show(g, O, true);
            }
            foreach (Segment n in pose)
            {
                n.Show(g, O);
            }
        }

        public int Canh { get => canh; set => canh = value; }
        internal Point A { get => a; set => a = value; }
        internal Point B { get => b; set => b = value; }
        internal Point C { get => c; set => c = value; }
        internal Point D { get => d; set => d = value; }
        internal Point E { get => a1; set => a1 = value; }
        internal Point F { get => b1; set => b1 = value; }
        internal Point G { get => c1; set => c1 = value; }
        internal Point H { get => d1; set => d1 = value; }
    }
}
