using GameManager.BLL; 
using GameManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                // Gọi Service lấy danh sách Liên Quân
                List<AccountDTO> list = _gameService.GetAllLienQuan();

                dgvLienQuan.DataSource = null;
                dgvLienQuan.Columns.Clear();
                dgvLienQuan.AutoGenerateColumns = true;

                if (list != null && list.Count > 0)
                {
                    dgvLienQuan.DataSource = new BindingList<AccountDTO>(list);

                    if (dgvLienQuan.Columns["Username"] != null) dgvLienQuan.Columns["Username"].HeaderText = "Tài khoản";
                    if (dgvLienQuan.Columns["RankLienQuan"] != null) dgvLienQuan.Columns["RankLienQuan"].HeaderText = "Bậc Hạng";
                    if (dgvLienQuan.Columns["SoTuong"] != null) dgvLienQuan.Columns["SoTuong"].HeaderText = "Số Tướng";
                    if (dgvLienQuan.Columns["Skins"] != null) dgvLienQuan.Columns["Skins"].HeaderText = "Số Trang Phục";

                    // Ẩn các cột của game khác
                    string[] hideCols = {"Id", "Password", "ID_InGame", "LevelAccount", "SoSkinSung","DoiHinh_OVR", "GiaTriDoiHinh", "Region", "GameCategory" };
                    foreach (string col in hideCols)
                    {
                        if (dgvLienQuan.Columns[col] != null) dgvLienQuan.Columns[col].Visible = false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
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
                var acc = dgvLienQuan.Rows[e.RowIndex].DataBoundItem as AccountDTO;

                if (acc != null)
                {
                    txtUser.Text = acc.Username ?? "";
                    txtPass.Text = acc.Password ?? "";
                    cboLoginType.Text = acc.LoginType ?? "";
                    cboRank.Text = acc.RankLienQuan ?? "";
                    numSoTuong.Value = acc.SoTuong;
                    numSkins.Value = acc.Skins;
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            try
            {
                // 1. Lấy thư mục hiện tại (...bin\Debug)
                string currentDir = AppDomain.CurrentDomain.BaseDirectory;
                DirectoryInfo di = new DirectoryInfo(currentDir);

                // 2. LÙI 3 LẦN: 
                // Lần 1: ra khỏi Debug
                // Lần 2: ra khỏi bin
                // Lần 3: ra khỏi GameManager.GUI để tới QLTK_Game
                string rootPath = di.Parent.Parent.Parent.FullName;

                // 3. Ghép với tên file
                string fullPath = Path.Combine(rootPath, "LienQuanFake.exe");

                if (File.Exists(fullPath))
                {
                    Process.Start(fullPath);
                    Thread.Sleep(4000);
                    SendKeys.SendWait(txtUser.Text);
                    Thread.Sleep(500);

                    SendKeys.SendWait("{TAB}");
                    Thread.Sleep(300);
                    SendKeys.SendWait("{TAB}");
                    Thread.Sleep(300);

                    SendKeys.SendWait(txtPass.Text);
                    Thread.Sleep(300);
                    SendKeys.SendWait("{TAB}");
                    Thread.Sleep(300);
                    SendKeys.SendWait("{TAB}");
                    Thread.Sleep(300);
                    SendKeys.SendWait("{ENTER}");
                }
                else
                {
                    MessageBox.Show("Không thấy file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}