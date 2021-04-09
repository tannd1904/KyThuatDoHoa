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
    class HinhTenLua_Ext : INotifyPropertyChanged
    {
        private Point[] dsDiem = new Point[200];
        int t = 0;
        int t_ch = 0;

        public Point[] diem
        {
            get => dsDiem;
            set
            {
                dsDiem = value;
            }
        }
        int x_d = 550;
        int y_d = 650;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public HinhTenLua_Ext()
        {



            //          35  3840   36   
            //      9       3739    10
            //      8               11
            //





            //tầng 3
            diem[8] = new Point(550, 260);
            diem[9] = new Point(550, 200);
            diem[10] = new Point(610, 200);
            diem[11] = new Point(610, 260);

            diem[35] = new Point(570, 170);
            diem[36] = new Point(590, 170);

            //diem tach rieng 2 phan dau
            //580,200
            //580,170
            diem[37] = new Point(580, 260);
            diem[38] = new Point(580, 170);
            diem[39] = new Point(580, 260);
            diem[40] = new Point(580, 170);


            NotifyPropertyChanged();

        }



        //tan test

        public void testscale(double n)
        {
            for (int i = 0; i < diem.Length; i++)
            {
                diem[i] = diem[i].Scale(n);
            }
            NotifyPropertyChanged();
        }









        public void drawBowRocket(Graphics g)
        {

            //          35  3840   36   
            //      9       3739    10
            //      8               11
            //


            new Line(this.diem[8], this.diem[9], Color.Black).Draw(g);
            new Line(this.diem[9], this.diem[35], Color.Black).Draw(g);
            new Line(this.diem[35], this.diem[38], Color.Black).Draw(g);
            new Line(this.diem[38], this.diem[37], Color.Black).Draw(g);
            new Line(this.diem[37], this.diem[8], Color.Black).Draw(g);


            new Line(this.diem[11], this.diem[10], Color.Black).Draw(g);
            new Line(this.diem[10], this.diem[36], Color.Black).Draw(g);
            new Line(this.diem[36], this.diem[40], Color.Black).Draw(g);
            new Line(this.diem[40], this.diem[39], Color.Black).Draw(g);
            new Line(this.diem[39], this.diem[11], Color.Black).Draw(g);



        }

        public void drawBowRocket2(Graphics g)
        {

            //          35  3840   36   
            //      9       3739    10
            //      8               11
            //


            new Line(this.diem[8], this.diem[9], Color.Black).Draw(g);
            new Line(this.diem[9], this.diem[35], Color.Black).Draw(g);
            new Line(this.diem[35], this.diem[38], Color.Black).Draw(g);
            new Line(this.diem[38], this.diem[37], Color.White).Draw(g);
            new Line(this.diem[37], this.diem[8], Color.Black).Draw(g);


            new Line(this.diem[11], this.diem[10], Color.Black).Draw(g);
            new Line(this.diem[10], this.diem[36], Color.Black).Draw(g);
            new Line(this.diem[36], this.diem[40], Color.Black).Draw(g);
            new Line(new Point(this.diem[40].X, this.diem[40].Y + 5), this.diem[39], Color.White).Draw(g);
            new Line(this.diem[39], this.diem[11], Color.Black).Draw(g);



        }


        public void ToMauBow2(Graphics g)
        {
            //          35  3840   36   
            //      9       3739    10
            //      8               11
            //

            SolidBrush brush = new SolidBrush(Color.White);
            SolidBrush brush1 = new SolidBrush(Color.Red);
            SolidBrush brush2 = new SolidBrush(Color.DarkGray);



            Point[] tang3 = { this.diem[8], this.diem[9], this.diem[35], this.diem[38], this.diem[37] };
            Point[] tang4 = { this.diem[39], this.diem[40], this.diem[36], this.diem[10], this.diem[11] };

            g.FillPolygon(brush, tang3);
            g.FillPolygon(brush, tang4);
        }







        // phép tịnh tiến xe theo tọa độ x, y
        public void traslation_TenLua(int x, int y)
        {

            for (int i = 0; i < diem.Length; i++)
            {
                tinhTien(ref this.diem[i], x, y);
            }
            NotifyPropertyChanged();

        }

        public void traslation_Bow_TenLua(int x, int y)
        {
            //          35  3840   36   
            //      9       3739    10
            //      8               11
            //
            tinhTien(ref this.diem[8], x, y);
            tinhTien(ref this.diem[9], x, y);
            tinhTien(ref this.diem[35], x, y);
            tinhTien(ref this.diem[38], x, y);
            tinhTien(ref this.diem[37], x, y);

            tinhTien(ref this.diem[39], -x, y);
            tinhTien(ref this.diem[40], -x, y);
            tinhTien(ref this.diem[36], -x, y);
            tinhTien(ref this.diem[10], -x, y);
            tinhTien(ref this.diem[11], -x, y);


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



        public void quay_bow(int goc, Graphics g)
        {
            //          35  3840   36   
            //      9       3739    10
            //      8               11
            //


            if (t < 5)
            {



                diem[38] = diem[38].RotateAt(diem[8], -goc);
                diem[9] = diem[9].RotateAt(diem[8], -goc);
                diem[35] = diem[35].RotateAt(diem[8], -goc);
                diem[37] = diem[37].RotateAt(diem[8], -goc);

                diem[39] = diem[39].RotateAt(diem[11], goc);
                diem[40] = diem[40].RotateAt(diem[11], goc);
                diem[10] = diem[10].RotateAt(diem[11], goc);
                diem[36] = diem[36].RotateAt(diem[11], goc);

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

