using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiBenhVien
{
    public partial class frmXemThongBao : Form
    {
        public frmXemThongBao()
        {
            InitializeComponent();
        }

        private void frmXemThongBao_Load(object sender, System.EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM QLHT.THONG_BAO", provider.Connect);
                provider.Connect.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dt.Columns.Remove("COT_OLS");
                dt.Columns["SOTB"].ColumnName = "Số TB";
                dt.Columns["VAITRO"].ColumnName = "Vai trò";
                dt.Columns["DONVI"].ColumnName = "Đơn vị";
                dt.Columns["CHINHANH"].ColumnName = "Chi nhánh";
                dt.Columns["NGAYTB"].ColumnName = "Ngày thông báo";
                dgvDSThongBao.DataSource = dt;
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
