using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa
{
    abstract class Descart
    {
        protected Graphics g;
        protected Coor o;
        protected int minx;
        protected int miny;
        protected int maxx;
        protected int maxy;
        private static Color backColor;
        private static readonly Color vec = Color.Orange;
        private static readonly Color ruler = Color.White;
        private static readonly Color point = Color.Green;

        public Descart()
        {
        }
        public void Reset()
        {
            for(int i=0;i<minx+maxx;i++)
            {
                g.DrawLine(new Pen(BackColor), i, 0, i, maxy + miny);
            }    
        }
        

        public Graphics G { get => g; set => g = value; }
        public int MinX { get => minx; set => minx = value; }
        public int MinY { get => miny; set => miny = value; }
        public int MaxX { get => maxx; set => maxx = value; }
        public int MaxY { get => maxy; set => maxy = value; }
        internal Coor O { get => o; set => o = value; }

        public static Color Point => point;

        public static Color Ruler => ruler;

        public static Color Vec => vec;

        public static Color BackColor { get => backColor; set => backColor = value; }
    }
}
