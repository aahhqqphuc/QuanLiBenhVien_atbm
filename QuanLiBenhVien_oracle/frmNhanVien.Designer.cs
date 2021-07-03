
namespace QuanLiBenhVien
{
    partial class frmNhanVien
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
            this.btnXemThongTinNhanVien = new System.Windows.Forms.Button();
            this.btnXemThongBao = new System.Windows.Forms.Button();
            this.btnXemHoSoBenhAn = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXemThongTinNhanVien
            // 
            this.btnXemThongTinNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXemThongTinNhanVien.Location = new System.Drawing.Point(75, 94);
            this.btnXemThongTinNhanVien.Name = "btnXemThongTinNhanVien";
            this.btnXemThongTinNhanVien.Size = new System.Drawing.Size(216, 45);
            this.btnXemThongTinNhanVien.TabIndex = 0;
            this.btnXemThongTinNhanVien.Text = "Xem thông tin nhân viên";
            this.btnXemThongTinNhanVien.UseVisualStyleBackColor = true;
            this.btnXemThongTinNhanVien.Click += new System.EventHandler(this.btnXemThongTinNhanVien_Click);
            // 
            // btnXemThongBao
            // 
            this.btnXemThongBao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXemThongBao.Location = new System.Drawing.Point(75, 180);
            this.btnXemThongBao.Name = "btnXemThongBao";
            this.btnXemThongBao.Size = new System.Drawing.Size(216, 45);
            this.btnXemThongBao.TabIndex = 1;
            this.btnXemThongBao.Text = "Xem thông báo";
            this.btnXemThongBao.UseVisualStyleBackColor = true;
            this.btnXemThongBao.Click += new System.EventHandler(this.btnXemThongBao_Click);
            // 
            // btnXemHoSoBenhAn
            // 
            this.btnXemHoSoBenhAn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXemHoSoBenhAn.Location = new System.Drawing.Point(75, 271);
            this.btnXemHoSoBenhAn.Name = "btnXemHoSoBenhAn";
            this.btnXemHoSoBenhAn.Size = new System.Drawing.Size(216, 45);
            this.btnXemHoSoBenhAn.TabIndex = 2;
            this.btnXemHoSoBenhAn.Text = "Xem hồ sơ bệnh án";
            this.btnXemHoSoBenhAn.UseVisualStyleBackColor = true;
            this.btnXemHoSoBenhAn.Click += new System.EventHandler(this.btnXemHoSoBenhAn_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 25);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User";
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDonVi.Location = new System.Drawing.Point(12, 49);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(64, 25);
            this.lblDonVi.TabIndex = 4;
            this.lblDonVi.Text = "Đơn vị";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 342);
            this.Controls.Add(this.lblDonVi);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnXemHoSoBenhAn);
            this.Controls.Add(this.btnXemThongBao);
            this.Controls.Add(this.btnXemThongTinNhanVien);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemThongTinNhanVien;
        private System.Windows.Forms.Button btnXemThongBao;
        private System.Windows.Forms.Button btnXemHoSoBenhAn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblDonVi;
    }
}