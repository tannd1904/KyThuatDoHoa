using KyThuatDoHoa._2D;
using KyThuatDoHoa._3D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace KyThuatDoHoa
{
    public partial class Form1 : Form
    {
        public static int PX;
        private Graphics g;
        private Descart d2;
        private bool painting = false;
        private bool tinhtien = false;
        private Point Cursor_temp = new Point(0,0);
        private Descart D2 { get => d2; set => d2 = value; }
        internal List<Label> List_name { get => list_name; set => list_name = value; }
        internal List<Segment> List_segment { get => list_segment; set => list_segment = value; }
        internal List<Circle> List_circle { get => list_circle; set => list_circle = value; }
        internal List<Point> List_temp { get => list_temp; set => list_temp = value; }
        internal List<Elip> List_Elip { get => list_Elip; set => list_Elip = value; }
        internal List<Square> List_hv { get => list_hv; set => list_hv = value; }
        internal List<Square> List_hcn { get => list_hcn; set => list_hcn = value; }

        public static bool [] PointName = Enumerable.Repeat(true, 26).ToArray();
        public static int CountName = 0;
        private Point c1, c2;
        private List<Label> list_name = new List<Label>();
        private List<Segment> list_segment = new List<Segment>();
        private List<Circle> list_circle = new List<Circle>();
        private List<Point> list_temp = new List<Point>();
        private List<Elip> list_Elip = new List<Elip>();
        private List<Square> list_hv = new List<Square>();
        private List<Square> list_hcn = new List<Square>();
        //--------------------------Load--------------------------
        public Form1()
        {
            InitializeComponent();
            grb_Circle.Location = grb_Segment.Location;
            grb_Elip.Location = grb_Segment.Location;
            grb_hv.Location = grb_Segment.Location;
            grb_hcn.Location = grb_Segment.Location;

        }
        public static String GetPointName()
        {
            if(!PointName.Contains(true))
            {
                for (int i = 0; i < PointName.Length; i++)
                {
                    PointName[i] = true;
                }
                CountName++;
            }
            for (int i = 0; i < PointName.Length; i++)
            {
                if(PointName[i])
                {
                    PointName[i] = false;
                    return (char)(i + 65) + "" + CountName;

                }    
            }
            return "";
        }
        private void Form_OnLoad(object sender, EventArgs e)
        {
            Form1.PX = zoom.Value;
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            g = this.draw.CreateGraphics();
            Draw_DesCart();
        }
        //===============================================================

        //--------------------------Xử lý dữ liệu-------------------------
        private void ShowAll()
        {
            if (cb_showName.Checked)
                Show_Name();
            
            if (cb1.Checked)
                Show_Segment();
            else
                Hide_Segment();
            if (cb2.Checked)
                Show_Circle();
            else
                Hide_Circle();
            if (cb3.Checked)
                Show_Ellip();
            else
                Hide_Ellip();
            if (cb4.Checked)
                Show_HCN();
            else
                Hide_HCN();
            if (cb5.Checked)
                Show_HV();
            else
                Hide_HV();
        }
        private void TyLe_Segment(double x)
        {
            try
            {
                foreach (var item in List_segment)
                {
                    item.Hide(g,d2.O);
                    item.PhepTyLe(x);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void TyLe_HCN(double x)
        {
            try
            {
                foreach (var item in List_hcn)
                {
                    item.Hide(g, d2.O);
                    item.PhepTyLe(x);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void TyLe_HV(double x)
        {
            try
            {
                foreach (var item in List_hv)
                {
                    item.Hide(g, d2.O);
                    item.PhepTyLe(x);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void TyLe_Ellip(double x)
        {
            try
            {
                foreach (var item in List_Elip)
                {
                    item.Hide(g, d2.O);
                    item.PhepTyLe(x);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void TyLe_Circle(double x)
        {
            try
            {
                foreach (var item in List_circle)
                {
                    item.Hide(g, d2.O);
                    item.PhepTyLe(x);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungO_Segment()
        {
            try
            {
                foreach (var item in List_segment)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungO();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungO_HCN()
        {
            try
            {
                foreach (var item in List_hcn)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungO();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungO_HV()
        {
            try
            {
                foreach (var item in List_hv)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungO();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungO_Ellip()
        {
            try
            {
                foreach (var item in List_Elip)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungO();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungO_Circle()
        {
            try
            {
                foreach (var item in List_circle)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungO();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungOx_Segment()
        {
            try
            {
                foreach (var item in List_segment)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungOx();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungOx_HCN()
        {
            try
            {
                foreach (var item in List_hcn)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungOx();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungOx_HV()
        {
            try
            {
                foreach (var item in List_hv)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungOx();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungOx_Ellip()
        {
            try
            {
                foreach (var item in List_Elip)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungOx();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungOx_Circle()
        {
            try
            {
                foreach (var item in List_circle)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungOx();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungOy_Segment()
        {
            try
            {
                foreach (var item in List_segment)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungOy();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungOy_HCN()
        {
            try
            {
                foreach (var item in List_hcn)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungOy();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungOy_HV()
        {
            try
            {
                foreach (var item in List_hv)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungOy();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungOy_Ellip()
        {
            try
            {
                foreach (var item in List_Elip)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungOy();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void DoiXungOy_Circle()
        {
            try
            {
                foreach (var item in List_circle)
                {
                    item.Hide(g, d2.O);
                    item.PhepDoiXungOy();
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Quay_Circle(int x)
        {
            try
            {
                foreach (var item in List_circle)
                {
                    item.Hide(g, d2.O);
                    item.PhepQuay(x);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Quay_HCN(int x)
        {
            try
            {
                foreach (var item in List_hcn)
                {
                    item.Hide(g, d2.O);
                    item.PhepQuay(x);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Quay_HV(int x)
        {
            try
            {
                foreach (var item in List_hv)
                {
                    item.Hide(g, d2.O);
                    item.PhepQuay(x);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Quay_Ellip(int x)
        {
            try
            {
                foreach (var item in List_Elip)
                {
                    item.Hide(g, d2.O);
                    item.PhepQuay(x);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Quay_Segment(int x)
        {
            try
            {
                foreach (var item in List_segment)
                {
                    item.Hide(g, d2.O);
                    item.PhepQuay(x);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void TinhTien_Segment(int x, int y)
        {
            try
            {
                foreach (var item in List_segment)
                {
                    item.Hide(g, d2.O);
                    item.PhepTinhTien(x, y);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void TinhTien_HCN(int x, int y)
        {
            try
            {
                foreach (var item in List_hcn)
                {
                    item.Hide(g, d2.O);
                    item.PhepTinhTien(x, y);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void TinhTien_HV(int x, int y)
        {
            try
            {
                foreach (var item in List_hv)
                {
                    item.Hide(g, d2.O);
                    item.PhepTinhTien(x, y);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void TinhTien_Ellip(int x, int y)
        {
            try
            {
                foreach (var item in List_Elip)
                {
                    item.Hide(g, d2.O);
                    item.PhepTinhTien(x, y);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void TinhTien_Circle(int x,int y)
        {
            try
            {
                foreach (var item in List_circle)
                {
                    item.Hide(g, d2.O);
                    item.PhepTinhTien(x,y);
                    item.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Show_Circle()/*Hiển thị tất cả vòng tròn*/
        {
            try
            {
                foreach (Circle p in List_circle)
                {
                    p.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Show_HCN()/*Hiển thị tất cả hình chữ nhật*/
        {
            try
            {
                foreach (var p in List_hcn)
                {
                    p.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Show_HV()/*Hiển thị tất cả hình chữ nhật*/
        {
            try
            {
                foreach (var p in List_hv)
                {
                    p.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Show_Ellip()/*Hiển thị tất cả vòng elip*/
        {
            try
            {
                foreach (var p in List_Elip)
                {
                    p.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Show_Temp(int type =0)
        {
            try
            {
                foreach (Point p in List_temp)
                {
                    if(type == 1)
                    {
                        p.Show(g, Color.MediumVioletRed, d2.O, 2);
                    }
                    else
                        p.Show(g, d2.O);
                }
            }
            catch(Exception) { }
        }
        private void Show_Name()
        {
            try
            {
                foreach (Label p in List_name)
                {
                    p.BackColor = Color.Empty;
                        if (!draw.Controls.Contains(p))
                            draw.Controls.Add(p);

                    p.Visible = true ;

                }
            }
            catch (Exception)
            { }
        }
        private void Show_Segment()/*Hiển thị tất cả đoạn thẳng*/
        {
            try
            {
                foreach (Segment p in List_segment)
                {
                    p.Show(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }

        private void HideAll()
        {
            
            Hide_Segment();
            Hide_Ellip();
            Hide_Circle();
            Hide_Temp();
            Hide_Name();
            Hide_HCN();
            Hide_HV();
        }

        private void Hide_Circle()/*Ẩn hết các vòng tròn*/
        {
            try
            {
                foreach (Circle p in List_circle)
                {
                    p.Hide(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Hide_Ellip()/*Ẩn hết các vòng elip*/
        {
            try
            {
                foreach (var p in List_Elip)
                {
                    p.Hide(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Hide_HCN()/*Ẩn hết các vòng elip*/
        {
            try
            {
                foreach (var p in List_hcn)
                {
                    p.Hide(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Hide_HV()/*Ẩn hết các vòng elip*/
        {
            try
            {
                foreach (var p in List_hv)
                {
                    p.Hide(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Hide_Name()
        {
            try
            {
                foreach (Label p in List_name)
                {
                    p.Visible = false;
                }
            }
            catch (Exception)
            { }
            draw.Refresh();
        }
        private void Hide_Temp()/*Ẩn hết các điểm tạm*/
        {
            try
            {
                foreach (Point p in List_temp)
                {
                    p.Hide(g, d2.O);
                }
            }
            catch (Exception)
            { }
        }
        private void Hide_Segment()/*ẩn hết các đoạn thẳng*/
        {
            try
            {
                foreach (Segment p in List_segment)
                {
                    p.Hide(g, d2.O);
                }
                
            }
            catch (Exception)
            { }
        }

        private void ClearAll()
        {
            try
            { 
                HideAll();
                List_Elip.Clear();
                List_segment.Clear();
                List_circle.Clear();
                List_name.Clear();
                List_temp.Clear();
                List_hcn.Clear();
                List_hv.Clear();
            }
            catch (Exception)
            { }
        }
        private void Draw_DesCart()/*-Vẽ tọa độ-*/
        {
            
            Descart.BackColor = draw.BackColor;
            if (cb_3D.Checked)
            {
                //cb_3D.Text = "Vẽ 3D";
                cb_3D.ForeColor = Color.Red;
                D2 = new Descart3D(g, new Coor(62*5,  draw.Height / 2), 0, 0, draw.Width, draw.Height);
               // Point s = new Point(5, 5, 5);
               // s.Show(g,d2.O);
                //List_name.Add(s.Show_Label(d2.O));
            }    
                
            else
            {
                //cb_3D.Text = "Vẽ 3D";
                cb_3D.ForeColor = Color.Green;
                D2 = new Descart2D(g, new Coor(draw.Width / 2, draw.Height / 2), 0, 0, draw.Width, draw.Height);
               
            }    
               
        }

        //--------------------------Zoom Event--------------------------
        private void Zoom_Change(object sender, EventArgs e)/*Thay đổi số pixel 1 đơn vị*/
        {
            D2.Reset();
            if (zoom.Value % 2 == 0)
                zoom.Value++;
            Form1.PX = zoom.Value;
            lb_zoom.Text = "x" + zoom.Value;
            Draw_DesCart();
            ShowAll();
        }
        //==================================================================


        //--------------------------Mouse Click Event--------------------------
        private void Start_Draw(object sender, MouseEventArgs e)/*Bắt đầu click lần 1*/
        {
            if(!cb_3D.Checked)
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                try
                {
                    contextMenuStrip1.PointToClient(new System.Drawing.Point(e.X, e.Y));
                    contextMenuStrip1.Show(Cursor.Position);
                    Cursor_temp.X = e.X;
                    Cursor_temp.Y = e.Y;
                }
                catch(NullReferenceException)
                {
                    contextMenuStrip1 = new ContextMenuStrip();
                }
                finally
                {
                    Cursor_temp.X = e.X;
                    Cursor_temp.Y = e.Y;
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (tinhtien)
                {
                    tinhtien = false;
                    Hide_Temp();
                    c2  = Point.Convert_P2D(e.X, e.Y, d2.O);
                    int x = c2.X - c1.X;
                    int y = c2.Y - c1.Y;
                    if (cb1.Checked)
                        TinhTien_Segment(x, y);
                    if (cb2.Checked)
                        TinhTien_Circle(x, y);
                    if (cb3.Checked)
                        TinhTien_Ellip(x, y);
                    if (cb4.Checked)
                        TinhTien_HCN(x, y);
                    if (cb5.Checked)
                        TinhTien_HV(x, y);
                }
                else
                {
                    List_temp.Clear();
                    painting = true;
                    c1 = Point.Convert_P2D(e.X, e.Y, d2.O);
                    c1.D3 = cb_3D.Checked;
                    c1.Show(g,  d2.O);
                    //lb_zoom.Text = e.X.ToString();
                    if (rb_dt.Checked)
                    {
                        coor_F_X.Text = c1.X + "";
                        coor_F_Y.Text = c1.Y + "";
                        if (cb_3D.Checked)
                        {
                            coor_F_Z.Text = c1.Z + "";
                        }
                        else
                        {
                            coor_F_Z.Text = "";
                        }
                    }
                    else if (rb_circle.Checked)
                    {
                        coor_Circle_X.Text = c1.X + "";
                        coor_Circle_Y.Text = c1.Y + "";
                        if (cb_3D.Checked)
                        {
                            coor_Circle_Z.Text = c1.Z + "";
                        }
                        else
                        {
                            coor_Circle_Z.Text = "";
                        }
                    }
                    else if (rb_elip.Checked)
                    {
                        coor_Elip_X.Text = c1.X + "";
                        coor_Elip_Y.Text = c1.Y + "";
                        if (cb_3D.Checked)
                        {
                            coor_Elip_Z.Text = c1.Z + "";
                        }
                        else
                        {
                            coor_Elip_Z.Text = "";
                        }
                    }
                    else if (rb_hcn.Checked)
                    {
                        coor_hcn_X.Text = c1.X + "";
                        coor_hcn_Y.Text = c1.Y + "";
                        if (cb_3D.Checked)
                        {
                            coor_hcn_Z.Text = c1.Z + "";
                        }
                        else
                        {
                            coor_hcn_Z.Text = "";
                        }
                    }
                    else if (rb_hv.Checked)
                    {
                        coor_hv_X.Text = c1.X + "";
                        coor_hv_Y.Text = c1.Y + "";
                        if (cb_3D.Checked)
                        {
                            coor_hv_Z.Text = c1.Z + "";
                        }
                        else
                        {
                            coor_hv_Z.Text = "";
                        }
                    }

                }
            }    
                
        }
        private void Mouse_E_Drag(object sender, MouseEventArgs e)/*Kéo chuột để vẽ*/
        {
            if (cb_3D.Checked) return;
            try
            {
                if (cb_3D.Checked)
                {

                }
                else
                {
                    lb_X.Text = Point.Convert_P2D(e.X, d2.O, -1) + "";
                    lb_Y.Text = Point.Convert_P2D(e.Y, d2.O, 0) + "";
                    //lb_Z.Text = Point.Convert_P2D(e.X, d2.O, 1) + "";
                }
            }
            catch (Exception) { }
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                 if (painting)
                {
                    try
                    {
                        Hide_Temp();
                        c2 = Point.Convert_P2D(e.X, e.Y, d2.O);
                        if (c1.X == c2.X && c1.Y == c2.Y)
                        {
                            c1.Hide(g, d2.O);
                            return;
                        }
                        if (rb_dt.Checked)
                        {
                            List_temp = new Segment(c1, c2).List;
                            coor_L_X.Text = c2.X + "";
                            coor_L_Y.Text = c2.Y + "";
                            if (cb_3D.Checked)
                            {
                                coor_L_Z.Text = c2.Z + "";
                            }
                        }
                        else if (rb_circle.Checked)
                        {
                            //lb_zoom.Text = Segment.Distant(c1, c2)+"";
                            List_temp = new Circle(c1, Segment.Distant(c1, c2)).List;
                            circle_radius.Text = Convert.ToInt32(Segment.Distant(c1, c2)) + "";
                        }
                        else if (rb_elip.Checked)
                        {
                            int a = Math.Abs(c2.X - c1.X);
                            int b = Math.Abs(c2.Y - c1.Y);
                            //lb_zoom.Text = Segment.Distant(c1, c2)+"";
                            List_temp = new Elip(c1, a,b).List;
                            txt_Eclip_a.Text = a + "";
                            txt_Eclip_b.Text = b + "";
                        }
                        else if (rb_hcn.Checked)
                        {
                            //lb_zoom.Text = Segment.Distant(c1, c2)+"";
                            Square s = new Square(c1, c2);
                            List_temp = s.List;
                            hcn_canh_a.Text = s.a + "";
                            hcn_canh_b.Text = s.b + "";
                        }
                        else if (rb_hv.Checked)
                        {
                            Square s = new Square(c1, c2,true);
                            List_temp = s.List;
                            hv_canh.Text = s.a + "";
                            
                        }
                        Show_Temp();
                    }
                    catch (Exception)
                    { }

                }
                 
            }
            if (tinhtien)
            {
                try
                {
                    Hide_Temp();
                    c2 = Point.Convert_P2D(e.X, e.Y, d2.O);
                    if (c1.X == c2.X && c1.Y == c2.Y)
                    {
                        c1.Hide(g, d2.O);
                        return;
                    }

                    List_temp = new Segment(c1, c2).List;

                    Show_Temp(1);
                }
                catch (Exception)
                { }
            }
        }
        private void Stop_Draw(object sender, MouseEventArgs e)/*Dừng kéo chuột - Click lần 2*/
        {
            if (cb_3D.Checked) return;
            if (e.Button == System.Windows.Forms.MouseButtons.Left&&painting)
            {
                painting = false;
                c2 = Point.Convert_P2D(e.X, e.Y, d2.O);
                if (c1.X == c2.X && c1.Y == c2.Y)
                {
                    c1.Hide(g, d2.O);
                    return;
                }

                //c2.Show(g, Descart.Point, d2.O, Form1.PX);
                try
                {
                    if (rb_dt.Checked)
                    {
                        List_name.Add(c1.Show_Label(d2.O));
                        List_name.Add(c2.Show_Label(d2.O));
                        List_segment.Add(new Segment(c1, c2));
                        coor_L_X.Text = c2.X + "";
                        coor_L_Y.Text = c2.Y + "";
                        if (cb_3D.Checked)
                        {
                            coor_L_Z.Text = c2.Z + "";
                        }
                    }
                    else if (rb_circle.Checked)
                    {
                        List_name.Add(c1.Show_Label(d2.O));
                        //lb_zoom.Text = Segment.Distant(c1, c2)+"";
                        List_circle.Add(new Circle(c1, Segment.Distant(c1, c2)));

                        circle_radius.Text = Convert.ToInt32(Segment.Distant(c1, c2)) + "";
                    }
                    else if (rb_elip.Checked)
                    {
                        List_name.Add(c1.Show_Label(d2.O));
                        int a = Math.Abs(c2.X - c1.X);
                        int b = Math.Abs(c2.Y - c1.Y);
                        //lb_zoom.Text = Segment.Distant(c1, c2)+"";
                        
                        txt_Eclip_a.Text = a + "";
                        txt_Eclip_b.Text = b + "";
                        List_Elip.Add(new Elip(c1, a, b));

                        
                    }
                    else if (rb_hcn.Checked)
                    {
                        
                        //lb_zoom.Text = Segment.Distant(c1, c2)+"";
                        Square s = new Square(c1, c2);
                        List_name.Add(s.A.Show_Label(d2.O)) ;
                        List_name.Add(s.B.Show_Label(d2.O));
                        List_name.Add(s.C.Show_Label(d2.O));
                        List_name.Add(s.D.Show_Label(d2.O));
                        List_hcn.Add(s);

                        hcn_canh_a.Text = s.a + "";
                        hcn_canh_b.Text = s.b + "";
                    }
                    else if (rb_hv.Checked)
                    {
                        Square s = new Square(c1, c2,true);
                        List_name.Add(s.A.Show_Label(d2.O));
                        List_name.Add(s.B.Show_Label(d2.O));
                        List_name.Add(s.C.Show_Label(d2.O));
                        List_name.Add(s.D.Show_Label(d2.O));
                        List_hv.Add(s);

                        hv_canh.Text = s.a + "";
                        
                    }
                }
                catch (Exception)
                { }
                ShowAll();
            }
        }
        private void PhepDoiXungO(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                DoiXungO_Segment();
            }
            if (cb2.Checked)
            {
                DoiXungO_Circle();
            }
            if (cb3.Checked)
            {
                DoiXungO_Ellip();
            }
            if (cb4.Checked)
            {
                DoiXungO_HCN();
            }
            if (cb5.Checked)
            {
                DoiXungO_HV();
            }
        }
        private void PhepDoiXungOx(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                DoiXungOx_Segment();
            }
            if (cb2.Checked)
            {
                DoiXungOx_Circle();
            }
            if (cb3.Checked)
            {
                DoiXungOx_Ellip();
            }
            if (cb4.Checked)
            {
                DoiXungOx_HCN();
            }
            if (cb5.Checked)
            {
                DoiXungOx_HV();
            }
        }
        private void PhepDoiXungOy(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                DoiXungOy_Segment();
            }
            if (cb2.Checked)
            {
                DoiXungOy_Circle();
            }
            if (cb3.Checked)
            {
                DoiXungOy_Ellip();
            }
            if (cb4.Checked)
            {
                DoiXungOy_HCN();
            }
            if (cb5.Checked)
            {
                DoiXungOy_HV();
            }
        }
        private void PhepQuay1(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                Quay_Segment(-45);
            }
            if (cb2.Checked)
            {
                Quay_Circle(-45);
            }
            if (cb3.Checked)
            {
                Quay_Ellip(-45);
            }
            if (cb4.Checked)
            {
                Quay_HCN(-45);
            }
            if (cb5.Checked)
            {
                Quay_HV(-45);
            }
        }
        private void PhepQuay2(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                Quay_Segment(-90);
            }
            if (cb2.Checked)
            {
                Quay_Circle(-90);
            }
            if (cb3.Checked)
            {
                Quay_Ellip(-90);
            }
            if (cb4.Checked)
            {
                Quay_HCN(-90);
            }
            if (cb5.Checked)
            {
                Quay_HV(-90);
            }
        }
        private void PhepQuay3(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                Quay_Segment(180);
            }
            if (cb2.Checked)
            {
                Quay_Circle(180);
            }
            if (cb3.Checked)
            {
                Quay_Ellip(180);
            }
            if (cb4.Checked)
            {
                Quay_HCN(180);
            }
            if (cb5.Checked)
            {
                Quay_HV(180);
            }
        }
        private void PhepQuay4(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                Quay_Segment(90);
            }
            if (cb2.Checked)
            {
                Quay_Circle(90);
            }
            if (cb3.Checked)
            {
                Quay_Ellip(90);
            }
            if (cb4.Checked)
            {
                Quay_HCN(90);
            }
            if (cb5.Checked)
            {
                Quay_HV(90);
            }
        }
        private void PhepQuay5(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                Quay_Segment(45);
            }
            if (cb2.Checked)
            {
                Quay_Circle(45);
            }
            if (cb3.Checked)
            {
                Quay_Ellip(45);
            }
            if (cb4.Checked)
            {
                Quay_HCN(45);
            }
            if (cb5.Checked)
            {
                Quay_HV(45);
            }
        }
        private void Click_TyLe1(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                TyLe_Segment(0.25);
            }
            if (cb2.Checked)
            {
                TyLe_Circle(0.25);
            }
            if (cb3.Checked)
            {
                TyLe_Ellip(0.25);
            }
            if (cb4.Checked)
            {
                TyLe_HCN(0.25);
            }
            if (cb5.Checked)
            {
                TyLe_HV(0.25);
            }
        }

        private void Click_TyLe2(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                TyLe_Segment(0.5);
            }
            if (cb2.Checked)
            {
                TyLe_Circle(0.5);
            }
            if (cb3.Checked)
            {
                TyLe_Ellip(0.5);
            }
            if (cb4.Checked)
            {
                TyLe_HCN(0.5);
            }
            if (cb5.Checked)
            {
                TyLe_HV(0.5);
            }
        }

        private void Click_TyLe3(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                TyLe_Segment(0.75);
            }
            if (cb2.Checked)
            {
                TyLe_Circle(0.75);
            }
            if (cb3.Checked)
            {
                TyLe_Ellip(0.75);
            }
            if (cb4.Checked)
            {
                TyLe_HCN(0.75);
            }
            if (cb5.Checked)
            {
                TyLe_HV(0.75);
            }
        }

        private void Click_TyLe4(object sender, EventArgs e)
        {
            return;
        }

        private void Click_TyLe5(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                TyLe_Segment(1.5);
            }
            if (cb2.Checked)
            {
                TyLe_Circle(1.5);
            }
            if (cb3.Checked)
            {
                TyLe_Ellip(1.5);
            }
            if (cb4.Checked)
            {
                TyLe_HCN(1.5);
            }
            if (cb5.Checked)
            {
                TyLe_HV(1.5);
            }
        }

        private void Click_TyLe6(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                TyLe_Segment(2.0);
            }
            if (cb2.Checked)
            {
                TyLe_Circle(2.0);
            }
            if (cb3.Checked)
            {
                TyLe_Ellip(2.0);
            }
            if (cb4.Checked)
            {
                TyLe_HCN(2.0);
            }
            if (cb5.Checked)
            {
                TyLe_HV(2.0);
            }
        }

        private void Click_TyLe7(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                TyLe_Segment(5.0);
            }
            if (cb2.Checked)
            {
                TyLe_Circle(5.0);
            }
            if (cb3.Checked)
            {
                TyLe_Ellip(5.0);
            }
            if (cb4.Checked)
            {
                TyLe_HCN(5.0);
            }
            if (cb5.Checked)
            {
                TyLe_HV(5.0);
            }
        }
        private void TinhTien_OnClick(object sender, MouseEventArgs e)
        {
            tinhtien = true;
            List_temp.Clear();
            c1 = Point.Convert_P2D(Cursor_temp.X, Cursor_temp.Y, d2.O);
            c1.Show(g, Color.MediumVioletRed, d2.O, 2);
        }
        //===============================End Mouse Event==========================


        //--------------------------Radio button event change--------------------------
        private void Grb1_CheckChange(object sender, EventArgs e)/*Chuyển chọn loại hình vẽ */
        {
            
            if (rb_dt.Checked)
            {
                cb1.Checked = true;
                grb_Circle.Hide();
                //grb_Segment.Hide();
                grb_Elip.Hide();
                grb_Segment.Show();
                grb_hcn.Hide();
                grb_hv.Hide();
            }
            else if(rb_circle.Checked)
            {
                cb2.Checked = true;
               // grb_Circle.Hide();
                grb_Segment.Hide();
                grb_Elip.Hide();
                grb_Circle.Show();
                grb_hcn.Hide();
                grb_hv.Hide();
            }
            else if(rb_elip.Checked)
            {
                cb3.Checked = true;
                grb_Circle.Hide();
                grb_Segment.Hide();
                //grb_Elip.Hide();
                grb_Elip.Show();
                grb_hcn.Hide();
                grb_hv.Hide();
            }    
            else if (rb_hv.Checked)
            {
                cb5.Checked = true;
                grb_Circle.Hide();
                grb_Segment.Hide();
                //grb_Elip.Hide();
                grb_Elip.Hide();
                grb_hv.Show();
                grb_hcn.Hide();
            }
            else if (rb_hcn.Checked)
            {
                cb4.Checked = true;
                grb_Circle.Hide();
                grb_Segment.Hide();
                //grb_Elip.Hide();
                grb_Elip.Hide();
                grb_hcn.Show();
                grb_hv.Hide();
            }
        }
        //===========================================================================


        //--------------------------Checkbox Event change--------------------------
        private void CB_Zoom_Change(object sender, EventArgs e)/*Kích hoạt thay đổi số pixel trên 1 đơn vị*/
        {
            if (cb_zoom.Checked)
            {
                zoom.Show();
            }
            else
                zoom.Hide();
        }
        private void Cb_ShowName_Change(object sender, EventArgs e)/*hiển thị tên điểm*/
        {
            if (cb_showName.Checked)
            {
                    
                Show_Name();
            }
            else
                Hide_Name();
             ShowAll();
        }
        private void CB3D_Changed(object sender, EventArgs e)/*Kích hoạt vẽ 3D*/
        {
            //HideAll();
            ClearAll();
            Draw_DesCart();
            if (cb_3D.Checked)
            {
                
                grb_Circle.Text = "Nhập hình cầu";
                grb_hv.Text = "Nhập hình lập phương";
                grb_hv.Location = groupBox1.Location;
                coor_hv_Z.Show();
                coor_hv_Z.ReadOnly = false;
                coor_Circle_Z.Show();
                coor_Circle_Z.ReadOnly=false;
                groupBox1.Hide();
                grb_hv.Show();
                grb_Circle.Show();
                grb_Segment.Hide();
                grb_Elip.Hide();
                grb_hcn.Hide();
                lb_X.Hide();
                lb_Y.Hide();
                label11.Hide();
                label13.Hide();
                //label15.Hide();
                label16.Hide();
                label18.Hide();
                label12.Show();
                label14.Show();
                label38.Show();
                label1.Show();
                label31.Show();
            }
            else
            {
                grb_hv.Location = grb_Segment.Location;
                grb_Circle.Text = "Nhập hình tròn";
                grb_hv.Text = "Nhập hình vuông";
                groupBox1.Show();
                grb_hv.Hide();
                coor_hv_Z.Hide();
                coor_hv_Z.ReadOnly = true;
                coor_Circle_Z.Hide();
                coor_Circle_Z.ReadOnly = true;
                grb_Circle.Hide();
                grb_Segment.Show();
                lb_X.Show();
                lb_Y.Show();
                label11.Show();
                label13.Show();
                //label15.Show();
                label16.Show();
                label18.Show();
                label12.Hide();
                label14.Hide();
                label38.Hide();
                label1.Hide();
                label31.Hide();
            }
        }
        private void CB1_Change(object sender, EventArgs e)
        {
            if(cb1.Checked)
            {
                Show_Segment();
            }
            else
            {
                Hide_Segment();
            }    
        }

        private void CB2_Change(object sender, EventArgs e)
        {
            if (cb2.Checked)
            {
                Show_Circle();
            }
            else
            {
                Hide_Circle();
            }
        }

        private void CB3_Change(object sender, EventArgs e)
        {
            if (cb3.Checked)
            {
                Show_Ellip();
            }
            else
            {
                Hide_Ellip();
            }
        }

        private void CB4_Change(object sender, EventArgs e)
        {
            if (cb4.Checked)
            {
                Show_HCN();
            }
            else
            {
                Hide_HCN();

            }
        }
        private void CB5_Change(object sender, EventArgs e)
        {
            if (cb4.Checked)
            {
                Show_HV();
            }
            else
            {
                Hide_HV();

            }
        }
        //===========================================================================
        //--------------------------Button Event Click--------------------------
        private void BT_Segment_OnClick(object sender, EventArgs e)/*Vẽ đoạn thẳng bằng nhập thông số*/
        {
            try
            {
                if (!Regex.IsMatch(coor_F_X.Text, @"^[-]?\d+$") || !Regex.IsMatch(coor_F_Y.Text, @"^[-]?\d+$"))
                {
                    MessageBox.Show(this, "Vui lòng nhập đúng tọa độ điểm đầu", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                if (!Regex.IsMatch(coor_L_X.Text, @"^[-]?\d+$") || !Regex.IsMatch(coor_L_Y.Text, @"^[-]?\d+$"))
                {
                    MessageBox.Show(this, "Vui lòng nhập đúng tọa độ điểm cuối", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                else if (!Regex.IsMatch(coor_F_Z.Text, @"^[-]?\d+$") && cb_3D.Checked)
                {
                    MessageBox.Show(this, "Vui lòng nhập đúng tọa độ điểm đầu", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                else if (!Regex.IsMatch(coor_F_Z.Text, @"^[-]?\d+$") && cb_3D.Checked)
                {
                    MessageBox.Show(this, "Vui lòng nhập đúng tọa độ điểm cuối", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                c1 = new Point(Int32.Parse(coor_Circle_X.Text), Int32.Parse(coor_Circle_Y.Text));
                c1.Show(g, Descart.Point, d2.O, Form1.PX);
                List_circle.Add(new Circle(c1, Int32.Parse(circle_radius.Text)));
                List_name.Add(c1.Show_Label(d2.O));
                List_name.Add(c2.Show_Label(d2.O));
                ShowAll();
            }
            catch (Exception)
            { }
        }
        private void BT_Circle_Draw_OnClick(object sender, EventArgs e)/*vẽ hình tròn bằng nhập thông số*/
        {
            try
            {
                if (!Regex.IsMatch(coor_Circle_X.Text, @"^[-]?\d+$") || !Regex.IsMatch(coor_Circle_Y.Text, @"^[-]?\d+$"))
                {
                    MessageBox.Show(this, "Vui lòng nhập đúng tọa độ", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                else if (!Regex.IsMatch(circle_radius.Text, @"\d+"))
                {
                    MessageBox.Show(this, "Vui lòng nhập bán kính", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                else if (!Regex.IsMatch(coor_Circle_Z.Text, @"^[-]?\d+$") && cb_3D.Checked)
                {
                    MessageBox.Show(this, "Vui lòng nhập đúng tọa độ", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                if (cb_3D.Checked)
                {
                    c1 = new Point(Int32.Parse(coor_Circle_X.Text), Int32.Parse(coor_Circle_Y.Text), Int32.Parse(coor_Circle_Z.Text));
                    c1.Show(g, Descart.Point, d2.O, Form1.PX);
                    Sphere hc = new Sphere(c1, Int32.Parse(circle_radius.Text));
                    hc.Show(g, d2.O);
                    List_name.Add(hc.O.Show_Label(d2.O));
                }
                else
                {
                    c1 = new Point(Int32.Parse(coor_Circle_X.Text), Int32.Parse(coor_Circle_Y.Text));
                    c1.Show(g, Descart.Point, d2.O, Form1.PX);
                    List_circle.Add(new Circle(c1, Int32.Parse(circle_radius.Text)));
                    List_name.Add(c1.Show_Label(d2.O));
                    ShowAll();
                }
            }
            catch (Exception)
            { }
        }
        private void BT_Elip_Draw_OnClick(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(coor_Elip_X.Text, @"^[-]?\d+$") || !Regex.IsMatch(coor_Elip_Y.Text, @"^[-]?\d+$"))
                {
                    MessageBox.Show(this, "Vui lòng nhập đúng tọa độ", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                else if (!Regex.IsMatch(txt_Eclip_a.Text, @"\d+")|| !Regex.IsMatch(txt_Eclip_b.Text, @"\d+"))
                {
                    MessageBox.Show(this, "Vui lòng nhập bán kính", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                else if (!Regex.IsMatch(coor_Elip_Z.Text, @"^[-]?\d+$") && cb_3D.Checked)
                {
                    MessageBox.Show(this, "Vui lòng nhập đúng tọa độ", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                c1 = new Point(Int32.Parse(coor_Elip_X.Text), Int32.Parse(coor_Elip_Y.Text));
                c1.Show(g, Descart.Point, d2.O, Form1.PX);
                List_Elip.Add(new Elip(c1, Int32.Parse(txt_Eclip_a.Text), Int32.Parse(txt_Eclip_b.Text)));
                List_name.Add(c1.Show_Label(d2.O));
                ShowAll();
            }
            catch (Exception)
            { }
        }
        private void BT_Square_Draw_OnClick(object sender, EventArgs e)
        {
            if(rb_hcn.Checked && !cb_3D.Checked)
            {
                try
                {
                    if (!Regex.IsMatch(coor_hcn_X.Text, @"^[-]?\d+$") || !Regex.IsMatch(coor_hcn_Y.Text, @"^[-]?\d+$"))
                    {
                        MessageBox.Show(this, "Vui lòng nhập đúng tọa độ", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else if (!Regex.IsMatch(hcn_canh_a.Text, @"\d+") || !Regex.IsMatch(hcn_canh_b.Text, @"\d+"))
                    {
                        MessageBox.Show(this, "Vui lòng nhập cạnh", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else if (!Regex.IsMatch(coor_hcn_Z.Text, @"^[-]?\d+$") && cb_3D.Checked)
                    {
                        MessageBox.Show(this, "Vui lòng nhập đúng tọa độ", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    c1 = new Point(Int32.Parse(coor_hcn_X.Text), Int32.Parse(coor_hcn_Y.Text));
                    c1.Show(g, Descart.Point, d2.O, Form1.PX);
                    Square s = new Square(c1, Int32.Parse(hcn_canh_a.Text), Int32.Parse(hcn_canh_b.Text));
                    List_hcn.Add(s);
                    List_name.Add(s.A.Show_Label(d2.O));
                    List_name.Add(s.B.Show_Label(d2.O));
                    List_name.Add(s.C.Show_Label(d2.O));
                    List_name.Add(s.D.Show_Label(d2.O));
                    ShowAll();
                }
                catch (Exception)
                { }
            } 
            else if (rb_hv.Checked|| cb_3D.Checked)
            {
                try
                {
                    if (!Regex.IsMatch(coor_hv_X.Text, @"^[-]?\d+$") || !Regex.IsMatch(coor_hv_Y.Text, @"^[-]?\d+$"))
                    {
                        MessageBox.Show(this, "Vui lòng nhập đúng tọa độ", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else if (!Regex.IsMatch(hv_canh.Text, @"\d+") )
                    {
                        MessageBox.Show(this, "Vui lòng nhập cạnh", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    else if (!Regex.IsMatch(coor_hv_Z.Text, @"^[-]?\d+$") && cb_3D.Checked)
                    {
                        MessageBox.Show(this, "Vui lòng nhập đúng tọa độ", "Cảnh báo", MessageBoxButtons.OK);
                        return;
                    }
                    if (cb_3D.Checked)
                    {
                        c1 = new Point(Int32.Parse(coor_hv_X.Text), Int32.Parse(coor_hv_Y.Text),Int32.Parse(coor_hv_Z.Text));
                        c1.Show(g, Descart.Point, d2.O, Form1.PX);
                        Cube s = new Cube(c1, Int32.Parse(hv_canh.Text));
                        s.Show(g,d2.O);
                        List_name.Add(s.A.Show_Label(d2.O));
                        List_name.Add(s.B.Show_Label(d2.O));
                        List_name.Add(s.C.Show_Label(d2.O));
                        List_name.Add(s.D.Show_Label(d2.O));
                        List_name.Add(s.E.Show_Label(d2.O));
                        List_name.Add(s.F.Show_Label(d2.O));
                        List_name.Add(s.G.Show_Label(d2.O));
                        List_name.Add(s.H.Show_Label(d2.O));
                    }
                    else
                    {
                        c1 = new Point(Int32.Parse(coor_hv_X.Text), Int32.Parse(coor_hv_Y.Text));
                        c1.Show(g, Descart.Point, d2.O, Form1.PX);
                        Square s = new Square(c1, Int32.Parse(hv_canh.Text));
                        List_hv.Add(s);
                        List_name.Add(s.A.Show_Label(d2.O));
                        List_name.Add(s.B.Show_Label(d2.O));
                        List_name.Add(s.C.Show_Label(d2.O));
                        List_name.Add(s.D.Show_Label(d2.O));
                        ShowAll();
                    }
                }
                catch (Exception)
                { }
            }
        }
        private void Clear_OnClick(object sender, EventArgs e)/*Xóa hết bộ nhớ đã lưu*/
        {
            try
            {
                ClearAll();
            }
            catch (Exception)
            { }
        }
        //===========================================================================


        //--------------------------Check input textbox--------------------------
        private void TextBox_KeyPress_Double(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void TextBox_KeyPress_Int(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') >-1))
            {
                e.Handled = true;
            }
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoom.Value = 3;
        }

        private void x5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            zoom.Value = 5;
        }

        private void x7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoom.Value = 7;
        }

        private void x9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zoom.Value = 9;
        }

        private void hiểnThịĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cb_showName.Checked)
            {
                cb_showName.Checked = false;
                hiểnThịĐiểmToolStripMenuItem.Checked = false;
            }
            else
            {
                hiểnThịĐiểmToolStripMenuItem.Checked = true;
                cb_showName.Checked = true;
            }    
                
        }

        private void vẽĐoạnThẳngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb_dt.Checked = true;
            cb_3D.Checked = false;
        }

        private void hìnhTrònToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb_circle.Checked = true;
            cb_3D.Checked = false;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs =  MessageBox.Show(this, "Bạn có muốn thoát chương trình?", "", MessageBoxButtons.YesNo);
            if(rs==DialogResult.Yes)
            {
                this.Dispose();
            }    
        }

        private void elipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb_3D.Checked = false;
            rb_elip.Checked = true;
        }

        private void hìnhChữNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb_3D.Checked = false;
            rb_hcn.Checked = true;
        }

        private void hìnhVuôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb_3D.Checked = false;
            rb_hv.Checked = true;
        }

        private void hìnhLậpPhươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb_3D.Checked = true;
        }

        private void danhSáchNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                "1.Nguyễn Duy Tân\tN17DCCN150\n" +
                "2.Võ Đình Tân\tN17DCCN151\n" +
                "3.Trần Oanh Toại\tN17DCCN155\n" +
                "4.Huỳnh Lê Hải Văn\tN17DCCN183", "Danh sách nhóm 12\n");
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
               ":)", "Hahaha\n");
        }

        private void thoátToolStripMenuItem_Click(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show(this, "Bạn có muốn thoát chương trình?", "", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                
                this.Dispose();
            }
            else
                e.Cancel=true;    
        }

        private void TextBox_KeyPress_Char(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) )
            {

                e.Handled = true;
            }

            // only allow one decimal point

        }
        //===========================================================================



    }
}
