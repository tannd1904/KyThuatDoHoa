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
    public partial class HinhLapPhuongProperties : UserControl, INotifyPropertyChanged 
    {
        private int[,] _dinh;
        public int[,] Dinh
        {
            get => _dinh;
            set
            {
                if (value != null)
                {
                    _dinh = value;
                    txtDinhA.Text = _dinh[0, 0] + "," + _dinh[0, 1] + "," + _dinh[0, 2];
                    txtDinhB.Text = value[1, 0].ToString() + "," + value[1, 1].ToString() + "," + value[1, 2].ToString();
                    txtDinhC.Text = value[2, 0].ToString() + "," + value[2, 1].ToString() + "," + value[2, 2].ToString();
                    txtDinhD.Text = value[3, 0].ToString() + "," + value[3, 1].ToString() + "," + value[3, 2].ToString();
                    txtDinhE.Text = value[4, 0].ToString() + "," + value[4, 1].ToString() + "," + value[4, 2].ToString();
                    txtDinhF.Text = value[5, 0].ToString() + "," + value[5, 1].ToString() + "," + value[5, 2].ToString();
                    txtDinhG.Text = value[6, 0].ToString() + "," + value[6, 1].ToString() + "," + value[6, 2].ToString();
                    txtDinhH.Text = value[7, 0].ToString() + "," + value[7, 1].ToString() + "," + value[7, 2].ToString();

                }
            }
        }
        public HinhLapPhuongProperties()
        {
            InitializeComponent();
        }
        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;           
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Int16.Parse(txtTamX.Text),
                    y = Int16.Parse(txtTamY.Text),
                    z = Int16.Parse(txtTamZ.Text),
                    chieuDai = Int16.Parse(txtChieuDai.Text);
                    

                OnPropertyChanged(x + "," + y + "," + z + "," + chieuDai);
               
            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm tra lại thông tin nhập !","Lỗi!");
            }
  
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtTamX.Text = "";
            txtTamY.Text = "";
            txtTamZ.Text = "";
            
            txtChieuDai.Text = "";
            
            txtDinhA.Text = "0";
            txtDinhB.Text = "0";
            txtDinhC.Text = "0";
            txtDinhD.Text = "0";
            txtDinhE.Text = "0";
            txtDinhF.Text = "0";
            txtDinhG.Text = "0";
            txtDinhH.Text = "0";       

        }

        private void HinhLapPhuongProperties_Load(object sender, EventArgs e)
        {

        }

        private void Truck_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
