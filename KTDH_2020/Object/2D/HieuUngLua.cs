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
    class HieuUngLua : INotifyPropertyChanged
    {
        private Point[] dsDiem = new Point[200];
        private int i = 0;
        int t = 0;
        int t_tran = 0;
        int x_d = 600;
        int y_d = 675;


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

        public HieuUngLua()
        {
            diem[0] = new Point(600, 675);
            diem[1] = new Point(580, 900);
            diem[2] = new Point(560, 675);
            diem[3] = new Point(580, 800);

            diem[8] = new Point(580, 675);

            diem[9] = new Point(560, 675);
            diem[10] = new Point(610, 675);
            diem[11] = new Point(580, 1000);
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





        public void drawFire(Graphics g)
        {
            //testscale(0.9);


            new HinhTamGiac(diem[0], diem[1], diem[2]).Draw(g, Color.OrangeRed);


        }






        public void traslation_Fire(int x, int y, Graphics g)
        {


            for (int i = 0; i < diem.Length; i++)
            {
                tinhTien(ref this.diem[i], x, y);
            }
            if (i % 2 == 0)
            {
                new HinhTamGiac(diem[0], diem[1], diem[2]).Draw(g, Color.OrangeRed);
            }
            else if (i % 2 == 3)
            {
                new HinhTamGiac(diem[0], diem[2], diem[3]).Draw(g, Color.IndianRed);
            }
            else
            {
                new HinhTamGiac(diem[9], diem[10], diem[11]).Draw(g, Color.IndianRed);
            }
            i++;
            NotifyPropertyChanged();

        }

        public int traslation_Fire_Smaller(int x, int y, Graphics g)
        {

            if (diem[0].X == x_d && diem[0].Y == y_d)
            {
                return 1;
            }
            else
            {
                t_tran++;
                for (int i = 0; i < diem.Length; i++)
                {

                    tinhTien(ref this.diem[i], x, y);
                }


                if (i % 2 == 0)
                {
                    new HinhTamGiac(diem[0], new Point(diem[1].X, diem[1].Y - t_tran * 2), diem[2]).Draw(g, Color.OrangeRed);
                }


                else if (i % 2 == 3)
                {
                    new HinhTamGiac(diem[0], new Point(diem[3].X, diem[3].Y - t_tran * 2), diem[2]).Draw(g, Color.IndianRed);
                }
                else
                {
                    new HinhTamGiac(diem[9], new Point(diem[11].X, diem[11].Y - t_tran * 3), diem[10]).Draw(g, Color.IndianRed);
                }

                i++;
            }


            NotifyPropertyChanged();
            return 0;

        }

        public void traslation_Fire_Bigger(int x, int y, Graphics g)
        {
            t_tran++;
            for (int i = 0; i < diem.Length; i++)
            {
                tinhTien(ref this.diem[i], x, y);
            }
            if (i % 2 == 0)
            {
                new HinhTamGiac(diem[0], new Point(diem[1].X, diem[1].Y + t_tran * 2), diem[2]).Draw(g, Color.OrangeRed);
            }


            else if (i % 2 == 3)
            {
                new HinhTamGiac(diem[0], new Point(diem[3].X, diem[3].Y + t_tran * 2), diem[2]).Draw(g, Color.IndianRed);
            }
            else
            {
                new HinhTamGiac(diem[9], new Point(diem[11].X, diem[11].Y + t_tran * 3), diem[10]).Draw(g, Color.IndianRed);
            }

            i++;
            NotifyPropertyChanged();

        }

        public void traslation_Fire_now(int x, int y)
        {

            for (int i = 0; i < diem.Length; i++)
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

        public void quay(int goc, Graphics g)
        {


            if (t < 1)
            {

                for (int i = 0; i < diem.Length; i++)
                {

                    diem[i] = diem[i].RotateAt(diem[8], goc);
                }




                t++;
                NotifyPropertyChanged();
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
