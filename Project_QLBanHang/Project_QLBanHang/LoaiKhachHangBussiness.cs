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
            if (!string.IsNullOrEmpty(timKiem))
            {
                strSQL += string.Format("and (MALOAI = '{0}' or  TENLOAI like N'%{0}%')", timKiem);
            }
            return DataProvider.LayDanhSach(strSQL);
        }
        public bool Sua(LoaiKhachHang objLoaiKH)
        {
            string strSQL = "UPDATE dbo.LOAIKKHACHHANG SET TENLOAI = @TENLOAI WHERE MALOAI = @MALOAI";
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@TENLOAI", SqlDbType.NVarChar, 100);
            sp[0].Value = objLoaiKH.TenLoaiKhachHang;
            sp[1] = new SqlParameter("@MALOAI", SqlDbType.VarChar, 10);
            sp[1].Value = objLoaiKH.MaLoaiKH;
            return DataProvider.ThucHien(strSQL, sp);
         
        }
        public bool Them(LoaiKhachHang objLoaiKH)
        {
            string strSQL = "INSERT INTO dbo.LOAIKKHACHHANG (MALOAI,TENLOAI) VALUES (@MALOAI,@TENLOAI)";
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@MALOAI", SqlDbType.VarChar, 10);
            sp[0].Value = objLoaiKH.MaLoaiKH;
            sp[1] = new SqlParameter("@TENLOAI", SqlDbType.NVarChar, 100);
            sp[1].Value = objLoaiKH.TenLoaiKhachHang;
            return DataProvider.ThucHien(strSQL, sp);
          
        }
        public bool Xoa(string maLoai)
        {
            string strSQL = "Delete LOAIKKHACHHANG where MALOAI = @MAKH";
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@MAKH", SqlDbType.VarChar, 10);
            sp[0].Value = maLoai;
            return DataProvider.ThucHien(strSQL, sp);
        }
    }
}
    
    

