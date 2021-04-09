using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa._2D
{
     class Shape
    {
        private List<Point> list = new List<Point>();

        public List<Point> List { get => list; set => list = value; }
        public void PhepTinhTien(int x, int y, int z = 0)
        {
            foreach (Point p in List)
            {
                p.PhepTinhTien(x, y, z);
            }
        }
        public void PhepTyLe(double x)
        {
            foreach (Point p in List)
            {
                p.PhepTyLe(x, x, 0);
            }
        }
        public void PhepTyLe(double x, double y, double z = 0)
        {
            foreach (Point p in List)
            {
                p.PhepTyLe(x, y, z);
            }
        }
        public void PhepTyLe( Point tamtyle,double x, double y, double z = 0)
        {
            foreach (Point p in List)
            {
                p.PhepTyLe(x, y, z);
                p.PhepTinhTien(tamtyle.X, tamtyle.Y, tamtyle.Z);
            }
        }
        public  void PhepQuay(double alpha)
        {
            
            foreach (Point p in List)
            {
                p.PhepQuay(alpha);
               
            }
        }
        public  void PhepQuay(int alpha)
        {

            
            PhepQuay((1.0 * alpha / 180) * Math.PI);
        }
        public  void PhepQuay(Point tamquay,double alpha)
        {
            foreach (Point p in List)
            {
                p.PhepQuay(alpha);
                p.PhepTinhTien(tamquay.X, tamquay.Y, tamquay.Z);
            }
        }
        public void PhepDoiXungO()
        {
            foreach (Point p in List)
            {
                p.PhepDoiXungO();

            }
        }
        public void PhepDoiXungOx()
        {
            foreach (Point p in List)
            {
                p.PhepDoiXungOx();

            }
        }
        public void PhepDoiXungOy()
        {
            foreach (Point p in List)
            {
                p.PhepDoiXungOy();

            }
        }
    }
}
