using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTDH_2020.Construct._2DObject
{
    class HinhPhu : INotifyPropertyChanged
    {
        private Point[] dsDiem = new Point[200];


        int t = 0;
        public Point[] diem
        {
            get => dsDiem;
            set
            {
                dsDiem = value;
            }
        }
       
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public HinhPhu()
        {
            //tầng 1
            diem[0] = new Point(450, 670);
            diem[1] = new Point(450, 220);
            diem[2] = new Point(500, 220);
            diem[3] = new Point(500, 670);


            diem[4] = new Point(475, 670);

            diem[5] = new Point(450, 270);
            diem[6] = new Point(550, 270);
            diem[7] = new Point(450, 280);
            diem[8] = new Point(550, 280);


            diem[9] = new Point(400, 670);
            diem[10] = new Point(450, 650);

            NotifyPropertyChanged();

        }



        //tan test

        public void testscale(double n)
        {
            for (int i = 0; i < diem.Length; i++)
            {
                diem[i] = diem[i].Scale(n);
            }

        }





        public void drawIt(Graphics g)
        {


            new Line(this.diem[0], this.diem[1], Color.Black).Draw(g);
            new Line(this.diem[1], this.diem[2], Color.Black).Draw(g);
            new Line(this.diem[2], this.diem[3], Color.Black).Draw(g);
            new Line(this.diem[3], this.diem[0], Color.Black).Draw(g);

            new Line(this.diem[5], this.diem[6], Color.Black).Draw(g);
            new Line(this.diem[7], this.diem[8], Color.Black).Draw(g);

            new Line(this.diem[7], this.diem[9], Color.Black).Draw(g);
            new Line(this.diem[9], this.diem[10], Color.Black).Draw(g);

            SolidBrush brush = new SolidBrush(Color.WhiteSmoke);


            Point[] tang1 = { this.diem[0], this.diem[1], this.diem[2], this.diem[3] };
            

            g.FillPolygon(brush, tang1);
            

            


        }
        public void ToMau(Graphics g)
        {



        }

        // phép tịnh tiến xe theo tọa độ x, y
        public void traslation_HinhPhu(int x, int y)
        {

            for (int i = 0; i < 31; i++)
            {
                tinhTien(ref this.diem[i], x, y);
            }
            NotifyPropertyChanged();

        }

        public void doiXungQuaOx()
        {

            for (int i = 0; i < this.diem.Length; i++)
            {
                this.dsDiem[i] = ToaDo.MayTinhNguoiDung(this.dsDiem[i]);
                doiXungOX(ref this.dsDiem[i]);
                this.dsDiem[i] = ToaDo.NguoiDungMayTinh(this.dsDiem[i]);
            }

            NotifyPropertyChanged();

        }

        public void doiXungQuaOy()
        {

            for (int i = 0; i < this.diem.Length; i++)
            {
                this.dsDiem[i] = ToaDo.MayTinhNguoiDung(this.dsDiem[i]);
                doiXungOY(ref this.dsDiem[i]);
                this.dsDiem[i] = ToaDo.NguoiDungMayTinh(this.dsDiem[i]);
            }

            NotifyPropertyChanged();

        }
        public void doiXungQuaGoc()
        {

            for (int i = 0; i < this.diem.Length; i++)
            {
                this.dsDiem[i] = ToaDo.MayTinhNguoiDung(this.dsDiem[i]);
                doiXungQuaGoc(ref this.dsDiem[i]);
                this.dsDiem[i] = ToaDo.NguoiDungMayTinh(this.dsDiem[i]);
            }

            NotifyPropertyChanged();

        }

        public void quay(int goc)
        {
            if (t < 10)
            {

                for (int i = 0; i < diem.Length; i++)
                {
                   
                    diem[i] = diem[i].RotateAt(diem[4], goc);
                }
                
                NotifyPropertyChanged();
                t++;
            }
            else
            {
                return;
            }
            
            

        }
        private Point nhanMT(double[,] matran, double[] mang)
        {
            double[] mangtam = new double[3];

            int dem = 0;
            for (int i = 0; i < 3; i++)
            {
                mangtam[i] = mang[0] * matran[0, dem] + mang[1] * matran[1, dem] + mang[2] * matran[2, dem];
                dem++;
            }

            Point pt = new Point(Convert.ToInt16(mangtam[0]), Convert.ToInt16(mangtam[1]));
            return pt;
        }

        // hàm tịnh tiến tọa đồ pn xDonVi, yDonVi
        private void tinhTien(ref Point pn, int xDonVi, int yDonVi)
        {
            double[] matran1 = new double[3] { pn.X, pn.Y, 1 };
            // khởi tạo ma trận tịnh tiến
            double[,] matran2 = new double[3, 3] { { 1,  0 , 0 },
                                             { 0,  1 , 0 },
                                             { xDonVi,  yDonVi, 1} };

            pn = nhanMT(matran2, matran1);
        }
        private void doiXungOX(ref Point pn)
        {
            double[] matran1 = new double[3] { pn.X, pn.Y, 1 };
            // khởi tạo ma trận tịnh tiến
            double[,] matran2 = new double[3, 3] { { -1,  0 , 0 },
                                             { 0,  1 , 0 },
                                             { 0,  0, 1} };

            pn = nhanMT(matran2, matran1);

        }

        private void doiXungOY(ref Point pn)
        {
            double[] matran1 = new double[3] { pn.X, pn.Y, 1 };
            // khởi tạo ma trận tịnh tiến
            double[,] matran2 = new double[3, 3] { { 1,  0 , 0 },
                                             { 0,  -1 , 0 },
                                             { 0,  0, 1} };

            pn = nhanMT(matran2, matran1);

        }

        private void doiXungQuaGoc(ref Point pn)
        {
            double[] matran1 = new double[3] { pn.X, pn.Y, 1 };
            // khởi tạo ma trận tịnh tiến
            double[,] matran2 = new double[3, 3] { {- 1,  0 , 0 },
                                             { 0,  -1 , 0 },
                                             { 0,  0, 1} };

            pn = nhanMT(matran2, matran1);

        }

    }
}

