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
    public partial class frmFreeFire : Form
    {
        // Khởi tạo dịch vụ từ tầng BLL
        private GameService _gameService = new GameService();

        public frmFreeFire()
        {
            InitializeComponent();
        }

        private void frmFreeFire_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadData();
        }

        // 1.Đưa dữ liệu vào ComboBox 
        private void LoadComboBox()
        {
            cboLoginType.Items.Clear();
            cboLoginType.Items.Add("Facebook");
            cboLoginType.Items.Add("Google");
            cboLoginType.Items.Add("Garena");
            cboLoginType.Items.Add("VK");
            cboLoginType.SelectedIndex = 0; 
        }

        // 2. Tải dữ liệu từ SQL Server lên DataGridView
        private void LoadData()
        {
            try
            {
                List<AccountDTO> list = _gameService.GetListData("FreeFireAccounts");
                dgvFreeFire.DataSource = null;
                dgvFreeFire.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // 3. Nút THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
                return;
            }

            AccountDTO acc = new AccountDTO
            {
                Username = txtUser.Text.Trim(),
                Password = txtPass.Text.Trim(),
                LoginType = cboLoginType.SelectedItem.ToString(),
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

        // 4. Nút SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvFreeFire.CurrentRow == null) return;

            AccountDTO acc = new AccountDTO
            {
                Id = Convert.ToInt32(dgvFreeFire.CurrentRow.Cells["Id"].Value),
                Username = txtUser.Text.Trim(),
                Password = txtPass.Text.Trim(),
                LoginType = cboLoginType.SelectedItem.ToString(),
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

        // 5. Nút XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvFreeFire.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvFreeFire.CurrentRow.Cells["Id"].Value);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                if (_gameService.DeleteFreeFire(id))
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
            txtIDInGame.Clear();
            numLevel.Value = 0;
            cboLoginType.SelectedIndex = 0;
            txtUser.Focus();
        }

        // 7. Click vào bảng để hiển thị lên các ô nhập
        private void dgvFreeFire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFreeFire.Rows[e.RowIndex];
                txtUser.Text = row.Cells["Username"].Value.ToString();
                txtPass.Text = row.Cells["Password"].Value.ToString();
                cboLoginType.SelectedItem = row.Cells["LoginType"].Value.ToString();
                txtIDInGame.Text = row.Cells["ID_InGame"].Value.ToString();
                numLevel.Value = Convert.ToInt32(row.Cells["LevelAccount"].Value);
                numSoSkin.Value = Convert.ToInt32(row.Cells["SoSkinSung"].Value);
            }
        }
    }
}
