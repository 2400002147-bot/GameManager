using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.DTO
{
    public class AccountDTO
    {
        //  Các thuộc tính chung
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LoginType { get; set; }
        

        // Thuộc tính riêng của Liên Quân 
        public string RankLienQuan { get; set; }
        public int SoTuong { get; set; }
        public int Skins { get; set; }
  
        // Thuộc tính riêng của Free Fire 
        public string ID_InGame { get; set; }
        public int LevelAccount { get; set; }
        public int SoSkinSung { get; set; }

        // Thuộc tính riêng của FC Mobile
        public int DoiHinh_OVR { get; set; }
        public long GiaTriDoiHinh { get; set; }
        public string Region { get; set; }

        // Thuộc tính để phân loại
        public string GameCategory { get; set; }
        public string Note { get; set; }
    }
}
