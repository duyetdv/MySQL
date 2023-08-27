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
            HienThiDanhSachLoaiKH();
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
            txtMaLoaiKH.Text = gridLoaiKH.Rows[numrow].Cells[0].Value.ToString();
            txtTenLoaiKH.Text = gridLoaiKH.Rows[numrow].Cells[1].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoaiKH.Text.Trim();
            string tenLoai = txtTenLoaiKH.Text;
            LoaiKhachHang objLoaiKH  = new LoaiKhachHang();
            errorProvider1.Clear();
            if (maLoai.Length == 0)
            {
                errorProvider1.SetError(txtMaLoaiKH, "Mã loại khách hàng không để trống!");
                txtMaLoaiKH.Focus();
                return; 
            }
            if (tenLoai.Length == 0)
            {
                errorProvider1.SetError(txtTenLoaiKH, "Tên loại khách hàng không để trống!");
                txtTenLoaiKH.Focus();
                return;
            }
            objLoaiKH.MaLoaiKH = maLoai;
            objLoaiKH.TenLoaiKhachHang= tenLoai;
            bool kq = DataProvider.LoaiKHBus.Sua(objLoaiKH);
            if (kq)
            {
                MessageBox.Show("Sửa thông tin Loại khách hàng thành công!", "Thông báo");
            }
            else
            {
                kq = DataProvider.LoaiKHBus.Them(objLoaiKH);
                if (kq)
                {
                    MessageBox.Show("Thêm thông tin Loại khách hàng thành công!", "Thông báo");
                }
            }
            HienThiDanhSachLoaiKH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string maLoai = txtMaLoaiKH.Text.Trim();
                bool kq = DataProvider.LoaiKHBus.Xoa(maLoai);
                if (kq)
                {
                    HienThiDanhSachLoaiKH();
                }
            }

        }
    }
}
