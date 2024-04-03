using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhHoaHong
{
    public partial class TinhHoaHong : Form
    {
        public TinhHoaHong()
        {
            InitializeComponent();
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaBan / 1.1 - giaNhap - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaBan / 1.0 - giaNhap - troGia - thayPin) / 4) * 1000;
            }
           
            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            
        }
        

        public void TinhHoaHong_Load(object sender, EventArgs e)
        {
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaBan / 1.1 - giaNhap - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaBan / 1.0 - giaNhap - troGia - thayPin) / 4) * 1000;
            }

            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaBan / 1.1 - giaNhap - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaBan / 1.0 - giaNhap - troGia - thayPin) / 4) * 1000;
            }

            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaBan / 1.1 - giaNhap - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaBan / 1.0 - giaNhap - troGia - thayPin) / 4) * 1000;
            }

            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            

        }

        private void txtTroGia_TextChanged(object sender, EventArgs e)
        {
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaBan / 1.1 - giaNhap - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaBan / 1.0 - giaNhap - troGia - thayPin) / 4) * 1000;
            }

            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            
        }

        private void txtThayPin_TextChanged(object sender, EventArgs e)
        {
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaBan / 1.1 - giaNhap - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaBan / 1.0 - giaNhap - troGia - thayPin) / 4) * 1000;
            }

            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaBan / 1.1 - giaNhap - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaBan / 1.0 - giaNhap - troGia - thayPin) / 4) * 1000;
            }

            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                checkBox1.Focus();
                
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTroGia.Focus();
            }
        }

        private void txtTroGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtThayPin.Focus();
            }
        }

        private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtGiaNhap.Focus();
            }
        }

        private void txtHoaHong_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHoaHong.Text);
        }
    }
}
