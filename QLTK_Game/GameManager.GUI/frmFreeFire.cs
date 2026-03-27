using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GameManager.BLL;
using GameManager.DTO;
using System.Data.SqlClient;

namespace GameManager.GUI
{
    public partial class frmFreeFire : Form
    {
        private GameService _gameService = new GameService();

        public frmFreeFire()
        {
            InitializeComponent();
            // Mẹo: Giúp bảng chọn cả dòng khi click
            dgvFreeFire.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFreeFire.MultiSelect = false;
            dgvFreeFire.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmFreeFire_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadData();
        }

        private void LoadComboBox()
        {
            cboLoginType.Items.Clear();
            cboLoginType.Items.AddRange(new string[] { "Facebook", "Google", "Garena", "VK" });
            if (cboLoginType.Items.Count > 0) cboLoginType.SelectedIndex = 0;
        }

        private void LoadData()
        {
            try
            {
                List<AccountDTO> list = _gameService.GetListData("FreeFireAccounts");

                // Reset bảng trước khi nạp
                dgvFreeFire.DataSource = null;
                dgvFreeFire.Columns.Clear();

                if (list != null && list.Count > 0)
                {
                    dgvFreeFire.AutoGenerateColumns = true;
                    dgvFreeFire.DataSource = new BindingList<AccountDTO>(list);

                    // 1. Đặt tiêu đề tiếng Việt
                    if (dgvFreeFire.Columns["Username"] != null) dgvFreeFire.Columns["Username"].HeaderText = "Tài khoản";
                    if (dgvFreeFire.Columns["LoginType"] != null) dgvFreeFire.Columns["LoginType"].HeaderText = "Loại đăng nhập";
                    if (dgvFreeFire.Columns["ID_InGame"] != null) dgvFreeFire.Columns["ID_InGame"].HeaderText = "ID In-game";
                    if (dgvFreeFire.Columns["LevelAccount"] != null) dgvFreeFire.Columns["LevelAccount"].HeaderText = "Cấp độ";
                    if (dgvFreeFire.Columns["SoSkinSung"] != null) dgvFreeFire.Columns["SoSkinSung"].HeaderText = "Số Skin súng";

                    // 2. Ẩn các cột rác (của game khác)
                    string[] hideCols = { "Id", "Password", "RankLienQuan", "SoTuong", "Skins", "DoiHinh_OVR", "GiaTriDoiHinh", "Region", "GameCategory" };
                    foreach (string colName in hideCols)
                    {
                        if (dgvFreeFire.Columns[colName] != null)
                            dgvFreeFire.Columns[colName].Visible = false;
                    }
                }
                else
                {
                    // Nếu không có dữ liệu, bảng sẽ trống xám. 
                    // Bạn có thể thêm 1 dòng Label báo "Chưa có dữ liệu" ở đây.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Nhắc nhở");
                return;
            }

            AccountDTO acc = new AccountDTO
            {
                Username = txtUser.Text.Trim(),
                Password = txtPass.Text.Trim(),
                LoginType = cboLoginType.Text, // Dùng .Text an toàn hơn
                ID_InGame = txtIDInGame.Text.Trim(),
                LevelAccount = (int)numLevel.Value,
                SoSkinSung = (int)numSoSkin.Value
            };

            if (_gameService.AddFreeFire(acc))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
                btnLamMoi.PerformClick();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var selectedAcc = dgvFreeFire.CurrentRow?.DataBoundItem as AccountDTO;
            if (selectedAcc == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!");
                return;
            }

            AccountDTO acc = new AccountDTO
            {
                Id = selectedAcc.Id, // Lấy ID ẩn từ DB
                Username = txtUser.Text.Trim(),
                Password = txtPass.Text.Trim(),
                LoginType = cboLoginType.Text,
                ID_InGame = txtIDInGame.Text.Trim(),
                LevelAccount = (int)numLevel.Value,
                SoSkinSung = (int)numSoSkin.Value
            };

            if (_gameService.UpdateFreeFire(acc))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var selectedAcc = dgvFreeFire.CurrentRow?.DataBoundItem as AccountDTO;
            if (selectedAcc == null) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_gameService.DeleteFreeFire(selectedAcc.Id))
                {
                    LoadData();
                    btnLamMoi.PerformClick();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtIDInGame.Clear();
            numLevel.Value = numLevel.Minimum;
            numSoSkin.Value = numSoSkin.Minimum;
            if (cboLoginType.Items.Count > 0) cboLoginType.SelectedIndex = 0;
            txtUser.Focus();
        }

        private void dgvFreeFire_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var acc = dgvFreeFire.Rows[e.RowIndex].DataBoundItem as AccountDTO;
                if (acc != null)
                {
                    txtUser.Text = acc.Username;
                    txtPass.Text = acc.Password;
                    cboLoginType.Text = acc.LoginType;
                    txtIDInGame.Text = acc.ID_InGame;
                    numLevel.Value = Math.Max(numLevel.Minimum, Math.Min(numLevel.Maximum, acc.LevelAccount));
                    numSoSkin.Value = Math.Max(numSoSkin.Minimum, Math.Min(numSoSkin.Maximum, acc.SoSkinSung));
                }
            }
        }

      
    }
}