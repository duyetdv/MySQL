using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UpdateTSCD.Controllers
{
    public class DanhSachTSCDBusiness
    {
        public List<DanhSachTSCD> LayDanhSachTSCD()
        {
            List<DanhSachTSCD> lstSach = new List<DanhSachTSCD>();
            string strSQL = "SELECT dst.ID, dst.LoaiTS, dst.ThongSo, dst.Photo, dst.NguoiSD, dst.TinhTrang, dst.GhiChu, dst.NgayTao FROM DanhSachTSCD dst";
            SqlConnection conn = DataProvider.OpenConnection();
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = strSQL;
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                SqlDataReader reader = comm.ExecuteReader();
                DanhSachTSCD objTSCD = null;
                while (reader.Read())
                {
                    objTSCD = new DanhSachTSCD();
                    objTSCD.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    objTSCD.LoaiTS = reader.GetString(reader.GetOrdinal("LoaiTS"));
                    if (!reader.IsDBNull(reader.GetOrdinal("ThongSo")))
                    {
                        objTSCD.ThongSo = reader.GetString(reader.GetOrdinal("ThongSo"));
                    }

                    if (!reader.IsDBNull(reader.GetOrdinal("Photo")))
                    {
                        objTSCD.Photo = reader.GetString(reader.GetOrdinal("Photo"));
                    }

                    if (!reader.IsDBNull(reader.GetOrdinal("NguoiSD")))
                    {
                        objTSCD.NguoiSD = reader.GetString(reader.GetOrdinal("NguoiSD"));
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("TinhTrang")))
                    {
                        objTSCD.TinhTrang = reader.GetString(reader.GetOrdinal("TinhTrang"));
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("GhiChu")))
                    {
                        objTSCD.TinhTrang = reader.GetString(reader.GetOrdinal("GhiChu"));
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("NgayTao")))
                    {
                        objTSCD.NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao"));
                    }
                    lstSach.Add(objTSCD);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                DataProvider.CloseConnection();
            }
            return lstSach;
        }

        public List<DanhSachTSCD> TimKiemTSCD(string tuKhoa)
        {
            List<DanhSachTSCD> lstSach = new List<DanhSachTSCD>();
            string strSQL = "SELECT dst.ID, dst.LoaiTS, dst.ThongSo, dst.Photo, dst.NguoiSD, dst.TinhTrang, dst.GhiChu, dst.NgayTao FROM DanhSachTSCD dst where 1=1 ";
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                strSQL += string.Format(" and LoaiTS like N'%{0}%' or ThongSo like N'%{0}%' or NguoiSD like N'%{0}%' or GhiChu like N'%{0}%' ", tuKhoa);
            }

            SqlConnection conn = DataProvider.OpenConnection();
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = strSQL;
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                SqlDataReader reader = comm.ExecuteReader();
                DanhSachTSCD objTSCD = null;
                while (reader.Read())
                {
                    objTSCD = new DanhSachTSCD();
                    objTSCD.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                    objTSCD.LoaiTS = reader.GetString(reader.GetOrdinal("LoaiTS"));
                    if (!reader.IsDBNull(reader.GetOrdinal("ThongSo")))
                    {
                        objTSCD.ThongSo = reader.GetString(reader.GetOrdinal("ThongSo"));
                    }

                    if (!reader.IsDBNull(reader.GetOrdinal("Photo")))
                    {
                        objTSCD.Photo = reader.GetString(reader.GetOrdinal("Photo"));
                    }

                    if (!reader.IsDBNull(reader.GetOrdinal("NguoiSD")))
                    {
                        objTSCD.NguoiSD = reader.GetString(reader.GetOrdinal("NguoiSD"));
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("TinhTrang")))
                    {
                        objTSCD.TinhTrang = reader.GetString(reader.GetOrdinal("TinhTrang"));
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("GhiChu")))
                    {
                        objTSCD.TinhTrang = reader.GetString(reader.GetOrdinal("GhiChu"));
                    }
                    if (!reader.IsDBNull(reader.GetOrdinal("NgayTao")))
                    {
                        objTSCD.NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao"));
                    }
                    lstSach.Add(objTSCD);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                DataProvider.CloseConnection();
            }
            return lstSach;
        }

        public DanhSachTSCD LayChiTiet(int sachId)
        {
            DanhSachTSCD objTSCD = null;
            string strSQL = "Select * from Sach where Id = @sachId";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@sachId", SqlDbType.Int);
            param[0].Value = sachId;
            DataTable dtSach = DataProvider.LayDanhSach(strSQL, param);
            if (dtSach != null && dtSach.Rows.Count > 0)
            {
                objTSCD = new DanhSachTSCD();
                objTSCD.Id = int.Parse("" + dtSach.Rows[0]["Id"]);
                objTSCD.LoaiTS = "" + dtSach.Rows[0]["LoaiTS"];
                objTSCD.Photo = "" + dtSach.Rows[0]["Photo"];
                objTSCD.ThongSo = "" + dtSach.Rows[0]["ThongSo"];
                objTSCD.NguoiSD = "" + dtSach.Rows[0]["NguoiSD"];
                objTSCD.TinhTrang = "" + dtSach.Rows[0]["TinhTrang"];
                objTSCD.GhiChu = "" + dtSach.Rows[0]["GhiChu"];
                DateTime ngayTao;
                DateTime.TryParse("" + dtSach.Rows[0]["NgayTao"], out ngayTao);
                objTSCD.NgayTao = ngayTao;


            }
            return objTSCD;
        }
        public bool ThemMoi(DanhSachTSCD objTSCD)
        {
            string strInsert = "Insert into DanhSachTSCD (LoaiTS, ThongSo, Photo, NguoiSD, TinhTrang, GhiChu, NgayTao) values (@LoaiTS, @ThongSo, @Photo, @NguoiSD, @TinhTrang, @GhiChu, @NgayTao)";

            SqlParameter[] pars = new SqlParameter[7];

            pars[0] = new SqlParameter("@LoaiTS", SqlDbType.NVarChar, 30);
            pars[0].Value = objTSCD.LoaiTS;

            pars[1] = new SqlParameter("@ThongSo", SqlDbType.NVarChar, 100);
            pars[1].Value = objTSCD.ThongSo;

            pars[2] = new SqlParameter("@Photo", SqlDbType.VarChar, 100);
            pars[2].Value = objTSCD.Photo;


            pars[3] = new SqlParameter("@NguoiSD", SqlDbType.VarChar, 6);
            pars[3].Value = objTSCD.NguoiSD;

            pars[4] = new SqlParameter("@TinhTrang", SqlDbType.VarChar, 30);
            pars[4].Value = objTSCD.TinhTrang;

            pars[5] = new SqlParameter("@GhiChu", SqlDbType.VarChar, 100);
            pars[5].Value = objTSCD.GhiChu;

            pars[6] = new SqlParameter("@NgayTao", SqlDbType.DateTime);
            pars[6].Value = objTSCD.NgayTao;



            return DataProvider.ThucHien(strInsert, pars);
        }
        public bool CapNhat(DanhSachTSCD objTSCD)
        {
            string strUpdate = "Update DanhSachTSCD set LoaiTS=@LoaiTS, ThongSo=@ThongSo, Photo=@Photo, NguoiSD = @NguoiSD, TinhTrang=@TinhTrang, GhiChu=@GhiChu where Id = @Id";

            SqlParameter[] pars = new SqlParameter[7];

            pars[0] = new SqlParameter("@LoaiTS", SqlDbType.NVarChar, 30);
            pars[0].Value = objTSCD.LoaiTS;

            pars[1] = new SqlParameter("@ThongSo", SqlDbType.NVarChar, 100);
            pars[1].Value = objTSCD.ThongSo;

            pars[2] = new SqlParameter("@Photo", SqlDbType.VarChar, 100);
            pars[2].Value = objTSCD.Photo;


            pars[3] = new SqlParameter("@NguoiSD", SqlDbType.VarChar, 6);
            pars[3].Value = objTSCD.NguoiSD;

            pars[4] = new SqlParameter("@TinhTrang", SqlDbType.VarChar, 30);
            pars[4].Value = objTSCD.TinhTrang;

            pars[5] = new SqlParameter("@GhiChu", SqlDbType.VarChar, 100);
            pars[5].Value = objTSCD.GhiChu;

            pars[6] = new SqlParameter("@Id", SqlDbType.Int);
            pars[6].Value = objTSCD.Id;

            return DataProvider.ThucHien(strUpdate, pars);
        }

        public bool Xoa(int Id)
        {
            string strDelete = "Delete from DanhSachTSCD where Id = @Id";

            SqlParameter[] pars = new SqlParameter[1];

            pars[0] = new SqlParameter("@Id", SqlDbType.Int);
            pars[0].Value = Id;

            return DataProvider.ThucHien(strDelete, pars);
        }

    }
}