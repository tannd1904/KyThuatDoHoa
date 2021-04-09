using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KTDH_2020.Construct._3DObject;

namespace KTDH_2020.UI.UserCtr
{
    public partial class HinhCauProperties : UserControl, INotifyPropertyChanged
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
                    //txtDinhB.Text = value[1, 0].ToString() + "," + value[1, 1].ToString() + "," + value[1, 2].ToString();
                    //txtDinhC.Text = value[2, 0].ToString() + "," + value[2, 1].ToString() + "," + value[2, 2].ToString();
                    //txtDinhD.Text = value[3, 0].ToString() + "," + value[3, 1].ToString() + "," + value[3, 2].ToString();
                    //txtDinhE.Text = value[4, 0].ToString() + "," + value[4, 1].ToString() + "," + value[4, 2].ToString();
                    //txtDinhF.Text = value[5, 0].ToString() + "," + value[5, 1].ToString() + "," + value[5, 2].ToString();

                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public HinhCauProperties()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

            try
            {
                int x = Int16.Parse(txtTamX.Text),
                    y = Int16.Parse(txtTamY.Text),
                    z = Int16.Parse(txtTamZ.Text),
                    banKinhDay = Int16.Parse(txtBanKinh.Text);

                OnPropertyChanged(x + "," + y + "," + z +  "," + banKinhDay);
            } catch(Exception)
            {
                MessageBox.Show("bla bla bla bla ", "Lỗi!");
            }
          
        }
        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtTamX.Text = "";
            txtTamY.Text = "";
            txtTamZ.Text = "";
            //txtChieuCao.Text = "";
            txtBanKinh.Text = "";
            txtDinhA.Text = "0";
            //txtDinhB.Text = "0";
            //txtDinhC.Text = "0";
            //txtDinhD.Text = "0";
            //txtDinhE.Text = "0";
            //txtDinhF.Text = "0";

        }

        private void HinhTruProperties_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
