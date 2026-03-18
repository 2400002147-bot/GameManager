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
    public partial class frmLienQuan : Form
    {
        // Khởi tạo dịch vụ từ tầng BLL để xử lý dữ liệu Liên Quân
        private GameService _gameService = new GameService();

        public frmLienQuan()
        {
            InitializeComponent();
        }

        private void frmLienQuan_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadData();
        }

        // 1. Tải dữ liệu vào các ComboBox 
        private void LoadComboBoxData()
        {
            // Danh sách phương thức đăng nhập
            cboLoginType.Items.Clear();
            cboLoginType.Items.AddRange(new string[] { "Garena", "Facebook", "Apple ID" });
            cboLoginType.SelectedIndex = 0;

            // Danh sách Rank Liên Quân
            cboRank.Items.Clear();
            cboRank.Items.AddRange(new string[] {
                "Đồng", "Bạc", "Vàng", "Bạch Kim",
                "Kim Cương", "Tinh Anh", "Cao Thủ", "Chiến Tướng"
            });
            cboRank.SelectedIndex = 0;
        }

        // 2. Tải danh sách tài khoản từ SQL Server lên DataGridView
        private void LoadData()
        {
            try
            {
                // Gọi BLL lấy dữ liệu từ bảng LienQuanAccounts
                dgvLienQuan.DataSource = _gameService.GetAllLienQuan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo");
            }
        }

        // 3. nút THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Nhắc nhở");
                return;
            }

            AccountDTO acc = new AccountDTO
            {
                Username = txtUser.Text.Trim(),
                Password = txtPass.Text.Trim(),
                LoginType = cboLoginType.SelectedItem.ToString(),
                RankLienQuan = cboRank.SelectedItem.ToString(), // Lấy từ ComboBox chọn
                SoTuong = (int)numSoTuong.Value,
                Skins = (int)numSkins.Value,
                GameCategory = "LienQuan" // Đánh dấu loại game để DAL xử lý
            };

            if (_gameService.AddLienQuan(acc))
            {
                MessageBox.Show("Thêm tài khoản Liên Quân thành công!");
                LoadData();
                btnLamMoi.PerformClick();
            }
        }

        // 4.nút SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLienQuan.CurrentRow == null) return;

            AccountDTO acc = new AccountDTO
            {
                Id = Convert.ToInt32(dgvLienQuan.CurrentRow.Cells["Id"].Value), // Lấy ID dòng chọn
                Username = txtUser.Text.Trim(),
                Password = txtPass.Text.Trim(),
                LoginType = cboLoginType.SelectedItem.ToString(),
                RankLienQuan = cboRank.SelectedItem.ToString(),
                SoTuong = (int)numSoTuong.Value,
                Skins = (int)numSkins.Value
            };

            if (_gameService.UpdateLienQuan(acc))
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
                LoadData();
            }
        }

        // 5.nút XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLienQuan.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvLienQuan.CurrentRow.Cells["Id"].Value);
            DialogResult dr = MessageBox.Show("Xác nhận xóa tài khoản này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                if (_gameService.DeleteLienQuan(id))
                {
                    LoadData();
                }
            }
        }

        // 6. Nút LÀM MỚI
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            numSoTuong.Value = 0;
            numSkins.Value = 0;
            cboLoginType.SelectedIndex = 0;
            cboRank.SelectedIndex = 0;
            txtUser.Focus();
        }

        // 7. Click để hiện dữ liệu lên các ô nhập
        private void dgvLienQuan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLienQuan.Rows[e.RowIndex];
                txtUser.Text = row.Cells["Username"].Value.ToString();
                txtPass.Text = row.Cells["Password"].Value.ToString();
                cboLoginType.SelectedItem = row.Cells["LoginType"].Value.ToString();
                cboRank.SelectedItem = row.Cells["RankLienQuan"].Value.ToString();
                numSoTuong.Value = Convert.ToInt32(row.Cells["SoTuong"].Value);
                numSkins.Value = Convert.ToInt32(row.Cells["Skins"].Value);
            }
        }
    }
}