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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.numSoSkin = new System.Windows.Forms.NumericUpDown();
            this.dgvFreeFire = new System.Windows.Forms.DataGridView();
            this.chkShowPass = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoSkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeFire)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(89, 74);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Tài khoản:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(195, 71);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(228, 26);
            this.txtUser.TabIndex = 1;
            // 
            // lblPass
            // 
            this.lblPass.Location = new System.Drawing.Point(89, 109);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(100, 23);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Mật khẩu:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(195, 107);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(228, 26);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblLoginType
            // 
            this.lblLoginType.Location = new System.Drawing.Point(89, 147);
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
            this.cboLoginType.Location = new System.Drawing.Point(248, 144);
            this.cboLoginType.Name = "cboLoginType";
            this.cboLoginType.Size = new System.Drawing.Size(175, 26);
            this.cboLoginType.TabIndex = 5;
            // 
            // lblIDInGame
            // 
            this.lblIDInGame.Location = new System.Drawing.Point(554, 77);
            this.lblIDInGame.Name = "lblIDInGame";
            this.lblIDInGame.Size = new System.Drawing.Size(100, 23);
            this.lblIDInGame.TabIndex = 6;
            this.lblIDInGame.Text = "ID In-game:";
            // 
            // txtIDInGame
            // 
            this.txtIDInGame.Location = new System.Drawing.Point(654, 74);
            this.txtIDInGame.Name = "txtIDInGame";
            this.txtIDInGame.Size = new System.Drawing.Size(250, 26);
            this.txtIDInGame.TabIndex = 7;
            // 
            // lblLevel
            // 
            this.lblLevel.Location = new System.Drawing.Point(554, 112);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(81, 23);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "Cấp độ (Level):";
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(654, 109);
            this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(250, 26);
            this.numLevel.TabIndex = 9;
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSkin
            // 
            this.lblSkin.Location = new System.Drawing.Point(554, 147);
            this.lblSkin.Name = "lblSkin";
            this.lblSkin.Size = new System.Drawing.Size(100, 23);
            this.lblSkin.TabIndex = 10;
            this.lblSkin.Text = "Số Skin súng:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(248, 216);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(348, 216);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(448, 216);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(548, 216);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 30);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // numSoSkin
            // 
            this.numSoSkin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numSoSkin.Location = new System.Drawing.Point(654, 145);
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
            this.numSoSkin.Size = new System.Drawing.Size(250, 26);
            this.numSoSkin.TabIndex = 17;
            this.numSoSkin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgvFreeFire
            // 
            this.dgvFreeFire.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvFreeFire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFreeFire.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFreeFire.EnableHeadersVisualStyles = false;
            this.dgvFreeFire.Location = new System.Drawing.Point(44, 266);
            this.dgvFreeFire.Name = "dgvFreeFire";
            this.dgvFreeFire.RowHeadersWidth = 51;
            this.dgvFreeFire.RowTemplate.Height = 24;
            this.dgvFreeFire.Size = new System.Drawing.Size(877, 256);
            this.dgvFreeFire.TabIndex = 18;
            this.dgvFreeFire.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFreeFire_CellClick);
            // 
            // chkShowPass
            // 
            this.chkShowPass.AutoSize = true;
            this.chkShowPass.Location = new System.Drawing.Point(430, 111);
            this.chkShowPass.Name = "chkShowPass";
            this.chkShowPass.Size = new System.Drawing.Size(64, 22);
            this.chkShowPass.TabIndex = 19;
            this.chkShowPass.Text = "Show";
            this.chkShowPass.UseVisualStyleBackColor = true;
            this.chkShowPass.CheckedChanged += new System.EventHandler(this.chkShowPass_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "FREE FIRE MANAGER";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(654, 216);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(100, 30);
            this.btnDangNhap.TabIndex = 23;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // frmFreeFire
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(958, 550);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkShowPass);
            this.Controls.Add(this.dgvFreeFire);
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
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFreeFire";
            this.Text = "Quản lý tài khoản Free Fire";
            this.Load += new System.EventHandler(this.frmFreeFire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoSkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFreeFire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblUser, lblPass, lblLoginType, lblIDInGame, lblLevel, lblSkin;
        private System.Windows.Forms.TextBox txtUser, txtPass, txtIDInGame;
        private System.Windows.Forms.ComboBox cboLoginType;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLamMoi;
        private System.Windows.Forms.NumericUpDown numSoSkin;
        private System.Windows.Forms.DataGridView dgvFreeFire;
        private System.Windows.Forms.CheckBox chkShowPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangNhap;
    }
}