using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiBenhVien
{
    public partial class frmXemHoSoBenhAn : Form
    {
        public frmXemHoSoBenhAn()
        {
            InitializeComponent();
        }

        private void frmXemHoSoBenhAn_Load(object sender, System.EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM QLHT.V_HOSOBENHAN", provider.Connect);
                provider.Connect.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dt.Columns["MAKB"].ColumnName = "Mã KB";
                dt.Columns["MABN"].ColumnName = "Mã BN";
                dt.Columns["MANV"].ColumnName = "Mã BS";
                dt.Columns["NGAYKB"].ColumnName = "Ngày khám";
                dt.Columns["TINHTRANGBANDAU"].ColumnName = "Tình trạng ban đầu";
                dt.Columns["KETLUANBS"].ColumnName = "Kết luận";
                dgvDSHoSoBenhAn.DataSource = dt;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                provider.DisConnect();
            }
        }
    }
}
