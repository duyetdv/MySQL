using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UpdateTSCD.Controllers
{
    public class DataProvider
    {
        private static string _ConnectString = "Server=DUYETPM; Database=TSCD; Uid=sa; Pwd=2569";
        public static string ConnectString 
        { 
            get 
            { 
                return _ConnectString; 
            } 
        }
        private static SqlConnection _conn= null;
        public static SqlConnection OpenConnection()
        {
            if(_conn == null)
            {
                _conn = new SqlConnection(ConnectString);
            }
            if(_conn.State==ConnectionState.Closed) 
            {
                _conn.Open();
            }
            return _conn;
        }
        public static void CloseConnection()
        {
            if(_conn != null && _conn.State==ConnectionState.Open)
            {
                _conn.Close();
            }
        }
        public static DataTable LayDanhSach( string strSQL, SqlParameter[] pars = null, bool procedure= false)
        {
            DataTable dt =new DataTable();
            SqlConnection conn= null;
            try
            {
                conn = OpenConnection();
                SqlCommand comm = new SqlCommand(strSQL);
                comm.Connection = conn;
                comm.CommandText = strSQL;
                if (procedure)
                {
                    comm.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    comm.CommandType = CommandType.Text;
                }
                if(pars!=null && pars.Length > 0)
                {
                    comm.Parameters.AddRange(pars);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                adapter.Fill(dt);
            }
            catch (Exception ex) 
            {
                CloseConnection();
                throw ex;
            }
            return dt;
        }

        public static bool ThucHien(string strSQL, SqlParameter[] pars = null, bool procedure= false)
        {
            bool ketQua = false;
            SqlConnection conn= null;
            try
            {
                conn = OpenConnection();
                SqlCommand comm = new SqlCommand(strSQL);
                comm.Connection = conn;
                comm.CommandText = strSQL;
                if (procedure)
                {
                    comm.CommandType = CommandType.StoredProcedure;

                }
                else
                {
                    comm.CommandType = CommandType.Text;
                }
                if(pars!=null &&pars.Length> 0)
                {
                    comm.Parameters.AddRange(pars);
                }
                ketQua = comm.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw ex;
            }
            return ketQua;
        }
    }
}