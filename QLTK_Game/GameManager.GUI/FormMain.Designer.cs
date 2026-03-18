namespace GameManager.GUI
{
    partial class FormMain
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
            this.btnFreeFire = new System.Windows.Forms.Button();
            this.btnLienQuan = new System.Windows.Forms.Button();
            this.btnFCMobile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFreeFire
            // 
            this.btnFreeFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.btnFreeFire.FlatAppearance.BorderSize = 0;
            this.btnFreeFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFreeFire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFreeFire.ForeColor = System.Drawing.Color.White;
            this.btnFreeFire.Location = new System.Drawing.Point(518, 139);
            this.btnFreeFire.Margin = new System.Windows.Forms.Padding(4);
            this.btnFreeFire.Name = "btnFreeFire";
            this.btnFreeFire.Size = new System.Drawing.Size(333, 74);
            this.btnFreeFire.TabIndex = 1;
            this.btnFreeFire.Text = "QUẢN LÝ FREE FIRE";
            this.btnFreeFire.UseVisualStyleBackColor = false;
            this.btnFreeFire.Click += new System.EventHandler(this.btnFreeFire_Click);
            // 
            // btnLienQuan
            // 
            this.btnLienQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnLienQuan.FlatAppearance.BorderSize = 0;
            this.btnLienQuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLienQuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLienQuan.ForeColor = System.Drawing.Color.White;
            this.btnLienQuan.Location = new System.Drawing.Point(54, 139);
            this.btnLienQuan.Margin = new System.Windows.Forms.Padding(4);
            this.btnLienQuan.Name = "btnLienQuan";
            this.btnLienQuan.Size = new System.Drawing.Size(333, 74);
            this.btnLienQuan.TabIndex = 2;
            this.btnLienQuan.Text = "QUẢN LÝ LIÊN QUÂN";
            this.btnLienQuan.UseVisualStyleBackColor = false;
            this.btnLienQuan.Click += new System.EventHandler(this.btnLienQuan_Click);
            // 
            // btnFCMobile
            // 
            this.btnFCMobile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnFCMobile.FlatAppearance.BorderSize = 0;
            this.btnFCMobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFCMobile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnFCMobile.ForeColor = System.Drawing.Color.White;
            this.btnFCMobile.Location = new System.Drawing.Point(54, 305);
            this.btnFCMobile.Margin = new System.Windows.Forms.Padding(4);
            this.btnFCMobile.Name = "btnFCMobile";
            this.btnFCMobile.Size = new System.Drawing.Size(333, 74);
            this.btnFCMobile.TabIndex = 3;
            this.btnFCMobile.Text = "QUẢN LÝ FC MOBILE";
            this.btnFCMobile.UseVisualStyleBackColor = false;
            this.btnFCMobile.Click += new System.EventHandler(this.btnFCMobile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.LightGray;
            this.btnLogout.Location = new System.Drawing.Point(421, 439);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 37);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "ĐĂNG XUẤT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(910, 62);
            this.panelHeader.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Gold;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(910, 62);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "GAME HUB MANAGER";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(910, 526);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnFCMobile);
            this.Controls.Add(this.btnLienQuan);
            this.Controls.Add(this.btnFreeFire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFreeFire;
        private System.Windows.Forms.Button btnLienQuan;
        private System.Windows.Forms.Button btnFCMobile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
    }
}