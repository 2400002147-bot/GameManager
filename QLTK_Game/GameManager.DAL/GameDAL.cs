using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GameManager.DTO;

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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = $"SELECT * FROM {tableName}";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    AccountDTO acc = new AccountDTO();
                    acc.Id = Convert.ToInt32(rdr["Id"]);
                    acc.Username = rdr["Username"].ToString();
                    acc.Password = rdr["Password"].ToString();
                    acc.LoginType = rdr["LoginType"].ToString();

                               if (tableName == "FreeFireAccounts")
                    {
                        acc.ID_InGame = rdr["ID_InGame"].ToString();
                        acc.LevelAccount = Convert.ToInt32(rdr["LevelAccount"]);
                        acc.SkinSungHiem = rdr["SkinSungHiem"].ToString();
                    }
                    else if (tableName == "LienQuanAccounts")
                    {
                        acc.RankLienQuan = rdr["RankLienQuan"].ToString();
                        acc.SoTuong = Convert.ToInt32(rdr["SoTuong"]);
                        acc.Skins = Convert.ToInt32(rdr["Skins"]);
                    }
                    else if (tableName == "FCMobileAccounts")
                    {
                        acc.DoiHinh_OVR = Convert.ToInt32(rdr["DoiHinh_OVR"]);
                        acc.GiaTriDoiHinh = Convert.ToInt64(rdr["GiaTriDoiHinh"]); // BIGINT
                        acc.Region = rdr["Region"].ToString();
                    }
                    list.Add(acc);
                }
            }
            return list;
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
                cmd.Parameters.AddWithValue("@s", acc.SkinSungHiem ?? "");
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
                cmd.Parameters.AddWithValue("@s", acc.SkinSungHiem ?? "");
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
