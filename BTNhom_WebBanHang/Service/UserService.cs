using BTNhom_WebBanHang.Helper;
using BTNhom_WebBanHang.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BTNhom_WebBanHang.Service
{
    class UserService : BaseService
    {
        private List<User> userData;
        private string userPath;

        public UserService()
        {
            userPath = Path.Combine(root, dataUser);
            if (File.Exists(userPath))
            {
                userData = Help.ReadFile<List<User>>(userPath);
            }
            else
            {
                userData = new List<User>();
            }
        }

        public bool SignIn(string Id, string pass, string name)
        {
            User newAcc = new User();
            for (int i = 0; i < userData.Count; i++)
            {
                if(Id == userData[i].userID)
                {
                    Console.WriteLine("Invalid ID or PassWord");
                    return false;
                }               
            }
            newAcc.userID = Id;
            newAcc.passWord = pass;
            newAcc.UserName = name;
            userData.Add(newAcc);
            Help.WriteFile<List<User>>(userPath, userData);
            Console.WriteLine($"Welcome {name}");
            return true;
        }

        public bool LogIn(string Id, string pass)
        {
            foreach(User user in userData)
            {
                if(user.userID == Id && user.passWord == pass)
                {
                    Console.WriteLine($"Welcome {user.UserName}");
                    return true;
                }
            }
            Console.WriteLine("Invalid ID or PassWord");
            return false;
        }
    }
}
