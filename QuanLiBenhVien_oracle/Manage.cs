using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;


namespace QuanLiBenhVien_oracle
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }
        public string connectString;
        private void Manage_Load(object sender, EventArgs e)
        {
            
        }

        private void dtgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRoleUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntLoadUser_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectString;
         
            try
            {
                
                string sql = "ViewListOfUser";
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                OracleParameter refcursor = new OracleParameter("_RESULTS", OracleDbType.RefCursor);
                refcursor.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(refcursor);

                con.Open();
                OracleDataReader oraReader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(oraReader);
            
                dtgvUser.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            con.Close();
            con.Dispose();
        }

        private void bntLoadRoleUser_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectString;
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                string sql = "";
                string param = "";

                if(txtUser.Text != "")
                {
                    sql = "ViewPrivilegesUser";
                    param = txtUser.Text;
                }
                else
                {
                    sql = "ViewPrivilegesRole";
                    param = txtRole.Text;
                }
                cmd.Connection = con;
                cmd.CommandText = sql;

                cmd.Parameters.Add("user/role", OracleDbType.Varchar2).Value = param;

                OracleParameter refcursor = new OracleParameter("_RESULTS", OracleDbType.RefCursor);
                refcursor.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(refcursor);

                con.Open();
                OracleDataReader oraReader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(oraReader);
      

                dtgvRoleUser.DataSource = dt;
                txtUser.Text = "";
                txtRole.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            con.Close();
            con.Dispose();
        }

        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntRunUser_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectString;
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandType = CommandType.StoredProcedure;
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
                cmd.Connection = con;
                cmd.CommandText = sql;

                cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = txtUserName.Text;
                if (cbbUser.Text != "Drop")
                {
                    cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = txtUserPass.Text;
                }

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suceed");

                txtUserName.Text = "";
                txtUserPass.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            con.Close();
            con.Dispose();
        }

        private void bntRunRole_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectString;
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandType = CommandType.StoredProcedure;
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
                cmd.Connection = con;
                cmd.CommandText = sql;

                cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = txtRoleName.Text;
                if (cbbRole.Text != "Drop")
                {
                    cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = txtRolePass.Text;
                }

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suceed");

                txtUserName.Text = "";
                txtUserPass.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            con.Close();
            con.Dispose();
        }

        private void bntUserGrant_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectString;
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                string sql = "GrantObject";
                int check = (cbOption.Checked == false) ? 0 : 1;
                cmd.Connection = con;
                cmd.CommandText = sql;

                cmd.Parameters.Add("privilege", OracleDbType.Varchar2).Value = txtUserPrivilege.Text;
                cmd.Parameters.Add("table", OracleDbType.Varchar2).Value = txtUserTable.Text;
                cmd.Parameters.Add("column", OracleDbType.Varchar2).Value = txtUserColumn.Text;
                cmd.Parameters.Add("user", OracleDbType.Varchar2).Value = txtUserUser.Text;
                cmd.Parameters.Add("check", OracleDbType.Int16).Value = check;


                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suceed");
                txtUserPrivilege.Text = "";
                txtUserTable.Text = "";
                txtUserColumn.Text = "";
                txtUserUser.Text = "";
                cbOption.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            con.Close();
            con.Dispose();
        }

        private void bntRoleGrant_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectString;
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                string sql = "GrantObject";
                int check = (cbOption.Checked == false) ? 0 : 1;
                cmd.Connection = con;
                cmd.CommandText = sql;


                cmd.Parameters.Add("privilege", OracleDbType.Varchar2).Value = txtRolePrivilege.Text;
                cmd.Parameters.Add("table", OracleDbType.Varchar2).Value = txtRoleTable.Text;
                cmd.Parameters.Add("column", OracleDbType.Varchar2).Value = txtRoleColumn.Text;
                cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = txtRoleRole.Text;
                cmd.Parameters.Add("check", OracleDbType.Int16).Value = 0;

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suceed");
                txtRolePrivilege.Text = "";
                txtRoleTable.Text = "";
                txtRoleColumn.Text = "";
                txtRoleRole.Text = "";
                cbOption.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            con.Close();
            con.Dispose();
        }

        private void bntRevoke_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectString;
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                string sql = "RevokeObject";
                cmd.Connection = con;
                cmd.CommandText = sql;

                cmd.Parameters.Add("privilege", OracleDbType.Varchar2).Value = txtRevokePrivilege.Text;
                cmd.Parameters.Add("table", OracleDbType.Varchar2).Value = txtRevokeTable.Text;
                cmd.Parameters.Add("role/user", OracleDbType.Varchar2).Value = txtRevokeRoleUser.Text;

                con.Open();
                cmd.ExecuteNonQuery();
                txtRevokePrivilege.Text = "";
                txtRevokeTable.Text = "";
                txtRevokeRoleUser.Text = "";
                MessageBox.Show("Suceed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            con.Close();
            con.Dispose();
        }

        private void bntRUGrant_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection();
            con.ConnectionString = connectString;
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                string sql = "GrantRoleToUser";
                cmd.Connection = con;
                cmd.CommandText = sql;


                cmd.Parameters.Add("user", OracleDbType.Varchar2).Value = txtRUUser.Text;
                cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = txtRURole.Text;

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suceed");
                txtRUUser.Text = "";
                txtRURole.Text = "";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            con.Close();
            con.Dispose();
        }
    }
}
