using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using KTDH_2020.Construct._2DObject;
using System.ComponentModel;

namespace KTDH_2020.Construct._3DObject
{
    class HinhCau
    {




        /*
            Double a = Math.Sqrt(2.0) / 2;
            int x1, y1;
            int x, y, z, r;
            x = Int32.Parse(numericUpDown1.Value.ToString());
            y = Int32.Parse(numericUpDown2.Value.ToString());
            z = Int32.Parse(numericUpDown6.Value.ToString());
            r = Int32.Parse(numericUpDown3.Value.ToString());

            x1 = (int)(x - y * a);
            y1 = (int)(z - y * a);
            Point p1 = Line.toado2(x1, y1);
            ht = new HT(p1.X, p1.Y, r*5);
            el = new Hinhelip(p1.X, p1.Y, r*5, r*5 / 2);
            this.Close();
         */

        //public int ChieuCao { get; set; }
        public int BanKinhDay { get; set; }
        public int[,] TamDay { get; set; }


        public HinhCau(int x,int y,int z,int banKinhDay)
        {
            //this.ChieuCao = chieuCao;
            this.BanKinhDay = banKinhDay;
            int[,] temp = { {x-banKinhDay,y,z },
                            {x,y,z },
                            { x+banKinhDay,y,z},
                            { x-banKinhDay,y+banKinhDay,z},
                            { x,y+banKinhDay,z},
                            { x+banKinhDay,y+banKinhDay,z}
                            
                            };
            this.TamDay = temp;

        }

        public HinhCau()
        {
        }
        public void Draw(Graphics g )
        {
            DrawLine(g, 1, 2, 2);        
            DrawLine(g, 1, 4, 2);         
            
            Point point = ToaDo.NguoiDungMayTinh_3D(this.TamDay[1, 0], this.TamDay[1, 1], this.TamDay[1, 2]);
            new HinhTron(point, BanKinhDay).Draw_W_Color_Line(g, Color.Navy);

            //O
            ToaDo.HienThi(point, g, Color.Red);
            char c = 'O';
            g.DrawString(c.ToString(), new Font("Arial", 14), Brushes.Red, point);

            point = ToaDo.NguoiDungMayTinh_3D(this.TamDay[1, 0], this.TamDay[1, 1], this.TamDay[1, 2]);
            double d = this.BanKinhDay * (Math.Sqrt(2) / 2);
            int b = (int)d;
            new HinhElip(point, this.BanKinhDay, b/2, Color.Navy).NetDut(g);


            
            


            //new HinhElip(point, b / 2, this.BanKinhDay, Color.Blue).NetDut(g);
            //new HinhElip(point, b / 2, this.BanKinhDay, Color.Blue).NetDut(g);




            /*
            Point point = ToaDo.NguoiDungMayTinh_3D(this.TamDay[1, 0], this.TamDay[1, 1], this.TamDay[1, 2]);
            ToaDo.HienThi(point, g, Color.Red);

                point = ToaDo.NguoiDungMayTinh_3D(this.TamDay[4, 0], this.TamDay[4, 1], this.TamDay[4, 2]);
            ToaDo.HienThi(point, g, Color.Red);


            
            
            DrawElip(g);

            for (int i = 0; i < 6; i++)
            {
                point = ToaDo.NguoiDungMayTinh_3D(this.TamDay[i, 0], this.TamDay[i, 1], this.TamDay[i, 2]);
                ToaDo.HienThi(point, g, Color.White);
                char c = (char)(65 + i);
                g.DrawString(c.ToString(), new Font("Verdana", 14), Brushes.Blue, point);
            }

            */

        }
        public void DrawLine(Graphics g,int A,int B,int n = 1)
        {
            Point point1 = ToaDo.NguoiDungMayTinh_3D(this.TamDay[A, 0], this.TamDay[A, 1], this.TamDay[A, 2]),
                  point2 = ToaDo.NguoiDungMayTinh_3D(this.TamDay[B, 0], this.TamDay[B, 1], this.TamDay[B, 2]);

           
            Line line = new Line(point1, point2,Color.RoyalBlue);
            if (n == 2)
            {
                line.NetDut(g);
            }
            else
                line.Draw(g);
        }


       
    }
}
