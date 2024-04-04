using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            txtChenhGia.Text = string.Format("{0:# ### ###}", giaBan-giaNhap);
            txtHoaHong.Text = string.Format("{0:# ### ###}", hoaHong);
            
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
            txtChenhGia.Text = string.Format("{0:# ### ###}", giaBan - giaNhap);
            txtHoaHong.Text = string.Format("{0:# ### ###}", hoaHong);
           

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
            txtChenhGia.Text = string.Format("{0:# ### ###}", giaBan - giaNhap);
            txtHoaHong.Text = string.Format("{0:# ### ###}", hoaHong);
            
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
            txtChenhGia.Text = string.Format("{0:# ### ###}", giaBan - giaNhap);
            txtHoaHong.Text = string.Format("{0:# ### ###}", hoaHong);
            

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
            txtChenhGia.Text = string.Format("{0:# ### ###}", giaBan - giaNhap);
            txtHoaHong.Text = string.Format("{0:# ### ###}", hoaHong);
            
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
            txtChenhGia.Text = string.Format("{0:# ### ###}", giaBan - giaNhap);
            txtHoaHong.Text = string.Format("{0:# ### ###}", hoaHong);
            
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
            txtChenhGia.Text = string.Format("{0:# ### ###}", giaBan - giaNhap);
            txtHoaHong.Text = string.Format("{0:# ### ###}", hoaHong);
            
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                checkBox1.Focus();
                checkBox1.BackColor = SystemColors.Highlight;
            }
        }
        private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                checkBox1.BackColor= SystemColors.ControlLight;
                txtGiaNhap.Focus();
                txtGiaNhap.SelectionStart = 0;
                txtGiaNhap.SelectionLength = txtGiaNhap.Text.Length;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
                txtTroGia.Focus();
                txtTroGia.SelectionStart = 0;
                txtTroGia.SelectionLength = txtTroGia.Text.Length;
            }
        }

        private void txtTroGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               
                txtThayPin.Focus();
                txtThayPin.SelectionStart = 0;
                txtThayPin.SelectionLength = txtTroGia.Text.Length;
                btnHH_Click(sender, e);
            }
        }

        private void btnGiaBan_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(string.Format("{0:# ### ###}", int.Parse(txtGiaBan.Text)*1000));
        }

        private void btnHH_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHoaHong.Text);
        }
    }
}
