using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameManager.DTO;



namespace GameManager.GUI
{
    public partial class FormMain : Form
    {
        // Form Login
        private string _displayName;

        public FormMain(string displayName)
        {
            InitializeComponent();
            _displayName = displayName;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Xin chào, {_displayName}!";
            this.Text = "Hệ thống quản lý tài khoản Game - 3 Layer";
        }

        // 1. Mở Form Free Fire
        private void btnFreeFire_Click(object sender, EventArgs e)
        {
            frmFreeFire ff = new frmFreeFire();
            this.Hide(); // Ẩn form chính
            ff.ShowDialog();
            this.Show(); 
        }

        // 2. Mở Form Liên Quân
        private void btnLienQuan_Click(object sender, EventArgs e)
        {
            frmLienQuan lq = new frmLienQuan();
            this.Hide();
            lq.ShowDialog();
            this.Show();
        }

        // 3. Mở Form FC Mobile
        private void btnFCMobile_Click(object sender, EventArgs e)
        {
            frmFCMobile fc = new frmFCMobile();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        // Đăng xuất
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close(); 
            }
        }
    }
}
