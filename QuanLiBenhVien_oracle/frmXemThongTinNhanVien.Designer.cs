
namespace QuanLiBenhVien
{
    partial class frmXemThongTinNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.AllowUserToAddRows = false;
            this.dgvDSNhanVien.AllowUserToDeleteRows = false;
            this.dgvDSNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNhanVien.Location = new System.Drawing.Point(6, 26);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.ReadOnly = true;
            this.dgvDSNhanVien.RowHeadersWidth = 51;
            this.dgvDSNhanVien.RowTemplate.Height = 29;
            this.dgvDSNhanVien.Size = new System.Drawing.Size(885, 257);
            this.dgvDSNhanVien.TabIndex = 0;
            // 
            // frmXemThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 415);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmXemThongTinNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhân viên";
            this.Load += new System.EventHandler(this.XemThongTinNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSNhanVien;
    }
}