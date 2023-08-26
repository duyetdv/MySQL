using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QLBanHang
{
    public class LoaiKhachHangBussiness
    {
        public DataTable LayDanhSach()
        {
            string strSQL = "SELECT * FROM dbo.LOAIKKHACHHANG ";    
            
            return DataProvider.LayDanhSach(strSQL);
        }
        public DataTable TimKiemLoaiKH(string timKiem)
        {
            string strSQL = "SELECT * FROM dbo.LOAIKKHACHHANG where 1=1 ";
            if(!string.IsNullOrEmpty(timKiem))
            {
                strSQL += string.Format("and (MALOAI = '{0}' or  TENLOAI like N'%{0}%')", timKiem);
            }
            return DataProvider.LayDanhSach(strSQL);
        }
        public void Sua(string tenLoai, string maLoai)
        {
            string strSQL = "UPDATE dbo.LOAIKKHACHHANG SET TENLOAI = @TENLOAI WHERE MALOAI = @MALOAI";
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@TENLOAI", SqlDbType.NVarChar, 100);
            sp[0].Value = tenLoai;
            sp[1] = new SqlParameter("@MALOAI", SqlDbType.VarChar, 10);
            sp[1].Value = tenLoai;
            bool kq = DataProvider.ThucHien(strSQL, sp);
            if (kq)
            {
                MessageBox.Show("Success!");
            }
        }
        public void Them(string maLoai, string tenLoai)
        {
            string strSQL = "INSERT INTO dbo.LOAIKKHACHHANG (MALOAI,TENLOAI) VALUES (@MALOAI,@TENLOAI)";
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@MALOAI", SqlDbType.NVarChar, 100);
            sp[0].Value = maLoai;
            sp[1] = new SqlParameter("@TENLOAI", SqlDbType.VarChar, 10);
            sp[1].Value = tenLoai;
            bool kq = DataProvider.ThucHien(strSQL, sp);
            if (kq)
            {
                MessageBox.Show("Success!");
            }
        }
        public void (string maLoai, string tenLoai)
        {
            string strSQL = "INSERT INTO dbo.LOAIKKHACHHANG (MALOAI,TENLOAI) VALUES (@MALOAI,@TENLOAI)";
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@MALOAI", SqlDbType.NVarChar, 100);
            sp[0].Value = maLoai;
            sp[1] = new SqlParameter("@TENLOAI", SqlDbType.VarChar, 10);
            sp[1].Value = tenLoai;
            bool kq = DataProvider.ThucHien(strSQL, sp);
            if (kq)
            {
                MessageBox.Show("Success!");
            }
        }
    }
    
}
