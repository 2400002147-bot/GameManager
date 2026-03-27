namespace GameManager.GUI
{
    partial class frmFCMobile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblLoginType = new System.Windows.Forms.Label();
            this.cboLoginType = new System.Windows.Forms.ComboBox();
            this.lblOVR = new System.Windows.Forms.Label();
            this.numOVR = new System.Windows.Forms.NumericUpDown();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvFCMobile = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numOVR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFCMobile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(88, 31);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 16;
            this.lblUser.Text = "Tài khoản:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(194, 28);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(228, 22);
            this.txtUser.TabIndex = 15;
            // 
            // lblPass
            // 
            this.lblPass.Location = new System.Drawing.Point(88, 66);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(100, 23);
            this.lblPass.TabIndex = 14;
            this.lblPass.Text = "Mật khẩu:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(194, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(228, 22);
            this.txtPass.TabIndex = 13;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblLoginType
            // 
            this.lblLoginType.Location = new System.Drawing.Point(88, 98);
            this.lblLoginType.Name = "lblLoginType";
            this.lblLoginType.Size = new System.Drawing.Size(166, 23);
            this.lblLoginType.TabIndex = 12;
            this.lblLoginType.Text = "Phương thức đăng nhập:";
            // 
            // cboLoginType
            // 
            this.cboLoginType.Items.AddRange(new object[] {
            "EA Account",
            "Garena",
            "Facebook",
            "Google"});
            this.cboLoginType.Location = new System.Drawing.Point(260, 95);
            this.cboLoginType.Name = "cboLoginType";
            this.cboLoginType.Size = new System.Drawing.Size(162, 24);
            this.cboLoginType.TabIndex = 11;
            // 
            // lblOVR
            // 
            this.lblOVR.Location = new System.Drawing.Point(553, 34);
            this.lblOVR.Name = "lblOVR";
            this.lblOVR.Size = new System.Drawing.Size(100, 23);
            this.lblOVR.TabIndex = 10;
            this.lblOVR.Text = "Chỉ số OVR:";
            // 
            // numOVR
            // 
            this.numOVR.Location = new System.Drawing.Point(653, 31);
            this.numOVR.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numOVR.Name = "numOVR";
            this.numOVR.Size = new System.Drawing.Size(250, 22);
            this.numOVR.TabIndex = 9;
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.Location = new System.Drawing.Point(553, 69);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(100, 23);
            this.lblGiaTri.TabIndex = 8;
            this.lblGiaTri.Text = "Giá trị đội hình:";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(653, 66);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(250, 22);
            this.txtGiaTri.TabIndex = 7;
            // 
            // lblRegion
            // 
            this.lblRegion.Location = new System.Drawing.Point(553, 104);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(100, 23);
            this.lblRegion.TabIndex = 5;
            this.lblRegion.Text = "Khu vực:";
            // 
            // cboRegion
            // 
            this.cboRegion.Items.AddRange(new object[] {
            "Global",
            "Việt Nam (VN)",
            "Hàn Quốc (KR)",
            "Nhật Bản (JP)"});
            this.cboRegion.Location = new System.Drawing.Point(653, 101);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(250, 24);
            this.cboRegion.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(247, 173);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(347, 173);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(447, 173);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(547, 173);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 30);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // dgvFCMobile
            // 
            this.dgvFCMobile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFCMobile.ColumnHeadersHeight = 29;
            this.dgvFCMobile.Location = new System.Drawing.Point(33, 228);
            this.dgvFCMobile.Name = "dgvFCMobile";
            this.dgvFCMobile.RowHeadersWidth = 51;
            this.dgvFCMobile.Size = new System.Drawing.Size(898, 273);
            this.dgvFCMobile.TabIndex = 0;
            // 
            // frmFCMobile
            // 
            this.ClientSize = new System.Drawing.Size(958, 532);
            this.Controls.Add(this.dgvFCMobile);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.lblGiaTri);
            this.Controls.Add(this.numOVR);
            this.Controls.Add(this.lblOVR);
            this.Controls.Add(this.cboLoginType);
            this.Controls.Add(this.lblLoginType);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Name = "frmFCMobile";
            this.Text = "Quản lý tài khoản FC Mobile";
            this.Load += new System.EventHandler(this.frmFCMobile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOVR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFCMobile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblUser, lblPass, lblLoginType, lblOVR, lblGiaTri, lblRegion;
        private System.Windows.Forms.TextBox txtUser, txtPass, txtGiaTri;
        private System.Windows.Forms.ComboBox cboLoginType, cboRegion;
        private System.Windows.Forms.NumericUpDown numOVR;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLamMoi;
        private System.Windows.Forms.DataGridView dgvFCMobile;
    }
}