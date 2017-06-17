using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOAD_RMS
{
    public class UserManage
    {
        List<User> _users;
        public UserManage()
        {
            _users = new List<User>();
        }

        public void addUser(User user)
        {
            _users.Add(user);
        }

        public User getUser(string account, string password)
        {
            return _users.Find(x => (x.UserAccount == account) && (x.UserPassword == password));
        }

        public List<User> GetUsers()
        {
            return _users;
        }

        public bool LoginCheck(string account, string password)
        {
            List<User> user = _users.FindAll(x => (x.UserAccount == account) && (x.UserPassword == password));
            if (user.Count == 1)
            {
                DBManager.CurrentUser = user[0];
                //setProject(user[0]);
                return true;
            }
            else
                return false;
        }

        public void registerAccount(string account, string password, string Identity)
        {
            DataTable userTable = DBManager.GetUsersIsRegister(account);
            string NotExist = userTable.Rows[0]["Result"].ToString();
            if (NotExist == "TRUE")
            {
                DBManager.AddUser(account, password, Identity);
                MessageBox.Show(account + " 註冊成功\n回到登入畫面", "註冊成功");
            }
            else
                MessageBox.Show(account + " 已被註冊", "註冊失敗");
        }
    }
}
