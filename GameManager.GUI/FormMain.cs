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
        // 1. Mở Form Free Fire
        private void btnFreeFire_Click(object sender, EventArgs e)
        {
            frmFreeFire frm = Application.OpenForms["frmFreeFire"] as frmFreeFire;
            
                frm = new frmFreeFire();
            
                frm.Show();
         
        }

        // 2. Mở Form Liên Quân
        private void btnLienQuan_Click(object sender, EventArgs e)
        {
            frmLienQuan frm = Application.OpenForms["frmLienQuan"] as frmLienQuan;
            
                frm = new frmLienQuan();
                
                frm.Show();         
        }

        // 3. Mở Form FC Mobile
        private void btnFCMobile_Click(object sender, EventArgs e)
        {
            frmFCMobile frm = Application.OpenForms["frmFCMobile"] as frmFCMobile;

            frm = new frmFCMobile();
            
            frm.Show();
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
