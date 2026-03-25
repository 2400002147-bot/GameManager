using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameManager.DAL; 
using GameManager.DTO;

namespace GameManager.BLL
{
    public class GameService
    {
        // Khởi tạo đối tượng DAL để gọi xuống Database
        private GameDAL _dal = new GameDAL();

        //  FREE FIRE 
        public List<AccountDTO> GetListData(string tableName)
        {
            return _dal.GetListData(tableName);
        }
        public bool Login(string user, string pass, out string displayName)
        {
            displayName = "";
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
                return false;

            return _dal.CheckLogin(user, pass, out displayName);
        }
        public bool AddFreeFire(AccountDTO acc)
        {
            return _dal.InsertFreeFire(acc);
        }

        public bool UpdateFreeFire(AccountDTO acc)
        {
            return _dal.UpdateFreeFire(acc);
        }

        public bool DeleteFreeFire(int id)
        {
            return _dal.DeleteAccount(id, "FreeFireAccounts");
        }

        // LIÊN QUÂN 
        public List<AccountDTO> GetAllLienQuan()
        {
            return _dal.GetListData("LienQuanAccounts");
        }

        public bool AddLienQuan(AccountDTO acc)
        {
            return _dal.InsertLienQuan(acc);
        }

        public bool UpdateLienQuan(AccountDTO acc)
        {
            return _dal.UpdateLienQuan(acc);
        }

        public bool DeleteLienQuan(int id)
        {
            return _dal.DeleteAccount(id, "LienQuanAccounts");
        }

        // FC MOBILE
        public List<AccountDTO> GetAllFCMobile()
        {
            return _dal.GetListData("FCMobileAccounts");
        }

        public bool AddFCMobile(AccountDTO acc)
        {
            return _dal.InsertFCMobile(acc);
        }

        public bool UpdateFCMobile(AccountDTO acc)
        {
            return _dal.UpdateFCMobile(acc);
        }

        public bool DeleteFCMobile(int id)
        {
            return _dal.DeleteAccount(id, "FCMobileAccounts");
        }
    }
}
