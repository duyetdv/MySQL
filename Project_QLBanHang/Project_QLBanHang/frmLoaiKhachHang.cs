using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLBanHang
{
    public partial class frmLoaiKhachHang : Form
    {
        public frmLoaiKhachHang()
        {
            InitializeComponent();
        }

        private void frmLoaiKhachHang_Load(object sender, EventArgs e)
        {

        }
        private void HienThiDanhSachLoaiKH()
        {
            LoaiKhachHangBussiness loaiKH= new LoaiKhachHangBussiness();
            DataTable dt = loaiKH.LayDanhSach(); 
            gridLoaiKH.DataSource = dt;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = "";
            timKiem = txtTimKH.Text.Trim();
            LoaiKhachHangBussiness loaiKH = new LoaiKhachHangBussiness();
            DataTable dt = loaiKH.TimKiemLoaiKH(timKiem);
            gridLoaiKH.DataSource = dt;
        }

        private void gridLoaiKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow = e.RowIndex;
            txtMaKH.Text = gridLoaiKH.Rows[numrow].Cells[0].Value.ToString();
            txtTenLoaiKH.Text = gridLoaiKH.Rows[numrow].Cells[1].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
