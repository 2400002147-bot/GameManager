using GameManager.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GameManager.DAL
{
    public class GameDAL
    {
        // Kết nối DB
        private string connectionString = "Server=.;Database=GameDB;Trusted_Connection=True;TrustServerCertificate=True;";

        // Lấy danh sách
        public List<AccountDTO> GetListData(string tableName)
        {
            List<AccountDTO> list = new List<AccountDTO>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = $"SELECT * FROM {tableName}";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            AccountDTO acc = new AccountDTO();

                            acc.Id = rdr["Id"] != DBNull.Value ? Convert.ToInt32(rdr["Id"]) : 0;
                            acc.Username = rdr["Username"]?.ToString() ?? "";
                            acc.Password = rdr["Password"]?.ToString() ?? "";
                            acc.LoginType = rdr["LoginType"]?.ToString() ?? "";

                            if (tableName == "FreeFireAccounts")
                            {
                                acc.ID_InGame = rdr["ID_InGame"]?.ToString() ?? "";
                                acc.LevelAccount = rdr["LevelAccount"] != DBNull.Value ? Convert.ToInt32(rdr["LevelAccount"]) : 0;
                                acc.SoSkinSung = rdr["SkinSungHiem"] != DBNull.Value ? Convert.ToInt32(rdr["SkinSungHiem"]) : 0;
                            }
                            else if (tableName == "LienQuanAccounts")
                            {
                                acc.RankLienQuan = rdr["RankLienQuan"]?.ToString() ?? "";
                                acc.SoTuong = rdr["SoTuong"] != DBNull.Value ? Convert.ToInt32(rdr["SoTuong"]) : 0;
                                acc.Skins = rdr["Skins"] != DBNull.Value ? Convert.ToInt32(rdr["Skins"]) : 0;
                            }
                            else if (tableName == "FCMobileAccounts")
                            {
                                acc.DoiHinh_OVR = rdr["DoiHinh_OVR"] != DBNull.Value ? Convert.ToInt32(rdr["DoiHinh_OVR"]) : 0;
                                acc.GiaTriDoiHinh = rdr["GiaTriDoiHinh"] != DBNull.Value ? Convert.ToInt64(rdr["GiaTriDoiHinh"]) : 0;
                                acc.Region = rdr["Region"]?.ToString() ?? "";
                            }
                            list.Add(acc);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi lấy dữ liệu: " + ex.Message);
            }
            return list;
        }
        public bool CheckLogin(string user, string pass, out string displayName)
        {
            displayName = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT DisplayName FROM Users WHERE Username = @u AND Password = @p";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@p", pass);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        displayName = result.ToString(); 
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Thêm, Update tài khoản Free Fire 
        public bool InsertFreeFire(AccountDTO acc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO FreeFireAccounts (Username, Password, LoginType, ID_InGame, LevelAccount, SkinSungHiem) " +
                             "VALUES (@u, @p, @t, @id, @lv, @s)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", acc.Username);
                cmd.Parameters.AddWithValue("@p", acc.Password);
                cmd.Parameters.AddWithValue("@t", acc.LoginType);
                cmd.Parameters.AddWithValue("@id", acc.ID_InGame);
                cmd.Parameters.AddWithValue("@lv", acc.LevelAccount);
                cmd.Parameters.AddWithValue("@s", acc.SoSkinSung);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool UpdateFreeFire(AccountDTO acc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE FreeFireAccounts SET Username=@u, Password=@p, LoginType=@t, " +
                             "ID_InGame=@id, LevelAccount=@lv, SkinSungHiem=@s WHERE Id=@idAcc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", acc.Username);
                cmd.Parameters.AddWithValue("@p", acc.Password);
                cmd.Parameters.AddWithValue("@t", acc.LoginType);
                cmd.Parameters.AddWithValue("@id", acc.ID_InGame);
                cmd.Parameters.AddWithValue("@lv", acc.LevelAccount);
                cmd.Parameters.AddWithValue("@s", acc.SoSkinSung);
                cmd.Parameters.AddWithValue("@idAcc", acc.Id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
       
        // Thêm, Update tài khoản liên quân
        public bool InsertLienQuan(AccountDTO acc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO LienQuanAccounts (Username, Password, LoginType, RankLienQuan, SoTuong, Skins) " +
                             "VALUES (@u, @p, @t, @rank, @st, @skins)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", acc.Username);
                cmd.Parameters.AddWithValue("@p", acc.Password);
                cmd.Parameters.AddWithValue("@t", acc.LoginType);
                cmd.Parameters.AddWithValue("@rank", acc.RankLienQuan ?? "");
                cmd.Parameters.AddWithValue("@st", acc.SoTuong);
                cmd.Parameters.AddWithValue("@skins", acc.Skins);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool UpdateLienQuan(AccountDTO acc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE LienQuanAccounts SET Username=@u, Password=@p, LoginType=@t, " +
                             "RankLienQuan=@rank, SoTuong=@st, Skins=@skins WHERE Id=@idAcc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", acc.Username);
                cmd.Parameters.AddWithValue("@p", acc.Password);
                cmd.Parameters.AddWithValue("@t", acc.LoginType);
                cmd.Parameters.AddWithValue("@rank", acc.RankLienQuan ?? "");
                cmd.Parameters.AddWithValue("@st", acc.SoTuong);
                cmd.Parameters.AddWithValue("@skins", acc.Skins);
                cmd.Parameters.AddWithValue("@idAcc", acc.Id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        // Thêm, Update tài khoản FC Mobile
        public bool InsertFCMobile(AccountDTO acc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO FCMobileAccounts (Username, Password, LoginType, DoiHinh_OVR, GiaTriDoiHinh, Region) " +
                             "VALUES (@u, @p, @t, @ovr, @giaTri, @region)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", acc.Username);
                cmd.Parameters.AddWithValue("@p", acc.Password);
                cmd.Parameters.AddWithValue("@t", acc.LoginType);
                cmd.Parameters.AddWithValue("@ovr", acc.DoiHinh_OVR);
                cmd.Parameters.AddWithValue("@giaTri", acc.GiaTriDoiHinh);
                cmd.Parameters.AddWithValue("@region", acc.Region ?? "");
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool UpdateFCMobile(AccountDTO acc)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "UPDATE FCMobileAccounts SET Username=@u, Password=@p, LoginType=@t, " +
                             "DoiHinh_OVR=@ovr, GiaTriDoiHinh=@giaTri, Region=@region WHERE Id=@idAcc";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", acc.Username);
                cmd.Parameters.AddWithValue("@p", acc.Password);
                cmd.Parameters.AddWithValue("@t", acc.LoginType);
                cmd.Parameters.AddWithValue("@ovr", acc.DoiHinh_OVR);
                cmd.Parameters.AddWithValue("@giaTri", acc.GiaTriDoiHinh);
                cmd.Parameters.AddWithValue("@region", acc.Region ?? "");
                cmd.Parameters.AddWithValue("@idAcc", acc.Id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        // Xóa tài khoản (cả 3 game) 
        public bool DeleteAccount(int id, string tableName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $"DELETE FROM {tableName} WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
