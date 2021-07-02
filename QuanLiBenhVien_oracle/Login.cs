using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QuanLiBenhVien_oracle
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public OracleConnection con;

        private void bntLogin_Click(object sender, EventArgs e)
        {
            string host = "localhost", port = "1521", sid = "ols",
                   user = txtUsername.Text, password = txtPassword.Text;

            string connectString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;


            con = new OracleConnection();
            con.ConnectionString = connectString;
            try
            {
                con.Open();
                MessageBox.Show("Dang nhap thanh cong");
                Manage mn = new Manage();
                this.Hide();
                mn.connectString = connectString;
                con.Close();
                mn.ShowDialog();
                
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Dispose();
                con.Close();
            }
            con.Dispose();
            con.Close();
        }
    }
}
