
namespace QuanLiBenhVien
{
    partial class frmXemHoSoBenhAn
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
            this.dgvDSHoSoBenhAn = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoSoBenhAn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSHoSoBenhAn);
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 289);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hồ sơ bệnh án";
            // 
            // dgvDSHoSoBenhAn
            // 
            this.dgvDSHoSoBenhAn.AllowUserToAddRows = false;
            this.dgvDSHoSoBenhAn.AllowUserToDeleteRows = false;
            this.dgvDSHoSoBenhAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHoSoBenhAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoSoBenhAn.Location = new System.Drawing.Point(6, 26);
            this.dgvDSHoSoBenhAn.Name = "dgvDSHoSoBenhAn";
            this.dgvDSHoSoBenhAn.ReadOnly = true;
            this.dgvDSHoSoBenhAn.RowHeadersWidth = 51;
            this.dgvDSHoSoBenhAn.RowTemplate.Height = 29;
            this.dgvDSHoSoBenhAn.Size = new System.Drawing.Size(764, 257);
            this.dgvDSHoSoBenhAn.TabIndex = 0;
            // 
            // frmXemHoSoBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 422);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmXemHoSoBenhAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XemHoSoBenhAn";
            this.Load += new System.EventHandler(this.frmXemHoSoBenhAn_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoSoBenhAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSHoSoBenhAn;
    }
}