
namespace QuanLiBenhVien
{
    partial class frmXemThongBao
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
            this.dgvDSThongBao = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSThongBao);
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thông báo";
            // 
            // dgvDSThongBao
            // 
            this.dgvDSThongBao.AllowUserToAddRows = false;
            this.dgvDSThongBao.AllowUserToDeleteRows = false;
            this.dgvDSThongBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThongBao.Location = new System.Drawing.Point(6, 26);
            this.dgvDSThongBao.Name = "dgvDSThongBao";
            this.dgvDSThongBao.ReadOnly = true;
            this.dgvDSThongBao.RowHeadersWidth = 51;
            this.dgvDSThongBao.RowTemplate.Height = 29;
            this.dgvDSThongBao.Size = new System.Drawing.Size(804, 257);
            this.dgvDSThongBao.TabIndex = 0;
            // 
            // frmXemThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 419);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmXemThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemThongBao";
            this.Load += new System.EventHandler(this.frmXemThongBao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSThongBao;
    }
}