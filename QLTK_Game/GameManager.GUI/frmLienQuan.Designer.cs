namespace GameManager.GUI
{
    partial class frmLienQuan
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
            this.lblRank = new System.Windows.Forms.Label();
            this.cboRank = new System.Windows.Forms.ComboBox();
            this.lblSoTuong = new System.Windows.Forms.Label();
            this.numSoTuong = new System.Windows.Forms.NumericUpDown();
            this.lblSkins = new System.Windows.Forms.Label();
            this.numSkins = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvLienQuan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLienQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(88, 31);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Tài khoản:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(194, 28);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(228, 22);
            this.txtUser.TabIndex = 1;
            // 
            // lblPass
            // 
            this.lblPass.Location = new System.Drawing.Point(88, 66);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(100, 23);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Mật khẩu:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(194, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(228, 22);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblLoginType
            // 
            this.lblLoginType.Location = new System.Drawing.Point(88, 98);
            this.lblLoginType.Name = "lblLoginType";
            this.lblLoginType.Size = new System.Drawing.Size(153, 23);
            this.lblLoginType.TabIndex = 4;
            this.lblLoginType.Text = "Phương thức đăng nhập:";
            // 
            // cboLoginType
            // 
            this.cboLoginType.Items.AddRange(new object[] {
            "Garena",
            "Facebook",
            "Google"});
            this.cboLoginType.Location = new System.Drawing.Point(247, 95);
            this.cboLoginType.Name = "cboLoginType";
            this.cboLoginType.Size = new System.Drawing.Size(175, 24);
            this.cboLoginType.TabIndex = 5;
            // 
            // lblRank
            // 
            this.lblRank.Location = new System.Drawing.Point(553, 34);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(100, 23);
            this.lblRank.TabIndex = 6;
            this.lblRank.Text = "Rank hiện tại:";
            // 
            // cboRank
            // 
            this.cboRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRank.Items.AddRange(new object[] {
            "Đồng",
            "Bạc ",
            "Vàng",
            "Bạch Kim,",
            "Kim Cương",
            "Tinh Anh",
            "Cao Thủ",
            "Chiến Tướng"});
            this.cboRank.Location = new System.Drawing.Point(653, 31);
            this.cboRank.Name = "cboRank";
            this.cboRank.Size = new System.Drawing.Size(250, 24);
            this.cboRank.TabIndex = 7;
            // 
            // lblSoTuong
            // 
            this.lblSoTuong.Location = new System.Drawing.Point(553, 69);
            this.lblSoTuong.Name = "lblSoTuong";
            this.lblSoTuong.Size = new System.Drawing.Size(81, 23);
            this.lblSoTuong.TabIndex = 8;
            this.lblSoTuong.Text = "Số tướng:";
            // 
            // numSoTuong
            // 
            this.numSoTuong.Location = new System.Drawing.Point(653, 66);
            this.numSoTuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSoTuong.Name = "numSoTuong";
            this.numSoTuong.Size = new System.Drawing.Size(250, 22);
            this.numSoTuong.TabIndex = 9;
            // 
            // lblSkins
            // 
            this.lblSkins.Location = new System.Drawing.Point(553, 104);
            this.lblSkins.Name = "lblSkins";
            this.lblSkins.Size = new System.Drawing.Size(100, 23);
            this.lblSkins.TabIndex = 10;
            this.lblSkins.Text = "Số trang phục:";
            // 
            // numSkins
            // 
            this.numSkins.Location = new System.Drawing.Point(653, 101);
            this.numSkins.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numSkins.Name = "numSkins";
            this.numSkins.Size = new System.Drawing.Size(250, 22);
            this.numSkins.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(247, 173);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(347, 173);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(447, 173);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(547, 173);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 30);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Làm mới";
            // 
            // dgvLienQuan
            // 
            this.dgvLienQuan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLienQuan.ColumnHeadersHeight = 29;
            this.dgvLienQuan.Location = new System.Drawing.Point(33, 228);
            this.dgvLienQuan.Name = "dgvLienQuan";
            this.dgvLienQuan.RowHeadersWidth = 51;
            this.dgvLienQuan.Size = new System.Drawing.Size(898, 273);
            this.dgvLienQuan.TabIndex = 16;
            // 
            // frmLienQuan
            // 
            this.ClientSize = new System.Drawing.Size(958, 532);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblLoginType);
            this.Controls.Add(this.cboLoginType);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.cboRank);
            this.Controls.Add(this.lblSoTuong);
            this.Controls.Add(this.numSoTuong);
            this.Controls.Add(this.lblSkins);
            this.Controls.Add(this.numSkins);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvLienQuan);
            this.Name = "frmLienQuan";
            this.Text = "Quản lý tài khoản Liên Quân";
            ((System.ComponentModel.ISupportInitialize)(this.numSoTuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSkins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLienQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblUser, lblPass, lblLoginType, lblRank, lblSoTuong, lblSkins;
        private System.Windows.Forms.TextBox txtUser, txtPass;
        private System.Windows.Forms.ComboBox cboLoginType, cboRank;
        private System.Windows.Forms.NumericUpDown numSoTuong, numSkins;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLamMoi;
        private System.Windows.Forms.DataGridView dgvLienQuan;
    }
}