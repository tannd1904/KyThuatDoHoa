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
    class HinhTenLua : INotifyPropertyChanged
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

        public HinhTenLua()
        {
            //tầng 1
            diem[0] = new Point(550, 650);
            diem[1] = new Point(550, 400);
            diem[2] = new Point(610, 400);
            diem[3] = new Point(610, 650);


            //tầng 2
            diem[4] = new Point(555, 400);
            diem[5] = new Point(555, 260);
            diem[6] = new Point(605, 260);
            diem[7] = new Point(605, 400);

            //tầng 3
            diem[8] = new Point(550, 260);
            diem[9] = new Point(550, 200);
            diem[10] = new Point(610, 200);
            diem[11] = new Point(610, 260);


            //tâm elip
            diem[12] = new Point(580, 230);


            //2 bên hình tâm giac ở đáy 
            diem[13] = new Point(580, 650);
            diem[14] = new Point(550, 550);

            diem[15] = new Point(610, 550);
            diem[16] = new Point(580, 650);

            //tam giac đáy 
            diem[17] = new Point(555, 670);
            diem[18] = new Point(580, 630);
            //diem[19] = new Point(605, 650);
            diem[20] = new Point(605, 670);


            diem[35] = new Point(570, 170);
            diem[36] = new Point(590, 170);


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








        public void drawRocket_2(Graphics g)
        {



            new Line(this.diem[0], this.diem[1], Color.Black).Draw(g);
            new Line(this.diem[1], this.diem[2], Color.Black).Draw(g);
            new Line(this.diem[2], this.diem[3], Color.Black).Draw(g);
            new Line(this.diem[3], this.diem[0], Color.Black).Draw(g);

            new Line(this.diem[4], this.diem[5], Color.Black).Draw(g);
            new Line(this.diem[5], this.diem[6], Color.Black).Draw(g);
            new Line(this.diem[6], this.diem[7], Color.Black).Draw(g);
            new Line(this.diem[7], this.diem[4], Color.Black).Draw(g);

            new Line(this.diem[8], this.diem[9], Color.Black).Draw(g);
            new Line(this.diem[9], this.diem[10], Color.White).Draw(g);
            new Line(this.diem[10], this.diem[11], Color.Black).Draw(g);
            new Line(this.diem[11], this.diem[8], Color.Black).Draw(g);



            new HinhTamGiac(diem[17], diem[18], diem[20]).Draw(g, Color.DarkGray);

            new HinhTamGiac(this.diem[13], this.diem[14], this.diem[0]).Draw(g, Color.Gray);
            new HinhTamGiac(this.diem[15], this.diem[16], this.diem[3]).Draw(g, Color.Gray);


            new Line(this.diem[35], this.diem[36], Color.Black).Draw(g);
            //new Line(this.diem[9], this.diem[10], Color.Black).Draw(g);
            new Line(this.diem[9], this.diem[35], Color.Black).Draw(g);
            new Line(this.diem[10], this.diem[36], Color.Black).Draw(g);



        }

        public void drawRocket_3(Graphics g)
        {



            new Line(this.diem[0], this.diem[1], Color.Black).Draw(g);
            new Line(this.diem[1], this.diem[2], Color.Black).Draw(g);
            new Line(this.diem[2], this.diem[3], Color.Black).Draw(g);
            new Line(this.diem[3], this.diem[0], Color.Black).Draw(g);

            new Line(this.diem[4], this.diem[5], Color.Black).Draw(g);
            new Line(this.diem[5], this.diem[6], Color.Black).Draw(g);
            new Line(this.diem[6], this.diem[7], Color.Black).Draw(g);
            new Line(this.diem[7], this.diem[4], Color.Black).Draw(g);


            new Line(this.diem[11], this.diem[8], Color.Black).Draw(g);



            new HinhTamGiac(diem[17], diem[18], diem[20]).Draw(g, Color.DarkGray);

            new HinhTamGiac(this.diem[13], this.diem[14], this.diem[0]).Draw(g, Color.Gray);
            new HinhTamGiac(this.diem[15], this.diem[16], this.diem[3]).Draw(g, Color.Gray);




        }


        public void ToMau_2(Graphics g)
        {


            SolidBrush brush = new SolidBrush(Color.White);
            SolidBrush brush1 = new SolidBrush(Color.Red);
            SolidBrush brush2 = new SolidBrush(Color.DarkGray);


            Point[] tang1 = { this.diem[0], this.diem[1], this.diem[2], this.diem[3] };
            Point[] tang2 = { this.diem[4], this.diem[5], this.diem[6], this.diem[7] };
            Point[] tang3 = { this.diem[8], this.diem[9], this.diem[10], this.diem[11] };



            //
            Point[] tang4 = { this.diem[9], this.diem[36], this.diem[10], this.diem[35] };
            Point[] tang41 = { this.diem[9], this.diem[10], this.diem[35], this.diem[36] };
            //

            g.FillPolygon(brush, tang1);
            g.FillPolygon(brush, tang2);
            g.FillPolygon(brush, tang3);


            g.FillPolygon(brush, tang41);
            g.FillPolygon(brush, tang4);
        }

        public void ToMau_3(Graphics g)
        {


            SolidBrush brush = new SolidBrush(Color.White);
            SolidBrush brush1 = new SolidBrush(Color.Red);
            SolidBrush brush2 = new SolidBrush(Color.DarkGray);


            Point[] tang1 = { this.diem[0], this.diem[1], this.diem[2], this.diem[3] };
            Point[] tang2 = { this.diem[4], this.diem[5], this.diem[6], this.diem[7] };


            g.FillPolygon(brush, tang1);
            g.FillPolygon(brush, tang2);

        }


        public void traslation_TenLua(int x, int y)
        {

            for (int i = 0; i < diem.Length; i++)
            {
                tinhTien(ref this.diem[i], x, y);
            }
            NotifyPropertyChanged();

        }
        public void traslation_TenLua_Top_Down(int x, int y)
        {
            if (diem[0].X == x_d && diem[0].Y == y_d)
            {
                return;
            }
            else
            {
                for (int i = 0; i < diem.Length; i++)
                {
                    tinhTien(ref this.diem[i], x, y);
                }
            }

            NotifyPropertyChanged();

        }
        public void traslation_Chan_TenLua(int x, int y)
        {
            if (t_ch < 15)
            {
                tinhTien(ref this.diem[14], -x, y);
                tinhTien(ref this.diem[15], x, y);
            }
            t_ch++;
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

                    diem[i] = diem[i].RotateAt(diem[1], goc);
                }




                t++;
                NotifyPropertyChanged();
            }


        }

        public void quay_2(int goc, Graphics g)
        {


            if (t < 18)
            {

                for (int i = 0; i < diem.Length; i++)
                {

                    diem[i] = diem[i].RotateAt(diem[18], goc);
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
