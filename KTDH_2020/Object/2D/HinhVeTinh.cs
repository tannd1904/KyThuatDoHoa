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
    class HinhVeTinh : INotifyPropertyChanged
    {
        private Point[] dsDiem = new Point[200];
        int t = 0;
        int dem_change = 0;

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

        // khởi tạo các giá trị mặc định cho thuộc tính vẽ xe
        public HinhVeTinh()
        {
            //         
            //                  5        4|   9               10    |13      14
            //                           3|   1               2     |12      
            //                  6        7|   8               11    |17      16
            //
            //
            //
            //
            //
            //
            //


            diem[8] = new Point(550, 260);
            diem[9] = new Point(550, 200);
            diem[10] = new Point(610, 200);
            diem[11] = new Point(610, 260);

            diem[1] = new Point(550, 230);
            diem[2] = new Point(610, 230);
            diem[3] = new Point(550, 230);
            diem[12] = new Point(610, 230);

            diem[4] = new Point(550, 200);
            diem[7] = new Point(550, 260);

            diem[13] = new Point(610, 200);
            diem[17] = new Point(610, 260);

            diem[5] = new Point(550, 200);
            diem[6] = new Point(550, 260);

            diem[14] = new Point(610, 200);
            diem[16] = new Point(610, 260);


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






        public void drawSattelite(Graphics g)
        {

            //         
            //                  5        4|   9               10    |13      14
            //                           3|   1               2     |12      
            //                  6        7|   8               11    |17      16
            //
            //
            //
            //
            //
            //
            //



            new Line(this.diem[8], this.diem[9], Color.Black).Draw(g);
            new Line(this.diem[9], this.diem[10], Color.Black).Draw(g);
            new Line(this.diem[10], this.diem[11], Color.Black).Draw(g);
            new Line(this.diem[11], this.diem[8], Color.Black).Draw(g);
            new Line(this.diem[9], this.diem[11], Color.Black).Draw(g);
            new Line(this.diem[8], this.diem[10], Color.Black).Draw(g);


            new Line(this.diem[1], this.diem[3], Color.Black).Draw(g);
            new Line(this.diem[2], this.diem[12], Color.Black).Draw(g);

            new Line(this.diem[4], this.diem[5], Color.Black).Draw(g);
            new Line(this.diem[5], this.diem[6], Color.Black).Draw(g);
            new Line(this.diem[6], this.diem[7], Color.Black).Draw(g);
            new Line(this.diem[7], this.diem[4], Color.Black).Draw(g);

            new Line(this.diem[13], this.diem[14], Color.Black).Draw(g);
            new Line(this.diem[14], this.diem[16], Color.Black).Draw(g);
            new Line(this.diem[16], this.diem[17], Color.Black).Draw(g);
            new Line(this.diem[17], this.diem[13], Color.Black).Draw(g);

        }
        public void changeSallite()
        {
            //         
            //                  5        4|   9               10    |13      14
            //                           3|   1               2     |12      
            //                  6        7|   8               11    |17      16
            //
            //
            //
            //
            //
            //
            //
            //L
            if (dem_change < 10)
            {
                tinhTien(ref this.diem[3], -5, 0);
                tinhTien(ref this.diem[4], -6, 0);
                tinhTien(ref this.diem[7], -3, 0);
                tinhTien(ref this.diem[5], -23, 0);
                tinhTien(ref this.diem[6], -20, 0);
                //R
                tinhTien(ref this.diem[13], 3, 0);
                tinhTien(ref this.diem[12], 5, 0);
                tinhTien(ref this.diem[17], 6, 0);
                tinhTien(ref this.diem[14], 20, 0);
                tinhTien(ref this.diem[16], 23, 0);
            }


            dem_change++;

        }
        public void ToMauSallite(Graphics g)
        {
            //         
            //                  5        4|   9               10    |13      14
            //                           3|   1               2     |12      
            //                  6        7|   8               11    |17      16
            //
            //
            //
            //
            //
            //
            //

            SolidBrush brush = new SolidBrush(Color.White);
            SolidBrush brush1 = new SolidBrush(Color.Orange);
            SolidBrush brush2 = new SolidBrush(Color.LightBlue);



            Point[] L = { this.diem[4], this.diem[5], this.diem[6], this.diem[7] };
            Point[] R = { this.diem[13], this.diem[14], this.diem[16], this.diem[17] };
            Point[] M = { this.diem[9], this.diem[10], this.diem[11], this.diem[8] };
            g.FillPolygon(brush2, L);
            g.FillPolygon(brush2, R);
            g.FillPolygon(brush1, M);
        }


        public void traslation_TenLua(int x, int y)
        {

            for (int i = 0; i < diem.Length; i++)
            {
                tinhTien(ref this.diem[i], x, y);
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

                    diem[i] = diem[i].RotateAt(diem[1], goc);
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

