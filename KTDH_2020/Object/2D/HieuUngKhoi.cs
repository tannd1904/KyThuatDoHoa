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
using System.Threading;

namespace KTDH_2020.Construct._2DObject
{
    class HieuUngKhoi : INotifyPropertyChanged
    {
        private Point[] dsDiem = new Point[200];

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

        public HieuUngKhoi()
        {

            diem[0] = new Point(670, 700);
            diem[1] = new Point(610, 670);
            diem[2] = new Point(550, 600);
            diem[3] = new Point(510, 670);
            diem[4] = new Point(525, 634);
            diem[5] = new Point(580, 634);
            diem[6] = new Point(575, 680);

            //smoke_2
            diem[7] = new Point(670, 700);
            diem[8] = new Point(700, 690);
            diem[9] = new Point(730, 680);
            diem[10] = new Point(770, 650);
            diem[11] = new Point(780, 690);
            diem[12] = new Point(800, 680);






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





        public void drawSmoke(Graphics g)
        {
            //testscale(0.9);

            new HinhTron(diem[0], 3, Color.DarkSlateGray).DrawWithFill(g, Color.WhiteSmoke);
            new HinhTron(diem[1], 10, Color.DarkSlateGray).DrawWithFill(g, Color.WhiteSmoke);
            new HinhTron(diem[2], 8, Color.DarkSlateGray).DrawWithFill(g, Color.WhiteSmoke);
            new HinhTron(diem[3], 10, Color.DarkSlateGray).DrawWithFill(g, Color.WhiteSmoke);
            new HinhTron(diem[4], 6, Color.DarkSlateGray).DrawWithFill(g, Color.WhiteSmoke);

            new HinhTron(diem[5], 10, Color.DarkSlateGray).DrawWithFill(g, Color.WhiteSmoke);
            new HinhTron(diem[6], 6, Color.DarkSlateGray).DrawWithFill(g, Color.WhiteSmoke);
        }


        public void drawSmoke_2(Graphics g)
        {
            //testscale(0.9);

            new HinhTron(diem[7], 2, Color.SlateGray).DrawWithFill(g, Color.White);
            new HinhTron(diem[8], 4, Color.SlateGray).DrawWithFill(g, Color.White);
            new HinhTron(diem[9], 6, Color.SlateGray).DrawWithFill(g, Color.White);
            new HinhTron(diem[11], 5, Color.SlateGray).DrawWithFill(g, Color.White);
            new HinhTron(diem[10], 10, Color.SlateGray).DrawWithFill(g, Color.White);
            new HinhTron(diem[12], 6, Color.SlateGray).DrawWithFill(g, Color.White);
            //new HinhTron(diem[13], 6, Color.DarkSlateGray).DrawWithFill(g, Color.WhiteSmoke);

        }

        public void drawFireSmoke(Graphics g)
        {
            //testscale(0.9);

            new HinhTron(diem[0], 3, Color.DarkSlateGray).DrawWithFill(g, Color.DarkRed);
            new HinhTron(diem[1], 10, Color.DarkSlateGray).DrawWithFill(g, Color.OrangeRed);
            new HinhTron(diem[2], 8, Color.DarkSlateGray).DrawWithFill(g, Color.OrangeRed);
            new HinhTron(diem[3], 10, Color.DarkSlateGray).DrawWithFill(g, Color.DarkRed);
            new HinhTron(diem[4], 6, Color.DarkSlateGray).DrawWithFill(g, Color.OrangeRed);

            new HinhTron(diem[5], 10, Color.DarkSlateGray).DrawWithFill(g, Color.OrangeRed);
            new HinhTron(diem[6], 6, Color.DarkSlateGray).DrawWithFill(g, Color.DarkRed);
        }





        public void traslation_Smoke(int x, int y)
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
                doiXungOY(ref this.dsDiem[i]);
                this.dsDiem[i] = ToaDo.NguoiDungMayTinh(this.dsDiem[i]);
            }

            NotifyPropertyChanged();

        }

        public void doiXungQuaOy()
        {




            for (int i = 0; i < this.diem.Length; i++)
            {
                this.dsDiem[i] = ToaDo.MayTinhNguoiDung(this.dsDiem[i]);
                doiXungOX(ref this.dsDiem[i]);
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

        public void quayBanhXe(int goc)
        {
            /*
            diem[19] = diem[19].RotateAt(diem[13], goc);
            diem[20] = diem[20].RotateAt(diem[13], goc);
            diem[21] = diem[21].RotateAt(diem[13], goc);

            diem[22] = diem[22].RotateAt(diem[14], goc);
            diem[23] = diem[23].RotateAt(diem[14], goc);
            diem[24] = diem[24].RotateAt(diem[14], goc);
          
            NotifyPropertyChanged();
            */

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
