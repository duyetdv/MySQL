﻿using System;
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
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaNhap / 1.1 - giaBan - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaNhap / 1.0 - giaBan - troGia - thayPin) / 4) * 1000;
            }
           
            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            Clipboard.SetText(txtHoaHong.Text);
        }
        

        public void TinhHoaHong_Load(object sender, EventArgs e)
        {
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaNhap / 1.1 - giaBan - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaNhap / 1.0 - giaBan - troGia - thayPin) / 4) * 1000;
            }

            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            Clipboard.SetText(txtHoaHong.Text);
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaNhap / 1.1 - giaBan - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaNhap / 1.0 - giaBan - troGia - thayPin) / 4) * 1000;
            }

            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            Clipboard.SetText(txtHoaHong.Text);
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaNhap / 1.1 - giaBan - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaNhap / 1.0 - giaBan - troGia - thayPin) / 4) * 1000;
            }

            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            Clipboard.SetText(txtHoaHong.Text);

        }

        private void txtTroGia_TextChanged(object sender, EventArgs e)
        {
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaNhap / 1.1 - giaBan - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaNhap / 1.0 - giaBan - troGia - thayPin) / 4) * 1000;
            }

            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            Clipboard.SetText(txtHoaHong.Text); 
        }

        private void txtThayPin_TextChanged(object sender, EventArgs e)
        {
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaNhap / 1.1 - giaBan - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaNhap / 1.0 - giaBan - troGia - thayPin) / 4) * 1000;
            }

            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            Clipboard.SetText(txtHoaHong.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int giaNhap = 0, giaBan = 0, troGia = 0, thayPin = 0;
            double hoaHong = 0;
            int.TryParse(txtGiaNhap.Text.Trim(), out giaNhap);
            int.TryParse(txtGiaBan.Text.Trim(), out giaBan);
            int.TryParse(txtTroGia.Text.Trim(), out troGia);
            int.TryParse(txtThayPin.Text.Trim(), out thayPin);
            if (checkBox1.Checked)
            {
                hoaHong = ((giaNhap / 1.1 - giaBan - troGia - thayPin) / 4) * 1000;
            }
            else
            {
                hoaHong = ((giaNhap / 1.0 - giaBan - troGia - thayPin) / 4) * 1000;
            }

            txtHoaHong.Text = string.Format("{0:# ##0}", hoaHong);
            Clipboard.SetText(txtHoaHong.Text);
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
                txtGiaBan.Focus();
            }
        }
    }
}
