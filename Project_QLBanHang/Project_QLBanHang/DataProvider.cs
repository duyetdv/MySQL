using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QLBanHang
{
    public class DataProvider
    {
        private static LoaiKhachHangBussiness _LoaiKH = null;
        public static LoaiKhachHangBussiness LoaiKHBus
        {
            get
            { 
                if (_LoaiKH == null)
                {
                    _LoaiKH = new LoaiKhachHangBussiness();
                }
                return _LoaiKH; 
            }
        }

        private const string _ConnectString = "Server = DUYETPM; Database=QLBANHANG; UID=sa; PWD=2569";
        public static string ConnectionString { get { return _ConnectString; } }
        public static DataTable LayDanhSach(string strSQL)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = strSQL;
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public static bool ThucHien(string strSQL, SqlParameter[] pars)
        {
            bool ketQua = false;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = strSQL;
                if (pars != null && pars.Length > 0)
                {
                    comm.Parameters.AddRange(pars);
                }
                ketQua = comm.ExecuteNonQuery() > 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close() ;
            }
            return ketQua;
        }
    }
}
