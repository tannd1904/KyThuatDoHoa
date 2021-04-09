using KTDH_2020.Construct._2DObject;
using KTDH_2020.Construct._3DObject;
using KTDH_2020.UI.UserCtr;
using KTDH_2020.Variables;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace KTDH_2020
{

    public partial class frm_Main : Form
    {
        //
        KyThuatDoHoa.Form1 vecoban = new KyThuatDoHoa.Form1();
        HieuUngLua hul = new HieuUngLua();
        HieuUngLua hul1 = new HieuUngLua();
        HieuUngLua hul2 = new HieuUngLua();


        HieuUngLua hul3 = new HieuUngLua();


        HieuUngKhoi huk = new HieuUngKhoi();
        HieuUngKhoi huk1 = new HieuUngKhoi();
        HieuUngKhoi huk2 = new HieuUngKhoi();
        HieuUngKhoi huk3 = new HieuUngKhoi();

        HieuUngKhoi huk5 = new HieuUngKhoi();
        HieuUngKhoi huk4 = new HieuUngKhoi();
        HieuUngKhoi huk6 = new HieuUngKhoi();
        HieuUngKhoi huk7 = new HieuUngKhoi();

        HieuUngKhoi huk8 = new HieuUngKhoi();




        //topdown
        HieuUngKhoi huk23 = new HieuUngKhoi();
        HieuUngKhoi huk24 = new HieuUngKhoi();
        HieuUngKhoi huk25 = new HieuUngKhoi();
        HieuUngKhoi huk26 = new HieuUngKhoi();
        HieuUngKhoi huk27 = new HieuUngKhoi();
        HieuUngKhoi huk28 = new HieuUngKhoi();
        HieuUngKhoi huk29 = new HieuUngKhoi();
        HieuUngKhoi huk30 = new HieuUngKhoi();
        HieuUngKhoi huk31 = new HieuUngKhoi();
        HieuUngKhoi huk32 = new HieuUngKhoi();
        HieuUngKhoi huk33 = new HieuUngKhoi();
        HieuUngKhoi huk34 = new HieuUngKhoi();
        HieuUngKhoi huk35 = new HieuUngKhoi();
        HieuUngKhoi huk36 = new HieuUngKhoi();
        //boom
        HieuUngKhoi huk9 = new HieuUngKhoi();
        HieuUngKhoi huk10 = new HieuUngKhoi();
        HieuUngKhoi huk11 = new HieuUngKhoi();
        HieuUngKhoi huk12= new HieuUngKhoi();
        HieuUngKhoi huk13 = new HieuUngKhoi();
        HieuUngKhoi huk14 = new HieuUngKhoi();
        HieuUngKhoi huk15= new HieuUngKhoi();
        HieuUngKhoi huk16 = new HieuUngKhoi();
        HieuUngKhoi huk17 = new HieuUngKhoi();
        HieuUngKhoi huk18 = new HieuUngKhoi();
        HieuUngKhoi huk19 = new HieuUngKhoi();
        HieuUngKhoi huk20 = new HieuUngKhoi();
        HieuUngKhoi huk21 = new HieuUngKhoi();
        HieuUngKhoi huk22 = new HieuUngKhoi();



        HinhPhu hp = new HinhPhu();

        //

        HinhTenLua_Ext htle = new HinhTenLua_Ext();
        HinhTenLua htle1 = new HinhTenLua();



        //


        //
        HinhVeTinh hvt = new HinhVeTinh();
        //

        HinhTenLua hinhTenLua = new HinhTenLua();
        HinhTenLua hinhTenLua1 = new HinhTenLua();
        HinhTenLua hinhTenLua2 = new HinhTenLua();
        HinhTenLua hinhTenLua3 = new HinhTenLua();


        HinhCau hinhCau;
        SpaceshipProperties spaceshipPrope;
        HinhCauProperties hinhCauProperties;
        HinhLapPhuongProperties hinhLapPhuongProperties;
        HinhLapPhuong hinhLapPhuong;
        bool flag_rocket, chay;
        int dem = 0;

        public frm_Main()
        {

            InitializeComponent();

            hinhCau = new HinhCau(0, 0, 0, 1);
            hinhCauProperties = new HinhCauProperties();
            hinhCauProperties.Visible = false;

            hinhLapPhuong = new HinhLapPhuong(0, 0, 0, 0);
            hinhLapPhuongProperties = new HinhLapPhuongProperties();
            hinhLapPhuongProperties.Visible = false;

            //2D mode is startup;
            Setup_Toolbar(Globals._Mode_current);
            picb_2DArea.Dock = picb_3DArea.Dock = DockStyle.Fill;

            Setup_ToolTips();
            flag_rocket = false;



        }

        #region Function
        private void Setup_ToolTips()
        {

            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 500;
            tt.ReshowDelay = 500;
            tt.ShowAlways = true;

            #region Set tooltip for button inside pnl_Change


            #endregion

            #region Set tooltip for button inside pnl_2D

            //grb 2D
            foreach (Control ctr in this.grb_2DShapes.Controls)
            {
                if (ctr is Button)
                {
                    if (ctr.Tag == null)
                    {
                        tt.SetToolTip(ctr, "Tag_name null");
                    }
                    else
                    {
                        tt.SetToolTip(ctr, ctr.Tag.ToString());
                    }
                }
            }

            //grb line
            foreach (Control ctr in this.grb_2DLine.Controls)
            {
                if (ctr is Button)
                {
                    if (ctr.Tag == null)
                    {
                        tt.SetToolTip(ctr, "Tag_name null");
                    }
                    else
                    {
                        tt.SetToolTip(ctr, ctr.Tag.ToString());
                    }
                }
            }

            #endregion

            #region Set tooltip for button inside pnl_3D
            foreach (Control ctr in this.grb_3Dobject.Controls)
            {
                if (ctr is Button)
                {
                    if (ctr.Tag == null)
                    {
                        tt.SetToolTip(ctr, "Tag_name null");
                    }
                    else
                    {
                        tt.SetToolTip(ctr, ctr.Tag.ToString());
                    }
                }
            }
            #endregion
        }
        private void Setup_Toolbar(Constants.Mode mode)
        {
            // Ẩn toàn bộ các panel trong pnl_toolBox
            foreach (Control ctr in this.pnl_ToolBox.Controls) // List control trong pnl_ToolBox
            {
                ctr.Visible = false;
            }

            //Hiển thị pnl, thay đổi text, img của btn_Toolbar với mode tương ứng
            if (mode == Constants.Mode._2D)
            {
                this.pnl_Tb_2D.Visible = true;
                if (Variables.Globals._btn_isShowDetails)
                    this.btn_Toolbar.Text = "2D";
                this.btn_Toolbar.Image = Image_Res._2D_Model_25px;
                this.picb_2DArea.Dock = DockStyle.Fill;
                //this.panel9.Visible = true;
                picb_2DArea.BringToFront();



            }
            else if (mode == Constants.Mode._3D)
            {
                this.pnl_Tb_3D.Visible = true;
                if (Variables.Globals._btn_isShowDetails)
                    this.btn_Toolbar.Text = "3D";
                this.btn_Toolbar.Image = Image_Res._3D_Model_25px;
                this.picb_3DArea.Dock = DockStyle.Fill;
                //this.panel9.Visible = false;
                picb_3DArea.BringToFront();
                picb_3DArea.Refresh();
                flag_rocket  = false;
            }

        }
        private void SetTextForButton(bool isShow)
        {
            if (isShow)
            {

                
                //set btn_Toolbar theo mode hien tai
                btn_Toolbar.ImageAlign = ContentAlignment.TopCenter;
                if (Globals._Mode_current == Constants.Mode._2D)
                {
                    btn_Toolbar.Text = "2D";
                }
                else if (Globals._Mode_current == Constants.Mode._3D)
                {
                    btn_Toolbar.Text = "3D";
                }
            }
            else
            {
                foreach (Control ctr in this.pnl_Mode.Controls)
                {
                    if (ctr is Button)
                    {
                        Button btn = ctr as Button;
                        btn.Text = "";
                        btn.ImageAlign = ContentAlignment.MiddleCenter;

                    }
                }
                
            }
        }
        #endregion
        #region Event Handl
   
        /// <summary>
        /// When user click to button Toolbar 
        /// </summary>
        private void Btn_Toolbar_Click(object sender, EventArgs e)
        {
            UI.UserCtr.ChooseMode cm = new UI.UserCtr.ChooseMode(Variables.Globals._Mode_current);
            // Tạo event thay đổi từ Mode 2D sang 3D và ngược lại
            cm.VisibleChanged += new EventHandler(delegate (object obj, EventArgs ea)
            {
                UI.UserCtr.ChooseMode _cm = obj as UI.UserCtr.ChooseMode;
                if (!_cm.Visible)
                {
                    _cm.Dispose(); // Xóa toàn bộ component có trong _cm
                    if (_cm.Return_Mode != Globals._Mode_current) //da thay doi che do
                    {
                        Globals._Mode_current = _cm.Return_Mode;
                        Setup_Toolbar(Globals._Mode_current); //thay do hien thi

                    }
                }
            });
            cm.Location = new Point(this.pnl_Change.Location.X, this.pnl_Change.Location.Y);
            this.Controls.Add(cm);
            cm.BringToFront();
            cm.Focus();
        }


        /// <summary>
        /// Event Handl whent mouse enter to button.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Event.</param>
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1; //Resize border
        }

        /// <summary>
        /// Event Handl whent mouse leave this button.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Event</param>
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 0; //Resize border
        }

        /// <summary>
        /// Handl Event whent clicked.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Event.</param>
        private void Button_Click(object sender, EventArgs e)
        {
            if (Variables.Globals._Mode_current == Constants.Mode._2D)
            {
                //End focus button in grb_2DShapes
                foreach (Control ctr in grb_2DShapes.Controls)
                {
                    if (ctr is Button)
                    {
                        Button b = ctr as Button;
                        b.BackColor = Color.Transparent;
                    }
                }
            }
            else if (Variables.Globals._Mode_current == Constants.Mode._3D)
            {
                //End focus button in grb_3Dobject
                foreach (Control ctr in grb_3Dobject.Controls)
                {
                    if (ctr is Button)
                    {
                        Button b = ctr as Button;
                        b.BackColor = Color.Transparent;
                    }
                }
            }

            //Focus button clicked
            Button btn = sender as Button;
            btn.BackColor = Color.OrangeRed;

        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Tag.Equals("SpaceX"))
            {
                this.timer1.Start();
                spaceshipPrope = new SpaceshipProperties();
                flag_rocket = true;
//hinhTenLua = new HinhTenLua();
                this.pnl_ToolBox.Controls.Add(spaceshipPrope);
                spaceshipPrope.BringToFront();
                spaceshipPrope.Visible = true;
                spaceshipPrope.PropertyChanged += Spaceship_PropertyChanged;

            }
           

        }

        
        private void Spaceship_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
            if (e.PropertyName.Equals("xoa"))
            {
                flag_rocket = false;
            }
            else if (e.PropertyName.Equals("hieuung"))
            {
                chay = true;
            }
            else if (e.PropertyName.Equals("stop"))
            {
                chay = false;
            }
        }

        #endregion
        #region Vẽ trên pnl_WorkStation

        private void Veluoi2D(Graphics g)
        {
            Pen pen = new Pen(Color.RoyalBlue);
            int i = 0,
               width = Variables.Globals.sizeOfNewCoor_2D.Width,
               height = Variables.Globals.sizeOfNewCoor_2D.Height;

            for (i = 0; i < picb_2DArea.Width; i += 5)
            {
                g.DrawLine(pen, new Point(i, 0), new Point(i, picb_2DArea.Height));
            }
            for (i = 0; i < picb_2DArea.Height; i += 5)
            {
                g.DrawLine(pen, new Point(0, i), new Point(picb_2DArea.Width, i));
            }

            pen = new Pen(Color.Black);
            Font font = new Font("Arial", 16, FontStyle.Italic);
            g.DrawLine(pen, 5 * width / 2, 0, 5 * width / 2, picb_2DArea.Height);
            g.DrawLine(pen, 0, 5 * height / 2, picb_2DArea.Width, 5 * height / 2);
            g.DrawString("y", font, Brushes.DarkBlue, new Point(550, 1));
            g.DrawString("x", font, Brushes.DarkBlue, new Point(1082, 370));
            g.DrawString("O", font, Brushes.DarkBlue, new Point(550, 370));

        }
        /// <summary>
        /// Trả về giá trị chẵn của pnl_WorkStation
        /// </summary>
        public int ReturnEvenNumber(int number)
        {
            if (number % 2 == 0)
                return number;
            return number - 1;
        }


        private void picb_2DArea_Paint(object sender, PaintEventArgs e)
        {
            Veluoi2D(e.Graphics);

           
            if (flag_rocket)
            {
                
                hp.drawIt(e.Graphics);
                hinhTenLua.ToMau_2(e.Graphics);
                hinhTenLua.drawRocket_2(e.Graphics);



                //23/6/2020
                


                if (chay)
                {
                    dem++;


                    if (dem > 0 && dem < 110)
                    {
                        if (dem == 1)
                        {
                            //spaceshipPrope.reset();
                        }
                        hinhTenLua.PropertyChanged += Canh1_PropertyChanged;

                       
                    }
                    //in toa do canh 2
                    if (dem > 110 && dem <191)
                    {
                        
                        
                        if (dem == 111)
                        {
                            spaceshipPrope.reset();
                        }
                        hinhTenLua1.PropertyChanged += Canh2_PropertyChanged;
                        
                    }
                    //in tọa độ cảnh 3
                    if (dem > 191 && dem <= 300)
                    {
                        
                        if (dem == 192)
                        {
                            spaceshipPrope.reset();
                        }
                        htle1.PropertyChanged += Canh3_PropertyChanged;
                        
                    }


                    // in toa do canh 4
                    if (dem > 300 && dem < 400)
                    {
                        if (dem == 301)
                        {
                            spaceshipPrope.reset();
                        }
                        hinhTenLua2.PropertyChanged += Canh4_PropertyChanged;
                    }

                   
                    //canh 1: 
                    if (dem <= 8)
                    {
                        hp.quay(-1);
                    }
                    if (dem > 2 && dem <= 100)
                    {
                        hul.traslation_Fire(0, -5, e.Graphics);
                        
                        
                        hinhTenLua.traslation_TenLua(0, -5);


                        huk.traslation_Smoke(-1, 0);
                        huk1.traslation_Smoke(1, 0);
                        huk2.traslation_Smoke(-3, 0);
                        huk3.traslation_Smoke(3, 0);
                        huk4.traslation_Smoke(-5, 0);
                        huk5.traslation_Smoke(5, 0);
                        huk6.traslation_Smoke(-1, -1);
                        huk7.traslation_Smoke(1, -1);

                        huk.drawSmoke(e.Graphics);
                        huk1.drawSmoke(e.Graphics);
                        huk2.drawSmoke(e.Graphics);
                        huk3.drawSmoke(e.Graphics);
                        huk4.drawSmoke(e.Graphics);
                        huk5.drawSmoke(e.Graphics);
                        huk6.drawSmoke(e.Graphics);
                        huk7.drawSmoke(e.Graphics);
                    }

                    if(dem > 100)
                    {
                        hul.traslation_Fire(0, -50, e.Graphics);


                        hinhTenLua.traslation_TenLua(0, -50);


                        huk.traslation_Smoke(-50, -2);
                        huk1.traslation_Smoke(50, -2);
                        huk2.traslation_Smoke(-50, -2);
                        huk3.traslation_Smoke(50, -2);
                        huk4.traslation_Smoke(-50, -2);
                        huk5.traslation_Smoke(50, -2);
                        huk6.traslation_Smoke(-50, 0);
                        huk7.traslation_Smoke(50, 0);
                        hp.traslation_HinhPhu(-50, 50);

                        huk.drawSmoke(e.Graphics);
                        huk1.drawSmoke(e.Graphics);
                        huk2.drawSmoke(e.Graphics);
                        huk3.drawSmoke(e.Graphics);
                        huk4.drawSmoke(e.Graphics);
                        huk5.drawSmoke(e.Graphics);
                        huk6.drawSmoke(e.Graphics);
                        huk7.drawSmoke(e.Graphics);
                    }



                    
                    //canh 2:
                    if (dem > 110 && dem <= 115)
                    {
                        hul2.traslation_Fire_now(-40, -10);
                    }

                    if(dem >120 && dem <= 190)
                    {
                        //rotate 45
                        hinhTenLua1.quay(45, e.Graphics);
                        hul2.quay(45, e.Graphics);


                        hinhTenLua1.ToMau_2(e.Graphics);
                        hinhTenLua1.drawRocket_2(e.Graphics);
                        //tinhtien
                        hul2.traslation_Fire(2, -15, e.Graphics);
                        hinhTenLua1.traslation_TenLua(2, -15);
                        
                        //zoom
                        hinhTenLua1.testscale(1.01);
                        hul2.testscale(1.01);
                    }



                    //canh3:
                    if (dem >190 && dem <= 191)
                    {
                        htle.traslation_TenLua(0, 500);
                        htle1.traslation_TenLua(0, 500);
                        hvt.traslation_TenLua(0, 500);
                        //htle.quay_2(90, e.Graphics);
                        //htle1.quay_2(90, e.Graphics);
                    }
                    if (dem > 191 && dem <= 239)
                    {


                        htle1.traslation_TenLua(0, -10);
                        htle1.ToMau_3(e.Graphics);
                        htle1.drawRocket_3(e.Graphics);

                        htle.traslation_TenLua(0, -10);
                        htle.ToMauBow2(e.Graphics);
                        htle.drawBowRocket2(e.Graphics);

                        hvt.traslation_TenLua(0, -10);
                    }
                    if (dem > 239 && dem <= 249)
                    {
                        htle1.traslation_TenLua(0, 10);
                        htle1.ToMau_3(e.Graphics);
                        htle1.drawRocket_3(e.Graphics);


                        htle.ToMauBow2(e.Graphics);
                        htle.drawBowRocket2(e.Graphics);
                        htle.traslation_TenLua(0, -5);

                        hvt.traslation_TenLua(0, -5);
                    }
                    if (dem > 249  && dem <= 300)
                    {
                        htle.quay_bow(5, e.Graphics);
                        htle.traslation_Bow_TenLua(-10, 5);
                        htle.ToMauBow2(e.Graphics);
                        htle.drawBowRocket(e.Graphics);

                        htle1.traslation_TenLua(0, 10);
                        htle1.ToMau_3(e.Graphics);
                        htle1.drawRocket_3(e.Graphics);

                        hvt.ToMauSallite(e.Graphics);
                        hvt.drawSattelite(e.Graphics);
                        if (dem > 269)
                        {
                            hvt.changeSallite();
                            hvt.ToMauSallite(e.Graphics);
                            hvt.drawSattelite(e.Graphics);

                            hvt.traslation_TenLua(1, 1);
                        }
                    }
                    //canh 4:
                    if (dem > 300 && dem <= 301)
                    {
                        huk23.doiXungQuaOy();
                        huk24.doiXungQuaOy();
                        huk25.doiXungQuaOy();
                        huk26.doiXungQuaOy();
                        huk27.doiXungQuaOy();
                        huk28.doiXungQuaOy();
                        huk29.doiXungQuaOy();

                    }




                    if (dem >300 && dem <= 310)
                    {
                        hinhTenLua2.traslation_TenLua(0, -60);
                        hul3.traslation_Fire_now(0, -61);

                    }
                    if (dem > 310)
                    {

                        int temp = 2;

                        temp = hul3.traslation_Fire_Smaller(0, 5, e.Graphics);
                        hinhTenLua2.ToMau_3(e.Graphics);
                        hinhTenLua2.drawRocket_3(e.Graphics);
                        hinhTenLua2.traslation_TenLua_Top_Down(0, 5);
                        hinhTenLua2.traslation_Chan_TenLua(5, 10);
                        if (temp != 1)
                        {
                            if (dem > 30)
                            {
                                huk23.drawSmoke_2(e.Graphics);
                                huk24.drawSmoke_2(e.Graphics);
                                huk25.drawSmoke_2(e.Graphics);
                                huk26.drawSmoke_2(e.Graphics);
                                huk27.drawSmoke_2(e.Graphics);
                                huk28.drawSmoke_2(e.Graphics);
                                huk29.drawSmoke_2(e.Graphics);
                                huk30.drawSmoke_2(e.Graphics);
                                huk31.drawSmoke_2(e.Graphics);
                                huk32.drawSmoke_2(e.Graphics);
                                huk33.drawSmoke_2(e.Graphics);
                                huk34.drawSmoke_2(e.Graphics);
                                huk35.drawSmoke_2(e.Graphics);
                                huk36.drawSmoke_2(e.Graphics);


                                huk23.traslation_Smoke(-5, 0);
                                huk24.traslation_Smoke(-90, -30);
                                huk25.traslation_Smoke(-70, -40);
                                huk26.traslation_Smoke(-50, -20);
                                huk27.traslation_Smoke(-30, 0);
                                huk28.traslation_Smoke(-10, 0);
                                huk29.traslation_Smoke(-6, 0);

                                huk30.traslation_Smoke(5, 0);
                                huk31.traslation_Smoke(6, 0);
                                huk32.traslation_Smoke(10, 0);
                                huk33.traslation_Smoke(20, 0);
                                huk34.traslation_Smoke(40, -20);
                                huk35.traslation_Smoke(60, -30);
                                huk36.traslation_Smoke(80, -40);
                            }


                        }
                        if (temp == 1)
                        {
                            hinhTenLua2.quay_2(5, e.Graphics);
                            hinhTenLua2.quay(45, e.Graphics);
                            hinhTenLua2.traslation_TenLua(50, -10);



                            huk12.drawSmoke(e.Graphics);
                            huk13.drawSmoke(e.Graphics);

                            huk9.drawSmoke(e.Graphics);

                            huk10.drawSmoke(e.Graphics);
                            huk14.drawSmoke(e.Graphics);
                            huk11.drawSmoke(e.Graphics);
                            huk15.drawSmoke(e.Graphics);



                            huk16.drawSmoke(e.Graphics);
                            huk17.drawSmoke(e.Graphics);
                            huk18.drawSmoke(e.Graphics);
                            huk19.drawSmoke(e.Graphics);
                            huk20.drawSmoke(e.Graphics);
                            huk21.drawSmoke(e.Graphics);
                            huk22.drawSmoke(e.Graphics);

                            huk9.traslation_Smoke(5, 0);

                            huk10.traslation_Smoke(1, 0);
                            huk11.traslation_Smoke(2, 0);
                            huk12.traslation_Smoke(3, 0);
                            huk13.traslation_Smoke(2, -1);
                            huk14.traslation_Smoke(5, 1);
                            huk15.traslation_Smoke(1, -1);

                            huk16.traslation_Smoke(2, -2);
                            huk17.traslation_Smoke(5, 1);
                            huk18.traslation_Smoke(8, -3);
                            huk19.traslation_Smoke(5, -1);
                            huk20.traslation_Smoke(7, 0);
                            huk21.traslation_Smoke(6, -4);
                            huk22.traslation_Smoke(10, -3);

                        }


                    }




                }
            }

            

        }
        #endregion
        private void Canh1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {


            spaceshipPrope.DsDiem = (Point[])hinhTenLua.diem.Clone();
            spaceshipPrope.DsDiemLua = (Point[])hul.diem.Clone();
            spaceshipPrope.DsDiemKhoi = (Point[])huk.diem.Clone();
            //spaceshipPrope.DsDiemVeTinh = (Point[])hinhTenLua1.diem.Clone();
            //spaceshipPrope.DsDiemDauTenLua = (Point[])hinhTenLua1.diem.Clone();

            //xe.bankinh = hinhXe.BkBanh;
            spaceshipPrope.infoShape(1);

        }
        private void Canh2_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            spaceshipPrope.DsDiem = (Point[])hinhTenLua1.diem.Clone();
            spaceshipPrope.DsDiemLua = (Point[])hul2.diem.Clone();
            //spaceshipPrope.DsDiemKhoi = (Point[])hinhTenLua1.diem.Clone();
            //spaceshipPrope.DsDiemVeTinh = (Point[])hinhTenLua1.diem.Clone();
            //spaceshipPrope.DsDiemDauTenLua = (Point[])hinhTenLua1.diem.Clone();

            //xe.bankinh = hinhXe.BkBanh;
            spaceshipPrope.infoShape(2);

        }

        private void Canh3_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            spaceshipPrope.DsDiem = (Point[])htle1.diem.Clone();
            spaceshipPrope.DsDiemDauTenLua = (Point[])htle.diem.Clone();
            spaceshipPrope.DsDiemVeTinh = (Point[])hvt.diem.Clone();


            //spaceshipPrope.DsDiemKhoi = (Point[])hinhTenLua1.diem.Clone();
            //spaceshipPrope.DsDiemVeTinh = (Point[])hinhTenLua1.diem.Clone();
            //spaceshipPrope.DsDiemDauTenLua = (Point[])hinhTenLua1.diem.Clone();

            //xe.bankinh = hinhXe.BkBanh;
            spaceshipPrope.infoShape(3);

        }
        private void Canh4_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            spaceshipPrope.DsDiem = (Point[])hinhTenLua2.diem.Clone();
            spaceshipPrope.DsDiemLua = (Point[])hul3.diem.Clone();
            spaceshipPrope.DsDiemKhoi = (Point[])huk23.diem.Clone();
            //spaceshipPrope.DsDiemVeTinh = (Point[])hinhTenLua1.diem.Clone();
            //spaceshipPrope.DsDiemDauTenLua = (Point[])hinhTenLua1.diem.Clone();

            //xe.bankinh = hinhXe.BkBanh;
            spaceshipPrope.infoShape(4);

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            this.picb_2DArea.Refresh();
        }

        

        private void picb_2DArea_SizeChanged(object sender, EventArgs e)
        {
            Variables.Globals.sizeOfNewCoor_2D.Width = ReturnEvenNumber(picb_2DArea.Width / Variables.Globals.sizePerPoint.Width);
            Variables.Globals.sizeOfNewCoor_2D.Height = ReturnEvenNumber(picb_2DArea.Height / Variables.Globals.sizePerPoint.Height);
        }

       



        #region Vẽ trên picb_3DArea sử dụng Cavalier
        private void Picb_3DArea_Paint(object sender, PaintEventArgs e)
        {
            VeLuoi3D(e.Graphics);

            if (hinhCauProperties.Visible == true)
            {
                hinhCau.Draw(e.Graphics);
                hinhCauProperties.Dinh = hinhCau.TamDay;
            }
            if (hinhLapPhuongProperties.Visible == true)
            {
                hinhLapPhuong.Draw(e.Graphics);
                hinhLapPhuongProperties.Dinh = hinhLapPhuong.Dinh;
            }

        }

        private void Picb_3DArea_SizeChanged(object sender, EventArgs e)
        {
            Variables.Globals.sizeOfNewCoor_3D.Width = ReturnEvenNumber(picb_3DArea.Width / Variables.Globals.sizePerPoint.Width);
            Variables.Globals.sizeOfNewCoor_3D.Height = ReturnEvenNumber(picb_3DArea.Height / Variables.Globals.sizePerPoint.Height);

            picb_3DArea.Width = Variables.Globals.sizeOfNewCoor_3D.Width * 5;
            picb_3DArea.Height = Variables.Globals.sizeOfNewCoor_3D.Height * 5;
        }

        public void VeLuoi3D(Graphics g)
        {
            Pen pen = new Pen(Color.RoyalBlue);

            // Vẽ lưới 
            for (int i = 0; i < picb_3DArea.Width; i += 5)
            {
                g.DrawLine(pen, new Point(i, 0), new Point(i, picb_2DArea.Height));
            }
            for (int i = 0; i < picb_3DArea.Height; i += 5)
            {
                g.DrawLine(pen, new Point(0, i), new Point(picb_2DArea.Width, i));
            }

            // Vẽ trục tọa độ
            pen = new Pen(Color.Black);
            int x = picb_3DArea.Width * 2 / 5,//365,
               y = picb_3DArea.Height / 2; //305,

            g.DrawLine(pen, new Point(x, y), new Point(picb_3DArea.Width, y));         // trục Ox
            g.DrawLine(pen, new Point(x, y), new Point(x, 0));                          // trục Oy
            g.DrawLine(pen, new Point(x, y), new Point(x - y, y + y));                      // trục Oz
            System.Console.WriteLine((x - y) + " " + (y));
            Font font = new Font("Arial", 16, FontStyle.Italic);

            g.DrawString("y", font, Brushes.DarkBlue, new Point(440, 1));

            g.DrawString("x", font, Brushes.DarkBlue, new Point(1082, 345));
            g.DrawString("z", font, Brushes.DarkBlue, new Point(50, 715));

        }

       

        private void Button2_Click(object sender, EventArgs e)
        {
            this.picb_3DArea.Refresh();
        }

        private void Picb_2DArea_Click(object sender, EventArgs e)
        {

        }

        private void grb_3Dobject_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_LocationInGird_Click(object sender, EventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void HinhCauProperties_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
           
            string[] str = e.PropertyName.Split(',');
            int x = Int16.Parse(str[0]),
                y = Int16.Parse(str[1]),
                z = Int16.Parse(str[2]),
                banKinhDay = Int16.Parse(str[3]);

            hinhCau = new HinhCau(x, y, z, banKinhDay);

            picb_3DArea.Refresh();
            hinhCau.Draw(picb_3DArea.CreateGraphics());

        }
        private void HinhLapPhuongProperties_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            string[] str = e.PropertyName.Split(',');
            int x = Int16.Parse(str[0]),
                y = Int16.Parse(str[1]),
                z = Int16.Parse(str[2]),
                chieuDai = Int16.Parse(str[3]);
                

            hinhLapPhuong = new HinhLapPhuong(x, y, z, chieuDai);

            picb_3DArea.Refresh();
            hinhLapPhuong.Draw(picb_3DArea.CreateGraphics());

        }

        private void grb_2DShapes_Enter(object sender, EventArgs e)
        {

        }

        private void pnl_Mode_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(vecoban.IsDisposed)
                {
                    vecoban = new KyThuatDoHoa.Form1();
                    
                }   
                
            }
            catch(Exception)
            {
                vecoban = new KyThuatDoHoa.Form1();
            }
            finally
            {
                vecoban.Show();
            }
        }

        private void BTN3D_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Tag.Equals("Hinh Cau"))
            {
                this.pnl_ToolBox.Controls.Add(hinhCauProperties);
                hinhCauProperties.PropertyChanged += HinhCauProperties_PropertyChanged;
                if (flag_rocket == false)
                {
                    hinhCauProperties.Refresh();
                }

                hinhCauProperties.BringToFront();
                hinhCauProperties.Visible = true;
                hinhLapPhuongProperties.Visible = false;
            }
            else if (btn.Tag.Equals("Hinh Lap Phuong"))
            {
                this.pnl_ToolBox.Controls.Add(hinhLapPhuongProperties);
                hinhLapPhuongProperties.PropertyChanged += HinhLapPhuongProperties_PropertyChanged;
                if (flag_rocket == false)
                {
                    hinhLapPhuongProperties.Refresh();
                }

                hinhLapPhuongProperties.BringToFront();
                hinhLapPhuongProperties.Visible = true;
                hinhCauProperties.Visible = false;
            }
        }
    }
    #endregion
}