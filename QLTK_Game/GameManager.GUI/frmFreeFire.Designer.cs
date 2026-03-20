namespace GameManager.GUI
{
    partial class frmFreeFire
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
            this.lblIDInGame = new System.Windows.Forms.Label();
            this.txtIDInGame = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.lblSkin = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvFreeFire = new System.Windows.Forms.DataGridView();
            this.numSoSkin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoSkin)).BeginInit();
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
            // lblIDInGame
            // 
            this.lblIDInGame.Location = new System.Drawing.Point(553, 34);
            this.lblIDInGame.Name = "lblIDInGame";
            this.lblIDInGame.Size = new System.Drawing.Size(100, 23);
            this.lblIDInGame.TabIndex = 6;
            this.lblIDInGame.Text = "ID In-game:";
            // 
            // txtIDInGame
            // 
            this.txtIDInGame.Location = new System.Drawing.Point(653, 31);
            this.txtIDInGame.Name = "txtIDInGame";
            this.txtIDInGame.Size = new System.Drawing.Size(250, 22);
            this.txtIDInGame.TabIndex = 7;
            // 
            // lblLevel
            // 
            this.lblLevel.Location = new System.Drawing.Point(553, 69);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(81, 23);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "Cấp độ (Level):";
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(653, 66);
            this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(250, 22);
            this.numLevel.TabIndex = 9;
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSkin
            // 
            this.lblSkin.Location = new System.Drawing.Point(553, 104);
            this.lblSkin.Name = "lblSkin";
            this.lblSkin.Size = new System.Drawing.Size(100, 23);
            this.lblSkin.TabIndex = 10;
            this.lblSkin.Text = "Số Skin súng:";
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
            // dgvFreeFire
            // 
            this.dgvFreeFire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFreeFire.ColumnHeadersHeight = 29;
            this.dgvFreeFire.Location = new System.Drawing.Point(33, 228);
            this.dgvFreeFire.Name = "dgvFreeFire";
            this.dgvFreeFire.RowHeadersWidth = 51;
            this.dgvFreeFire.Size = new System.Drawing.Size(898, 273);
            this.dgvFreeFire.TabIndex = 16;
            // 
            // numSoSkin
            // 
            this.numSoSkin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numSoSkin.Location = new System.Drawing.Point(653, 102);
            this.numSoSkin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSoSkin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoSkin.Name = "numSoSkin";
            this.numSoSkin.Size = new System.Drawing.Size(250, 22);
            this.numSoSkin.TabIndex = 17;
            this.numSoSkin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmFreeFire
            // 
            this.ClientSize = new System.Drawing.Size(958, 532);
            this.Controls.Add(this.numSoSkin);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblLoginType);
            this.Controls.Add(this.cboLoginType);
            this.Controls.Add(this.lblIDInGame);
            this.Controls.Add(this.txtIDInGame);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.numLevel);
            this.Controls.Add(this.lblSkin);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvFreeFire);
            this.Name = "frmFreeFire";
            this.Text = "Quản lý tài khoản Free Fire";
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoSkin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblUser, lblPass, lblLoginType, lblIDInGame, lblLevel, lblSkin;
        private System.Windows.Forms.TextBox txtUser, txtPass, txtIDInGame;
        private System.Windows.Forms.ComboBox cboLoginType;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLamMoi;
        private System.Windows.Forms.DataGridView dgvFreeFire;
        private System.Windows.Forms.NumericUpDown numSoSkin;
    }
}