
namespace QuanLiBenhVien_oracle
{
    partial class Manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.user = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bntLoadUser = new System.Windows.Forms.Button();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntLoadRoleUser = new System.Windows.Forms.Button();
            this.dtgvRoleUser = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bntRunRole = new System.Windows.Forms.Button();
            this.cbbRole = new System.Windows.Forms.ComboBox();
            this.txtRolePass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbbUser = new System.Windows.Forms.ComboBox();
            this.bntRunUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bntRevoke = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRevokeTable = new System.Windows.Forms.TextBox();
            this.txtRevokePrivilege = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRevokeRoleUser = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bntRUGrant = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRUUser = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRURole = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntRoleGrant = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRoleTable = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRoleColumn = new System.Windows.Forms.TextBox();
            this.txtRolePrivilege = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRoleRole = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntUserGrant = new System.Windows.Forms.Button();
            this.cbOption = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserTable = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserColumn = new System.Windows.Forms.TextBox();
            this.txtUserPrivilege = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserUser = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.user.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoleUser)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Controls.Add(this.tabPage1);
            this.user.Controls.Add(this.tabPage2);
            this.user.Controls.Add(this.tabPage3);
            this.user.Controls.Add(this.tabPage6);
            this.user.Location = new System.Drawing.Point(-2, 0);
            this.user.Name = "user";
            this.user.SelectedIndex = 0;
            this.user.Size = new System.Drawing.Size(1117, 608);
            this.user.TabIndex = 0;
            this.user.SelectedIndexChanged += new System.EventHandler(this.user_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bntLoadUser);
            this.tabPage1.Controls.Add(this.dtgvUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1109, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin user";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bntLoadUser
            // 
            this.bntLoadUser.Location = new System.Drawing.Point(869, 13);
            this.bntLoadUser.Name = "bntLoadUser";
            this.bntLoadUser.Size = new System.Drawing.Size(94, 29);
            this.bntLoadUser.TabIndex = 1;
            this.bntLoadUser.Text = "Load";
            this.bntLoadUser.UseVisualStyleBackColor = true;
            this.bntLoadUser.Click += new System.EventHandler(this.bntLoadUser_Click);
            // 
            // dtgvUser
            // 
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Location = new System.Drawing.Point(22, 48);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.RowHeadersWidth = 51;
            this.dtgvUser.RowTemplate.Height = 29;
            this.dtgvUser.Size = new System.Drawing.Size(941, 493);
            this.dtgvUser.TabIndex = 0;
            this.dtgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUser_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtUser);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.txtRole);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bntLoadRoleUser);
            this.tabPage2.Controls.Add(this.dtgvRoleUser);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1109, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin quyền của role/user";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(526, 18);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(159, 27);
            this.txtUser.TabIndex = 5;
            this.txtUser.TextChanged += new System.EventHandler(this.txtRoleUser_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(420, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "Nhập tên user";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(131, 18);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(159, 27);
            this.txtRole.TabIndex = 5;
            this.txtRole.TextChanged += new System.EventHandler(this.txtRoleUser_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập tên role";
            // 
            // bntLoadRoleUser
            // 
            this.bntLoadRoleUser.Location = new System.Drawing.Point(843, 18);
            this.bntLoadRoleUser.Name = "bntLoadRoleUser";
            this.bntLoadRoleUser.Size = new System.Drawing.Size(94, 29);
            this.bntLoadRoleUser.TabIndex = 1;
            this.bntLoadRoleUser.Text = "Load";
            this.bntLoadRoleUser.UseVisualStyleBackColor = true;
            this.bntLoadRoleUser.Click += new System.EventHandler(this.bntLoadRoleUser_Click);
            // 
            // dtgvRoleUser
            // 
            this.dtgvRoleUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRoleUser.Location = new System.Drawing.Point(25, 64);
            this.dtgvRoleUser.Name = "dtgvRoleUser";
            this.dtgvRoleUser.RowHeadersWidth = 51;
            this.dtgvRoleUser.RowTemplate.Height = 29;
            this.dtgvRoleUser.Size = new System.Drawing.Size(912, 477);
            this.dtgvRoleUser.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1109, 575);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Quản lý User/Role";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bntRunRole);
            this.groupBox6.Controls.Add(this.cbbRole);
            this.groupBox6.Controls.Add(this.txtRolePass);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtRoleName);
            this.groupBox6.Location = new System.Drawing.Point(47, 234);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(841, 125);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Quản lý Role";
            // 
            // bntRunRole
            // 
            this.bntRunRole.Location = new System.Drawing.Point(700, 37);
            this.bntRunRole.Name = "bntRunRole";
            this.bntRunRole.Size = new System.Drawing.Size(94, 29);
            this.bntRunRole.TabIndex = 8;
            this.bntRunRole.Text = "Thực thi";
            this.bntRunRole.UseVisualStyleBackColor = true;
            this.bntRunRole.Click += new System.EventHandler(this.bntRunRole_Click);
            // 
            // cbbRole
            // 
            this.cbbRole.FormattingEnabled = true;
            this.cbbRole.Items.AddRange(new object[] {
            "Create",
            "Drop",
            "Alter"});
            this.cbbRole.Location = new System.Drawing.Point(17, 37);
            this.cbbRole.Name = "cbbRole";
            this.cbbRole.Size = new System.Drawing.Size(151, 28);
            this.cbbRole.TabIndex = 8;
            // 
            // txtRolePass
            // 
            this.txtRolePass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRolePass.Location = new System.Drawing.Point(541, 35);
            this.txtRolePass.Name = "txtRolePass";
            this.txtRolePass.Size = new System.Drawing.Size(126, 30);
            this.txtRolePass.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = " Tên Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(452, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mật khẩu";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRoleName.Location = new System.Drawing.Point(298, 33);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(126, 30);
            this.txtRoleName.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbbUser);
            this.groupBox5.Controls.Add(this.bntRunUser);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtUserPass);
            this.groupBox5.Controls.Add(this.txtUserName);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(47, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(841, 125);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Quản lý User";
            // 
            // cbbUser
            // 
            this.cbbUser.FormattingEnabled = true;
            this.cbbUser.Items.AddRange(new object[] {
            "Create",
            "Drop",
            "Alter"});
            this.cbbUser.Location = new System.Drawing.Point(17, 37);
            this.cbbUser.Name = "cbbUser";
            this.cbbUser.Size = new System.Drawing.Size(151, 28);
            this.cbbUser.TabIndex = 8;
            this.cbbUser.SelectedIndexChanged += new System.EventHandler(this.cbbUser_SelectedIndexChanged);
            // 
            // bntRunUser
            // 
            this.bntRunUser.Location = new System.Drawing.Point(700, 33);
            this.bntRunUser.Name = "bntRunUser";
            this.bntRunUser.Size = new System.Drawing.Size(94, 29);
            this.bntRunUser.TabIndex = 9;
            this.bntRunUser.Text = "Thực thi";
            this.bntRunUser.UseVisualStyleBackColor = true;
            this.bntRunUser.Click += new System.EventHandler(this.bntRunUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = " Tên User";
            // 
            // txtUserPass
            // 
            this.txtUserPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserPass.Location = new System.Drawing.Point(541, 33);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.Size = new System.Drawing.Size(126, 30);
            this.txtUserPass.TabIndex = 6;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(298, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(126, 30);
            this.txtUserName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(452, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox4);
            this.tabPage6.Controls.Add(this.groupBox3);
            this.tabPage6.Controls.Add(this.groupBox2);
            this.tabPage6.Controls.Add(this.groupBox1);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1109, 575);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Cấp quyền";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bntRevoke);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtRevokeTable);
            this.groupBox4.Controls.Add(this.txtRevokePrivilege);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtRevokeRoleUser);
            this.groupBox4.Location = new System.Drawing.Point(575, 407);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(493, 149);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thu quyền";
            // 
            // bntRevoke
            // 
            this.bntRevoke.Location = new System.Drawing.Point(379, 92);
            this.bntRevoke.Name = "bntRevoke";
            this.bntRevoke.Size = new System.Drawing.Size(94, 29);
            this.bntRevoke.TabIndex = 3;
            this.bntRevoke.Text = "Thu hồi quyền";
            this.bntRevoke.UseVisualStyleBackColor = true;
            this.bntRevoke.Click += new System.EventHandler(this.bntRevoke_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(272, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "Tên bảng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Tên quyền";
            // 
            // txtRevokeTable
            // 
            this.txtRevokeTable.Location = new System.Drawing.Point(348, 44);
            this.txtRevokeTable.Name = "txtRevokeTable";
            this.txtRevokeTable.Size = new System.Drawing.Size(125, 27);
            this.txtRevokeTable.TabIndex = 0;
            // 
            // txtRevokePrivilege
            // 
            this.txtRevokePrivilege.Location = new System.Drawing.Point(130, 94);
            this.txtRevokePrivilege.Name = "txtRevokePrivilege";
            this.txtRevokePrivilege.Size = new System.Drawing.Size(125, 27);
            this.txtRevokePrivilege.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Tên Role/ User";
            // 
            // txtRevokeRoleUser
            // 
            this.txtRevokeRoleUser.Location = new System.Drawing.Point(130, 43);
            this.txtRevokeRoleUser.Name = "txtRevokeRoleUser";
            this.txtRevokeRoleUser.Size = new System.Drawing.Size(125, 27);
            this.txtRevokeRoleUser.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bntRUGrant);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtRUUser);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtRURole);
            this.groupBox3.Location = new System.Drawing.Point(50, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 149);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cấp Role cho User";
            // 
            // bntRUGrant
            // 
            this.bntRUGrant.Location = new System.Drawing.Point(307, 101);
            this.bntRUGrant.Name = "bntRUGrant";
            this.bntRUGrant.Size = new System.Drawing.Size(94, 29);
            this.bntRUGrant.TabIndex = 3;
            this.bntRUGrant.Text = "Cấp quyền";
            this.bntRUGrant.UseVisualStyleBackColor = true;
            this.bntRUGrant.Click += new System.EventHandler(this.bntRUGrant_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Tên User";
            // 
            // txtRUUser
            // 
            this.txtRUUser.Location = new System.Drawing.Point(136, 98);
            this.txtRUUser.Name = "txtRUUser";
            this.txtRUUser.Size = new System.Drawing.Size(125, 27);
            this.txtRUUser.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Tên Role";
            // 
            // txtRURole
            // 
            this.txtRURole.Location = new System.Drawing.Point(136, 44);
            this.txtRURole.Name = "txtRURole";
            this.txtRURole.Size = new System.Drawing.Size(125, 27);
            this.txtRURole.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntRoleGrant);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtRoleTable);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtRoleColumn);
            this.groupBox2.Controls.Add(this.txtRolePrivilege);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtRoleRole);
            this.groupBox2.Location = new System.Drawing.Point(50, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 149);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cấp quyền cho Role";
            // 
            // bntRoleGrant
            // 
            this.bntRoleGrant.Location = new System.Drawing.Point(646, 98);
            this.bntRoleGrant.Name = "bntRoleGrant";
            this.bntRoleGrant.Size = new System.Drawing.Size(94, 29);
            this.bntRoleGrant.TabIndex = 3;
            this.bntRoleGrant.Text = "Cấp quyền";
            this.bntRoleGrant.UseVisualStyleBackColor = true;
            this.bntRoleGrant.Click += new System.EventHandler(this.bntRoleGrant_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tên bảng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên cột";
            // 
            // txtRoleTable
            // 
            this.txtRoleTable.Location = new System.Drawing.Point(424, 98);
            this.txtRoleTable.Name = "txtRoleTable";
            this.txtRoleTable.Size = new System.Drawing.Size(125, 27);
            this.txtRoleTable.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Tên quyền";
            // 
            // txtRoleColumn
            // 
            this.txtRoleColumn.Location = new System.Drawing.Point(136, 98);
            this.txtRoleColumn.Name = "txtRoleColumn";
            this.txtRoleColumn.Size = new System.Drawing.Size(125, 27);
            this.txtRoleColumn.TabIndex = 0;
            // 
            // txtRolePrivilege
            // 
            this.txtRolePrivilege.Location = new System.Drawing.Point(424, 44);
            this.txtRolePrivilege.Name = "txtRolePrivilege";
            this.txtRolePrivilege.Size = new System.Drawing.Size(125, 27);
            this.txtRolePrivilege.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tên Role";
            // 
            // txtRoleRole
            // 
            this.txtRoleRole.Location = new System.Drawing.Point(136, 44);
            this.txtRoleRole.Name = "txtRoleRole";
            this.txtRoleRole.Size = new System.Drawing.Size(125, 27);
            this.txtRoleRole.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.bntUserGrant);
            this.groupBox1.Controls.Add(this.cbOption);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUserTable);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtUserColumn);
            this.groupBox1.Controls.Add(this.txtUserPrivilege);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUserUser);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(50, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấp quyền cho User";
            // 
            // bntUserGrant
            // 
            this.bntUserGrant.Location = new System.Drawing.Point(646, 98);
            this.bntUserGrant.Name = "bntUserGrant";
            this.bntUserGrant.Size = new System.Drawing.Size(94, 29);
            this.bntUserGrant.TabIndex = 3;
            this.bntUserGrant.Text = "Cấp quyền";
            this.bntUserGrant.UseVisualStyleBackColor = true;
            this.bntUserGrant.Click += new System.EventHandler(this.bntUserGrant_Click);
            // 
            // cbOption
            // 
            this.cbOption.AutoSize = true;
            this.cbOption.Location = new System.Drawing.Point(646, 43);
            this.cbOption.Name = "cbOption";
            this.cbOption.Size = new System.Drawing.Size(146, 24);
            this.cbOption.TabIndex = 2;
            this.cbOption.Text = "with grant option";
            this.cbOption.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(330, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tên bảng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên cột";
            // 
            // txtUserTable
            // 
            this.txtUserTable.Location = new System.Drawing.Point(424, 98);
            this.txtUserTable.Name = "txtUserTable";
            this.txtUserTable.Size = new System.Drawing.Size(125, 27);
            this.txtUserTable.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên quyền";
            // 
            // txtUserColumn
            // 
            this.txtUserColumn.Location = new System.Drawing.Point(136, 98);
            this.txtUserColumn.Name = "txtUserColumn";
            this.txtUserColumn.Size = new System.Drawing.Size(125, 27);
            this.txtUserColumn.TabIndex = 0;
            // 
            // txtUserPrivilege
            // 
            this.txtUserPrivilege.Location = new System.Drawing.Point(424, 44);
            this.txtUserPrivilege.Name = "txtUserPrivilege";
            this.txtUserPrivilege.Size = new System.Drawing.Size(125, 27);
            this.txtUserPrivilege.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên User";
            // 
            // txtUserUser
            // 
            this.txtUserUser.Location = new System.Drawing.Point(136, 44);
            this.txtUserUser.Name = "txtUserUser";
            this.txtUserUser.Size = new System.Drawing.Size(125, 27);
            this.txtUserUser.TabIndex = 0;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 620);
            this.Controls.Add(this.user);
            this.Name = "Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Load);
            this.user.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRoleUser)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl user;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button bntLoadUser;
        private System.Windows.Forms.DataGridView dtgvUser;
        private System.Windows.Forms.Button bntLoadRoleUser;
        private System.Windows.Forms.DataGridView dtgvRoleUser;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bntRunUser;
        private System.Windows.Forms.ComboBox cbbUser;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox o;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bntRevoke;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRevokeTable;
        private System.Windows.Forms.TextBox txtRevokePrivilege;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRevokeRoleUser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bntRUGrant;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRUUser;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRURole;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntRoleGrant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRoleTable;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRoleColumn;
        private System.Windows.Forms.TextBox txtRolePrivilege;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRoleRole;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntUserGrant;
        private System.Windows.Forms.CheckBox cbOption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserTable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserColumn;
        private System.Windows.Forms.TextBox txtUserPrivilege;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserUser;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button bntRunRole;
        private System.Windows.Forms.ComboBox cbbRole;
        private System.Windows.Forms.TextBox txtRolePass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label19;
    }
}