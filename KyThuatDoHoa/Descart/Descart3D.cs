using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa
{
    class Descart3D : Descart
    {
       
        private int minZ;
        private int maxZ;
        //public static double K = 99.0/62;
        public Descart3D(Graphics g, Coor o, int minx, int minz, int maxx, int maxz)
        {
            
            this.G = g;
            this.O = o;
            this.MinX = minx;
            this.MinY = minz;
            this.MaxX = maxx;
            this.MaxY = maxz;
           

            Pen pen = new Pen(Descart.Ruler);

            // Vẽ lưới 
            for (int i = O.X; i < MaxX; i += Form1.PX)
            {
                g.DrawLine(pen, i, 0, i, Math.Abs(MinY) + MaxY);
            }
            for (int i = O.X; i > MinX; i -= Form1.PX)
            {
                g.DrawLine(pen, i, 0, i, Math.Abs(MinY) + MaxY);
            }
            for (int i = O.Y; i < MaxY; i += Form1.PX)
            {
                g.DrawLine(pen, 0, i, Math.Abs(MinX) + MaxX, i);
            }
            for (int i = O.Y; i > MinY; i -= Form1.PX)
            {
                g.DrawLine(pen, 0, i, Math.Abs(MinX) + MaxX, i);
            }
            pen = new Pen(Descart.Vec);
            g.DrawLine(pen, O.X,0, O.X, O.Y);
            g.DrawLine(pen, O.X, O.Y, Math.Abs(MinX) + MaxX, O.Y);
            g.DrawLine(pen, O.X, O.Y, 0, Math.Abs(MinY) + MaxY);
            SolidBrush brush = new SolidBrush(Descart.Vec);
            for (int i = 0; i < 6; i++)
            {
                g.FillRectangle(brush, O.X + i, i, 1, 1);
            }
            for (int i = 0; i < 6; i++)
            {
                g.FillRectangle(brush, O.X - i, i, 1, 1);
            }
            for (int i = 0; i < 6; i++)
            {
                g.FillRectangle(brush, Math.Abs(MinX) + MaxX - i, O.Y - i, 1, 1);

            }
            for (int i = 0; i < 6; i++)
            {
                g.FillRectangle(brush, Math.Abs(MinX) + MaxX - i, O.Y + i, 1, 1);
            }


        }

       
        public int MinZ { get => minZ; set => minZ = value; }
        public int MaxZ { get => maxZ; set => maxZ = value; }
    }
}
