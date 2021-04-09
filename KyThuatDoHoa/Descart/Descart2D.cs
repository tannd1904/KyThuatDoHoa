using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa
{
    class Descart2D :Descart
    {
        public Descart2D(Graphics g, Coor o, int minx, int miny, int maxx, int maxy)
        {
            
            this.G = g;
            this.O = o;
            this.MinX = minx;
            this.MinY = miny;
            this.MaxX = maxx;
            this.MaxY = maxy;

            Pen pen = new Pen(BackColor);
            g.DrawLine(pen, O.X, O.Y, 0, Math.Abs(MinY) + MaxY);
            pen = new Pen(Descart.Ruler);

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

            g.DrawLine(pen, O.X, 0, O.X, Math.Abs(MinY) + MaxY);
            g.DrawLine(pen, 0, O.Y, Math.Abs(MinX) + MaxX, O.Y);
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
    }
}
