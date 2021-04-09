﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTDH_2020.Construct.DefineType;

namespace KTDH_2020.Construct._2DObject
{
    public class HinhTron : Shapes2DObject, INotifyPropertyChanged
    {
        private Point point;
        private int radius;
        private Color color;

        public Point Point { get => point;
            set
            {
                if(value != point)
                {
                    point = value;
                    OnPropertyChanged("point");
                }
            }
        }
        
        public int Radius { get => radius;
            set
            {
                if(value != radius)
                {
                    radius = value;
                    OnPropertyChanged("radius");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public void Drawn8Point( int x,int y, Graphics g, Color color)
        {
            ToaDo.HienThi(x + point.X, y + point.Y, g, color);
            ToaDo.HienThi(y + point.X, x + point.Y, g, color);
            ToaDo.HienThi(-x + point.X, -y + point.Y, g, color);
            ToaDo.HienThi(-y + point.X, -x + point.Y, g, color);
            ToaDo.HienThi(-x + point.X, y + point.Y, g, color);
            ToaDo.HienThi(-y + point.X, x + point.Y, g, color);
            ToaDo.HienThi(x + point.X, -y + point.Y, g, color);
            ToaDo.HienThi(y + point.X, -x + point.Y, g, color); 
        }

        public HinhTron( Point tamht, int bk, Color m)
        {           
            Radius = bk*5;
            point = new Point(tamht.X, tamht.Y);
            color = m;
        }

        public HinhTron(Point point,int R)
        {
            this.point = point;
            this.radius = R * 5;
            this.color = Color.Black;
        }
        public void Draw(Graphics g)
        {
            int x = 0,
             y = Radius,
             p = 3 - 2 * Radius;
            while (x <= y)
            {
                if (p < 0)
                    p = p + 4 * x - 6;
                else
                {
                    y -= 5;
                    p = p + 4 * (x - y) + 10;
                }
                Drawn8Point( x, y, g, color);
                x += 5;
            }
        }


        public void Draw_W_Color_Line(Graphics g, Color color)
        {
            int x = 0,
             y = Radius,
             p = 3 - 2 * Radius;
            while (x <= y)
            {
                if (p < 0)
                    p = p + 4 * x - 6;
                else
                {
                    y -= 5;
                    p = p + 4 * (x - y) + 10;
                }
                Drawn8Point(x, y, g, color);
                x += 5;
            }
        }

        public void Draw(Graphics g, Color c)
        {
            FillColor(g, c);
            int x = 0,
             y = Radius,
             p = 3 - 2 * Radius;
            while (x <= y)
            {
                if (p < 0)
                    p = p + 4 * x - 6;
                else
                {
                    y -= 5;
                    p = p + 4 * (x - y) + 10;
                }
                Drawn8Point(x, y, g, color);
                x += 5;
            }
        }

        public void DrawWithFill(Graphics g, Color c)
        {
            FillColor(g, c);
            int x = 0,
             y = Radius,
             p = 3 - 2 * Radius;
            while (x <= y)
            {
                if (p < 0)
                    p = p + 4 * x - 6;
                else
                {
                    y -= 5;
                    p = p + 4 * (x - y) + 10;
                }
                Drawn8Point(x, y, g, color);
                x += 5;
            }
            FillColor(g, c);
        }

        private void FillColor(Graphics g, Color c)
        {
            //Point p = ToaDo
            g.FillEllipse(new SolidBrush(c), this.point.X - radius, this.point.Y - radius, radius * 2 + 3, radius * 2 + 3);
        }

        public void Init(Point start, Point end, Size sizeOfLine, Color color)
        {
            throw new NotImplementedException();
        }

        public void Rotate(Point p, double alpha)
        {
            throw new NotImplementedException();
        }

        public void Scale(SizeF scaleSize)
        {
            throw new NotImplementedException();
        }

        public void Shifting(int dx, int dy)
        {
            this.Point = this.Point.Translate(dx, dy);
        }

        public void Symmetry(Point orgin, SymmetryMode mode)
        {
            throw new NotImplementedException();
        }

        public void Shifting(Point pDest)
        {
            throw new NotImplementedException();
        }
    }
}
