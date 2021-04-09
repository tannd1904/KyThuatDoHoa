using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTDH_2020.UI.UserCtr
{
    public partial class SpaceshipProperties : UserControl, INotifyPropertyChanged
    {
        public Point[] DsDiem = new Point[37];
        public Point[] DsDiemKhoi = new Point[13];
        public Point[] DsDiemLua = new Point[12];
        public Point[] DsDiemVeTinh = new Point[18];
        public Point[] DsDiemDauTenLua = new Point[100];

        public int bankinh;

        public event PropertyChangedEventHandler PropertyChanged;

        public SpaceshipProperties()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OnPropertyChanged("xoa");
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            OnPropertyChanged("goc");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OnPropertyChanged("ox");
        }*/

        protected void OnPropertyChanged(string PropertyName)
        {

            if (PropertyChanged != null)
            {

                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }


        /*private void button3_Click(object sender, EventArgs e)
        {
            OnPropertyChanged("oy");
        }
*/


        private void btn_Destroy_Click(object sender, EventArgs e)
        {

        }
        public void reset()
        {
            this.label1.Text = "";
            this.label2.Text = "";
            this.label3.Text = "";
            this.label5.Text = "";
            this.label6.Text = "";

            //Tầng 2
            this.label7.Text = "";
            this.label8.Text = "";
            this.label9.Text = "";
            this.label11.Text = "";
            this.label12.Text = "";

            //Tầng 3
            this.label13.Text = "";
            this.label14.Text = "";
            this.label15.Text = "";
            this.label17.Text = "";
            this.label18.Text = "";

            //Tam giac trai
            this.label19.Text = "";
            this.label20.Text = "";
            this.label21.Text = "";
            this.label23.Text = "";

            //tg phai

            this.label25.Text = "";
            this.label26.Text = "";
            this.label27.Text = "";
            this.label29.Text = "";


            //tam giac cuoi
            this.label31.Text = "";
            this.label32.Text = "";
            this.label33.Text = "";
            this.label35.Text = "";


            //Hieu ung lua
            this.label37.Text = "";
            this.label39.Text = "";
            this.label40.Text = "";
            this.label41.Text = "";
            this.label42.Text = "";

            this.label43.Text = "";
            this.label44.Text = "";
            this.label45.Text = "";

            this.label46.Text = "";
            this.label47.Text = "";
            this.label48.Text = "";
        }
        public void infoShape(int choice)
        {

            if (choice == 1)
            {
                for (int i = 0; i < this.DsDiem.Length; i++)
                {
                    this.DsDiem[i] = ToaDo.MayTinhNguoiDung(this.DsDiem[i]);
                }

                for (int i = 0; i < this.DsDiemLua.Length; i++)
                {
                    this.DsDiemLua[i] = ToaDo.MayTinhNguoiDung(this.DsDiemLua[i]);
                }

                //Tầng 1 
                this.label1.Text = "Tầng 1";
                this.label2.Text = this.DsDiem[0].ToString();
                this.label3.Text = this.DsDiem[1].ToString();
                this.label5.Text = this.DsDiem[2].ToString();
                this.label6.Text = this.DsDiem[3].ToString();

                //Tầng 2
                this.label7.Text = "Tầng 2";
                this.label8.Text = this.DsDiem[4].ToString();
                this.label9.Text = this.DsDiem[5].ToString();
                this.label11.Text = this.DsDiem[6].ToString();
                this.label12.Text = this.DsDiem[7].ToString();

                //Tầng 3
                this.label13.Text = "Tầng 3";
                this.label14.Text = this.DsDiem[8].ToString();
                this.label15.Text = this.DsDiem[9].ToString();
                this.label17.Text = this.DsDiem[10].ToString();
                this.label18.Text = this.DsDiem[11].ToString();

                //Tam giac trai
                this.label19.Text = "Tam giác trái";
                this.label20.Text = this.DsDiem[13].ToString();
                this.label21.Text = this.DsDiem[14].ToString();
                this.label23.Text = this.DsDiem[0].ToString();

                //tg phai

                this.label25.Text = "Tam giác phải";
                this.label26.Text = this.DsDiem[15].ToString();
                this.label27.Text = this.DsDiem[16].ToString();
                this.label29.Text = this.DsDiem[3].ToString();


                //tam giac cuoi
                this.label31.Text = "Tam giác cuối";
                this.label32.Text = this.DsDiem[17].ToString();
                this.label33.Text = this.DsDiem[18].ToString();
                this.label35.Text = this.DsDiem[20].ToString();


                //Hieu ung lua
                this.label37.Text = "Hiệu ứng lửa";
                this.label39.Text = "Tam giác";
                this.label40.Text = this.DsDiemLua[0].ToString();
                this.label41.Text = this.DsDiemLua[2].ToString();
                this.label42.Text = this.DsDiemLua[1].ToString();

                this.label43.Text = this.DsDiemLua[0].ToString();
                this.label44.Text = this.DsDiemLua[2].ToString();
                this.label45.Text = this.DsDiemLua[3].ToString();

                this.label46.Text = this.DsDiemLua[9].ToString();
                this.label47.Text = this.DsDiemLua[11].ToString();
                this.label48.Text = this.DsDiemLua[10].ToString();

            }
            if (choice == 2)
            {
                for (int i = 0; i < this.DsDiem.Length; i++)
                {
                    this.DsDiem[i] = ToaDo.MayTinhNguoiDung(this.DsDiem[i]);
                }

                for (int i = 0; i < this.DsDiemLua.Length; i++)
                {
                    this.DsDiemLua[i] = ToaDo.MayTinhNguoiDung(this.DsDiemLua[i]);
                }

                //Tầng 1 
                this.label1.Text = "Tầng 1";
                this.label2.Text = this.DsDiem[0].ToString();
                this.label3.Text = this.DsDiem[1].ToString();
                this.label5.Text = this.DsDiem[2].ToString();
                this.label6.Text = this.DsDiem[3].ToString();

                //Tầng 2
                this.label7.Text = "Tầng 2";
                this.label8.Text = this.DsDiem[4].ToString();
                this.label9.Text = this.DsDiem[5].ToString();
                this.label11.Text = this.DsDiem[6].ToString();
                this.label12.Text = this.DsDiem[7].ToString();

                //Tầng 3
                this.label13.Text = "Tầng 3";
                this.label14.Text = this.DsDiem[8].ToString();
                this.label15.Text = this.DsDiem[9].ToString();
                this.label17.Text = this.DsDiem[10].ToString();
                this.label18.Text = this.DsDiem[11].ToString();

                //Tam giac trai
                this.label19.Text = "Tam giác trái";
                this.label20.Text = this.DsDiem[13].ToString();
                this.label21.Text = this.DsDiem[14].ToString();
                this.label23.Text = this.DsDiem[0].ToString();

                //tg phai

                this.label25.Text = "Tam giác phải";
                this.label26.Text = this.DsDiem[15].ToString();
                this.label27.Text = this.DsDiem[16].ToString();
                this.label29.Text = this.DsDiem[3].ToString();


                //tam giac cuoi
                this.label31.Text = "Tam giác cuối";
                this.label32.Text = this.DsDiem[17].ToString();
                this.label33.Text = this.DsDiem[18].ToString();
                this.label35.Text = this.DsDiem[20].ToString();


                //Hieu ung lua
                this.label37.Text = "Hiệu ứng lửa";
                this.label39.Text = "Tam giác";
                this.label40.Text = this.DsDiemLua[0].ToString();
                this.label41.Text = this.DsDiemLua[2].ToString();
                this.label42.Text = this.DsDiemLua[1].ToString();

                this.label43.Text = this.DsDiemLua[0].ToString();
                this.label44.Text = this.DsDiemLua[2].ToString();
                this.label45.Text = this.DsDiemLua[3].ToString();

                this.label46.Text = this.DsDiemLua[9].ToString();
                this.label47.Text = this.DsDiemLua[11].ToString();
                this.label48.Text = this.DsDiemLua[10].ToString();
            }

            if (choice == 3)
            {
                for (int i = 0; i < this.DsDiem.Length; i++)
                {
                    this.DsDiem[i] = ToaDo.MayTinhNguoiDung(this.DsDiem[i]);
                }

                for (int i = 0; i < this.DsDiemDauTenLua.Length; i++)
                {
                    this.DsDiemDauTenLua[i] = ToaDo.MayTinhNguoiDung(this.DsDiemDauTenLua[i]);
                }
                for (int i = 0; i < this.DsDiemVeTinh.Length; i++)
                {
                    this.DsDiemVeTinh[i] = ToaDo.MayTinhNguoiDung(this.DsDiemVeTinh[i]);
                }

                //Tầng 1 
                this.label1.Text = "Tầng 1";
                this.label2.Text = this.DsDiem[0].ToString();
                this.label3.Text = this.DsDiem[1].ToString();
                this.label5.Text = this.DsDiem[2].ToString();
                this.label6.Text = this.DsDiem[3].ToString();

                //Tầng 2
                this.label7.Text = "Tầng 2";
                this.label8.Text = this.DsDiem[4].ToString();
                this.label9.Text = this.DsDiem[5].ToString();
                this.label11.Text = this.DsDiem[6].ToString();
                this.label12.Text = this.DsDiem[7].ToString();

                //Tầng 3
                this.label13.Text = "Tầng 3";
                this.label14.Text = this.DsDiem[8].ToString();
                this.label15.Text = this.DsDiem[9].ToString();
                this.label17.Text = this.DsDiem[10].ToString();
                this.label18.Text = this.DsDiem[11].ToString();

                //Tam giac trai
                this.label19.Text = "Tam giác trái";
                this.label20.Text = this.DsDiem[13].ToString();
                this.label21.Text = this.DsDiem[14].ToString();
                this.label23.Text = this.DsDiem[0].ToString();

                //tg phai

                this.label25.Text = "Tam giác phải";
                this.label26.Text = this.DsDiem[15].ToString();
                this.label27.Text = this.DsDiem[16].ToString();
                this.label29.Text = this.DsDiem[3].ToString();


                //tam giac cuoi
                this.label31.Text = "Tam giác cuối";
                this.label32.Text = this.DsDiem[17].ToString();
                this.label33.Text = this.DsDiem[18].ToString();
                this.label35.Text = this.DsDiem[20].ToString();

                this.label37.Text = "Hiệu ứng lửa";
                this.label39.Text = "Tam giác";
                this.label40.Text = "not found";
                this.label41.Text = "not found";
                this.label42.Text = "not found";

                this.label43.Text = "not found";
                this.label44.Text = "not found";
                this.label45.Text = "not found";

                this.label46.Text = "not found";
                this.label47.Text = "not found";
                this.label48.Text = "not found";

                //Ve Tinh
                this.label49.Text = "Vệ tinh-Thân";
                this.label50.Text = this.DsDiemVeTinh[8].ToString();
                this.label51.Text = this.DsDiemVeTinh[9].ToString();
                this.label53.Text = this.DsDiemVeTinh[10].ToString();
                this.label54.Text = this.DsDiemVeTinh[11].ToString();

                this.label55.Text = "Cánh Trái";
                this.label56.Text = this.DsDiemVeTinh[6].ToString();
                this.label57.Text = this.DsDiemVeTinh[5].ToString();
                this.label59.Text = this.DsDiemVeTinh[4].ToString();
                this.label60.Text = this.DsDiemVeTinh[7].ToString();

                this.label61.Text = "Cánh Phải";
                this.label62.Text = this.DsDiemVeTinh[17].ToString();
                this.label63.Text = this.DsDiemVeTinh[13].ToString();
                this.label65.Text = this.DsDiemVeTinh[14].ToString();
                this.label66.Text = this.DsDiemVeTinh[16].ToString();

                this.label67.Text = "Mảnh vỡ-Trái";
                this.label68.Text = this.DsDiemDauTenLua[8].ToString();
                this.label69.Text = this.DsDiemDauTenLua[9].ToString();
                this.label70.Text = this.DsDiemDauTenLua[35].ToString();
                this.label71.Text = this.DsDiemDauTenLua[38].ToString();
                this.label72.Text = this.DsDiemDauTenLua[37].ToString();

                this.label73.Text = "Mảnh vỡ-Phải";
                this.label74.Text = this.DsDiemDauTenLua[11].ToString();
                this.label75.Text = this.DsDiemDauTenLua[10].ToString();
                this.label76.Text = this.DsDiemDauTenLua[36].ToString();
                this.label77.Text = this.DsDiemDauTenLua[40].ToString();
                this.label78.Text = this.DsDiemDauTenLua[39].ToString();


            }

            if (choice == 4)
            {
                for (int i = 0; i < this.DsDiem.Length; i++)
                {
                    this.DsDiem[i] = ToaDo.MayTinhNguoiDung(this.DsDiem[i]);
                }

                for (int i = 0; i < this.DsDiemLua.Length; i++)
                {
                    this.DsDiemLua[i] = ToaDo.MayTinhNguoiDung(this.DsDiemLua[i]);
                }

                //Tầng 1 
                this.label1.Text = "Tầng 1";
                this.label2.Text = this.DsDiem[0].ToString();
                this.label3.Text = this.DsDiem[1].ToString();
                this.label5.Text = this.DsDiem[2].ToString();
                this.label6.Text = this.DsDiem[3].ToString();

                //Tầng 2
                this.label7.Text = "Tầng 2";
                this.label8.Text = this.DsDiem[4].ToString();
                this.label9.Text = this.DsDiem[5].ToString();
                this.label11.Text = this.DsDiem[6].ToString();
                this.label12.Text = this.DsDiem[7].ToString();

                //Tầng 3
                this.label13.Text = "Tầng 3";
                this.label14.Text = this.DsDiem[8].ToString();
                this.label15.Text = this.DsDiem[9].ToString();
                this.label17.Text = this.DsDiem[10].ToString();
                this.label18.Text = this.DsDiem[11].ToString();

                //Tam giac trai
                this.label19.Text = "Tam giác trái";
                this.label20.Text = this.DsDiem[13].ToString();
                this.label21.Text = this.DsDiem[14].ToString();
                this.label23.Text = this.DsDiem[0].ToString();

                //tg phai

                this.label25.Text = "Tam giác phải";
                this.label26.Text = this.DsDiem[15].ToString();
                this.label27.Text = this.DsDiem[16].ToString();
                this.label29.Text = this.DsDiem[3].ToString();


                //tam giac cuoi
                this.label31.Text = "Tam giác cuối";
                this.label32.Text = this.DsDiem[17].ToString();
                this.label33.Text = this.DsDiem[18].ToString();
                this.label35.Text = this.DsDiem[20].ToString();


                //Hieu ung lua
                this.label37.Text = "Hiệu ứng lửa";
                this.label39.Text = "Tam giác";
                this.label40.Text = this.DsDiemLua[0].ToString();
                this.label41.Text = this.DsDiemLua[2].ToString();
                this.label42.Text = this.DsDiemLua[1].ToString();

                this.label43.Text = this.DsDiemLua[0].ToString();
                this.label44.Text = this.DsDiemLua[2].ToString();
                this.label45.Text = this.DsDiemLua[3].ToString();

                this.label46.Text = this.DsDiemLua[9].ToString();
                this.label47.Text = this.DsDiemLua[11].ToString();
                this.label48.Text = this.DsDiemLua[10].ToString();


                this.label49.Text = "Vệ tinh-Thân";
                this.label50.Text = "not found";
                this.label51.Text = "not found";
                this.label53.Text = "not found";
                this.label54.Text = "not found";

                this.label55.Text = "Cánh Trái";
                this.label56.Text = "not found";
                this.label57.Text = "not found";
                this.label59.Text = "not found";
                this.label60.Text = "not found";

                this.label61.Text = "Cánh Phải";
                this.label62.Text = "not found";
                this.label63.Text = "not found";
                this.label65.Text = "not found";
                this.label66.Text = "not found";


                this.label67.Text = "Mảnh vỡ-Trái";
                this.label68.Text = "not found";
                this.label69.Text = "not found";
                this.label70.Text = "not found";
                this.label71.Text = "not found";
                this.label72.Text = "not found";

                this.label73.Text = "Mảnh vỡ-Phải";
                this.label74.Text = "not found";
                this.label75.Text = "not found";
                this.label76.Text = "not found";
                this.label77.Text = "not found";
                this.label78.Text = "not found";


            }

            /*
                        for (int i = 0; i < this.DsDiem.Length; i++)
                        {
                            this.DsDiem[i] = ToaDo.MayTinhNguoiDung(this.DsDiem[i]);
                        }
                        for (int i = 0; i < this.DsDiemLua.Length; i++)
                        {
                            this.DsDiemLua[i] = ToaDo.MayTinhNguoiDung(this.DsDiemLua[i]);
                        }
                        for (int i = 0; i < this.DsDiemKhoi.Length; i++)
                        {
                            this.DsDiemKhoi[i] = ToaDo.MayTinhNguoiDung(this.DsDiemKhoi[i]);
                        }
                        for (int i = 0; i < this.DsDiemDauTenLua.Length; i++)
                        {
                            this.DsDiemDauTenLua[i] = ToaDo.MayTinhNguoiDung(this.DsDiemDauTenLua[i]);
                        }
                        for (int i = 0; i < this.DsDiemVeTinh.Length; i++)
                        {
                            this.DsDiemVeTinh[i] = ToaDo.MayTinhNguoiDung(this.DsDiemVeTinh[i]);
                        }



                        //Tầng 1 
                        this.label1.Text = "Tầng 1";
                        this.label2.Text = this.DsDiem[0].ToString();
                        this.label3.Text = this.DsDiem[1].ToString();
                        this.label5.Text = this.DsDiem[2].ToString();
                        this.label6.Text = this.DsDiem[3].ToString();

                        //Tầng 2
                        this.label7.Text = "Tầng 2";
                        this.label8.Text = this.DsDiem[4].ToString();
                        this.label9.Text = this.DsDiem[5].ToString();
                        this.label11.Text = this.DsDiem[6].ToString();
                        this.label12.Text = this.DsDiem[7].ToString();

                        //Tầng 3
                        this.label13.Text = "Tầng 3";
                        this.label14.Text = this.DsDiem[8].ToString();
                        this.label15.Text = this.DsDiem[9].ToString();
                        this.label17.Text = this.DsDiem[10].ToString();
                        this.label18.Text = this.DsDiem[11].ToString();

                        //Tam giac trai
                        this.label19.Text = "Tam giác trái";
                        this.label20.Text = this.DsDiem[13].ToString();
                        this.label21.Text = this.DsDiem[14].ToString();
                        this.label23.Text = this.DsDiem[0].ToString();

                        //tg phai

                        this.label25.Text ="Tam giác phải";
                        this.label26.Text = this.DsDiem[15].ToString();
                        this.label27.Text = this.DsDiem[16].ToString();
                        this.label29.Text = this.DsDiem[3].ToString();


                        //tam giac cuoi
                        this.label31.Text = "Tam giác cuối";
                        this.label32.Text = this.DsDiem[17].ToString();
                        this.label33.Text = this.DsDiem[18].ToString();
                        this.label35.Text = this.DsDiem[20].ToString();


                        //Hieu ung lua
                        this.label37.Text = "Hiệu ứng lửa";
                        this.label39.Text = "Tam giác";
                        this.label40.Text = this.DsDiemLua[0].ToString();
                        this.label41.Text = this.DsDiemLua[2].ToString();
                        this.label42.Text = this.DsDiemLua[1].ToString();

                        this.label43.Text = this.DsDiemLua[0].ToString();
                        this.label44.Text = this.DsDiemLua[2].ToString();
                        this.label45.Text = this.DsDiemLua[3].ToString();

                        this.label46.Text = this.DsDiemLua[9].ToString();
                        this.label47.Text = this.DsDiemLua[11].ToString();
                        this.label48.Text = this.DsDiemLua[10].ToString();


                        //Ve Tinh
                        this.label49.Text = "Vệ tinh-Thân";
                        this.label50.Text = this.DsDiemVeTinh[8].ToString();
                        this.label51.Text = this.DsDiemVeTinh[9].ToString();
                        this.label53.Text = this.DsDiemVeTinh[10].ToString();
                        this.label54.Text = this.DsDiemVeTinh[11].ToString();

                        this.label55.Text = "Cánh Trái";
                        this.label56.Text = this.DsDiemVeTinh[6].ToString();
                        this.label57.Text = this.DsDiemVeTinh[5].ToString();
                        this.label59.Text = this.DsDiemVeTinh[4].ToString();
                        this.label60.Text = this.DsDiemVeTinh[7].ToString();

                        this.label61.Text = "Cánh Phải";
                        this.label62.Text = this.DsDiemVeTinh[17].ToString();
                        this.label63.Text = this.DsDiemVeTinh[13].ToString();
                        this.label65.Text = this.DsDiemVeTinh[14].ToString();
                        this.label66.Text = this.DsDiemVeTinh[16].ToString();



            */
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            OnPropertyChanged("hieuung");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            OnPropertyChanged("stop");
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void TruckProperties_Load(object sender, EventArgs e)
        {

        }

        private void Truck_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OnPropertyChanged("xoa");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
