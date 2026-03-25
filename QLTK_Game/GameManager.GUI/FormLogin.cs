using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameManager.BLL;
using GameManager.DTO;


namespace GameManager.GUI
{
    public partial class FormLogin : Form
    {
        // Khởi tạo đối tượng xử lý logic từ tầng BLL
        GameService _gameService = new GameService();

        public FormLogin()
        {
            InitializeComponent();
        }

        // Ấn enter để đăng nhập
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GameService _gameService = new GameService();
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            string nameFromDB; 

            if (_gameService.Login(user, pass, out nameFromDB))
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                FormMain main = new FormMain(nameFromDB);
                main.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
