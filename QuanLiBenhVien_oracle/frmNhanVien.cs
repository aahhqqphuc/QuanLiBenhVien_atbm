using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace QuanLiBenhVien
{
    public partial class frmNhanVien : Form
    {
        string _user;
        public frmNhanVien(string user)
        {
            _user = user;
            InitializeComponent();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            lblUser.Text = _user;
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {
                OracleCommand cmd = new OracleCommand("SELECT TENDONVI FROM " +
                    "QLHT.NHAN_VIEN NV JOIN QLHT.DON_VI DV ON NV.MADONVI = DV.MADONVI  " +
                    "WHERE USERNAME = '" + _user + "'", provider.Connect);
                provider.Connect.Open();

                using (OracleDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        lblDonVi.Text = rd.GetString(0);
                    }
                }
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

        private void btnXemThongTinNhanVien_Click(object sender, EventArgs e)
        {
            frmXemThongTinNhanVien frmXemThongTinNhanVien = new frmXemThongTinNhanVien();
            this.Hide();
            frmXemThongTinNhanVien.ShowDialog();
            this.Show();
        }

        private void btnXemThongBao_Click(object sender, EventArgs e)
        {
            frmXemThongBao frmXemThongBao = new frmXemThongBao();
            this.Hide();
            frmXemThongBao.ShowDialog();
            this.Show();
        }

        private void btnXemHoSoBenhAn_Click(object sender, EventArgs e)
        {
            frmXemHoSoBenhAn frmXemHoSoBenhAn = new frmXemHoSoBenhAn();
            this.Hide();
            frmXemHoSoBenhAn.ShowDialog();
            this.Show();
        }
    }
}
