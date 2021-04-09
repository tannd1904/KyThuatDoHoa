using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using KTDH_2020.Construct._2DObject;


namespace KTDH_2020.Construct._3DObject
{
    class HinhLapPhuong
    {
        public int ChieuDai { get; set; }
      
        public int[,] Dinh { get; set; }
        /// <summary>
        /// Khởi tạo hình hộp chữ nhật
        /// </summary>
        /// <param name="x">Tọa độ Ox</param>
        /// <param name="y">Tọa độ Oy</param>
        /// <param name="z">Tọa độ Oz</param>
        /// <param name="chieuDai">Chiều dài của hình hộp chữ nhật</param>
       
        public HinhLapPhuong(int x,int y,int z, int chieuDai)
        {
            this.ChieuDai = chieuDai;
            int[,] temp = { { x,y,z},
                            { x+chieuDai,y,z },
                            { x+chieuDai,y,z+chieuDai },
                            { x,y,z+chieuDai},

                            { x,y+chieuDai,z },
                            { x+chieuDai,y+chieuDai,z },
                            { x+chieuDai,y+chieuDai,z+ chieuDai},
                            { x,y+chieuDai,z+chieuDai} };

            this.Dinh = temp;
        }
        public void Draw(Graphics g)
        {
            // Vẽ nét đứt
            DrawLine(g, 0, 1,2); 
            DrawLine(g, 3, 0,2); 
            DrawLine(g, 0, 4,2); 
            // Vẽ nét liền
            DrawLine(g, 1, 2);
            DrawLine(g, 2, 3);
            DrawLine(g, 4, 5);
            DrawLine(g, 5, 6);
            DrawLine(g, 6, 7);
            DrawLine(g, 7, 4);
            DrawLine(g, 1, 5);
            DrawLine(g, 2, 6);
            DrawLine(g, 3, 7);

            Point point;
            for (int i = 0; i < 8; i++)
            {
                point = ToaDo.NguoiDungMayTinh_3D(this.Dinh[i, 0], this.Dinh[i, 1], this.Dinh[i, 2]);
                ToaDo.HienThi(point, g, Color.White);
                char c = (char)(65 + i);
                g.DrawString(c.ToString(), new Font("Arial", 14), Brushes.Red, point);
            }
        }
        /// <summary>
        /// Vẽ đường thẳng nối liền giữa 2 điểm A và B
        /// </summary>
        /// <param name="n">1: Vẽ nét liền 2: Vẽ nét đứt</param>
        public void DrawLine(Graphics g,int A,int B,int n = 1)
        {
            Point point1 = ToaDo.NguoiDungMayTinh_3D(this.Dinh[A,0], this.Dinh[A, 1], this.Dinh[A, 2]),
                  point2 = ToaDo.NguoiDungMayTinh_3D(this.Dinh[B, 0], this.Dinh[B, 1], this.Dinh[B, 2]);
            

            if (n == 2)
            {
                new Line(point1, point2, Color.RoyalBlue).NetDut(g);
               
            }
            else
                new Line(point1, point2, Color.Navy).Draw(g);
                

            Point point;
            for (int i = 0; i < 8; i++)
            {
                point = ToaDo.NguoiDungMayTinh_3D(this.Dinh[i, 0], this.Dinh[i, 1], this.Dinh[i, 2]);
                ToaDo.HienThi(point, g, Color.Pink);
                char c = (char)(65 + i);
                g.DrawString(c.ToString(), new Font("Arial", 14), Brushes.Red, point);
            }
        }
    }
}
