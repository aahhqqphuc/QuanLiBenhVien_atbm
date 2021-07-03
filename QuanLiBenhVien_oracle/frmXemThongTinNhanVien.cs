using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiBenhVien
{
    public partial class frmXemThongTinNhanVien : Form
    {
        public frmXemThongTinNhanVien()
        {
            InitializeComponent();
        }

        private void XemThongTinNhanVien_Load(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {
                OracleCommand cmd = new OracleCommand("SELECT * FROM QLHT.NHAN_VIEN", provider.Connect);
                provider.Connect.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dt.Columns.Remove("Username");
                dt.Columns["MANV"].ColumnName = "Mã NV";
                dt.Columns["MADONVI"].ColumnName = "Mã ĐV";
                dt.Columns["HOTENNV"].ColumnName = "Họ tên";
                dt.Columns["DIACHINV"].ColumnName = "Địa chỉ";
                dt.Columns["SDTNV"].ColumnName = "SĐT";
                dt.Columns["LUONG"].ColumnName = "Lương";
                dt.Columns["TROCAP"].ColumnName = "Trợ cấp";
                dt.Columns["VAITRO"].ColumnName = "Vai trò";
                dgvDSNhanVien.DataSource = dt;
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
