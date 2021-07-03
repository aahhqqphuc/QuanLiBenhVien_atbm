using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiBenhVien
{
    public partial class frmManage : Form
    {
        public frmManage()
        {
            InitializeComponent();
        }

        private void bntLoadUser_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {
                string sql = "ViewListOfUser";
                OracleCommand cmd = new OracleCommand(sql, provider.Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                OracleParameter refcursor = new OracleParameter("_RESULTS", OracleDbType.RefCursor);
                refcursor.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(refcursor);

                provider.Connect.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dtgvUser.DataSource = dt;
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

        private void bntLoadRoleUser_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {
                string sql = "";
                string param = "";

                if (txtUser.Text != "")
                {
                    sql = "ViewPrivilegesUser";
                    param = txtUser.Text;
                }
                else
                {
                    sql = "ViewPrivilegesRole";
                    param = txtRole.Text;
                }

                OracleCommand cmd = new OracleCommand(sql, provider.Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("user/role", OracleDbType.Varchar2).Value = param;
                OracleParameter refcursor = new OracleParameter("_RESULTS", OracleDbType.RefCursor);
                refcursor.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(refcursor);

                provider.Connect.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dtgvRoleUser.DataSource = dt;
                reader.Close();

                txtUser.Clear();
                txtRole.Clear();

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


        private void bntRunUser_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {
                string sql = "";

                if (cbbUser.Text == "Create")
                {
                    sql = "CreateNewUser";
                }
                else if (cbbUser.Text == "Drop")
                {
                    sql = "DropUser";
                }
                else if (cbbUser.Text == "Alter")
                {
                    sql = "UpdateUser";
                }

                OracleCommand cmd = new OracleCommand(sql, provider.Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = txtUserName.Text;

                if (cbbUser.Text != "Drop")
                {
                    cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = txtUserPass.Text;
                }

                provider.Connect.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suceed");

                txtUserName.Clear();
                txtUserPass.Clear();
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

        private void bntRunRole_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {
                string sql = "";

                if (cbbRole.Text == "Create")
                {
                    sql = "CreateNewRole";
                }
                else if (cbbRole.Text == "Drop")
                {
                    sql = "DropRole";
                }
                else if (cbbRole.Text == "Alter")
                {
                    sql = "UpdateRole";
                }

                OracleCommand cmd = new OracleCommand(sql, provider.Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = txtRoleName.Text;

                if (cbbRole.Text != "Drop")
                {
                    cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = txtRolePass.Text;
                }

                provider.Connect.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suceed");

                txtRoleName.Text = "";
                txtRolePass.Text = "";
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

        private void bntUserGrant_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {
                string sql = "GrantObject";
                int check = (cbOption.Checked == false) ? 0 : 1;
                OracleCommand cmd = new OracleCommand(sql, provider.Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("privilege", OracleDbType.Varchar2).Value = txtUserPrivilege.Text;
                cmd.Parameters.Add("table", OracleDbType.Varchar2).Value = txtUserTable.Text;
                cmd.Parameters.Add("column", OracleDbType.Varchar2).Value = txtUserColumn.Text;
                cmd.Parameters.Add("user", OracleDbType.Varchar2).Value = txtUserUser.Text;
                cmd.Parameters.Add("check", OracleDbType.Int16).Value = check;

                provider.Connect.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suceed");

                txtUserPrivilege.Clear();
                txtUserTable.Clear();
                txtUserColumn.Clear();
                txtUserUser.Clear();
                cbOption.Checked = false;
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

        private void bntRoleGrant_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {
                string sql = "GrantObject";
                int check = (cbOption.Checked == false) ? 0 : 1;
                OracleCommand cmd = new OracleCommand(sql, provider.Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("privilege", OracleDbType.Varchar2).Value = txtRolePrivilege.Text;
                cmd.Parameters.Add("table", OracleDbType.Varchar2).Value = txtRoleTable.Text;
                cmd.Parameters.Add("column", OracleDbType.Varchar2).Value = txtRoleColumn.Text;
                cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = txtRoleRole.Text;
                cmd.Parameters.Add("check", OracleDbType.Int16).Value = 0;

                provider.Connect.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suceed");

                txtRolePrivilege.Clear();
                txtRoleTable.Clear();
                txtRoleColumn.Clear();
                txtRoleRole.Clear();
                cbOption.Checked = false;
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

        private void bntRevoke_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {          
                string sql = "RevokeObject";
                OracleCommand cmd = new OracleCommand(sql, provider.Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("privilege", OracleDbType.Varchar2).Value = txtRevokePrivilege.Text;
                cmd.Parameters.Add("table", OracleDbType.Varchar2).Value = txtRevokeTable.Text;
                cmd.Parameters.Add("role/user", OracleDbType.Varchar2).Value = txtRevokeRoleUser.Text;

                provider.Connect.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suceed");

                txtRevokePrivilege.Clear();
                txtRevokeTable.Clear();
                txtRevokeRoleUser.Clear();
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

        private void bntRUGrant_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {            
                string sql = "GrantRoleToUser";
                OracleCommand cmd = new OracleCommand(sql, provider.Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("user", OracleDbType.Varchar2).Value = txtRUUser.Text;
                cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = txtRURole.Text;

                provider.Connect.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suceed");

                txtRUUser.Clear();
                txtRURole.Clear();
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

        private void btnLoadLoginLog_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {
                string sql = "QLHT.xemLogonLog";
                OracleCommand cmd = new OracleCommand(sql, provider.Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new OracleParameter
                                    ("l_re", OracleDbType.RefCursor, ParameterDirection.ReturnValue));

                provider.Connect.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvLogonLog.DataSource = dt;
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

        private void btnLoadAccessLog_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.GetConnect();

            try
            {
                string sql = "QLHT.XemHSBNLog";
                OracleCommand cmd = new OracleCommand(sql, provider.Connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new OracleParameter
                                    ("l_re", OracleDbType.RefCursor, ParameterDirection.ReturnValue));

                provider.Connect.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvAccessLog.DataSource = dt;
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
