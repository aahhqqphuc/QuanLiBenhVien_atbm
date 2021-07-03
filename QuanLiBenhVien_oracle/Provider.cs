using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiBenhVien
{
    public sealed class Provider
    {
        OracleConnection conn { get; set; }
        static string _connectString;

        public OracleConnection Connect
        {
            set { conn = value; }
            get { return conn; }
        }

        public void SetConnect(string userName, string passWord)
        {
            string host = "localhost", port = "1521", sid = "ols";
            _connectString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + passWord + ";User ID=" + userName;
        }

        public void GetConnect()
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(_connectString);
                }

                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisConnect()
        {
            try
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Dispose();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
