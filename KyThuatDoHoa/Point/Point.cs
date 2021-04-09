using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyThuatDoHoa
{

    class Point
    {
        private int x;
        private int y;
        private int z;
        private string name;

        private bool d3 ;
        
        public Point(int x,int y,string N="")
        {
            Name = N;
            D3 = false;
            X = x;
            Y = y;
        }
        public Point(int x, int y,int z, string N = "")
        {
            Name = N;
            D3 = true;
            X = x;
            Y = y;
            Z = z;
        }
        public void Show(Graphics g,Color c,Coor O,int size = 5)
        {   if(!D3)
            {
                SolidBrush brush = new SolidBrush(c);
                g.FillRectangle(brush, O.X + X * Form1.PX - Form1.PX / 2, O.Y - Y * Form1.PX - Form1.PX / 2, size, size);
            }
            else
            {
                SolidBrush brush = new SolidBrush(c);
                g.FillRectangle(brush, O.X + X * Form1.PX - Form1.PX / 2 - Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Form1.PX, O.Y - Y * Form1.PX - Form1.PX / 2 + Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Form1.PX, size, size);
            }
        }
        public void Show(Graphics g,  Coor O)
        {
            if (!D3)
            {
                SolidBrush brush = new SolidBrush(Descart.Point);
                g.FillRectangle(brush, O.X + X * Form1.PX - Form1.PX / 2, O.Y - Y * Form1.PX - Form1.PX / 2, Form1.PX, Form1.PX);
            }
            else
            {
                SolidBrush brush = new SolidBrush(Descart.Point);
                g.FillRectangle(brush, O.X + X * Form1.PX - Form1.PX / 2-Convert.ToInt32(Math.Ceiling(Z *0.5))* Form1.PX, O.Y - Y * Form1.PX - Form1.PX / 2 + Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Form1.PX, Form1.PX, Form1.PX);
            }    

        }
        public void Hide(Graphics g,  Coor O)
        {
            if (!D3)
            {
                SolidBrush brush = new SolidBrush(Descart.BackColor);
                g.FillRectangle(brush, O.X + X * Form1.PX - Form1.PX / 2, O.Y - Y * Form1.PX - Form1.PX / 2, Form1.PX / 2, Form1.PX / 2);
                g.FillRectangle(brush, O.X + X * Form1.PX +1, O.Y - Y * Form1.PX - Form1.PX / 2, Form1.PX / 2, Form1.PX / 2);
                g.FillRectangle(brush, O.X + X * Form1.PX - Form1.PX / 2, O.Y - Y * Form1.PX +1, Form1.PX / 2, Form1.PX / 2);
                g.FillRectangle(brush, O.X + X * Form1.PX + 1, O.Y - Y * Form1.PX +1, Form1.PX / 2, Form1.PX / 2);
                g.DrawLine(new Pen(Descart.Ruler), O.X + X * Form1.PX - Form1.PX / 2, O.Y - Y * Form1.PX, O.X + X * Form1.PX + Form1.PX / 2, O.Y - Y * Form1.PX);
                g.DrawLine(new Pen(Descart.Ruler), O.X + X * Form1.PX , O.Y - Y * Form1.PX - Form1.PX / 2, O.X + X * Form1.PX , O.Y - Y * Form1.PX + Form1.PX / 2);
                if(X ==0)
                {
                    g.DrawLine(new Pen(Descart.Vec), O.X + X * Form1.PX, O.Y - Y * Form1.PX - Form1.PX / 2, O.X + X * Form1.PX, O.Y - Y * Form1.PX + Form1.PX / 2);
                }
                if(Y==0)
                {
                    g.DrawLine(new Pen(Descart.Vec), O.X + X * Form1.PX - Form1.PX / 2, O.Y - Y * Form1.PX, O.X + X * Form1.PX + Form1.PX / 2, O.Y - Y * Form1.PX);
                }
            }
            else
            {
                SolidBrush brush = new SolidBrush(Descart.BackColor);
                g.FillRectangle(brush, O.X + X * Form1.PX - Form1.PX / 2, O.Y - Y * Form1.PX - Form1.PX / 2, Form1.PX / 2, Form1.PX / 2);
                g.FillRectangle(brush, O.X + X * Form1.PX + 1, O.Y - Y * Form1.PX - Form1.PX / 2, Form1.PX / 2, Form1.PX / 2);
                g.FillRectangle(brush, O.X + X * Form1.PX - Form1.PX / 2, O.Y - Y * Form1.PX + 1, Form1.PX / 2, Form1.PX / 2);
                g.FillRectangle(brush, O.X + X * Form1.PX + 1, O.Y - Y * Form1.PX + 1, Form1.PX / 2, Form1.PX / 2);
                g.DrawLine(new Pen(Descart.Ruler), O.X + X * Form1.PX - Form1.PX / 2, O.Y - Y * Form1.PX, O.X + X * Form1.PX + Form1.PX / 2, O.Y - Y * Form1.PX);
                g.DrawLine(new Pen(Descart.Ruler), O.X + X * Form1.PX, O.Y - Y * Form1.PX - Form1.PX / 2, O.X + X * Form1.PX, O.Y - Y * Form1.PX + Form1.PX / 2);
                if (X == 0&&Y>0)
                {
                    g.DrawLine(new Pen(Descart.Vec), O.X + X * Form1.PX, O.Y - Y * Form1.PX - Form1.PX / 2, O.X + X * Form1.PX, O.Y - Y * Form1.PX + Form1.PX / 2);
                }
                if (Y == 0&&X>0)
                {
                    g.DrawLine(new Pen(Descart.Vec), O.X + X * Form1.PX - Form1.PX / 2, O.Y - Y * Form1.PX, O.X + X * Form1.PX + Form1.PX / 2, O.Y - Y * Form1.PX);
                }
                if (Z == 0 && X > 0&&Y>0)
                {
                    g.DrawLine(new Pen(Descart.Vec), O.X + X * Form1.PX - Form1.PX / 2, O.Y - Y * Form1.PX + Form1.PX / 2, O.X + X * Form1.PX + Form1.PX / 2, O.Y - Y * Form1.PX - Form1.PX / 2);
                }
            }    

        }
        public static Point Convert_P2D(int x, int y,Coor  O)/*Chuyển đổi từ tọa độ Pixel sang Descart*/
        {
            return new Point(Convert.ToInt32(Math.Round(1.0 * (x - O.X) / Form1.PX)), Convert.ToInt32(Math.Round(1.0 * (O.Y - y) / Form1.PX)));
        }
        public static int Convert_P2D(int x, Coor O,int type)/*Chuyển đổi từ tọa độ Pixel sang Descart*/
        {
            if (type == -1) //X
                return Convert.ToInt32(Math.Round(1.0 * (x - O.X) / Form1.PX));
            else if (type == 0)//Y
                return Convert.ToInt32(Math.Round(1.0 * (O.Y - x) / Form1.PX));
            else
                return 0;
        }
        public static Coor Convert_D2P(int x, int y, Coor O)/*Chuyển đổi từ tọa độ Descart sang Pixel*/
        {
            return new Coor( x* Form1.PX+O.X, O.Y - y* Form1.PX);
        }
        public Label Show_Label(Coor O)
        {
            Label lb = new Label();
            Coor temp = Point.Convert_D2P(X, Y, O);
            string name1 = this.Name;
            if (name1.Equals(""))
                name1 = Form1.GetPointName();
            if (D3)
            {
                lb.Text = name1 + "(" + X + "," + Y + "," + Z + ")";
            }
            else
            {
                lb.Text = name1 + "(" + X + "," + Y + ")";
            }    
            int x1, y1;
            if (D3)
            {
                if (X >= 0 && Y >= 0)
                {
                    x1 = temp.X + 10 - Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Form1.PX;
                    y1 = temp.Y - 28 + Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Form1.PX;
                }
                else if (X >= 0 && Y < 0)
                {
                    x1 = temp.X + 10 - Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Form1.PX;
                    y1 = temp.Y + 28 + Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Form1.PX;
                }
                else if (X < 0 && Y < 0)
                {


                    x1 = temp.X - 10 - Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Form1.PX;
                    y1 = temp.Y + 28 + Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Form1.PX;
                }
                else

                {

                    x1 = temp.X - 10 - Convert.ToInt32(Math.Ceiling(Z * 0.5))*Form1.PX;
                    y1 = temp.Y - 28 + Convert.ToInt32(Math.Ceiling(Z * 0.5)) * Form1.PX;
                }
            }
            else
            {
                if (X >= 0 && Y >= 0)
                {
                    x1 = temp.X + 10;
                    y1 = temp.Y - 10;
                }
                else if (X >= 0 && Y < 0)
                {
                    x1 = temp.X + 10;
                    y1 = temp.Y + 10;
                }
                else if (X < 0 && Y < 0)
                {


                    x1 = temp.X - 10;
                    y1 = temp.Y + 10;
                }
                else

                {

                    x1 = temp.X - 10;
                    y1 = temp.Y - 10;
                }
            }
            lb.Location = new System.Drawing.Point(x1, y1);
            lb.Width = Convert.ToInt32(lb.Font.Size)*lb.Text.Length-10;
            return lb;
        }
        public static int Convert_D2P(int x, Coor O,int type)/*Chuyển đổi từ tọa độ Descart sang Pixel*/
        {
            if (type == -1)
                return x * Form1.PX + O.X;
            else if (type == 0)
                return O.Y - x * Form1.PX;
            else
                return 0;
        }
        public Matrix<double> GetMatrix()
        {
            if(D3)
            {
                return Matrix<double>.Build.DenseOfRowArrays(new[] { 1.0*X, Y, Z, 1 });
            }
            else
                return Matrix<double>.Build.DenseOfRowArrays(new[] { 1.0*X, Y, 1 });
        }
        public void PhepTinhTien(int x, int y,int z=0)
        {
            if(D3)

            {
                Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 0, 0,0 },
                                                                               { 0, 1, 0,0 },
                                                                               { 0, 0, 1,0 },
                                                                               { x,y, z,1 } });
                Matrix<double> result = this.GetMatrix().Multiply(matrix);
                X = Convert.ToInt32(result[0, 0]);
                Y = Convert.ToInt32(result[0, 1]);
                Z = Convert.ToInt32(result[0, 2]);
            }
            else
            { 
                Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(new[,] { { 1.0, 0, 0 },
                                                                                   { 0, 1, 0 },
                                                                                   { x,y, 1 } });
                Matrix<double> result = this.GetMatrix().Multiply(matrix);
                X = Convert.ToInt32(result[0, 0]);
                Y = Convert.ToInt32(result[0, 1]);
                //Console.WriteLine(X + " " + Y);
            }
        }
        public void PhepTyLe(double x, double y, double z = 0)
        {
            if (D3)

            {
                Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(new[,] { { x, 0, 0,0 },
                                                                               { 0, y, 0,0 },
                                                                               { 0, 0, z,0 },
                                                                               { 0,0, 0,1 } });
                Matrix<double> result = this.GetMatrix().Multiply(matrix);
                X = Convert.ToInt32(result[0, 0]);
                Y = Convert.ToInt32(result[0, 1]);
                Y = Convert.ToInt32(result[0, 2]);
            }
            else
            {
                Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(new[,] { { x, 0, 0 },
                                                                                   { 0, y, 0 },
                                                                                   { 0,0, 1 } });
                Matrix<double> result = this.GetMatrix().Multiply(matrix);
                X = Convert.ToInt32(result[0, 0]);
                Y = Convert.ToInt32(result[0, 1]);
            }
        }
        public void PhepQuay(double alpha)
        {
            double sin = Math.Sin(alpha);
            double cos = Math.Cos(alpha);
            if (D3)

            {
                
            }
            else
            {
                Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(new[,] { { cos, sin, 0 },
                                                                                   { -1*sin, cos, 0 },
                                                                                   { 0,0, 1 } });
                Matrix<double> result = this.GetMatrix().Multiply(matrix);
                X = Convert.ToInt32(result[0, 0]);
                Y = Convert.ToInt32(result[0, 1]);
            }
        }
        public void PhepDoiXungO()
        {
            X *= -1;
            Y *= -1;
        }
        public void PhepDoiXungOx()
        {
           
            Y *= -1;
        }
        public void PhepDoiXungOy()
        {

            X *= -1;
        }
        public string Name { get => name; set => name = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }
        public bool D3 { get => d3; set => d3 = value; }
    }
}
