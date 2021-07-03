using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLiBenhVien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public OracleConnection con;

        private void bntLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            Provider provider = new Provider();
            provider.SetConnect(userName, txtPassWord.Text);
            provider.GetConnect();

            try
            {
                provider.Connect.Open();
                MessageBox.Show("Đăng nhập thành công");
                if (userName == "QLHT")
                {
                    frmManage frmManage = new frmManage();
                    this.Hide();
                    frmManage.ShowDialog();
                }
                else
                {
                    frmNhanVien frmNhanVien = new frmNhanVien(userName);
                    this.Hide();
                    frmNhanVien.ShowDialog();
                }
                provider.DisConnect();
                this.Show();
            }
            catch(Exception ex)
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
