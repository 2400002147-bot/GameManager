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
    public partial class frmFCMobile : Form
    {
        private GameService _gameService = new GameService();

        public frmFCMobile()
        {
            InitializeComponent();
        }

        private void frmFCMobile_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadData();
        }

        private void LoadComboBoxData()
        {
            // Hình thức đăng nhập
            cboLoginType.Items.Clear();
            cboLoginType.Items.AddRange(new string[] { "EA Account", "Facebook", "Google Play", "Apple ID" });
            cboLoginType.SelectedIndex = 0;

            // Khu vực Server
            cboRegion.Items.Clear();
            cboRegion.Items.AddRange(new string[] { "Việt Nam", "Global", "Hàn Quốc (KR)", "Nhật Bản (JP)" });
            cboRegion.SelectedIndex = 0;
        }

        private void LoadData()
        {
            try
            {
                // Gọi Service lấy danh sách FC Mobile
                List<AccountDTO> list = _gameService.GetAllFCMobile();

                dgvFCMobile.DataSource = null;
                dgvFCMobile.Columns.Clear();
                dgvFCMobile.AutoGenerateColumns = true;

                if (list != null && list.Count > 0)
                {
                    dgvFCMobile.DataSource = new BindingList<AccountDTO>(list);

                    //Đổi tiêu đề cột
                    if (dgvFCMobile.Columns["DoiHinh_OVR"] != null) dgvFCMobile.Columns["DoiHinh_OVR"].HeaderText = "Chỉ số OVR";
                    if (dgvFCMobile.Columns["GiaTriDoiHinh"] != null) dgvFCMobile.Columns["GiaTriDoiHinh"].HeaderText = "Giá trị (Coin)";
                    if (dgvFCMobile.Columns["Region"] != null) dgvFCMobile.Columns["Region"].HeaderText = "Khu vực";

                    // Ẩn các cột của game khác
                    string[] hideCols = {
                "Id", "Password", "RankLienQuan", "SoTuong", "Skins",
                "ID_InGame", "LevelAccount", "SoSkinSung", "GameCategory"
            };
                    foreach (string col in hideCols)
                    {
                        if (dgvFCMobile.Columns[col] != null) dgvFCMobile.Columns[col].Visible = false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
        // nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtGiaTri.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            AccountDTO acc = new AccountDTO
            {
                Username = txtUser.Text.Trim(),
                Password = txtPass.Text.Trim(),
                LoginType = cboLoginType.SelectedItem.ToString(),
                DoiHinh_OVR = (int)numOVR.Value,
                GiaTriDoiHinh = long.Parse(txtGiaTri.Text.Replace(".", "").Replace(",", "")), // Xử lý BIGINT
                Region = cboRegion.SelectedItem.ToString()
            };

            if (_gameService.AddFCMobile(acc))
            {
                MessageBox.Show("Thêm thành công!");
                LoadData();
                btnLamMoi.PerformClick();
            }
        }
        // nút sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvFCMobile.CurrentRow == null) return;

            AccountDTO acc = new AccountDTO
            {
                Id = Convert.ToInt32(dgvFCMobile.CurrentRow.Cells["Id"].Value),
                Username = txtUser.Text.Trim(),
                Password = txtPass.Text.Trim(),
                LoginType = cboLoginType.SelectedItem.ToString(),
                DoiHinh_OVR = (int)numOVR.Value,
                GiaTriDoiHinh = long.Parse(txtGiaTri.Text),
                Region = cboRegion.SelectedItem.ToString()
            };

            if (_gameService.UpdateFCMobile(acc))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
        }
        // nút xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvFCMobile.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvFCMobile.CurrentRow.Cells["Id"].Value);
            if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_gameService.DeleteFCMobile(id)) LoadData();
            }
        }
        // nút làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtGiaTri.Clear();
            numOVR.Value = 0;
            cboLoginType.SelectedIndex = 0;
            cboRegion.SelectedIndex = 0;
        }
        // Click vào dòng để hiển thị thông tin lên form
        private void dgvFCMobile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var acc = dgvFCMobile.Rows[e.RowIndex].DataBoundItem as AccountDTO;

                if (acc != null)
                {
                    txtUser.Text = acc.Username ?? "";
                    txtPass.Text = acc.Password ?? "";
                    cboLoginType.Text = acc.LoginType ?? "";
                    numOVR.Value = acc.DoiHinh_OVR;
                    txtGiaTri.Text = acc.GiaTriDoiHinh.ToString();
                    cboRegion.Text = acc.Region ?? "";
                }
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                // Hiện chữ bình thường
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                // Hiện dấu * hoặc dấu chấm
                txtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
